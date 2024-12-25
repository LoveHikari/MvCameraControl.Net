// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ICamlDeviceInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>Camera Link串口设备信息</summary>
  public interface ICamlDeviceInfo : IDeviceInfo
  {
    /// <summary>端口号</summary>
    string PortID { get; }

    /// <summary>名称</summary>
    string FamilyName { get; }
  }
}
