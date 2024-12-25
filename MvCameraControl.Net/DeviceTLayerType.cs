// Decompiled with JetBrains decompiler
// Type: MvCameraControl.DeviceTLayerType
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>设备接口类型</summary>
  [Flags]
  public enum DeviceTLayerType
  {
    /// <summary>GigE Vision 设备</summary>
    MvGigEDevice = 1,
    /// <summary>USB3 Vision 设备</summary>
    MvUsbDevice = 4,
    /// <summary>Camera Link 设备（串口）</summary>
    MvCameraLinkDevice = 8,
    /// <summary>虚拟 GigE Vision 设备</summary>
    MvVirGigEDevice = 16, // 0x00000010
    /// <summary>虚拟 USB3 Vision 设备</summary>
    MvVirUsbDevice = 32, // 0x00000020
    /// <summary>网口采集卡下GigE Vision设备</summary>
    MvGenTLGigEDevice = 64, // 0x00000040
    /// <summary>Camera Link 设备</summary>
    MvGenTLCameraLinkDevice = 128, // 0x00000080
    /// <summary>CoaXPress设备</summary>
    MvGenTLCXPDevice = 256, // 0x00000100
    /// <summary>XoFLink设备</summary>
    MvGenTLXoFDevice = 512, // 0x00000200
  }
}
