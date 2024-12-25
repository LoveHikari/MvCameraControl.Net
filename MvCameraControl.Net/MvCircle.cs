// Decompiled with JetBrains decompiler
// Type: MvCameraControl.MvCircle
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
    /// <summary>圆形</summary>
    /// <summary>构造函数</summary>
    public struct MvCircle
    {
    /// <summary>圆心</summary>
    public MvPoint CenterPoint;
    /// <summary>
    /// 宽向半径，根据图像的相对位置[0, 1.0]，半径与圆心的位置有关，需保证画出的圆在显示框范围之内，否则报错
    /// </summary>
    public float R1;
    /// <summary>
    /// 高向半径，根据图像的相对位置[0, 1.0]，半径与圆心的位置有关，需保证画出的圆在显示框范围之内，否则报错
    /// </summary>
    public float R2;

    /// <summary>圆形</summary>
    /// <summary>构造函数</summary>
    /// <param name="centerPoint">圆心</param>
    /// <param name="r1">宽向半径，根据图像的相对位置[0, 1.0]，半径与圆心的位置有关，需保证画出的圆在显示框范围之内，否则报错</param>
    /// <param name="r2">高向半径，根据图像的相对位置[0, 1.0]，半径与圆心的位置有关，需保证画出的圆在显示框范围之内，否则报错</param>
    public MvCircle(MvPoint centerPoint, float r1, float r2)
    {
        CenterPoint = centerPoint;
        R1 = r1;
        R2 = r2;
    }
  }
}
