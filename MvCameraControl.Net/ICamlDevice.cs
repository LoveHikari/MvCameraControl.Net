// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ICamlDevice
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>Camera Link串口设备专用接口</summary>
  public interface ICamlDevice : IDevice, IDisposable
  {
    /// <summary>设置设备波特率</summary>
    /// <param name="baudrate">波特率</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetDeviceBaudrate(CameraLinkBaudrate baudrate);

    /// <summary>获取设备波特率</summary>
    /// <param name="baudrate">波特率</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetDeviceBaudrate(out CameraLinkBaudrate baudrate);

    /// <summary>获取设备与主机间连接支持的波特率</summary>
    /// <param name="baudrateAbility">所支持波特率的或运算结果，单个波特率参考 <see cref="T:MvCameraControl.CameraLinkBaudrate" /></param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetSupportBaudrates(out uint baudrateAbility);

    /// <summary>设置串口操作等待时长</summary>
    /// <param name="timeoutInMS">串口操作的等待时长，单位为ms</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetGenCPTimeOut(uint timeoutInMS);
  }
}
