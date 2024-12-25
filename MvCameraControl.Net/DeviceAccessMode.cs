// Decompiled with JetBrains decompiler
// Type: MvCameraControl.DeviceAccessMode
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>设备访问权限，只支持GigE设备</summary>
  public enum DeviceAccessMode
  {
    /// <summary>独占权限，其他APP只允许读CCP寄存器</summary>
    AccessExclusive = 1,
    /// <summary>可以从5模式下抢占权限，然后以独占权限打开</summary>
    AccessExclusiveWithSwitch = 2,
    /// <summary>控制权限，其他APP允许读所有寄存器</summary>
    AccessControl = 3,
    /// <summary>可以从5模式下抢占权限，然后以控制权限打开</summary>
    AccessControlWithSwitch = 4,
    /// <summary>以可被抢占的控制权限打开</summary>
    AccessControlSwitchEnable = 5,
    /// <summary>可以从5模式下抢占权限，然后以可被抢占的控制权限打开</summary>
    AccessControlSwitchEnableWithKey = 6,
    /// <summary>读模式打开设备，适用于控制权限下</summary>
    AccessMonitor = 7,
  }
}
