// Decompiled with JetBrains decompiler
// Type: MvCameraControl.DeviceExceptionArgs
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>设备异常消息</summary>
  public class DeviceExceptionArgs : EventArgs
  {
    /// <summary>消息类型</summary>
    public DeviceExceptionType MsgType { get; internal set; }

    internal DeviceExceptionArgs(DeviceExceptionType msgType) => this.MsgType = msgType;
  }
}
