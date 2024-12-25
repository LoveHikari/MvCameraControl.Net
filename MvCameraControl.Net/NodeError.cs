// Decompiled with JetBrains decompiler
// Type: MvCameraControl.NodeError
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>参数导入时出错的节点信息</summary>
  internal class NodeError : INodeError
  {
    /// <summary>节点名称</summary>
    public string NodeName { get; set; }

    /// <summary>错误信息</summary>
    public NodeErrorType ErrorType { get; set; }
  }
}
