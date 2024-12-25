// Decompiled with JetBrains decompiler
// Type: MvCameraControl.CamlDeviceInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>Camera Link串口设备信息</summary>
  internal class CamlDeviceInfo : ICamlDeviceInfo, IDeviceInfo
  {
    /// <summary>设备接口类型</summary>
    public DeviceTLayerType TLayerType { get; set; }

    /// <summary>制造商信息</summary>
    public string ManufacturerName { get; set; }

    /// <summary>设备型号</summary>
    public string ModelName { get; set; }

    /// <summary>设备版本</summary>
    public string DeviceVersion { get; set; }

    /// <summary>设备序列号</summary>
    public string SerialNumber { get; set; }

    /// <summary>用户自定义名称</summary>
    public string UserDefinedName { get; set; }

    /// <summary>
    /// 设备类型信息，7 - 0 bit: 预留，15 - 8 bit：产品子类别，23 - 16 bit：产品类型，31 - 24bit：产品线（如: 0x01 标准产品；0x02 3D产品；0x03 智能ID产品）
    /// </summary>
    public uint DevTypeInfo { get; set; }

    /// <summary>端口号</summary>
    public string PortID { get; set; }

    /// <summary>名称</summary>
    public string FamilyName { get; set; }
  }
}
