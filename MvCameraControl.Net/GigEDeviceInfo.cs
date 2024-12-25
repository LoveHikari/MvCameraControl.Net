// Decompiled with JetBrains decompiler
// Type: MvCameraControl.GigEDeviceInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>gige设备信息实现</summary>
  internal class GigEDeviceInfo : IGigEDeviceInfo, IDeviceInfo
  {
    /// <summary>占用设备的主机ip</summary>
    public uint HostIp;
    /// <summary>组播ip</summary>
    public uint nMulticastIp;
    /// <summary>组播port</summary>
    public uint nMulticastPort;

    /// <summary>设备接口类型</summary>
    public DeviceTLayerType TLayerType { get; set; }

    /// <summary>制造商信息</summary>
    public string ManufacturerName { get; set; }

    /// <summary>制造商特殊信息</summary>
    public string ManufacturerSpecificInfo { get; set; }

    /// <summary>设备型号</summary>
    public string ModelName { get; set; }

    /// <summary>设备版本</summary>
    public string DeviceVersion { get; set; }

    /// <summary>设备序列号</summary>
    public string SerialNumber { get; set; }

    /// <summary>用户自定义名称</summary>
    public string UserDefinedName { get; set; }

    /// <summary>
    /// 设备类型信息，7 - 0 bit: 预留，15 - 8 bit：产品子类别，23 - 16 bit：产品类型，31 - 24bit：产品线（如: 0x01 标准产品；0x02 3D产品；0x03 智能ID产品）
    /// </summary>
    public uint DevTypeInfo { get; set; }

    /// <summary>GigE Vision协议主要版本</summary>
    public ushort MajorVer { get; set; }

    /// <summary>GigE Vision协议次要版本</summary>
    public ushort MinorVer { get; set; }

    /// <summary>高MAC地址</summary>
    public uint MacAddrHigh { get; set; }

    /// <summary>低MAC地址</summary>
    public uint MacAddrLow { get; set; }

    /// <summary>IP配置选项</summary>
    public uint IpCfgOption { get; set; }

    /// <summary>当前IP配置</summary>
    public uint IpCfgCurrent { get; set; }

    /// <summary>当前IP地址</summary>
    public uint CurrentIp { get; set; }

    /// <summary>当前子网掩码</summary>
    public uint CurrentSubNetMask { get; set; }

    /// <summary>当前网关</summary>
    public uint DefultGateWay { get; set; }

    /// <summary>网口IP地址</summary>
    public uint NetExport { get; set; }

    /// <summary>是否虚拟相机</summary>
    public bool VirtualDevice { get; set; }

    /// <summary>是否采集卡上的相机</summary>
    public bool GenTLDevice { get; set; }
  }
}
