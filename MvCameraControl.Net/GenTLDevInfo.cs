// Decompiled with JetBrains decompiler
// Type: MvCameraControl.GenTLDevInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  internal class GenTLDevInfo : IGenTLDevInfo
  {
    /// <summary>GenTL接口ID</summary>
    public string InterfaceID { get; set; }

    /// <summary>设备ID</summary>
    public string DeviceID { get; set; }

    /// <summary>供应商名字</summary>
    public string VendorName { get; set; }

    /// <summary>型号名字</summary>
    public string ModelName { get; set; }

    /// <summary>传输层类型</summary>
    public string TLType { get; set; }

    /// <summary>设备显示名称</summary>
    public string DisplayName { get; set; }

    /// <summary>用户自定义名字</summary>
    public string UserDefinedName { get; set; }

    /// <summary>序列号</summary>
    public string SerialNumber { get; set; }

    /// <summary>设备版本号</summary>
    public string DeviceVersion { get; set; }

    /// <summary>GenTL的cti文件索引</summary>
    public uint CtiIndex { get; set; }
  }
}
