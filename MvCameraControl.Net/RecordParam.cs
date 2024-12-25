// Decompiled with JetBrains decompiler
// Type: MvCameraControl.RecordParam
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>录像参数</summary>
  public struct RecordParam
  {
    /// <summary>输入数据的像素格式</summary>
    public MvGvspPixelType PixelType;
    /// <summary>图像宽（指定目标参数时需为2的倍数）</summary>
    public uint Width;
    /// <summary>图像高（指定目标参数时需为2的倍数）</summary>
    public uint Height;
    /// <summary>帧率fps(大于1/16)</summary>
    public float FrameRate;
    /// <summary>码率kbps(128-16*1024)</summary>
    public uint BitRate;
    /// <summary>录像格式</summary>
    public VideoFormatType FormatType;
  }
}
