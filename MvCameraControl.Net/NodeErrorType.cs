// Decompiled with JetBrains decompiler
// Type: MvCameraControl.NodeErrorType
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>节点错误信息的类型</summary>
  public enum NodeErrorType
  {
    /// <summary>节点不存在</summary>
    NODE_INVALID = 1,
    /// <summary>访问条件错误,通常是节点不可读写</summary>
    ACCESS_ERROR = 2,
    /// <summary>写入越界,超出该节点支持的范围</summary>
    OUT_RANGE = 3,
    /// <summary>校验失败,通常是写入的值与文件中的值不匹配</summary>
    VERIFY_FAILD = 4,
    /// <summary>其它错误,可查阅日志</summary>
    OTHER = 100, // 0x00000064
  }
}
