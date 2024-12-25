// Decompiled with JetBrains decompiler
// Type: MvCameraControl.MvImage
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  /// <summary>图像类，实现基本的图像属性和接口,实现图像克隆、ToBitmap。作为其他图像类的基类</summary>
  internal class MvImage : IImage, ICloneable, IDisposable
  {
    protected byte[] _pixelData;
    protected uint _width;
    protected uint _height;
    protected MvGvspPixelType _pixelType = MvGvspPixelType.PixelType_Gvsp_Undefined;
    protected ulong _imageSize;
    protected IntPtr _deviceHandle = IntPtr.Zero;
    protected bool _isDisposed;

    /// <summary>相机句柄，用于内部做格式转换等图像处理</summary>
    internal virtual IntPtr DeviceHandle
    {
      get => this._deviceHandle;
      set => this._deviceHandle = value;
    }

    /// <summary>非托管内存指针</summary>
    public virtual IntPtr PixelDataPtr
    {
      get => Marshal.UnsafeAddrOfPinnedArrayElement((Array) this._pixelData, 0);
    }

    /// <summary>图像数据，内部会进行一次拷贝，将非托管内存拷贝到托管内存</summary>
    public virtual byte[] PixelData => this._pixelData;

    public virtual uint Width
    {
      get => this._width;
      internal set => this._width = value;
    }

    public virtual uint Height
    {
      get => this._height;
      internal set => this._height = value;
    }

    public virtual MvGvspPixelType PixelType
    {
      get => this._pixelType;
      internal set => this._pixelType = value;
    }

    public virtual ulong ImageSize
    {
      get => this._imageSize;
      internal set => this._imageSize = value;
    }

    /// <summary>根据图像宽、高和像素格式创建对象，内部申请内存</summary>
    /// <param name="width">图像宽度</param>
    /// <param name="height">图像高度</param>
    /// <param name="pixelType">像素格式</param>
    /// <param name="handle">相机句柄，用于ToBitmap时像素格式转换</param>
    public MvImage(uint width, uint height, MvGvspPixelType pixelType, IntPtr handle)
    {
      this._width = width;
      this._height = height;
      this._pixelType = pixelType;
      ulong imageSize = InnerTools.GetImageSize(width, height, pixelType);
      this._pixelData = new byte[(long) imageSize];
      this._imageSize = imageSize;
      this._deviceHandle = handle;
    }

    /// <summary>根据图像宽、高、像素格式、图像大小创建对象，内部申请内存</summary>
    /// <param name="width">图像宽度</param>
    /// <param name="height">图像高度</param>
    /// <param name="pixelType">像素格式</param>
    /// <param name="imageSize">图像大小</param>
    /// <param name="handle">相机句柄，用于ToBitmap时像素格式转换</param>
    public MvImage(
      uint width,
      uint height,
      MvGvspPixelType pixelType,
      ulong imageSize,
      IntPtr handle)
    {
      this._width = width;
      this._height = height;
      this._pixelType = pixelType;
      this._pixelData = new byte[(long) imageSize];
      this._imageSize = imageSize;
      this._deviceHandle = handle;
    }

    /// <summary>根据图像宽、高、像素格式、图像大小创建对象，外部传入内存</summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="pixelType"></param>
    /// <param name="imageSize"></param>
    /// <param name="buffer"></param>
    /// <param name="handle"></param>
    public MvImage(
      uint width,
      uint height,
      MvGvspPixelType pixelType,
      ulong imageSize,
      byte[] buffer,
      IntPtr handle)
    {
      this._width = width;
      this._height = height;
      this._pixelType = pixelType;
      this._imageSize = imageSize;
      this._pixelData = buffer;
      this._deviceHandle = handle;
    }

    /// <summary>用于克隆</summary>
    /// <param name="image"></param>
    protected MvImage(MvImage image)
    {
      this._width = image.Width;
      this._height = image.Height;
      this._pixelType = image.PixelType;
      this._pixelData = new byte[image.ImageSize];
      this._imageSize = image.ImageSize;
      Marshal.Copy(image.PixelDataPtr, this._pixelData, 0, (int) image.ImageSize);
      this._deviceHandle = image.DeviceHandle;
    }

    /// <summary>构造空对象，内部变量由由子类初始化</summary>
    protected MvImage()
    {
    }

    ~MvImage() => this.Dispose(false);

    protected virtual void Dispose(bool disposing)
    {
      if (this._isDisposed)
        return;
      int num = disposing ? 1 : 0;
      this._isDisposed = true;
    }

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public object Clone() => (object) new MvImage(this);

    public Bitmap ToBitmap()
    {
      if (InnerTools.IsHBPixelType(this.PixelType))
      {
        IImage outImage;
        return new ImageDecoder(this._deviceHandle).HBDecode((IImage) this, out outImage) == 0 ? outImage.ToBitmap() : (Bitmap) null;
      }
      PixelFormat format;
      if (InnerTools.IsMonoPixel(this.PixelType))
      {
        format = PixelFormat.Format8bppIndexed;
      }
      else
      {
        if (!InnerTools.IsColorPixel(this.PixelType))
          throw new MvException(-2147483647, "Unsupport PixelType");
        format = PixelFormat.Format24bppRgb;
      }
      try
      {
        Bitmap bitmap = new Bitmap((int) this.Width, (int) this.Height, format);
        if (format == PixelFormat.Format8bppIndexed)
        {
          ColorPalette palette = bitmap.Palette;
          for (int index = 0; index < palette.Entries.Length; ++index)
            palette.Entries[index] = Color.FromArgb(index, index, index);
          bitmap.Palette = palette;
        }
        IntPtr src = this.PixelDataPtr;
        ulong count = this.ImageSize;
        if (this._pixelType != MvGvspPixelType.PixelType_Gvsp_Mono8 && this._pixelType != MvGvspPixelType.PixelType_Gvsp_BGR8_Packed)
        {
          ulong outDataLen = 0;
          MvGvspPixelType dstPixelType;
          ulong length;
          if (InnerTools.IsMonoPixel(this._pixelType))
          {
            dstPixelType = MvGvspPixelType.PixelType_Gvsp_Mono8;
            length = (ulong) (this._width * this._height);
          }
          else
          {
            dstPixelType = MvGvspPixelType.PixelType_Gvsp_BGR8_Packed;
            length = (ulong) (uint) ((int) this._width * (int) this._height * 3);
          }
          byte[] numArray = new byte[length];
          int errorCode = new PixelTypeConverter(this._deviceHandle).ConvertPixelType((IImage) this, numArray, out outDataLen, dstPixelType);
          if (errorCode != 0)
            throw new MvException(errorCode, "ConvertPixelType failed, result: " + errorCode.ToString("X"));
          src = Marshal.UnsafeAddrOfPinnedArrayElement((Array) numArray, 0);
          count = length;
        }
        BitmapData bitmapdata = bitmap.LockBits(new Rectangle(0, 0, (int) this.Width, (int) this.Height), ImageLockMode.ReadWrite, format);
        InnerTools.CopyMemory(bitmapdata.Scan0, src, (uint) count);
        bitmap.UnlockBits(bitmapdata);
        return bitmap;
      }
      catch (Exception ex)
      {
        return (Bitmap) null;
      }
    }
  }
}
