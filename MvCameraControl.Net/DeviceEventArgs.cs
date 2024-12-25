// Decompiled with JetBrains decompiler
// Type: MvCameraControl.DeviceEventArgs
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>设备事件</summary>
  public class DeviceEventArgs : EventArgs
  {
    private IEventOutInfo _EventInfo;

    internal DeviceEventArgs(IEventOutInfo eventInfo) => this._EventInfo = eventInfo;

    /// <summary>事件信息</summary>
    public IEventOutInfo EventInfo => this._EventInfo;
  }
}
