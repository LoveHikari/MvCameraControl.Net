// Decompiled with JetBrains decompiler
// Type: MvCameraControl.Interface
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace MvCameraControl
{
  internal class Interface : IInterface, IDisposable
  {
    private IntPtr _ifHandle = IntPtr.Zero;
    private IParameters _parameters;
    private IEventGrabber _eventGrabber;
    private bool _isDisposed;

    public Interface(IntPtr handle)
    {
      this._ifHandle = handle;
      this._parameters = (IParameters) new MvCameraControl.Parameters(this._ifHandle);
      this._eventGrabber = (IEventGrabber) new MvCameraControl.EventGrabber(this._ifHandle);
    }

    /// <summary>打开采集卡</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int Open() => MvCCDll.MV_CC_OpenInterface(this._ifHandle, "");

    /// <summary>关闭采集卡</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int Close() => MvCCDll.MV_CC_CloseInterface(this._ifHandle);

    /// <summary>获取采集卡对应的参数配置对象</summary>
    public IParameters Parameters => this._parameters;

    public IEventGrabber EventGrabber => this._eventGrabber;

    /// <summary>设备本地升级</summary>
    /// <param name="filePath">升级文件路径</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 通过该接口可以将升级固件文件发送给设备进行升级。该接口需要等待升级固件文件成功传给设备端之后再返回，响应时间可能较长。
    /// </remarks>
    public int LocalUpgrade(string filePath)
    {
      return MvCCDll.MV_CC_LocalUpgrade(this._ifHandle, filePath);
    }

    /// <summary>获取升级进度</summary>
    /// <param name="process">升级进度</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int GetUpgradeProcess(out uint process)
    {
      process = 0U;
      return MvCCDll.MV_CC_GetUpgradeProcess(this._ifHandle, ref process);
    }

    /// <summary>枚举采集卡上的相机</summary>
    /// <param name="devInfoList">相机列表</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int EnumDevices(out List<IDeviceInfo> devInfoList)
    {
      devInfoList = new List<IDeviceInfo>();
      int num;
      try
      {
        MvCCDll.MV_CC_DEVICE_INFO_LIST pstDevInfoList = new MvCCDll.MV_CC_DEVICE_INFO_LIST();
        num = MvCCDll.MV_CC_EnumDevicesByInterface(this._ifHandle, ref pstDevInfoList);
        if (num == 0)
          InnerTools.DevInfoListStruct2DevInfoList(pstDevInfoList, ref devInfoList);
      }
      catch (Exception ex)
      {
        num = -2147483642;
      }
      return num;
    }

    public int EventNotificationOn(string eventName)
    {
      return MvCCDll.MV_CC_EventNotificationOn(this._ifHandle, eventName);
    }

    public int EventNotificationOff(string eventName)
    {
      return MvCCDll.MV_CC_EventNotificationOff(this._ifHandle, eventName);
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this._isDisposed)
        return;
      int num = disposing ? 1 : 0;
      if (this._ifHandle != IntPtr.Zero)
      {
        MvCCDll.MV_CC_DestroyInterface(this._ifHandle);
        this._ifHandle = IntPtr.Zero;
      }
      this._isDisposed = true;
    }

    ~Interface() => this.Dispose(false);
  }
}
