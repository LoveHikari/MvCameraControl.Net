﻿// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IEnumValue
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>枚举类型参数</summary>
  public interface IEnumValue
  {
    /// <summary>当前枚举项</summary>
    IEnumEntry CurEnumEntry { get; }

    /// <summary>支持的枚举类型个数</summary>
    uint SupportedNum { get; }

    /// <summary>支持的枚举项列表</summary>
    IEnumEntry[] SupportEnumEntries { get; }
  }
}