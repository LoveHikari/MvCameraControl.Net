// Decompiled with JetBrains decompiler
// Type: MvCameraControl.StreamExceptionType
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>流异常类型</summary>
  public enum StreamExceptionType
  {
    /// <summary>异常的图像，该帧被丢弃</summary>
    AbnormalImage = 16385, // 0x00004001
    /// <summary>缓存列表溢出，清除最旧的一帧</summary>
    ListOverflow = 16386, // 0x00004002
    /// <summary>缓存列表为空，该帧被丢弃</summary>
    ListEmpty = 16387, // 0x00004003
    /// <summary>断流恢复</summary>
    Reconnection = 16388, // 0x00004004
    /// <summary>断流,恢复失败,取流被中止</summary>
    Disconnection = 16389, // 0x00004005
    /// <summary>设备异常,取流被中止</summary>
    DeviceException = 16390, // 0x00004006
  }
}
