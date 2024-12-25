// Decompiled with JetBrains decompiler
// Type: MvCameraControl.CameraLinkBaudrate
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>Camera Link波特率</summary>
  [Flags]
  public enum CameraLinkBaudrate
  {
    /// <summary>9600</summary>
    B9600 = 1,
    /// <summary>19200</summary>
    B19200 = 2,
    /// <summary>38400</summary>
    B38400 = 4,
    /// <summary>57600</summary>
    B57600 = 8,
    /// <summary>115200</summary>
    B115200 = 16, // 0x00000010
    /// <summary>230400</summary>
    B230400 = 32, // 0x00000020
    /// <summary>460800</summary>
    B460800 = 64, // 0x00000040
    /// <summary>921600</summary>
    B921600 = 128, // 0x00000080
    /// <summary>最大值</summary>
    AutoMax = 1073741824, // 0x40000000
  }
}
