// Decompiled with JetBrains decompiler
// Type: MvCameraControl.USBDevice
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  internal class USBDevice : Device, IUSBDevice, IDevice, IDisposable
  {
      public USBDevice(IDeviceInfo deviceInfo) : base(deviceInfo)
      {
      }

      /// <summary>设置U3V的传输包大小</summary>
    /// <param name="transferSize">传输的包大小,单位：Byte，默认为1M，范围：Windows[0x400, 0x400000], Linux[0x400, 0x200000]</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 增加传输包大小可以适当降低取流时的CPU占用率。但不同的PC和不同USB扩展卡存在不同的兼容性，如果该参数设置过大可能会出现取不到图像的风险。
    /// </remarks>
    public int SetTransferSize(uint transferSize)
    {
      return MvCCDll.MV_USB_SetTransferSize(this.DevHandle, transferSize);
    }

    /// <summary>获取U3V的传输包大小</summary>
    /// <param name="transferSize">传输的包大小， 单位：Byte</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int GetTransferSize(out uint transferSize)
    {
      transferSize = 0U;
      return MvCCDll.MV_USB_GetTransferSize(this.DevHandle, ref transferSize);
    }

    /// <summary>设置U3V的传输通道个数</summary>
    /// <param name="transferWays">传输通道个数，范围：1-10 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 可根据PC的性能、设备出图帧率、图像大小和内存使用率等因素对该参数进行调节。但不同的PC和不同的USB扩展卡存在不同的兼容性。
    /// </remarks>
    public int SetTransferWays(uint transferWays)
    {
      return MvCCDll.MV_USB_SetTransferWays(this.DevHandle, transferWays);
    }

    /// <summary>获取U3V的传输通道个数</summary>
    /// <param name="transferWays">传输通道个数</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 该接口用于获取当前的U3V异步取流节点个数，2000W设备的MONO8默认为3个，YUV为默认2个，RGB为默认1个，其它情况默认8个节点。
    /// </remarks>
    public int GetTransferWays(out uint transferWays)
    {
      transferWays = 0U;
      return MvCCDll.MV_USB_GetTransferWays(this.DevHandle, ref transferWays);
    }

    /// <summary>设置U3V的事件缓存节点个数</summary>
    /// <param name="eventNodeNum">事件缓存节点个数，范围：1-64 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>该接口用于设置当前的U3V事件缓存节点个数，默认情况下为5个。</remarks>
    public int SetEventNodeNum(uint eventNodeNum)
    {
      return MvCCDll.MV_USB_SetEventNodeNum(this.DevHandle, eventNodeNum);
    }

    /// <summary>设置U3V相机同步读写超时时间，范围为1000~UINT，默认1000 ms</summary>
    /// <param name="timeoutInMS">同步读写超时时间</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetSyncTimeOut(uint timeoutInMS)
    {
      return MvCCDll.MV_USB_SetSyncTimeOut(this.DevHandle, timeoutInMS);
    }

    /// <summary>获取U3V相机同步读写超时时间</summary>
    /// <param name="timeoutInMS">同步读写超时时间</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int GetSyncTimeOut(out uint timeoutInMS)
    {
      timeoutInMS = 0U;
      return MvCCDll.MV_USB_GetSyncTimeOut(this.DevHandle, ref timeoutInMS);
    }

    /// <summary>获取主机从USB设备接收的数据统计信息，如已接收字节数、帧数</summary>
    /// <param name="usbTransInfo">USB传输信息</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int GetUSBTransInfo(out USBTransInfo usbTransInfo)
    {
      usbTransInfo = new USBTransInfo();
      MvCCDll.MV_ALL_MATCH_INFO pstInfo = new MvCCDll.MV_ALL_MATCH_INFO();
      MvCCDll.MV_MATCH_INFO_USB_DETECT matchInfoUsbDetect = new MvCCDll.MV_MATCH_INFO_USB_DETECT();
      byte[] numArray = new byte[Marshal.SizeOf(typeof (MvCCDll.MV_MATCH_INFO_USB_DETECT))];
      MvCCDll.StructToBytes<MvCCDll.MV_MATCH_INFO_USB_DETECT>(matchInfoUsbDetect, numArray);
      pstInfo.pInfo = Marshal.UnsafeAddrOfPinnedArrayElement((Array) numArray, 0);
      pstInfo.nType = 2U;
      pstInfo.nInfoSize = (uint) Marshal.SizeOf(typeof (MvCCDll.MV_MATCH_INFO_USB_DETECT));
      int allMatchInfo = MvCCDll.MV_CC_GetAllMatchInfo(this.DevHandle, ref pstInfo);
      if (allMatchInfo != 0)
        return allMatchInfo;
      MvCCDll.MV_MATCH_INFO_USB_DETECT structure = (MvCCDll.MV_MATCH_INFO_USB_DETECT) Marshal.PtrToStructure(pstInfo.pInfo, typeof (MvCCDll.MV_MATCH_INFO_USB_DETECT));
      usbTransInfo.ReceiveDataSize = structure.nReviceDataSize;
      usbTransInfo.ReceivedFrameCount = structure.nRevicedFrameCount;
      usbTransInfo.ErrorFrameCount = structure.nErrorFrameCount;
      return 0;
    }
  }
}
