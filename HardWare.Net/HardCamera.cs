using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using HardWareNet.Base;
using HardWareNet.Camera2D;
using HardWareNet.Frm;
using MvCameraControl;
using HardWareNet.Enum;
using MVSDK_Net;

namespace HardWareNet;

public class HardCamera
{
  /// <summary>
  /// 海康支持的设备类型
  /// </summary>
  const DeviceTLayerType devLayerType = DeviceTLayerType.MvGigEDevice | DeviceTLayerType.MvUsbDevice | DeviceTLayerType.MvGenTLCameraLinkDevice
                                        | DeviceTLayerType.MvGenTLCXPDevice | DeviceTLayerType.MvGenTLXoFDevice;


  private static readonly Lazy<HardCamera> _lazyInstance = new Lazy<HardCamera>(() => new HardCamera());
  public static HardCamera Instance => _lazyInstance.Value;

  public Dictionary<string,Camera2DBase> Cameras = new ();

  public Form GetFormCamera2D => new Frm_Camera2D();


  public void Initialization()
  {
    //// ch: 初始化 SDK | en: Initialize SDK
    //SDKSystem.Initialize();
    EnumDevices();
  }

  public void Unitialization()
  {
    //// ch: 反初始化SDK | en: Finalize SDK
    //SDKSystem.Finalize();
    foreach (var item in Cameras.Values)
    {
      if (item.bConnect)
      {
        item.Close();
      }
    }
  }

  private void EnumDevices()
  {
    #region 枚举海康相机

    // ch:枚举设备 | en:Enum device
    int ret = DeviceEnumerator.EnumDevices(devLayerType, out var devInfoList);
    if (ret != MvError.MV_OK)
    {
      Console.WriteLine("Enum device failed:{0:x8}", ret);
      return;
    }

    if (0 != devInfoList.Count)
    {
      // ch:打印设备信息 en:Print device info
      foreach (var devInfo in devInfoList)
      {
        if (devInfo.ManufacturerName != EnumDeviceType.Hikrobot.ToString()) continue;
        HikCamera2D cam = new HikCamera2D(devInfo)
        {
          ManufacturerName = devInfo.ManufacturerName,
          UserDefinedName = devInfo.UserDefinedName,
          ModelName = devInfo.ModelName,
          SN = devInfo.SerialNumber
        };

        cam.OpenCamera();
        Cameras.Add(cam.SN, cam);
      }
    }

    #endregion

    #region 枚举大华相机

    //枚举设备
    // Discover device
    int res = IMVDefine.IMV_OK;
    IMVDefine.IMV_DeviceList deviceList = new IMVDefine.IMV_DeviceList();
    IMVDefine.IMV_EInterfaceType interfaceTp = IMVDefine.IMV_EInterfaceType.interfaceTypeAll;
    res = MyCamera.IMV_EnumDevices(ref deviceList, (uint)interfaceTp);
    if (res == IMVDefine.IMV_OK)
    {
      if (deviceList.nDevNum > 0)
      {
        for (int i = 0; i < deviceList.nDevNum; i++)
        {
          IMVDefine.IMV_DeviceInfo devInfo =
            (IMVDefine.IMV_DeviceInfo)
            Marshal.PtrToStructure(
              deviceList.pDevInfo + Marshal.SizeOf(typeof(IMVDefine.IMV_DeviceInfo)) * i,
              typeof(IMVDefine.IMV_DeviceInfo));

          if (devInfo.manufactureInfo != EnumDeviceType.iRAYPLE.GetDescription()) continue;
          iRAYPLE_Camera2D cam = new iRAYPLE_Camera2D
          {
            CameraKey = devInfo.cameraKey,
            ManufacturerName = devInfo.manufactureInfo,
            UserDefinedName = devInfo.cameraName,
            ModelName = devInfo.modelName,
            SN = devInfo.serialNumber
          };
          cam.OpenCamera();
          Cameras.Add(cam.SN, cam);
        }
      }
      else
      {
        //Console.WriteLine("Enumeration devices failed! ErrorCode:[{0}]", res);
      }

      #endregion
    }
  }
}

