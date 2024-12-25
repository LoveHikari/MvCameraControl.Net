// Decompiled with JetBrains decompiler
// Type: MvCameraControl.SortMethod
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>排序方式</summary>
  public enum SortMethod
  {
    /// <summary>按序列号排序</summary>
    SortBySerialNumber,
    /// <summary>按用户自定义名字排序</summary>
    SortByUserDefinedName,
    /// <summary>按当前IP地址排序（升序）</summary>
    SortByAscIpAddress,
    /// <summary>按当前IP地址排序（降序）</summary>
    SortByDescIpAddress,
  }
}
