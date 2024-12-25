// Decompiled with JetBrains decompiler
// Type: MvCameraControl.GigEDevice
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  internal class GigEDevice : Device, IGigEDevice, IDevice, IDisposable
  {
      public GigEDevice(IDeviceInfo deviceInfo) : base(deviceInfo)
      {
      }

      /// <summary>获取最佳包大小</summary>
    /// <param name="optimalPacketSize"></param>
    /// <returns></returns>
    public int GetOptimalPacketSize(out int optimalPacketSize)
    {
      optimalPacketSize = MvCCDll.MV_CC_GetOptimalPacketSize(this.DevHandle);
      return optimalPacketSize <= 0 ? optimalPacketSize : 0;
    }

    /// <summary>强制配置ip</summary>
    /// <param name="ip"></param>
    /// <param name="subnetMask"></param>
    /// <param name="defaultGateway"></param>
    /// <returns></returns>
    public int ForceIp(uint ip, uint subnetMask, uint defaultGateway)
    {
      return MvCCDll.MV_GIGE_ForceIpEx(this.DevHandle, ip, subnetMask, defaultGateway);
    }

    /// <summary>设置ip方式</summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public int SetIpConfig(IpConfigType type)
    {
      return MvCCDll.MV_GIGE_SetIpConfig(this.DevHandle, (uint) type);
    }

    /// <summary>设置传输模式，默认为Driver模式</summary>
    /// <param name="mode">网络传输模式</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetNetTransMode(NetTransMode mode)
    {
      return MvCCDll.MV_GIGE_SetNetTransMode(this.DevHandle, (uint) mode);
    }

    /// <summary>获取网络传输信息</summary>
    /// <param name="info">网络传输信息</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int GetNetTransInfo(out NetTransInfo info)
    {
      info = new NetTransInfo();
      MvCCDll.MV_ALL_MATCH_INFO pstInfo = new MvCCDll.MV_ALL_MATCH_INFO();
      MvCCDll.MV_MATCH_INFO_NET_DETECT matchInfoNetDetect = new MvCCDll.MV_MATCH_INFO_NET_DETECT();
      byte[] numArray = new byte[Marshal.SizeOf(typeof (MvCCDll.MV_MATCH_INFO_NET_DETECT))];
      MvCCDll.StructToBytes<MvCCDll.MV_MATCH_INFO_NET_DETECT>(matchInfoNetDetect, numArray);
      pstInfo.pInfo = Marshal.UnsafeAddrOfPinnedArrayElement((Array) numArray, 0);
      pstInfo.nType = 1U;
      pstInfo.nInfoSize = (uint) Marshal.SizeOf(typeof (MvCCDll.MV_MATCH_INFO_NET_DETECT));
      int allMatchInfo = MvCCDll.MV_CC_GetAllMatchInfo(this.DevHandle, ref pstInfo);
      if (allMatchInfo != 0)
        return allMatchInfo;
      MvCCDll.MV_MATCH_INFO_NET_DETECT structure = (MvCCDll.MV_MATCH_INFO_NET_DETECT) Marshal.PtrToStructure(pstInfo.pInfo, typeof (MvCCDll.MV_MATCH_INFO_NET_DETECT));
      info.ReceiveDataSize = structure.nReviceDataSize;
      info.LostPacketCount = structure.nLostPacketCount;
      info.LostFrameCount = (int) structure.nLostFrameCount;
      info.NetRecvFrameCount = structure.nNetRecvFrameCount;
      info.RequestResendPacketCount = (ulong) structure.nRequestResendPacketCount;
      info.ResendPacketCount = (ulong) structure.nResendPacketCount;
      return 0;
    }

    /// <summary>设置GVSP取流超时时间</summary>
    /// <param name="timeoutInMS">超时时间(MS)，默认300ms，范围：&gt;10ms</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetGvspTimeout(uint timeoutInMS)
    {
      return MvCCDll.MV_GIGE_SetGvspTimeout(this.DevHandle, timeoutInMS);
    }

    /// <summary>获取GVSP取流超时时间</summary>
    /// <param name="timeoutInMS">超时时间(MS)</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int GetGvspTimeout(out uint timeoutInMS)
    {
      timeoutInMS = 0U;
      return MvCCDll.MV_GIGE_GetGvspTimeout(this.DevHandle, ref timeoutInMS);
    }

    /// <summary>设置GVCP命令超时时间</summary>
    /// <param name="timeoutInMS">超时时间(MS)，默认500ms，范围：0-10000ms </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetGvcpTimeout(uint timeoutInMS)
    {
      return MvCCDll.MV_GIGE_SetGvcpTimeout(this.DevHandle, timeoutInMS);
    }

    /// <summary>获取GVCP命令超时时间</summary>
    /// <param name="timeoutInMS">超时时间(MS)</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int GetGvcpTimeout(out uint timeoutInMS)
    {
      timeoutInMS = 0U;
      return MvCCDll.MV_GIGE_GetGvcpTimeout(this.DevHandle, ref timeoutInMS);
    }

    /// <summary>设置重传GVCP命令次数</summary>
    /// <param name="retryGvcpTimes">重传次数，范围：0-100 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetRetryGvcpTimes(uint retryGvcpTimes)
    {
      return MvCCDll.MV_GIGE_SetRetryGvcpTimes(this.DevHandle, retryGvcpTimes);
    }

    /// <summary>获取重传GVCP命令次数</summary>
    /// <param name="retryGvcpTimes">重传次数</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int GetRetryGvcpTimes(out uint retryGvcpTimes)
    {
      retryGvcpTimes = 0U;
      return MvCCDll.MV_GIGE_GetRetryGvcpTimes(this.DevHandle, ref retryGvcpTimes);
    }

    /// <summary>设置是否打开重发包，及重发包参数</summary>
    /// <param name="enable">是否支持重发包</param>
    /// <param name="maxResendPercent">最大重发比</param>
    /// <param name="resendTimeout">重发超时时间</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetResend(bool enable, uint maxResendPercent, uint resendTimeout)
    {
      return MvCCDll.MV_GIGE_SetResend(this.DevHandle, enable ? 1U : 0U, maxResendPercent, resendTimeout);
    }

    /// <summary>设置重传命令最大尝试次数</summary>
    /// <param name="retryTimes">重传命令最大尝试次数，默认值20</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 该接口必须在调用<see cref="M:MvCameraControl.GigEDevice.SetResend(System.Boolean,System.UInt32,System.UInt32)" />开启重传包功能之后调用，否则失败且返回MV_E_CALLORDER。
    /// </remarks>
    public int SetResendMaxRetryTimes(uint retryTimes)
    {
      return MvCCDll.MV_GIGE_SetResendMaxRetryTimes(this.DevHandle, retryTimes);
    }

    /// <summary>获取重传命令最大尝试次数</summary>
    /// <param name="retryTimes">传命令最大尝试次数 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 该接口必须在调用<see cref="M:MvCameraControl.GigEDevice.SetResend(System.Boolean,System.UInt32,System.UInt32)" />开启重传包功能之后调用，否则失败且返回MV_E_CALLORDER。
    /// </remarks>
    public int GetResendMaxRetryTimes(out uint retryTimes)
    {
      retryTimes = 0U;
      return MvCCDll.MV_GIGE_GetResendMaxRetryTimes(this.DevHandle, ref retryTimes);
    }

    /// <summary>设置同一重传包多次请求之间的时间间隔</summary>
    /// <param name="timeInMS">同一重传包多次请求之间的时间间隔，默认10ms </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetResendTimeInterval(uint timeInMS)
    {
      return MvCCDll.MV_GIGE_SetResendTimeInterval(this.DevHandle, timeInMS);
    }

    /// <summary>获取同一重传包多次请求之间的时间间隔</summary>
    /// <param name="timeInMS"></param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int GetResendTimeInterval(out uint timeInMS)
    {
      timeInMS = 0U;
      return MvCCDll.MV_GIGE_GetResendTimeInterval(this.DevHandle, ref timeInMS);
    }

    /// <summary>设置传输模式，可以为单播模式、组播模式等</summary>
    /// <param name="type"></param>
    /// <param name="multicastIP">组播地址，组播模式下有意义</param>
    /// <param name="multicastPort">组播端口，组播模式下有意义</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetTransmissionType(TransmissionType type, uint multicastIP, uint multicastPort)
    {
        var v = new MvCCDll.MV_CC_TRANSMISSION_TYPE()
        {
            enTransmissionType = (MvCCDll.MV_GIGE_TRANSMISSION_TYPE)type,
            nDestIp = multicastIP,
            nDestPort = (ushort)multicastPort
        };
      return MvCCDll.MV_GIGE_SetTransmissionType(this.DevHandle, ref v);
    }
  }
}
