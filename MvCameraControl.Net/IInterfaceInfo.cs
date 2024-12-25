// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IInterfaceInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>采集卡信息</summary>
  public interface IInterfaceInfo
  {
    /// <summary>
    /// 采集卡接口类型，<see cref="T:MvCameraControl.InterfaceTLayerType" />
    /// </summary>
    InterfaceTLayerType TLayerType { get; }

    /// <summary>采集卡的PCIE插槽信息</summary>
    uint PCIEInfo { get; }

    /// <summary>采集卡ID</summary>
    string InterfaceID { get; }

    /// <summary>显示名称</summary>
    string DisplayName { get; }

    /// <summary>序列号</summary>
    string SerialNumber { get; }

    /// <summary>型号</summary>
    string ModelName { get; }

    /// <summary>厂商</summary>
    string Manufacturer { get; }

    /// <summary>版本号</summary>
    string DeviceVersion { get; }

    /// <summary>自定义名称</summary>
    string UserDefinedName { get; }
  }
}
