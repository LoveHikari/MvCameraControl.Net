// Decompiled with JetBrains decompiler
// Type: MvCameraControl.InterfaceTLayerType
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>采集卡接口类型定义</summary>
  [Flags]
  public enum InterfaceTLayerType
  {
    /// <summary>GigE Vision采集卡</summary>
    MvGigEInterface = 1,
    /// <summary>Camera Link采集卡</summary>
    MvCameraLinkInterface = 4,
    /// <summary>CoaXPress采集卡</summary>
    MvCXPInterface = 8,
    /// <summary>XoFLink采集卡</summary>
    MvXoFInterface = 16, // 0x00000010
  }
}
