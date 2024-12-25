// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IGenTLDevInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>通过GenTL枚举到的设备信息</summary>
  public interface IGenTLDevInfo
  {
    /// <summary>GenTL接口ID</summary>
    string InterfaceID { get; }

    /// <summary>设备ID</summary>
    string DeviceID { get; }

    /// <summary>供应商名字</summary>
    string VendorName { get; }

    /// <summary>型号名字</summary>
    string ModelName { get; }

    /// <summary>传输层类型</summary>
    string TLType { get; }

    /// <summary>设备显示名称</summary>
    string DisplayName { get; }

    /// <summary>用户自定义名字</summary>
    string UserDefinedName { get; }

    /// <summary>序列号</summary>
    string SerialNumber { get; }

    /// <summary>设备版本号</summary>
    string DeviceVersion { get; }

    /// <summary>GenTL的cti文件索引</summary>
    uint CtiIndex { get; }
  }
}
