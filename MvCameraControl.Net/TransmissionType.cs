// Decompiled with JetBrains decompiler
// Type: MvCameraControl.TransmissionType
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>GigE传输类型</summary>
  public enum TransmissionType
  {
    /// <summary>单播</summary>
    Unicast = 0,
    /// <summary>组播</summary>
    Multicast = 1,
    /// <summary>局域网内广播</summary>
    LimitedBroadcast = 2,
    /// <summary>子网内广播</summary>
    SubnetBroadcast = 3,
    /// <summary>从相机获取</summary>
    CameraDefined = 4,
    /// <summary>用户自定义应用端接收图像数据Port号</summary>
    UnicastDefinedPort = 5,
    /// <summary>设置了单播，但本实例不接收图像数据</summary>
    UnicastWithoutRecv = 65536, // 0x00010000
    /// <summary>组播模式，但本实例不接收图像数据</summary>
    MulticastWithoutRecv = 65537, // 0x00010001
  }
}
