// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ImageDecoder
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  /// <summary>解码功能实现类</summary>
  internal class ImageDecoder : IImageDecoder
  {
    private IntPtr _devHandle;
    private ByteBlockPool _byteBlockPool;

    public ImageDecoder(IntPtr devHandle) => this._devHandle = devHandle;

    public ImageDecoder(IntPtr devHandle, ByteBlockPool pool)
    {
      this._devHandle = devHandle;
      this._byteBlockPool = pool;
    }

    public int HBDecode(IFrameOut inFrameInfo, out IFrameOut outFrameInfo)
    {
      outFrameInfo = (IFrameOut) null;
      if (inFrameInfo == null)
        return -2147483644;
      int num1 = 0;
      MvCCDll.MV_CC_HB_DECODE_PARAM pstDecodeParam = new MvCCDll.MV_CC_HB_DECODE_PARAM();
      pstDecodeParam.pSrcBuf = inFrameInfo.Image.PixelDataPtr;
      pstDecodeParam.nSrcLen = (uint) inFrameInfo.Image.ImageSize;
      pstDecodeParam.nDstBufSize = 0U;
      num1 = MvCCDll.MV_CC_HB_Decode(this._devHandle, ref pstDecodeParam);
      ByteBlock byteBlock = this._byteBlockPool.GetByteBlock((long) pstDecodeParam.nDstBufLen);
      pstDecodeParam.pDstBuf = byteBlock.NativePtr;
      pstDecodeParam.nDstBufSize = pstDecodeParam.nDstBufLen;
      int num2 = MvCCDll.MV_CC_HB_Decode(this._devHandle, ref pstDecodeParam);
      if (num2 != 0)
      {
        this._byteBlockPool.FreeByteBlock(byteBlock, true);
        return num2;
      }
      outFrameInfo = (IFrameOut) new FrameOut(this._devHandle)
      {
        Image = (IImage) new MvPooledImage(pstDecodeParam.nWidth, pstDecodeParam.nHeight, (MvGvspPixelType) pstDecodeParam.enDstPixelType, (ulong) pstDecodeParam.nDstBufLen, byteBlock, this._devHandle, this._byteBlockPool),
        SecondCount = pstDecodeParam.stFrameSpecInfo.nSecondCount,
        CycleCount = pstDecodeParam.stFrameSpecInfo.nCycleCount,
        CycleOffset = pstDecodeParam.stFrameSpecInfo.nCycleOffset,
        Gain = pstDecodeParam.stFrameSpecInfo.fGain,
        ExposureTime = pstDecodeParam.stFrameSpecInfo.fExposureTime,
        AverageBrightness = pstDecodeParam.stFrameSpecInfo.nAverageBrightness,
        Red = pstDecodeParam.stFrameSpecInfo.nRed,
        Green = pstDecodeParam.stFrameSpecInfo.nGreen,
        Blue = pstDecodeParam.stFrameSpecInfo.nBlue,
        FrameCount = pstDecodeParam.stFrameSpecInfo.nFrameCounter,
        TriggerIndex = pstDecodeParam.stFrameSpecInfo.nTriggerIndex,
        Input = pstDecodeParam.stFrameSpecInfo.nInput,
        Output = pstDecodeParam.stFrameSpecInfo.nOutput,
        OffsetX = (uint) pstDecodeParam.stFrameSpecInfo.nOffsetX,
        OffsetY = (uint) pstDecodeParam.stFrameSpecInfo.nOffsetY,
        FrameLen = (ulong) pstDecodeParam.nDstBufLen,
        FrameNum = inFrameInfo.FrameNum,
        DevTimeStamp = inFrameInfo.DevTimeStamp,
        HostTimeStamp = inFrameInfo.HostTimeStamp
      };
      return num2;
    }

    internal int HBDecode(IImage inImage, out IImage outImage)
    {
      outImage = (IImage) null;
      int num1 = 0;
      MvCCDll.MV_CC_HB_DECODE_PARAM pstDecodeParam = new MvCCDll.MV_CC_HB_DECODE_PARAM();
      pstDecodeParam.pSrcBuf = inImage.PixelDataPtr;
      pstDecodeParam.nSrcLen = (uint) inImage.ImageSize;
      pstDecodeParam.nDstBufSize = 0U;
      num1 = MvCCDll.MV_CC_HB_Decode(this._devHandle, ref pstDecodeParam);
      byte[] numArray = new byte[pstDecodeParam.nDstBufLen];
      pstDecodeParam.pDstBuf = Marshal.UnsafeAddrOfPinnedArrayElement((Array) numArray, 0);
      pstDecodeParam.nDstBufSize = pstDecodeParam.nDstBufLen;
      int num2 = MvCCDll.MV_CC_HB_Decode(this._devHandle, ref pstDecodeParam);
      if (num2 != 0)
        return num2;
      outImage = (IImage) new MvImage(pstDecodeParam.nWidth, pstDecodeParam.nHeight, (MvGvspPixelType) pstDecodeParam.enDstPixelType, (ulong) pstDecodeParam.nDstBufLen, numArray, this._devHandle);
      return num2;
    }
  }
}
