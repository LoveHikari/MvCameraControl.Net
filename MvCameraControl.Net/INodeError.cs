﻿// Decompiled with JetBrains decompiler
// Type: MvCameraControl.INodeError
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>参数导入导出时的节点错误信息</summary>
  public interface INodeError
  {
    /// <summary>节点名称</summary>
    string NodeName { get; }

    /// <summary>错误类型</summary>
    NodeErrorType ErrorType { get; }
  }
}