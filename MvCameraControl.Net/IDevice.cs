// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IDevice
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供设备通用的属性和接口</summary>
  public interface IDevice : IDisposable
  {
    /// <summary>设备异常事件</summary>
    event EventHandler<DeviceExceptionArgs> DeviceExceptionEvent;

    /// <summary>判断设备是否处于连接状态</summary>
    bool IsConnected { get; }

    /// <summary>获取设备对应的图像采集对象</summary>
    IStreamGrabber StreamGrabber { get; }

    /// <summary>获取设备对应的事件采集对象</summary>
    IEventGrabber EventGrabber { get; }

    /// <summary>获取设备信息</summary>
    IDeviceInfo DeviceInfo { get; }

    /// <summary>获取设备对应的参数配置对象</summary>
    IParameters Parameters { get; }

    /// <summary>获取格式转换对象</summary>
    IPixelTypeConverter PixelTypeConverter { get; }

    /// <summary>获取用于图像处理的对象</summary>
    IImageProcess ImageProcess { get; }

    /// <summary>获取用于图像保存的对象</summary>
    IImageSaver ImageSaver { get; }

    /// <summary>获取用于解码图像的的对象</summary>
    IImageDecoder ImageDecoder { get; }

    /// <summary>获取录像对象</summary>
    IVideoRecorder VideoRecorder { get; }

    /// <summary>获取图像和图形渲染对象</summary>
    IImageRender ImageRender { get; }

    /// <summary>打开设备，默认以独占权限打开</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int Open();

    /// <summary>以指定访问权限打开设备，只支持GigE设备</summary>
    /// <param name="AccessMode">访问权限</param>
    /// <param name="switchoverKey">切换访问权限时的密钥</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 目前设备暂不支持MV_ACCESS_ExclusiveWithSwitch、MV_ACCESS_ControlWithSwitch、MV_ACCESS_ControlSwitchEnable、MV_ACCESS_ControlSwitchEnableWithKey这四种抢占模式。
    /// </remarks>
    int Open(DeviceAccessMode AccessMode, uint switchoverKey);

    /// <summary>关闭设备</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int Close();

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
