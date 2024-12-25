// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ImageFormatInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>图像格式信息</summary>
  public struct ImageFormatInfo
  {
    /// <summary>图像格式</summary>
    public ImageFormatType FormatType;
    /// <summary>JPEG编码质量(50-99]，其他格式无效</summary>
    public uint JpegQuality;
  }
}
