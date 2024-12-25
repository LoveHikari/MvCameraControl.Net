// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ImageProcess
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace MvCameraControl
{
  internal class ImageProcess : IImageProcess
  {
    private IntPtr _devHandle = IntPtr.Zero;
    private ByteBlockPool _byteBlockPool;

    internal ImageProcess(IntPtr devHandle, ByteBlockPool pool)
    {
      this._devHandle = devHandle;
      this._byteBlockPool = pool;
    }

    public int FlipImage(IImage inImage, out IImage outImage, ImageFlipType flipType)
    {
      outImage = (IImage) null;
      if (inImage == null)
        return -2147483644;
      MvPooledImage mvPooledImage = new MvPooledImage(inImage.Width, inImage.Height, inImage.PixelType, inImage.ImageSize, this._devHandle, this._byteBlockPool);
      var v = new MvCCDll.MV_CC_FLIP_IMAGE_PARAM()
      {
          nWidth = inImage.Width,
          nHeight = inImage.Height,
          enPixelType = (MvCCDll.MvGvspPixelType)inImage.PixelType,
          pSrcData = inImage.PixelDataPtr,
          nSrcDataLen = (uint)inImage.ImageSize,
          enFlipType = (MvCCDll.MV_IMG_FLIP_TYPE)flipType,
          pDstBuf = mvPooledImage.PixelDataPtr,
          nDstBufSize = (uint)mvPooledImage.ImageSize
      };
      int num = MvCCDll.MV_CC_FlipImage(this._devHandle, ref v);
      if (num != 0)
      {
        mvPooledImage.Dispose();
        return num;
      }
      outImage = (IImage) mvPooledImage;
      return num;
    }

    public int ImageContrast(IImage inImage, out IImage outImage, uint contrastFactor)
    {
      outImage = (IImage) null;
      if (inImage == null)
        return -2147483644;
      MvPooledImage mvPooledImage = new MvPooledImage(inImage.Width, inImage.Height, inImage.PixelType, inImage.ImageSize, this._devHandle, this._byteBlockPool);
      var v = new MvCCDll.MV_CC_CONTRAST_PARAM()
      {
          nWidth = inImage.Width,
          nHeight = inImage.Height,
          enPixelType = (MvCCDll.MvGvspPixelType)inImage.PixelType,
          pSrcBuf = inImage.PixelDataPtr,
          nSrcBufLen = (uint)inImage.ImageSize,
          nContrastFactor = contrastFactor,
          pDstBuf = mvPooledImage.PixelDataPtr,
          nDstBufSize = (uint)mvPooledImage.ImageSize
      };
      int num = MvCCDll.MV_CC_ImageContrast(this._devHandle, ref v);
      if (num != 0)
      {
        mvPooledImage.Dispose();
        return num;
      }
      outImage = (IImage) mvPooledImage;
      return num;
    }

    public int ReconstructImage(
      IImage inImage,
      uint exposureNum,
      ImageReconstructionMethod method,
      ImageStitchingMethod imageStitchingMethod,
      out IImage outImage)
    {
      outImage = (IImage) null;
      if (inImage == null || exposureNum > 8U)
        return -2147483644;
      MvPooledImage mvPooledImage = new MvPooledImage(inImage.Width, inImage.Height, inImage.PixelType, inImage.ImageSize, this._devHandle, this._byteBlockPool);
      MvCCDll.MV_RECONSTRUCT_IMAGE_PARAM pstReconstructParam = new MvCCDll.MV_RECONSTRUCT_IMAGE_PARAM();
      pstReconstructParam.nWidth = inImage.Width;
      pstReconstructParam.nHeight = inImage.Height;
      pstReconstructParam.enPixelType = (MvCCDll.MvGvspPixelType) inImage.PixelType;
      pstReconstructParam.pSrcData = inImage.PixelDataPtr;
      pstReconstructParam.nSrcDataLen = (uint) inImage.ImageSize;
      pstReconstructParam.stDstBufList = new MvCCDll.MV_OUTPUT_IMAGE_INFO[8];
      ulong num1 = inImage.ImageSize / (ulong) exposureNum;
      ulong num2 = inImage.ImageSize % (ulong) exposureNum;
      long num3 = 0;
      for (int index = 0; (long) index < (long) exposureNum; ++index)
      {
        pstReconstructParam.stDstBufList[index].nBufSize = (uint) num1;
        if (num2 > 0UL)
        {
          --num2;
          ++pstReconstructParam.stDstBufList[index].nBufSize;
        }
        pstReconstructParam.stDstBufList[index].pBuf = new IntPtr(mvPooledImage.PixelDataPtr.ToInt64() + num3);
        num3 += (long) pstReconstructParam.stDstBufList[index].nBufSize;
      }
      pstReconstructParam.nExposureNum = exposureNum;
      pstReconstructParam.enReconstructMethod = (MvCCDll.MV_IMAGE_RECONSTRUCTION_METHOD) method;
      int num4 = MvCCDll.MV_CC_ReconstructImage(this._devHandle, ref pstReconstructParam);
      if (num4 != 0)
      {
        mvPooledImage.Dispose();
        return num4;
      }
      outImage = (IImage) mvPooledImage;
      return 0;
    }

    public int ReconstructImage(
      IImage inImage,
      uint exposureNum,
      ImageReconstructionMethod method,
      out List<IImage> outImages)
    {
      outImages = new List<IImage>();
      if (inImage == null || exposureNum > 8U)
        return -2147483644;
      uint height = inImage.Height % exposureNum == 0U ? inImage.Height / exposureNum : inImage.Height / exposureNum + 1U;
      long num1 = (long) (inImage.ImageSize / (ulong) inImage.Height);
      ulong imageSize = InnerTools.GetImageSize(inImage.Width, height, inImage.PixelType);
      List<MvPooledImage> mvPooledImageList = new List<MvPooledImage>((int) exposureNum);
      for (int index = 0; (long) index < (long) exposureNum; ++index)
      {
        MvPooledImage mvPooledImage = new MvPooledImage(inImage.Width, height, inImage.PixelType, imageSize, this._devHandle, this._byteBlockPool);
        mvPooledImageList.Add(mvPooledImage);
      }
      MvCCDll.MV_RECONSTRUCT_IMAGE_PARAM pstReconstructParam = new MvCCDll.MV_RECONSTRUCT_IMAGE_PARAM();
      pstReconstructParam.nWidth = inImage.Width;
      pstReconstructParam.nHeight = inImage.Height;
      pstReconstructParam.enPixelType = (MvCCDll.MvGvspPixelType) inImage.PixelType;
      pstReconstructParam.pSrcData = inImage.PixelDataPtr;
      pstReconstructParam.nSrcDataLen = (uint) inImage.ImageSize;
      pstReconstructParam.stDstBufList = new MvCCDll.MV_OUTPUT_IMAGE_INFO[8];
      for (int index = 0; (long) index < (long) exposureNum; ++index)
      {
        pstReconstructParam.stDstBufList[index].nBufSize = (uint) mvPooledImageList[index].ImageSize;
        pstReconstructParam.stDstBufList[index].pBuf = mvPooledImageList[index].PixelDataPtr;
      }
      pstReconstructParam.nExposureNum = exposureNum;
      pstReconstructParam.enReconstructMethod = (MvCCDll.MV_IMAGE_RECONSTRUCTION_METHOD) method;
      int num2 = MvCCDll.MV_CC_ReconstructImage(this._devHandle, ref pstReconstructParam);
      if (num2 != 0)
      {
        foreach (MvImage mvImage in mvPooledImageList)
          mvImage.Dispose();
        mvPooledImageList.Clear();
        return num2;
      }
      for (int index = 0; (long) index < (long) exposureNum; ++index)
      {
        mvPooledImageList[index].Width = pstReconstructParam.stDstBufList[index].nWidth;
        mvPooledImageList[index].Height = pstReconstructParam.stDstBufList[index].nHeight;
        mvPooledImageList[index].ImageSize = (ulong) pstReconstructParam.stDstBufList[index].nBufLen;
        mvPooledImageList[index].PixelType = (MvGvspPixelType) pstReconstructParam.stDstBufList[index].enPixelType;
        outImages.Add((IImage) mvPooledImageList[index]);
      }
      return 0;
    }

    public int RotateImage(IImage inImage, out IImage outImage, ImageRotateAngle angle)
    {
      outImage = (IImage) null;
      if (inImage == null)
        return -2147483644;
      MvPooledImage mvPooledImage = new MvPooledImage(inImage.Width, inImage.Height, inImage.PixelType, inImage.ImageSize, this._devHandle, this._byteBlockPool);
      MvCCDll.MV_CC_ROTATE_IMAGE_PARAM pstRotateParam = new MvCCDll.MV_CC_ROTATE_IMAGE_PARAM();
      pstRotateParam.nWidth = inImage.Width;
      pstRotateParam.nHeight = inImage.Height;
      pstRotateParam.enPixelType = (MvCCDll.MvGvspPixelType) inImage.PixelType;
      pstRotateParam.pSrcData = inImage.PixelDataPtr;
      pstRotateParam.nSrcDataLen = (uint) inImage.ImageSize;
      pstRotateParam.enRotationAngle = (MvCCDll.MV_IMG_ROTATION_ANGLE) angle;
      pstRotateParam.pDstBuf = mvPooledImage.PixelDataPtr;
      pstRotateParam.nDstBufSize = (uint) mvPooledImage.ImageSize;
      int num = MvCCDll.MV_CC_RotateImage(this._devHandle, ref pstRotateParam);
      if (num != 0)
      {
        mvPooledImage.Dispose();
        return num;
      }
      mvPooledImage.Width = pstRotateParam.nWidth;
      mvPooledImage.Height = pstRotateParam.nHeight;
      outImage = (IImage) mvPooledImage;
      return num;
    }
  }
}
