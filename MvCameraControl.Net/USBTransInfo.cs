// Decompiled with JetBrains decompiler
// Type: MvCameraControl.USBTransInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>USB传输信息</summary>
  public struct USBTransInfo
  {
    /// <summary>已接收数据大小 [Open和Close之间]</summary>
    public long ReceiveDataSize;
    /// <summary>已收到的帧数</summary>
    public uint ReceivedFrameCount;
    /// <summary>错误帧数</summary>
    public uint ErrorFrameCount;
  }
}
