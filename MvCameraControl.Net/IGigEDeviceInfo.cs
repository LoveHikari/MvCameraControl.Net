// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IGigEDeviceInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>GigE相机信息</summary>
  public interface IGigEDeviceInfo : IDeviceInfo
  {
    /// <summary>GigE Vision协议主要版本</summary>
    ushort MajorVer { get; }

    /// <summary>GigE Vision协议次要版本</summary>
    ushort MinorVer { get; }

    /// <summary>高MAC地址</summary>
    uint MacAddrHigh { get; }

    /// <summary>低MAC地址</summary>
    uint MacAddrLow { get; }

    /// <summary>IP配置选项</summary>
    uint IpCfgOption { get; }

    /// <summary>当前IP配置</summary>
    uint IpCfgCurrent { get; }

    /// <summary>当前IP地址</summary>
    uint CurrentIp { get; }

    /// <summary>当前子网掩码</summary>
    uint CurrentSubNetMask { get; }

    /// <summary>当前网关</summary>
    uint DefultGateWay { get; }

    /// <summary>网口IP地址</summary>
    uint NetExport { get; }

    /// <summary>是否虚拟相机</summary>
    bool VirtualDevice { get; }

    /// <summary>是否采集卡上的相机</summary>
    bool GenTLDevice { get; }
  }
}
