// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ActionCmdInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>动作命令信息</summary>
  public struct ActionCmdInfo
  {
    /// <summary>设备密钥</summary>
    public uint DeviceKey;
    /// <summary>组键</summary>
    public uint GroupKey;
    /// <summary>组掩码</summary>
    public uint GroupMask;
    /// <summary>只有设置成1时Action Time才有效，非1时无效</summary>
    public uint ActionTimeEnable;
    /// <summary>预定的时间，和主频有关</summary>
    public long ActionTime;
    /// <summary>广播包地址</summary>
    public string BroadcastAddress;
    /// <summary>等待ACK的超时时间，如果为0表示不需要ACK</summary>
    public uint TimeOut;
    /// <summary>只有设置成1时指定的网卡IP才有效，非1时无效</summary>
    public uint SpecialNetEnable;
    /// <summary>指定的网卡IP</summary>
    public string SpecialNetIP;
  }
}
