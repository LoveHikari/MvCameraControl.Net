// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IGenTLIFInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>通过GenTL枚举到的接口信息</summary>
  public interface IGenTLIFInfo
  {
    /// <summary>GenTL接口ID</summary>
    string InterfaceID { get; }

    /// <summary>传输层类型</summary>
    string TLType { get; }

    /// <summary>显示名称</summary>
    string DisplayName { get; }

    /// <summary>GenTL的cti文件索引</summary>
    uint CtiIndex { get; }
  }
}
