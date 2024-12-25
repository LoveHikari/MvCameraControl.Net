// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IUSBDevice
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>USB设备专用接口</summary>
  public interface IUSBDevice : IDevice, IDisposable
  {
    /// <summary>设置U3V的传输包大小</summary>
    /// <param name="transferSize">传输的包大小,单位：Byte，默认为1M，范围：Windows[0x400, 0x400000], Linux[0x400, 0x200000]</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 增加传输包大小可以适当降低取流时的CPU占用率。但不同的PC和不同USB扩展卡存在不同的兼容性，如果该参数设置过大可能会出现取不到图像的风险。
    /// </remarks>
    int SetTransferSize(uint transferSize);

    /// <summary>获取U3V的传输包大小</summary>
    /// <param name="transferSize">传输的包大小， 单位：Byte</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetTransferSize(out uint transferSize);

    /// <summary>设置U3V的传输通道个数</summary>
    /// <param name="transferWays">传输通道个数，范围：1-10 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 可根据PC的性能、设备出图帧率、图像大小和内存使用率等因素对该参数进行调节。但不同的PC和不同的USB扩展卡存在不同的兼容性。
    /// </remarks>
    int SetTransferWays(uint transferWays);

    /// <summary>获取U3V的传输通道个数</summary>
    /// <param name="transferWays">传输通道个数</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 该接口用于获取当前的U3V异步取流节点个数，2000W设备的MONO8默认为3个，YUV为默认2个，RGB为默认1个，其它情况默认8个节点。
    /// </remarks>
    int GetTransferWays(out uint transferWays);

    /// <summary>设置U3V的事件缓存节点个数</summary>
    /// <param name="eventNodeNum">事件缓存节点个数，范围：1-64 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>该接口用于设置当前的U3V事件缓存节点个数，默认情况下为5个。</remarks>
    int SetEventNodeNum(uint eventNodeNum);

    /// <summary>设置U3V相机同步读写超时时间，范围为1000~UINT，默认1000 ms</summary>
    /// <param name="timeoutInMS">同步读写超时时间</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetSyncTimeOut(uint timeoutInMS);

    /// <summary>获取U3V相机同步读写超时时间</summary>
    /// <param name="timeoutInMS">同步读写超时时间</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetSyncTimeOut(out uint timeoutInMS);

    /// <summary>获取主机从USB设备接收的数据统计信息，如已接收字节数、帧数</summary>
    /// <param name="usbTransInfo">USB传输信息</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetUSBTransInfo(out USBTransInfo usbTransInfo);
  }
}
