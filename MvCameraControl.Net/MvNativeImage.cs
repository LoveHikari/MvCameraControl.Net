// Decompiled with JetBrains decompiler
// Type: MvCameraControl.MvNativeImage
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  /// <summary>从C库获取图像地址（GetImageBuffer或者回调），包装成Image，图像数据存放在非托管内存中</summary>
  internal class MvNativeImage : MvImage
  {
    private IntPtr _pixelDataPtr = IntPtr.Zero;

    /// <summary>非托管内存指针</summary>
    public override IntPtr PixelDataPtr => this._pixelDataPtr;

    /// <summary>图像数据，内部会进行一次拷贝，将非托管内存拷贝到托管内存</summary>
    public override byte[] PixelData
    {
      get
      {
        if (this._pixelData == null)
        {
          this._pixelData = new byte[this.ImageSize];
          Marshal.Copy(this.PixelDataPtr, this._pixelData, 0, (int) this.ImageSize);
        }
        return this._pixelData;
      }
    }

    /// <summary>使用传入的非托管内存创建新的对象</summary>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="pixelType"></param>
    /// <param name="pixelDataPtr"></param>
    /// <param name="pixelDataLen"></param>
    /// <param name="devHandle">设备句柄</param>
    public MvNativeImage(
      uint width,
      uint height,
      MvGvspPixelType pixelType,
      IntPtr pixelDataPtr,
      ulong pixelDataLen,
      IntPtr devHandle)
    {
      this._width = width;
      this._height = height;
      this._pixelType = pixelType;
      this._pixelDataPtr = pixelDataPtr;
      this._imageSize = pixelDataLen;
      this._deviceHandle = devHandle;
    }

    ~MvNativeImage() => this.Dispose(false);

    protected override void Dispose(bool disposing)
    {
      if (this._isDisposed)
        return;
      int num = disposing ? 1 : 0;
      var v = new MvCCDll.MV_FRAME_OUT()
      {
          pBufAddr = this._pixelDataPtr
      };
      MvCCDll.MV_CC_FreeImageBuffer(this.DeviceHandle, ref v);
      this._isDisposed = true;
    }
  }
}
