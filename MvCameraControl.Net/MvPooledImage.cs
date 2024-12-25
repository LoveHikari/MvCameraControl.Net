// Decompiled with JetBrains decompiler
// Type: MvCameraControl.MvPooledImage
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  /// <summary>基于内存池的Image对象，用于图像处理相关接口</summary>
  internal class MvPooledImage : MvImage
  {
    private ByteBlock _byteBlock;
    private ByteBlockPool _byteBlockPool;

    public override IntPtr PixelDataPtr
    {
      get => Marshal.UnsafeAddrOfPinnedArrayElement((Array) this._byteBlock.ByteArray, 0);
    }

    public override byte[] PixelData => this._byteBlock.ByteArray;

    /// <summary>根据图像宽、高和像素格式创建对象，内部申请内存</summary>
    /// <param name="width">图像宽度</param>
    /// <param name="height">图像高度</param>
    /// <param name="pixelType">像素格式</param>
    /// <param name="handle">相机句柄，用于ToBitmap时像素格式转换</param>
    /// <param name="pool">内存池</param>
    public MvPooledImage(
      uint width,
      uint height,
      MvGvspPixelType pixelType,
      IntPtr handle,
      ByteBlockPool pool)
    {
      this._width = width;
      this._height = height;
      this._pixelType = pixelType;
      this._deviceHandle = handle;
      this._byteBlockPool = pool;
      ulong imageSize = InnerTools.GetImageSize(width, height, pixelType);
      this._byteBlock = this._byteBlockPool.GetByteBlock((long) imageSize);
      this._pixelData = this._byteBlock.ByteArray;
      this._imageSize = imageSize;
    }

    /// <summary>根据图像宽、高、像素格式、图像大小创建对象，内部申请内存</summary>
    /// <param name="width">图像宽度</param>
    /// <param name="height">图像高度</param>
    /// <param name="pixelType">像素格式</param>
    /// <param name="handle">相机句柄，用于ToBitmap时像素格式转换</param>
    /// <param name="imageSize">图像大小</param>
    /// <param name="pool">内存池</param>
    public MvPooledImage(
      uint width,
      uint height,
      MvGvspPixelType pixelType,
      ulong imageSize,
      IntPtr handle,
      ByteBlockPool pool)
    {
      this._width = width;
      this._height = height;
      this._pixelType = pixelType;
      this._deviceHandle = handle;
      this._byteBlockPool = pool;
      this._byteBlock = this._byteBlockPool.GetByteBlock((long) imageSize);
      this._pixelData = this._byteBlock.ByteArray;
      this._imageSize = imageSize;
    }

    /// <summary>根据图像宽、高、像素格式、图像大小创建对象，外部传入内存池内存</summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="pixelType"></param>
    /// <param name="imageSize"></param>
    /// <param name="byteBlock"></param>
    /// <param name="handle"></param>
    /// <param name="pool"></param>
    public MvPooledImage(
      uint width,
      uint height,
      MvGvspPixelType pixelType,
      ulong imageSize,
      ByteBlock byteBlock,
      IntPtr handle,
      ByteBlockPool pool)
    {
      this._width = width;
      this._height = height;
      this._pixelType = pixelType;
      this._deviceHandle = handle;
      this._byteBlockPool = pool;
      this._byteBlock = byteBlock;
      this._pixelData = this._byteBlock.ByteArray;
      this._imageSize = imageSize;
    }

    ~MvPooledImage() => this.Dispose(false);

    protected override void Dispose(bool disposing)
    {
      if (this._isDisposed)
        return;
      if (this._byteBlock != null)
      {
        if (disposing)
        {
          if (this._byteBlockPool != null)
          {
            this._byteBlockPool.FreeByteBlock(this._byteBlock, disposing);
            this._byteBlock = (ByteBlock) null;
          }
        }
        else
          this._byteBlock = (ByteBlock) null;
      }
      this._isDisposed = true;
    }
  }
}
