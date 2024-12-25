// Decompiled with JetBrains decompiler
// Type: MvCameraControl.XmlAccessMode
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>Xml节点访问模式</summary>
  public enum XmlAccessMode
  {
    /// <summary>不可实现</summary>
    NI,
    /// <summary>不可用</summary>
    NA,
    /// <summary>只写</summary>
    WO,
    /// <summary>只读</summary>
    RO,
    /// <summary>读写</summary>
    RW,
    /// <summary>未定义</summary>
    Undefined,
    /// <summary>内部用于AccessMode循环检测</summary>
    CycleDetect,
  }
}
