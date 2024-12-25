// Decompiled with JetBrains decompiler
// Type: MvCameraControl.XmlInterfaceType
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>每个节点对应的接口类型</summary>
  public enum XmlInterfaceType
  {
    /// <summary>Value</summary>
    IValue,
    /// <summary>Base</summary>
    IBase,
    /// <summary>Integer</summary>
    IInteger,
    /// <summary>Boolean</summary>
    IBoolean,
    /// <summary>Command</summary>
    ICommand,
    /// <summary>Float</summary>
    IFloat,
    /// <summary>String</summary>
    IString,
    /// <summary>Register</summary>
    IRegister,
    /// <summary>Category</summary>
    ICategory,
    /// <summary>Enumeration</summary>
    IEnumeration,
    /// <summary>EnumEntry</summary>
    IEnumEntry,
    /// <summary>Port</summary>
    IPort,
  }
}
