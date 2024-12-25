// Decompiled with JetBrains decompiler
// Type: MvCameraControl.FrameGrabbedEventArgs
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>采集一帧图像的事件，用于获取图像数据和帧信息</summary>
  public class FrameGrabbedEventArgs : EventArgs
  {
    private IFrameOut _frame;

    /// <summary>图像帧信息</summary>
    public IFrameOut FrameOut => this._frame;

    internal FrameGrabbedEventArgs(IFrameOut frame) => this._frame = frame;
  }
}
