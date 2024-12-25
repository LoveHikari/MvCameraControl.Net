// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IpConfigType
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>IP配置类型</summary>
  public enum IpConfigType
  {
    /// <summary>LLA(Link-local address)，链路本地地址</summary>
    LLA = 67108864, // 0x04000000
    /// <summary>静态IP</summary>
    Static = 83886080, // 0x05000000
    /// <summary>DHCP自动获取IP</summary>
    DHCP = 100663296, // 0x06000000
  }
}
