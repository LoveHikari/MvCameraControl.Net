// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IInterface
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供采集卡属性和接口</summary>
  public interface IInterface : IDisposable
  {
    /// <summary>打开采集卡</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int Open();

    /// <summary>关闭采集卡</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int Close();

    /// <summary>获取采集卡对应的参数配置对象</summary>
    IParameters Parameters { get; }

    /// <summary>获取采集卡对应的事件采集对象</summary>
    IEventGrabber EventGrabber { get; }

    /// <summary>设备本地升级</summary>
    /// <param name="filePath">升级文件路径</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 通过该接口可以将升级固件文件发送给设备进行升级。该接口需要等待升级固件文件成功传给设备端之后再返回，响应时间可能较长。
    /// </remarks>
    int LocalUpgrade(string filePath);

    /// <summary>获取升级进度</summary>
    /// <param name="process">升级进度</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetUpgradeProcess(out uint process);

    /// <summary>枚举采集卡上的相机</summary>
    /// <param name="devInfoList">相机列表</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int EnumDevices(out List<IDeviceInfo> devInfoList);

    /// <summary>开启设备指定事件</summary>
    /// <param name="eventName">事件名称</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int EventNotificationOn(string eventName);

    /// <summary>关闭设备指定事件</summary>
    /// <param name="eventName">事件名称</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int EventNotificationOff(string eventName);
  }
}
