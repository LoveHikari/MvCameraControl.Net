// Decompiled with JetBrains decompiler
// Type: MvCameraControl.MvRect
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
    /// <summary>矩形</summary>
    /// <summary>构造函数</summary>
    public struct MvRect
    {
    /// <summary>矩形上边缘距离图像上边缘的距离，根据图像的相对位置，范围为[0.0 , 1.0]</summary>
    public float Top;
    /// <summary>矩形下边缘距离图像下边缘的距离，根据图像的相对位置，范围为[0.0 , 1.0]</summary>
    public float Bottom;
    /// <summary>矩形左边缘距离图像左边缘的距离，根据图像的相对位置，范围为[0.0 , 1.0]</summary>
    public float Left;
    /// <summary>矩形右边缘距离图像右边缘的距离，根据图像的相对位置，范围为[0.0 , 1.0]</summary>
    public float Right;

    /// <summary>矩形</summary>
    /// <summary>构造函数</summary>
    /// <param name="top">矩形上边缘距离图像上边缘的距离，根据图像的相对位置，范围为[0.0 , 1.0]</param>
    /// <param name="bottom">矩形下边缘距离图像下边缘的距离，根据图像的相对位置，范围为[0.0 , 1.0]</param>
    /// <param name="left">矩形左边缘距离图像左边缘的距离，根据图像的相对位置，范围为[0.0 , 1.0]</param>
    /// <param name="right">矩形右边缘距离图像右边缘的距离，根据图像的相对位置，范围为[0.0 , 1.0]</param>
    public MvRect(float top, float bottom, float left, float right)
    {
        Top = top;
        Bottom = bottom;
        Left = left;
        Right = right;
    }
  }
}
