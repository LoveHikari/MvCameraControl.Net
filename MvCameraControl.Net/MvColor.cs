// Decompiled with JetBrains decompiler
// Type: MvCameraControl.MvColor
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
    /// <summary>颜色</summary>
    /// <summary>构造函数</summary>
    public struct MvColor
    {
    /// <summary>红色，根据像素颜色的相对深度，范围为[0.0 , 1.0]，代表着[0, 255]的颜色深度</summary>
    public float R;
    /// <summary>绿色，根据像素颜色的相对深度，范围为[0.0 , 1.0]，代表着[0, 255]的颜色深度</summary>
    public float G;
    /// <summary>蓝色，根据像素颜色的相对深度，范围为[0.0 , 1.0]，代表着[0, 255]的颜色深度</summary>
    public float B;
    /// <summary>透明度，根据像素颜色的相对透明度，范围为[0.0 , 1.0] （此参数功能暂不支持）</summary>
    public float Alpha;

    /// <summary>颜色</summary>
    /// <summary>构造函数</summary>
    /// <param name="r">红色，根据像素颜色的相对深度，范围为[0.0 , 1.0]，代表着[0, 255]的颜色深度</param>
    /// <param name="g">绿色，根据像素颜色的相对深度，范围为[0.0 , 1.0]，代表着[0, 255]的颜色深度</param>
    /// <param name="b">蓝色，根据像素颜色的相对深度，范围为[0.0 , 1.0]，代表着[0, 255]的颜色深度</param>
    /// <param name="alpha">透明度，根据像素颜色的相对透明度，范围为[0.0 , 1.0] （此参数功能暂不支持）</param>
    public MvColor(float r, float g, float b, float alpha)
    {
        R = r;
        G = g;
        B = b;
        Alpha = alpha;
    }
  }
}
