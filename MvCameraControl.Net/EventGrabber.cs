// Decompiled with JetBrains decompiler
// Type: MvCameraControl.EventGrabber
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  internal class EventGrabber : IEventGrabber
  {
    private IntPtr _devHandle = IntPtr.Zero;
    private MvCCDll.cbEventdelegateEx _eventDelegate;

    public EventGrabber(IntPtr devHandle)
    {
      this._devHandle = devHandle;
      this._eventDelegate = new MvCCDll.cbEventdelegateEx(this.EventDelegate);
    }

    public event EventHandler<DeviceEventArgs> DeviceEvent;

    public int SubscribeEvent(string eventName)
    {
      return MvCCDll.MV_CC_RegisterEventCallBackEx(this._devHandle, eventName, this._eventDelegate, IntPtr.Zero);
    }

    public int UnSubscribeEvent(string eventName)
    {
      return MvCCDll.MV_CC_RegisterEventCallBackEx(this._devHandle, eventName, (MvCCDll.cbEventdelegateEx) null, IntPtr.Zero);
    }

    public int SubscribeAllEvent()
    {
      return MvCCDll.MV_CC_RegisterAllEventCallBack(this._devHandle, this._eventDelegate, IntPtr.Zero);
    }

    public int UnSubscribeAllEvent()
    {
      return MvCCDll.MV_CC_RegisterAllEventCallBack(this._devHandle, (MvCCDll.cbEventdelegateEx) null, IntPtr.Zero);
    }

    private void EventDelegate(ref MvCCDll.MV_EVENT_OUT_INFO pEventInfo, IntPtr pUser)
    {
      EventHandler<DeviceEventArgs> deviceEvent = this.DeviceEvent;
      if (deviceEvent == null)
        return;
      DeviceEventArgs e = new DeviceEventArgs((IEventOutInfo) new EventOutInfo(pEventInfo));
      deviceEvent((object) this, e);
    }
  }
}
