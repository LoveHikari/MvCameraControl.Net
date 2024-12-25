// Decompiled with JetBrains decompiler
// Type: MvCameraControl.MvPoint
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
    /// <summary>点</summary>
    /// <summary>构造函数</summary>
    public struct MvPoint
    {
    /// <summary>该点距离图像左边缘距离，根据图像的相对位置，范围为[0.0 , 1.0]</summary>
    public float X;
    /// <summary>该点距离图像上边缘距离，根据图像的相对位置，范围为[0.0 , 1.0]</summary>
    public float Y;

    /// <summary>点</summary>
    /// <summary>构造函数</summary>
    /// <param name="x">该点距离图像左边缘距离，根据图像的相对位置，范围为[0.0 , 1.0]</param>
    /// <param name="y">该点距离图像上边缘距离，根据图像的相对位置，范围为[0.0 , 1.0]</param>
    public MvPoint(float x, float y)
    {
        X = x;
        Y = y;
    }
  }
}
