// Decompiled with JetBrains decompiler
// Type: MvCameraControl.InterfaceInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  internal class InterfaceInfo : IInterfaceInfo
  {
    /// <summary>
    /// 采集卡接口类型，<see cref="T:MvCameraControl.InterfaceTLayerType" />
    /// </summary>
    public InterfaceTLayerType TLayerType { get; set; }

    /// <summary>采集卡的PCIE插槽信息</summary>
    public uint PCIEInfo { get; set; }

    /// <summary>采集卡ID</summary>
    public string InterfaceID { get; set; }

    /// <summary>显示名称</summary>
    public string DisplayName { get; set; }

    /// <summary>序列号</summary>
    public string SerialNumber { get; set; }

    /// <summary>型号</summary>
    public string ModelName { get; set; }

    /// <summary>厂商</summary>
    public string Manufacturer { get; set; }

    /// <summary>版本号</summary>
    public string DeviceVersion { get; set; }

    /// <summary>自定义名称</summary>
    public string UserDefinedName { get; set; }
  }
}
