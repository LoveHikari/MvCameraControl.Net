// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ImageSaver
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  internal class ImageSaver : IImageSaver
  {
    private IntPtr _devHandle = IntPtr.Zero;

    internal ImageSaver(IntPtr devHandle) => this._devHandle = devHandle;

    public int SaveImageToBuffer(
      byte[] buffer,
      out uint dataLen,
      IImage image,
      ImageFormatInfo imageFormatInfo,
      CFAMethod cfaMethod)
    {
      dataLen = 0U;
      if (image == null)
        return -2147483644;
      MvCCDll.MV_SAVE_IMAGE_PARAM_EX3 stSaveParam = new MvCCDll.MV_SAVE_IMAGE_PARAM_EX3();
      stSaveParam.nWidth = image.Width;
      stSaveParam.nHeight = image.Height;
      stSaveParam.enPixelType = (MvCCDll.MvGvspPixelType) image.PixelType;
      stSaveParam.pData = image.PixelDataPtr;
      stSaveParam.nDataLen = (uint) image.ImageSize;
      if (buffer == null)
      {
        stSaveParam.pImageBuffer = IntPtr.Zero;
        stSaveParam.nBufferSize = 0U;
      }
      else
      {
        stSaveParam.pImageBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array) buffer, 0);
        stSaveParam.nBufferSize = Convert.ToUInt32(buffer.Length);
      }
      stSaveParam.enImageType = (MvCCDll.MV_SAVE_IAMGE_TYPE) imageFormatInfo.FormatType;
      stSaveParam.nJpgQuality = imageFormatInfo.JpegQuality;
      stSaveParam.iMethodValue = (uint) cfaMethod;
      int buffer1 = MvCCDll.MV_CC_SaveImageEx3(this._devHandle, ref stSaveParam);
      if (buffer1 != 0)
      {
        dataLen = stSaveParam.nImageLen;
        return buffer1;
      }
      dataLen = stSaveParam.nImageLen;
      return buffer1;
    }

    public int SaveImageToFile(
      string filePath,
      IImage image,
      ImageFormatInfo imageFormatInfo,
      CFAMethod cfaMethod)
    {
      if (image == null)
        return -2147483644;
      MvCCDll.MV_CC_IMAGE pstImage = new MvCCDll.MV_CC_IMAGE();
      MvCCDll.MV_CC_SAVE_IMAGE_PARAM pSaveImageParam = new MvCCDll.MV_CC_SAVE_IMAGE_PARAM();
      pstImage.nWidth = image.Width;
      pstImage.nHeight = image.Height;
      pstImage.enPixelType = (MvCCDll.MvGvspPixelType) image.PixelType;
      pstImage.pImageBuf = image.PixelDataPtr;
      pstImage.nImageBufLen = image.ImageSize;
      pSaveImageParam.enImageType = (MvCCDll.MV_SAVE_IAMGE_TYPE) imageFormatInfo.FormatType;
      pSaveImageParam.nQuality = imageFormatInfo.JpegQuality;
      pSaveImageParam.iMethodValue = (uint) cfaMethod;
      int fileEx2 = MvCCDll.MV_CC_SaveImageToFileEx2(this._devHandle, ref pstImage, ref pSaveImageParam, filePath);
      return fileEx2 != 0 ? fileEx2 : fileEx2;
    }
  }
}
