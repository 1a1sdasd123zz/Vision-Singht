#nullable enable
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using Cognex.VisionPro;
using HardWareNet.Base;
using HardWareNet.Enum;
using MvCameraControl;
using MVSDK_Net;

namespace HardWareNet.Camera2D;

public class HikCamera2D(IDeviceInfo devInfo) : Camera2DBase
{
    private IDevice? device;
    private Thread? CallbackDataProcessThread;
    private Thread? ReconnectThread;
    private readonly ConcurrentQueue<IImage> mCallbackDataQueue = new ();

    private EumnTriggerMode2D temTriggerMode;

    public override double Exposure
    {
        get
        {
            try
            {
                if (device.Parameters.GetFloatValue("ExposureTime", out var val) == MvError.MV_OK)
                    return Convert.ToDouble(val.CurValue);
            }
            catch (Exception)
            {
                // ignored
            }

            return 0.0;
        }
        set
        {
            try
            {
                device.Parameters.SetEnumValue("ExposureAuto", 0u);
                device.Parameters.SetFloatValue("ExposureTime", (float)value);
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
    public override double MaxExposure
    {
        get
        {
            try
            {
                if (device.Parameters.GetFloatValue("ExposureTime", out var val) == MvError.MV_OK)
                    return Convert.ToDouble(val.Max);
            }
            catch (Exception)
            {
                // ignored
            }

            return 0.0;
        }
    }

    public override double Gain
    {
        get
        {
            try
            {
                if (device.Parameters.GetFloatValue("Gain", out var val) == MvError.MV_OK)
                    return Convert.ToDouble(val.CurValue);
            }
            catch (Exception)
            {
                // ignored
            }

            return 0.0;
        }
        set
        {
            try
            {
                device.Parameters.SetEnumValue("GainAuto", 0u);
                device.Parameters.SetFloatValue("Gain", (float)value);
            }
            catch (Exception)
            {
                // ignored
            }
        }
    }
    public override double MaxGain
    {
        get
        {
            try
            {
                if (device.Parameters.GetFloatValue("Gain", out var val) == MvError.MV_OK)
                    return Convert.ToDouble(val.Max);
            }
            catch (Exception)
            {
                // ignored
            }

            return 0.0;
        }
    }

    public override List<string> TriggerSource
    {
        get
        {
            try
            {
                if (device.Parameters.GetEnumValue("TriggerSource", out var val) == MvError.MV_OK)
                {
                    List<string> list = [];
                    foreach (var item in val.SupportEnumEntries)
                    {
                        list.Add(item.Symbolic);
                    }
                    return list;
                }
                    
            }
            catch (Exception)
            {
                // ignored
            }
            return [];
        }
    }

    #region 断线重连
    private void ExceptionEventHandler(object sender, DeviceExceptionArgs e)
    {
        if (e.MsgType == DeviceExceptionType.DisConnect)
        {
            Console.WriteLine($"[{SN}]Device disconnect!");
            bConnect = false;
            StopThread();
            ReconnectThread = new Thread(ReconnectProcess) { IsBackground = true };
            ReconnectThread.Start();
        }
    }

    private void ReconnectProcess()
    {
        while (!bConnect)
        {
            if (OpenCamera() == MvError.MV_OK)
            {
                Console.WriteLine($"[{SN}]相机重连成功");
                break;
            }
            Thread.Sleep(3000);
        }
    }
    #endregion


    public override int OpenCamera()
    {
        try
        {
            // ch:创建设备 | en:Create device
            device = DeviceFactory.CreateDevice(devInfo);

            var ret = device.Open();
            if (ret != MvError.MV_OK)
            {
                Console.WriteLine("Open device failed:{0:x8}", ret);
                return ret;
            }
            // ch:设置触发模式为off | en:set trigger mode as off
            ret = device.Parameters.SetEnumValue("TriggerMode", 1);
            if (ret != MvError.MV_OK)
            {
                //Console.WriteLine("Set TriggerMode failed:{0:x8}", ret);
                return ret;
            }

            //ch: 设置合适的缓存节点数量 | en: Setting the appropriate number of image nodes
            device.StreamGrabber.SetImageNodeNum(5);
            // ch:注册回调函数 | en:Register image callback
            device.StreamGrabber.FrameGrabedEvent += FrameGrabedEventHandler;
            device.DeviceExceptionEvent += ExceptionEventHandler;
            CallbackDataProcessThread = new Thread(ImageCallbackProcess)
            {
                IsBackground = true
            };
            CallbackDataProcessThread.Start();
            bConnect = true;
            // ch:开启抓图 || en: start grab image
            ret = StartGrabbing();
            if (ret != MvError.MV_OK)
            {
                return ret;
            }
            Console.WriteLine("Open device Success:{0:x8}", ret);
            return MvError.MV_OK;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return -1;
        }
    }

    #region 图像回调

    private void FrameGrabedEventHandler(object sender, FrameGrabbedEventArgs e)
    {
        if(e.FrameOut.Image.PixelDataPtr == IntPtr.Zero)
            return;
        mCallbackDataQueue.Enqueue(e.FrameOut.Image);
    }

    private void ImageCallbackProcess()
    {

        while (true)
        {
            try
            {
                if (mCallbackDataQueue.TryDequeue(out var image))
                {
                    IImage inputImage = image;
                    MvGvspPixelType dstPixelType = MvGvspPixelType.PixelType_Gvsp_Undefined;
                    Rectangle bitmapRect = new Rectangle();

                    if (IsColorPixelFormat(image.PixelType))
                    {
                        dstPixelType = MvGvspPixelType.PixelType_Gvsp_BGR8_Packed;
                    }
                    else if (IsMonoPixelFormat(image.PixelType))
                    {
                        dstPixelType = MvGvspPixelType.PixelType_Gvsp_Mono8;
                    }
                    else
                    {
                        Console.WriteLine("Don't need to convert!");
                    }

                    if (dstPixelType != MvGvspPixelType.PixelType_Gvsp_Undefined)
                    {
                        // ch:像素格式转换 | en:Pixel type convert 
                        int result = device.PixelTypeConverter.ConvertPixelType(inputImage, out var outImage, dstPixelType);
                        if (result != MvError.MV_OK)
                        {
                            Console.WriteLine("Image Convert failed:{0:x8}", result);
                            continue;
                        }

                        var Width = (int)outImage.Width;
                        var Height = (int)outImage.Height;

                        if (outImage.PixelDataPtr == IntPtr.Zero)
                        {
                            continue;
                        }

                        ICogImage cogImage;
                        BitmapData bmpData;
                        if (dstPixelType == MvGvspPixelType.PixelType_Gvsp_Mono8)
                        {
                            // 用Mono8数据生成Bitmap
                            using var bitmap = new Bitmap(Width,Height,
                                PixelFormat.Format8bppIndexed);
                            ColorPalette colorPalette = bitmap.Palette;
                            for (int i = 0; i != 256; ++i)
                            {
                                colorPalette.Entries[i] = Color.FromArgb(i, i, i);
                            }

                            bitmap.Palette = colorPalette;

                            bitmapRect.Height = bitmap.Height;
                            bitmapRect.Width = bitmap.Width;
                            bmpData = bitmap.LockBits(bitmapRect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
                            CopyMemory(bmpData.Scan0, outImage.PixelDataPtr, bmpData.Stride * bitmap.Height);
                            bitmap.UnlockBits(bmpData);
                            cogImage = new CogImage8Grey(bitmap);
                        }
                        else
                        {
                            // 用BGR24数据生成Bitmap
                            using var bitmap = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
                            bitmapRect.Height = bitmap.Height;
                            bitmapRect.Width = bitmap.Width;
                            bmpData = bitmap.LockBits(bitmapRect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
                            CopyMemory(bmpData.Scan0, outImage.PixelDataPtr, bmpData.Stride * bitmap.Height);
                            bitmap.UnlockBits(bmpData);
                            cogImage = new CogImage24PlanarColor(bitmap);
                        }
                        UpdateImage?.Invoke(cogImage);
                        outImage.Dispose();
                        //GC.Collect();
                    }
                }
            }
            catch (Exception e)
            {
                // ignored
            }

            Thread.Sleep(1);
        }
    }

    private bool IsMonoPixelFormat(MvGvspPixelType enType)
    {
        switch (enType)
        {
            case MvGvspPixelType.PixelType_Gvsp_Mono8:
            case MvGvspPixelType.PixelType_Gvsp_Mono10_Packed:
            case MvGvspPixelType.PixelType_Gvsp_Mono12_Packed:
            case MvGvspPixelType.PixelType_Gvsp_Mono10:
            case MvGvspPixelType.PixelType_Gvsp_Mono12:
                return true;
            default:
                return false;
        }
    }

    private bool IsColorPixelFormat(MvGvspPixelType enType)
    {
        switch (enType)
        {
            case MvGvspPixelType.PixelType_Gvsp_BayerGR8:
            case MvGvspPixelType.PixelType_Gvsp_BayerRG8:
            case MvGvspPixelType.PixelType_Gvsp_BayerGB8:
            case MvGvspPixelType.PixelType_Gvsp_BayerBG8:
            case MvGvspPixelType.PixelType_Gvsp_BayerGR10_Packed:
            case MvGvspPixelType.PixelType_Gvsp_BayerRG10_Packed:
            case MvGvspPixelType.PixelType_Gvsp_BayerGB10_Packed:
            case MvGvspPixelType.PixelType_Gvsp_BayerBG10_Packed:
            case MvGvspPixelType.PixelType_Gvsp_BayerGR12_Packed:
            case MvGvspPixelType.PixelType_Gvsp_BayerRG12_Packed:
            case MvGvspPixelType.PixelType_Gvsp_BayerGB12_Packed:
            case MvGvspPixelType.PixelType_Gvsp_BayerBG12_Packed:
            case MvGvspPixelType.PixelType_Gvsp_BayerGR10:
            case MvGvspPixelType.PixelType_Gvsp_BayerRG10:
            case MvGvspPixelType.PixelType_Gvsp_BayerGB10:
            case MvGvspPixelType.PixelType_Gvsp_BayerBG10:
            case MvGvspPixelType.PixelType_Gvsp_BayerGR12:
            case MvGvspPixelType.PixelType_Gvsp_BayerRG12:
            case MvGvspPixelType.PixelType_Gvsp_BayerGB12:
            case MvGvspPixelType.PixelType_Gvsp_BayerBG12:
            case MvGvspPixelType.PixelType_Gvsp_YUV422_Packed:
            case MvGvspPixelType.PixelType_Gvsp_YUV422_YUYV_Packed:
            case MvGvspPixelType.PixelType_Gvsp_RGB8_Packed:
            case MvGvspPixelType.PixelType_Gvsp_BGR8_Packed:
            case MvGvspPixelType.PixelType_Gvsp_RGBA8_Packed:
            case MvGvspPixelType.PixelType_Gvsp_BGRA8_Packed:
                return true;
            default:
                return false;
        }
    }
    #endregion

    private void StopThread()
    {
        try
        {
            // 2. 等待线程完全退出
            if (CallbackDataProcessThread is { IsAlive: true })
            {
                //等待3秒
                bool isExited = CallbackDataProcessThread.Join(3000);
                if (!isExited)
                {
                    Console.WriteLine("警告：图像处理线程超时未退出！");
                    CallbackDataProcessThread.Abort();
                }
            }

            // 3. 释放线程引用
            CallbackDataProcessThread = null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public override int SoftwareTriggerOnce()
    {
        device.Parameters.SetEnumValue("TriggerMode", 1);
        device.Parameters.SetEnumValueByString("TriggerSource", EumnTriggerMode2D.Software.ToString());
        int ret = device.Parameters.SetCommandValue("TriggerSoftware");
        if (MvError.MV_OK != ret)
        {
            return ret;
        }
        return 0;
    }

    public override void ContinuousGrab()
    {
        device.Parameters.SetEnumValue("TriggerMode", 0);
        device.Parameters.SetEnumValueByString("TriggerSource", EumnTriggerMode2D.Software.ToString());
    }

    public override void SetSoftwareTrigger()
    {
        try
        {
            device.Parameters.SetEnumValue("TriggerMode", 1);
            device.Parameters.SetEnumValueByString("TriggerSource", EumnTriggerMode2D.Software.ToString());
            temTriggerMode = EumnTriggerMode2D.Software;
        }
        catch (Exception e)
        {
        }
    }

    public override void SetHardwareTrigger(string tiggersource)
    {
        try
        {
            device.Parameters.SetEnumValue("TriggerMode", 1);
            device.Parameters.SetEnumValueByString("TriggerSource", tiggersource);
            temTriggerMode = EumnTriggerMode2D.Hardware;
        }
        catch (Exception e)
        {
        }
    }

    public override void SetCameraParame()
    {
        base.Exposure = Exposure;
        base.Gain = Gain;
        TriggerMode = temTriggerMode;
    }

    private int StartGrabbing()
    {
        // ch:开启抓图 | en: start grab image
        int ret = device.StreamGrabber.StartGrabbing();
        if (ret != MvError.MV_OK)
        {
            Console.WriteLine("Start grabbing failed:{0:x8}", ret);
        }
        bGrabbing = true;
        return ret;
    }

    private void StopGrabbing()
    {
        // ch:停止抓图 | en:Stop grabbing
        var ret = device.StreamGrabber.StopGrabbing();
        if (ret != MvError.MV_OK)
        {
            Console.WriteLine("Stop grabbing failed:{0:x8}", ret);
        }
        bGrabbing = false;
    }

    public override void Close()
    {
        try
        {
            StopGrabbing();
            // ch:关闭设备 | en:Close device
            if (device == null) return;
            int ret = device.Close();
            if (ret != MvError.MV_OK)
            {
                Console.WriteLine("Close device failed:{0:x8}", ret);
            }
            bConnect = false;
        }
        catch (Exception e)
        {
            // ignored
        }
    }
    [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", CharSet = CharSet.Ansi)]
    private static extern void CopyMemory(IntPtr pDst, IntPtr pSrc, int len);
}

