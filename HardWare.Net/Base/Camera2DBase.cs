using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Cognex.VisionPro;
using HardWareNet.Camera2D;
using HardWareNet.Enum;

namespace HardWareNet.Base;

[XmlInclude(typeof(HikCamera2D))]
[XmlInclude(typeof(iRAYPLE_Camera2D))]
public abstract class Camera2DBase
{
    /// <summary>
    /// 设备键，大华相机专用
    /// </summary>
    [XmlIgnore]
    public string CameraKey { get; set; }
    /// <summary>
    /// 序列号
    /// </summary>
    public string SN { get; set; }
    /// <summary>
    /// 厂商
    /// </summary>
    public string ManufacturerName { get; set; }

    /// <summary>
    /// 设备名称
    /// </summary>
    public string UserDefinedName { get; set; }

    public EumnTriggerMode2D TriggerMode { get; set; }
    public double Timeout { get; set; } = 5000.0;

    /// <summary>
    /// 相机型号
    /// </summary>
    public string ModelName { get; set; }

    public virtual double Exposure { get; set; }
    [XmlIgnore]
    public virtual double MaxExposure { get; }
    public virtual double Gain { get; set; }
    [XmlIgnore]
    public virtual double MaxGain { get; }
    [XmlIgnore]
    public virtual List<string> TriggerSource { get; }


    [XmlIgnore]
    public Action<ICogImage> UpdateImage;

    /// <summary>
    /// 是否在取流
    /// </summary>
    [XmlIgnore]
    public bool bGrabbing { get; set; }

    /// <summary>
    /// 相机是否连接
    /// </summary>
    [XmlIgnore]
    public bool bConnect { get; protected set; }

    public abstract int OpenCamera();
    public abstract void Close();

    public abstract int SoftwareTriggerOnce();

    public abstract void ContinuousGrab();

    public abstract void SetSoftwareTrigger();
    public abstract void SetHardwareTrigger(string tiggersource);

    public abstract void SetCameraParame();
}



