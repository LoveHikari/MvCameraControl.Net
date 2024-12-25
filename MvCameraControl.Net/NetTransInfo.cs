// Decompiled with JetBrains decompiler
// Type: MvCameraControl.NetTransInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>GigE设备网络传输的相关信息</summary>
  public struct NetTransInfo
  {
    /// <summary>已接收数据大小 [统计StartGrabbing和StopGrabbing之间的数据量]</summary>
    public long ReceiveDataSize;
    /// <summary>丢失的包数量</summary>
    public long LostPacketCount;
    /// <summary>丢帧数量</summary>
    public int LostFrameCount;
    /// <summary>已接收的帧数</summary>
    public uint NetRecvFrameCount;
    /// <summary>请求重发包数</summary>
    public ulong RequestResendPacketCount;
    /// <summary>重发包数</summary>
    public ulong ResendPacketCount;
  }
}
