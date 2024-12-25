// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IEventOutInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>设备event信息</summary>
  public interface IEventOutInfo
  {
    /// <summary>Event名称</summary>
    string EventName { get; }

    /// <summary>EventID</summary>
    ushort EventID { get; }

    /// <summary>流通道序号</summary>
    ushort StreamChannel { get; }

    /// <summary>帧号 (暂无固件支持)</summary>
    ulong BlockId { get; }

    /// <summary>时间戳</summary>
    ulong Timestamp { get; }

    /// <summary>Event数据长度 (暂无固件支持)</summary>
    uint EventDataSize { get; }

    /// <summary>Event数据，内部会进行一次拷贝，将非托管内存拷贝到托管内存 (暂无固件支持)</summary>
    byte[] EventData { get; }
  }
}
