using MVSDK_Net;
using System;
using System.Collections.Concurrent;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using Cognex.VisionPro;
using HardWareNet.Base;
using HardWareNet.Enum;
using MvCameraControl;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;

namespace HardWareNet.Camera2D;

public class iRAYPLE_Camera2D:Camera2DBase
{
  private  readonly MyCamera device = new ();
  private  IMVDefine.IMV_ConnectCallBack pConnectCallBack;
  private  IMVDefine.IMV_FrameCallBack frameCallBack;
  private readonly ConcurrentQueue<IMVDefine.IMV_Frame> frameQueue = new();
  private Thread CallbackDataProcessThread;
  private Thread? ReconnectThread;

  private EumnTriggerMode2D temTriggerMode;

  public override double Exposure
  {
    get
    {
      try
      {
        double val = 0;
        // 获取属性值
        var ret = device.IMV_GetDoubleFeatureValue("ExposureTime", ref val);
        if (IMVDefine.IMV_OK != ret)
        {
          Console.WriteLine($"Get feature value failed! ErrorCode[{ret}]");
          return 0;
        }
        return val;
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
        // 设置属性值
        device.IMV_SetEnumFeatureSymbol("ExposureAuto", "Off");
        var ret = device.IMV_SetDoubleFeatureValue("ExposureTime",value);
        if (IMVDefine.IMV_OK != ret)
        {
          Console.WriteLine($"Get feature value failed! ErrorCode[{ret}]");
        }
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
        double val = 0;
        var ret = device.IMV_GetDoubleFeatureMax("ExposureTime", ref val);
        if (IMVDefine.IMV_OK != ret)
        {
          Console.WriteLine($"Get feature maximum value failed! ErrorCode[{ret}]");
          return 0;
        }
        return val;
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
        double val = 0;
        // 获取属性值
        var ret = device.IMV_GetDoubleFeatureValue("GainRaw", ref val);
        if (IMVDefine.IMV_OK != ret)
        {
          Console.WriteLine($"Get feature value failed! ErrorCode[{ret}]");
          return 0;
        }
        return val;
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
        var ret = device.IMV_SetDoubleFeatureValue("GainRaw", value);
        if (IMVDefine.IMV_OK != ret)
        {
          Console.WriteLine($"Get feature value failed! ErrorCode[{ret}]");
        }
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
        double val = 0;
        var ret = device.IMV_GetDoubleFeatureMax("GainRaw", ref val);
        if (IMVDefine.IMV_OK != ret)
        {
          Console.WriteLine($"Get feature maximum value failed! ErrorCode[{ret}]");
          return 0;
        }
        return val;
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
        List<string> val = [];
        IMVDefine.IMV_EnumEntryList enumEntryList = new IMVDefine.IMV_EnumEntryList();
        uint nEntryNum = 0;

        // 获取枚举属性的可设枚举值的个数
        //  Get the number of enumeration property settable enumeration
        var res = device.IMV_GetEnumFeatureEntryNum("TriggerSource", ref nEntryNum);
        if (res != IMVDefine.IMV_OK)
        {
          Console.WriteLine("Get settable enumeration number failed! ErrorCode[{0}]", res);
          return [];
        }

        IMVDefine.IMV_EnumEntryInfo[] info = new IMVDefine.IMV_EnumEntryInfo[nEntryNum];
        enumEntryList.nEnumEntryBufferSize = (uint)Marshal.SizeOf(typeof(IMVDefine.IMV_EnumEntryInfo)) * nEntryNum;
        enumEntryList.pEnumEntryInfo = Marshal.AllocHGlobal((int)enumEntryList.nEnumEntryBufferSize);

        if (enumEntryList.pEnumEntryInfo == IntPtr.Zero)
        {
          Console.WriteLine("pEnumEntryInfo is NULL");
          return [];
        }

        // 获取枚举属性的可设枚举值列表
        // Get enumeration property's settable enumeration value list
        res = device.IMV_GetEnumFeatureEntrys("TriggerSource", ref enumEntryList);
        if (res != IMVDefine.IMV_OK)
        {
          Console.WriteLine("Get settable enumeration value failed! ErrorCode[{0}]", res);
          return [];
        }

        for (int i = 0; i < nEntryNum; i++)
        {
          var t =
            (IMVDefine.IMV_EnumEntryInfo)
            Marshal.PtrToStructure(
              enumEntryList.pEnumEntryInfo + Marshal.SizeOf(typeof(IMVDefine.IMV_EnumEntryInfo)) * i,
              typeof(IMVDefine.IMV_EnumEntryInfo));

          val.Add(t.name);
        }

        return val;
      }
      catch (Exception)
      {
        // ignored
      }
      return [];
    }
  }


  #region 断线重连
  // 连接事件通知回调函数
  // Connect event notify callback function
  private void onDeviceLinkNotify(ref IMVDefine.IMV_SConnectArg pConnectArg, IntPtr pUser)
  {
    // 断线通知
    // offLine notify 
    if (IMVDefine.IMV_EVType.offLine == pConnectArg.EvType)
    {
      Console.WriteLine($"[{SN}]Device disconnect!");
      StopThread();
      ReconnectThread = new Thread(ReconnectProcess) { IsBackground = true };
      ReconnectThread.Start();
    }
    // 上线通知
    // onLine notify 
    else if (IMVDefine.IMV_EVType.onLine == pConnectArg.EvType)
    {
      if (ReconnectThread is { IsAlive: true })
      {
        ReconnectThread.Abort();
      }
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
      // 创建设备句柄
      // Create Device Handle
      var res = device.IMV_CreateHandle(IMVDefine.IMV_ECreateHandleMode.modeByCameraKey, 0,CameraKey);
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("Create devHandle failed! ErrorCode[{0}]", res);
        return res;
      }
      // 打开相机设备 
      // Connect to camera 
      res = device.IMV_Open();
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("Open camera failed! ErrorCode:[{0}]", res);
        return res;
      }
      SetSoftwareTrigger();
      // 注册数据帧回调函数
      // Register data frame callback function
      frameCallBack = onGetFrame;
      res = device.IMV_AttachGrabbing(frameCallBack, IntPtr.Zero);
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("Attach grabbing failed! ErrorCode:[{0}]", res);
        return res;
      }
      // 设备连接状态事件回调函数
      // Device connection status event callback function
      pConnectCallBack = onDeviceLinkNotify;
      res = device.IMV_SubscribeConnectArg(pConnectCallBack, IntPtr.Zero);
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("SubscribeConnectArg failed! ErrorCode:[{0}]", res);
        return res;
      }

      res = StartGrabbing();
      if (IMVDefine.IMV_OK != res)
      {
        return res;
      }
      bConnect = true;
      CallbackDataProcessThread = new Thread(ImageConvertProcess) { IsBackground = true };
      CallbackDataProcessThread.Start();
      return IMVDefine.IMV_OK;
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      return -1;
    }
  }

  #region 图像回调
  // 数据帧回调函数
  // Data frame callback function
  private void onGetFrame(ref IMVDefine.IMV_Frame frame, IntPtr pUser)
  {
    try
    {
      if (frame.frameHandle == IntPtr.Zero)
      {
        Console.WriteLine("frame is NULL");
        return;
      }

      
      if (frame.pData == IntPtr.Zero || frame.frameInfo.size == 0)
      {
        Console.WriteLine("Invalid frame data");
        // 即使数据无效，也需要释放帧
        device.IMV_ReleaseFrame(ref frame);
        return;
      }

      IMVDefine.IMV_Frame frameclone = new IMVDefine.IMV_Frame();
      int res = device.IMV_CloneFrame(ref frame, ref frameclone);

      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine($"Clone frame failed: {res}");
        device.IMV_ReleaseFrame(ref frame);
        return;
      }
      frameQueue.Enqueue(frameclone);

      // 释放图像缓存
      // Free image buffer
      device.IMV_ReleaseFrame(ref frame);
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
    }
  }

  private void ImageConvertProcess()
  {
    while (bConnect)
    {

      if (frameQueue.TryDequeue(out var frame))
      {
        try
        {
          Bitmap bmp = null;
          IMVDefine.IMV_EPixelType convertFormat = frame.frameInfo.pixelFormat;
          ConvertToBitmap(ref frame, ref bmp);

          if (bmp != null)
          {
            ICogImage cogImage = isColor(convertFormat)
              ? new CogImage24PlanarColor(bmp)
              : new CogImage8Grey(bmp);
            UpdateImage?.Invoke(cogImage);
            bmp.Dispose();
            //GC.Collect();
          }
        }
        catch (Exception e)
        {
          Console.WriteLine(e);
        }
        finally
        {
          //释放克隆帧
          var res = device.IMV_ReleaseFrame(ref frame);
          if (res != IMVDefine.IMV_OK)
          {
            Console.WriteLine($"Release cloned frame failed: {res}");
          }
        }
      }

      Thread.Sleep(1);
    }
  }

  private bool isColor(IMVDefine.IMV_EPixelType format)
  {
    if (format == IMVDefine.IMV_EPixelType.gvspPixelMono8 || format == IMVDefine.IMV_EPixelType.gvspPixelMono10||
        format == IMVDefine.IMV_EPixelType.gvspPixelMono12 || format == IMVDefine.IMV_EPixelType.gvspPixelMono10Packed||
        format == IMVDefine.IMV_EPixelType.gvspPixelMono12Packed)
    {
      return false;
    }

    return true;
  }

  private bool ConvertToBitmap(ref IMVDefine.IMV_Frame frame, ref Bitmap bitmap)
  {
    try
    {
      BitmapData bmpData;
      Rectangle bitmapRect = new Rectangle();
      IMVDefine.IMV_PixelConvertParam stPixelConvertParam = new IMVDefine.IMV_PixelConvertParam();

      // mono8和BGR8裸数据不需要转码
      // mono8 and BGR8 raw data is not need to convert
      IntPtr pDstRGB;
      if (frame.frameInfo.pixelFormat != IMVDefine.IMV_EPixelType.gvspPixelMono8
          && frame.frameInfo.pixelFormat != IMVDefine.IMV_EPixelType.gvspPixelBGR8)
      {
        //转目标内存 彩色
        var ImgSize = (int)frame.frameInfo.width * (int)frame.frameInfo.height * 3;
        //当内存申请失败，返回false
        try
        {
          pDstRGB = Marshal.AllocHGlobal(ImgSize);
        }
        catch
        {
          return false;
        }

        if (pDstRGB == IntPtr.Zero)
        {
          return false;
        }

        // 图像转换成BGR8
        // convert image to BGR8
        stPixelConvertParam.nWidth = frame.frameInfo.width;
        stPixelConvertParam.nHeight = frame.frameInfo.height;
        stPixelConvertParam.ePixelFormat = frame.frameInfo.pixelFormat;
        stPixelConvertParam.pSrcData = frame.pData;
        stPixelConvertParam.nSrcDataLen = frame.frameInfo.size;
        stPixelConvertParam.nPaddingX = frame.frameInfo.paddingX;
        stPixelConvertParam.nPaddingY = frame.frameInfo.paddingY;
        stPixelConvertParam.eBayerDemosaic = IMVDefine.IMV_EBayerDemosaic.demosaicNearestNeighbor;
        stPixelConvertParam.eDstPixelFormat = IMVDefine.IMV_EPixelType.gvspPixelBGR8;
        stPixelConvertParam.pDstBuf = pDstRGB;
        stPixelConvertParam.nDstBufSize = (uint)ImgSize;
        var res = device.IMV_PixelConvert(ref stPixelConvertParam);
        if (res != IMVDefine.IMV_OK)
        {
          Console.WriteLine("image convert to BGR failed!");
          return false;
        }
      }
      else
      {
        pDstRGB = frame.pData;
      }

      if (frame.frameInfo.pixelFormat == IMVDefine.IMV_EPixelType.gvspPixelMono8)
      {
        // 用Mono8数据生成Bitmap
        bitmap = new Bitmap((int)frame.frameInfo.width, (int)frame.frameInfo.height, PixelFormat.Format8bppIndexed);
        ColorPalette colorPalette = bitmap.Palette;
        for (int i = 0; i != 256; ++i)
        {
          colorPalette.Entries[i] = Color.FromArgb(i, i, i);
        }

        bitmap.Palette = colorPalette;

        bitmapRect.Height = bitmap.Height;
        bitmapRect.Width = bitmap.Width;
        bmpData = bitmap.LockBits(bitmapRect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
        CopyMemory(bmpData.Scan0, pDstRGB, bmpData.Stride * bitmap.Height);
        bitmap.UnlockBits(bmpData);
      }
      else
      {
        // 用BGR24数据生成Bitmap
        bitmap = new Bitmap((int)frame.frameInfo.width, (int)frame.frameInfo.height, PixelFormat.Format24bppRgb);
        bitmapRect.Height = bitmap.Height;
        bitmapRect.Width = bitmap.Width;
        bmpData = bitmap.LockBits(bitmapRect, ImageLockMode.ReadWrite, bitmap.PixelFormat);
        CopyMemory(bmpData.Scan0, pDstRGB, bmpData.Stride * bitmap.Height);
        bitmap.UnlockBits(bmpData);
        if (frame.frameInfo.pixelFormat != IMVDefine.IMV_EPixelType.gvspPixelBGR8)
        {
          Marshal.FreeHGlobal(pDstRGB);
        }
      }

      return true;
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
      return false;
    }
  }

  #endregion


  public override void Close()
  {
    try
    {
      //关闭相机
      //Close camera 
      StopGrabbing();
      var res = device.IMV_Close();
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("Close camera failed! ErrorCode:[{0}]", res);
      }

      // 销毁设备句柄
      // Destroy Device Handle
      res = device.IMV_DestroyHandle();
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("Destroy camera failed! ErrorCode[{0}]", res);
      }
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
    }
  }

  private void StopThread()
  {
    try
    {
      bConnect = false;
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
    try
    {
      SetSoftwareTrigger();
      // 开始采集 
      // ExecuteCommand TriggerSoftware
      var res = device.IMV_ExecuteCommandFeature("TriggerSoftware");
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("Set triggerMode value failed! ErrorCode[{0}]", res);
        return res;
      }
      return res;
    }
    catch (Exception e)
    {
      return -1;
    }

  }

  public override void ContinuousGrab()
  {
    try
    {
      // set TriggerMode Off
      var res = device.IMV_SetEnumFeatureSymbol("TriggerMode", "Off");
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
    }
  }

  public override void SetSoftwareTrigger()
  {
    try
    {
      // 设置触发源为软触发 
      // Set trigger source to Software 
      int res = device.IMV_SetEnumFeatureSymbol("TriggerSource", "Software");
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("Set triggerSource value failed! ErrorCode[{0}]", res);
        return;
      }

      // 设置触发器 
      // Set trigger selector to FrameStart 
      res = device.IMV_SetEnumFeatureSymbol("TriggerSelector", "FrameStart");
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("Set triggerSelector value failed! ErrorCode[{0}]", res);
        return;
      }

      // 设置触发模式 
      // Set trigger mode to On 
      res = device.IMV_SetEnumFeatureSymbol("TriggerMode", "On");
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("Set triggerMode value failed! ErrorCode[{0}]", res);
        return;
      }
      temTriggerMode = EumnTriggerMode2D.Software;
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
    }
  }

  public override void SetHardwareTrigger(string tiggersource)
  {
    try
    {
      // set TriggerMode On
      var res = device.IMV_SetEnumFeatureSymbol("TriggerMode", "On");
      res = device.IMV_SetEnumFeatureSymbol("TriggerSource", tiggersource);
      temTriggerMode = EumnTriggerMode2D.Hardware;
    }
    catch (Exception e)
    {
      Console.WriteLine(e);
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
    try
    {
      if (device.IMV_IsGrabbing()) return IMVDefine.IMV_OK;
      // 开始拉流 
      // Start grabbing 
      var res = device.IMV_StartGrabbing();
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("Start grabbing failed! ErrorCode:[{0}]", res);
        return res;
      }

      return IMVDefine.IMV_OK;
    }
    catch (Exception e)
    {
      return -1;
    }
  }

  private int StopGrabbing()
  {
    try
    {
      if (!device.IMV_IsGrabbing()) return IMVDefine.IMV_OK;
      // 停止拉流 
      // Stop grabbing 
      var res = device.IMV_StopGrabbing();
      if (res != IMVDefine.IMV_OK)
      {
        Console.WriteLine("Stop grabbing failed! ErrorCode:[{0}]", res);
        return res;
      }
      return IMVDefine.IMV_OK;
    }
    catch (Exception e)
    {
      return -1;
    }
  }

  /// <summary>
  /// 指针之间进行数据拷贝
  /// </summary>
  /// <param name="pDst">目标地址</param>
  /// <param name="pSrc">源地址</param>
  /// <param name="len">拷贝数据长度</param>
  [DllImport("Kernel32.dll", EntryPoint = "RtlMoveMemory", CharSet = CharSet.Ansi)]
  private static extern void CopyMemory(IntPtr pDst, IntPtr pSrc, int len);
}