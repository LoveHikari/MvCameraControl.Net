// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IEventGrabber
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供设备事件订阅相关接口</summary>
  public interface IEventGrabber
  {
    /// <summary>设备事件</summary>
    event EventHandler<DeviceEventArgs> DeviceEvent;

    /// <summary>订阅事件</summary>
    /// <param name="eventName">事件名称</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SubscribeEvent(string eventName);

    /// <summary>取消事件订阅</summary>
    /// <param name="eventName">事件名称</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int UnSubscribeEvent(string eventName);

    /// <summary>订阅所有事件</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SubscribeAllEvent();

    /// <summary>取消订阅所有事件</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int UnSubscribeAllEvent();
  }
}
