// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IGigEDevice
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>GigE设备专用接口</summary>
  public interface IGigEDevice : IDevice, IDisposable
  {
    /// <summary>获取最佳包大小</summary>
    /// <param name="optimalPacketSize">最佳包大小</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetOptimalPacketSize(out int optimalPacketSize);

    /// <summary>强制设备IP</summary>
    /// <param name="ip">IP地址</param>
    /// <param name="subnetMask">子网掩码</param>
    /// <param name="defaultGateway">默认网关</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 强制设置设备网络参数（包括IP、子网掩码、默认网关），强制设置之后将需要重新创建设备句柄，仅GigE设备支持。
    /// 如果设备为DHCP的状态，调用该接口强制设置设备网络参数之后设备将会重启。
    /// </remarks>
    int ForceIp(uint ip, uint subnetMask, uint defaultGateway);

    /// <summary>配置IP方式</summary>
    /// <param name="type">IP配置类型 <see cref="T:MvCameraControl.IpConfigType" /></param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetIpConfig(IpConfigType type);

    /// <summary>设置传输模式，默认为Driver模式</summary>
    /// <param name="mode">网络传输模式</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetNetTransMode(NetTransMode mode);

    /// <summary>获取网络传输信息</summary>
    /// <param name="info">网络传输信息</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetNetTransInfo(out NetTransInfo info);

    /// <summary>设置GVSP取流超时时间</summary>
    /// <param name="timeoutInMS">超时时间(MS)，默认300ms，范围：&gt;10ms</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetGvspTimeout(uint timeoutInMS);

    /// <summary>获取GVSP取流超时时间</summary>
    /// <param name="timeoutInMS">超时时间(MS)</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetGvspTimeout(out uint timeoutInMS);

    /// <summary>设置GVCP命令超时时间</summary>
    /// <param name="timeoutInMS">超时时间(MS)，默认500ms，范围：0-10000ms </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetGvcpTimeout(uint timeoutInMS);

    /// <summary>获取GVCP命令超时时间</summary>
    /// <param name="timeoutInMS">超时时间(MS)</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetGvcpTimeout(out uint timeoutInMS);

    /// <summary>设置重传GVCP命令次数</summary>
    /// <param name="retryGvcpTimes">重传次数，范围：0-100 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetRetryGvcpTimes(uint retryGvcpTimes);

    /// <summary>获取重传GVCP命令次数</summary>
    /// <param name="retryGvcpTimes">重传次数</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetRetryGvcpTimes(out uint retryGvcpTimes);

    /// <summary>设置是否打开重发包，及重发包参数</summary>
    /// <param name="enable">是否支持重发包</param>
    /// <param name="maxResendPercent">最大重发比</param>
    /// <param name="resendTimeout">重发超时时间</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetResend(bool enable, uint maxResendPercent, uint resendTimeout);

    /// <summary>设置重传命令最大尝试次数</summary>
    /// <param name="retryTimes">重传命令最大尝试次数，默认值20</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 该接口必须在调用<see cref="M:MvCameraControl.IGigEDevice.SetResend(System.Boolean,System.UInt32,System.UInt32)" />开启重传包功能之后调用，否则失败且返回MV_E_CALLORDER。
    /// </remarks>
    int SetResendMaxRetryTimes(uint retryTimes);

    /// <summary>获取重传命令最大尝试次数</summary>
    /// <param name="retryTimes">传命令最大尝试次数 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 该接口必须在调用<see cref="M:MvCameraControl.IGigEDevice.SetResend(System.Boolean,System.UInt32,System.UInt32)" />开启重传包功能之后调用，否则失败且返回MV_E_CALLORDER。
    /// </remarks>
    int GetResendMaxRetryTimes(out uint retryTimes);

    /// <summary>设置同一重传包多次请求之间的时间间隔</summary>
    /// <param name="timeInMS">同一重传包多次请求之间的时间间隔，默认10ms </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetResendTimeInterval(uint timeInMS);

    /// <summary>获取同一重传包多次请求之间的时间间隔</summary>
    /// <param name="timeInMS">同一重传包多次请求之间的时间间隔(以毫秒为单位)</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetResendTimeInterval(out uint timeInMS);

    /// <summary>设置传输模式，可以为单播模式、组播模式等</summary>
    /// <param name="type">传输模式</param>
    /// <param name="multicastIP">组播地址，组播模式下有意义</param>
    /// <param name="multicastPort">组播端口，组播模式下有意义</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetTransmissionType(TransmissionType type, uint multicastIP, uint multicastPort);
  }
}
