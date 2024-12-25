// Decompiled with JetBrains decompiler
// Type: MvCameraControl.GammaType
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>Gamma类型</summary>
  public enum GammaType
  {
    /// <summary>不启用</summary>
    None,
    /// <summary>Gamma值</summary>
    Value,
    /// <summary>
    /// Gamma曲线
    /// 8位，长度：256*sizeof(unsigned char)
    /// 10位，长度：1024*sizeof(unsigned short)
    /// 12位，长度：4096*sizeof(unsigned short)
    /// 16位，长度：65536*sizeof(unsigned short)
    /// </summary>
    UserCurve,
    /// <summary>linear RGB to sRGB</summary>
    LRGB2SRGB,
    /// <summary>sRGB to linear RGB（仅色彩插值时支持，色彩校正时无效）</summary>
    SRGB2LRGB,
  }
}
