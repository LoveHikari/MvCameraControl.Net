// Decompiled with JetBrains decompiler
// Type: MvCameraControl.EventOutInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  internal class EventOutInfo : IEventOutInfo
  {
    public EventOutInfo(MvCCDll.MV_EVENT_OUT_INFO eventOutInfo)
    {
      this.EventName = eventOutInfo.EventName;
      this.EventID = eventOutInfo.nEventID;
      this.StreamChannel = eventOutInfo.nStreamChannel;
      this.BlockId = ((ulong) eventOutInfo.nBlockIdHigh << 32) + (ulong) eventOutInfo.nBlockIdLow;
      this.Timestamp = ((ulong) eventOutInfo.nTimestampHigh << 32) + (ulong) eventOutInfo.nTimestampLow;
      this.EventDataSize = eventOutInfo.nEventDataSize;
      this.EventData = new byte[eventOutInfo.nEventDataSize];
      if (eventOutInfo.nEventDataSize == 0U)
        return;
      Marshal.Copy(eventOutInfo.pEventData, this.EventData, 0, (int) eventOutInfo.nEventDataSize);
    }

    /// <summary>Event名称</summary>
    public string EventName { get; set; }

    /// <summary>EventID</summary>
    public ushort EventID { get; set; }

    /// <summary>流通道序号</summary>
    public ushort StreamChannel { get; set; }

    /// <summary>帧号</summary>
    public ulong BlockId { get; set; }

    /// <summary>时间戳</summary>
    public ulong Timestamp { get; set; }

    /// <summary>Event数据长度</summary>
    public uint EventDataSize { get; set; }

    /// <summary>Event数据</summary>
    public byte[] EventData { get; set; }
  }
}
