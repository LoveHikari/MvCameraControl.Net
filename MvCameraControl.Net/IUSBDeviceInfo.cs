// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IUSBDeviceInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>USB相机信息</summary>
  public interface IUSBDeviceInfo : IDeviceInfo
  {
    /// <summary>控制输入端点</summary>
    byte CrtlInEndPoint { get; }

    /// <summary>控制输出端点</summary>
    byte CrtlOutEndPoint { get; }

    /// <summary>流端点</summary>
    byte StreamEndPoint { get; }

    /// <summary>事件端点</summary>
    byte EventEndPoint { get; }

    /// <summary>供应商ID号</summary>
    ushort VendorID { get; }

    /// <summary>产品ID号</summary>
    ushort ProductID { get; }

    /// <summary>设备索引号</summary>
    uint DeviceNumber { get; }

    /// <summary>设备GUID号</summary>
    string DeviceGUID { get; }

    /// <summary>家族名字</summary>
    string FamilyName { get; }

    /// <summary>支持的USB协议</summary>
    uint nbcdUSB { get; }

    /// <summary>设备地址</summary>
    uint DeviceAddress { get; }

    /// <summary>是否虚拟相机</summary>
    bool VirtualDevice { get; }
  }
}
