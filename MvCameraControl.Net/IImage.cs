// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IImage
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Drawing;

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供获取图像缓存、图像属性的接口</summary>
  public interface IImage : ICloneable, IDisposable
  {
    /// <summary>图像数据指针（非托管内存）</summary>
    IntPtr PixelDataPtr { get; }

    /// <summary>图像数据，内部会进行一次拷贝，将非托管内存拷贝到托管内存</summary>
    byte[] PixelData { get; }

    /// <summary>图像宽度</summary>
    uint Width { get; }

    /// <summary>图像高度</summary>
    uint Height { get; }

    /// <summary>像素格式</summary>
    MvGvspPixelType PixelType { get; }

    /// <summary>图像大小</summary>
    ulong ImageSize { get; }

    /// <summary>转换为Bitmap</summary>
    /// <returns>Bitmap对象，失败返回null</returns>
    Bitmap ToBitmap();
  }
}
