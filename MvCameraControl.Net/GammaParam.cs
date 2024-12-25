// Decompiled with JetBrains decompiler
// Type: MvCameraControl.GammaParam
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>Gamma参数</summary>
  public struct GammaParam
  {
    /// <summary>Gamma类型</summary>
    public GammaType Type;
    /// <summary>Gamma值[0.1, 4.0]</summary>
    public float Value;
    /// <summary>Gamma曲线缓存</summary>
    public byte[] CurveBuf;
    /// <summary>Gamma曲线长度</summary>
    public uint CurveLen;
  }
}
