// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IDeviceInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>设备基本信息</summary>
  public interface IDeviceInfo
  {
    /// <summary>设备接口类型</summary>
    DeviceTLayerType TLayerType { get; }

    /// <summary>制造商信息</summary>
    string ManufacturerName { get; }

    /// <summary>设备型号</summary>
    string ModelName { get; }

    /// <summary>设备版本</summary>
    string DeviceVersion { get; }

    /// <summary>设备序列号</summary>
    string SerialNumber { get; }

    /// <summary>用户自定义名称</summary>
    string UserDefinedName { get; }

    /// <summary>
    /// 设备类型信息，7 - 0 bit: 预留，15 - 8 bit：产品子类别，23 - 16 bit：产品类型，31 - 24bit：产品线（如: 0x01 标准产品；0x02 3D产品；0x03 智能ID产品）
    /// </summary>
    uint DevTypeInfo { get; }
  }
}
