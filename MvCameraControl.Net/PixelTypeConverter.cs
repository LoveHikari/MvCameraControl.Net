// Decompiled with JetBrains decompiler
// Type: MvCameraControl.PixelTypeConverter
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  internal class PixelTypeConverter : IPixelTypeConverter
  {
    /// <summary>设备句柄, 用于内部做格式转换</summary>
    private IntPtr _deviceHandle = IntPtr.Zero;
    private ByteBlockPool _byteBlockPool;

    /// <summary>构造函数，内部创建内存池，只在ToBitmap中使用</summary>
    /// <param name="deviceHandle">设备句柄</param>
    public PixelTypeConverter(IntPtr deviceHandle)
    {
      this._deviceHandle = deviceHandle;
      this._byteBlockPool = new ByteBlockPool();
    }

    /// <summary>构造函数</summary>
    /// <param name="deviceHandle">设备句柄</param>
    /// <param name="pool"></param>
    public PixelTypeConverter(IntPtr deviceHandle, ByteBlockPool pool)
    {
      this._deviceHandle = deviceHandle;
      this._byteBlockPool = pool;
    }

    /// <summary>设置图像插值算法类型</summary>
    /// <param name="method">图像插值算法</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetBayerCvtQuality(CFAMethod method)
    {
      return MvCCDll.MV_CC_SetBayerCvtQuality(this._deviceHandle, (uint) method);
    }

    /// <summary>插值算法平滑使能设置</summary>
    /// <param name="enable">平滑使能（默认关闭）</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetBayerFilterEnable(bool enable)
    {
      return MvCCDll.MV_CC_SetBayerFilterEnable(this._deviceHandle, enable ? (byte) 1 : (byte) 0);
    }

    /// <summary>设置Bayer格式的Gamma值</summary>
    /// <param name="gammaValue">Gamma值：0.1 ~ 4.0</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetBayerGammaValue(float gammaValue)
    {
      return MvCCDll.MV_CC_SetBayerGammaValue(this._deviceHandle, gammaValue);
    }

    /// <summary>设置Mono8/Bayer8/10/12/16格式的Gamma值</summary>
    /// <param name="pixelType">像素格式</param>
    /// <param name="gammaValue">Gamma值:0.1 ~ 4.0</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetGammaValue(MvGvspPixelType pixelType, float gammaValue)
    {
      return MvCCDll.MV_CC_SetGammaValue(this._deviceHandle, (MvCCDll.MvGvspPixelType) pixelType, gammaValue);
    }

    /// <summary>设置Bayer格式的Gamma信息</summary>
    /// <param name="gammaParam">Gamma参数</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetBayerGammaParam(GammaParam gammaParam)
    {
      MvCCDll.MV_CC_GAMMA_PARAM pstGammaParam = new MvCCDll.MV_CC_GAMMA_PARAM();
      pstGammaParam.enGammaType = (MvCCDll.MV_CC_GAMMA_TYPE) gammaParam.Type;
      if (gammaParam.Type == GammaType.Value)
        pstGammaParam.fGammaValue = gammaParam.Value;
      else if (gammaParam.Type == GammaType.UserCurve)
      {
        if (gammaParam.CurveBuf == null)
          return -2147483644;
        pstGammaParam.pGammaCurveBuf = Marshal.UnsafeAddrOfPinnedArrayElement((Array) gammaParam.CurveBuf, 0);
        pstGammaParam.nGammaCurveBufLen = gammaParam.CurveLen;
      }
      return MvCCDll.MV_CC_SetBayerGammaParam(this._deviceHandle, ref pstGammaParam);
    }

    /// <summary>设置Bayer格式的CCM使能和矩阵，量化系数默认1024</summary>
    /// <param name="ccmParam">CCM参数</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int SetBayerCCMParam(CCMParam ccmParam)
    {
        var v = new MvCCDll.MV_CC_CCM_PARAM_EX()
        {
            bCCMEnable = ccmParam.CCMEnable,
            nCCMScale = ccmParam.CCMScale,
            nCCMat = ccmParam.CCMat
        };
      return MvCCDll.MV_CC_SetBayerCCMParamEx(this._deviceHandle, ref v);
    }

    /// <summary>将图像转换为指定格式，输出IImage图像</summary>
    /// <param name="inImage">输入图像</param>
    /// <param name="outImage">输出图像</param>
    /// <param name="dstPixelType">目的像素格式</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public int ConvertPixelType(IImage inImage, out IImage outImage, MvGvspPixelType dstPixelType)
    {
      outImage = (IImage) null;
      if (inImage == null)
        return -2147483644;
      MvCCDll.MV_CC_PIXEL_CONVERT_PARAM_EX pstCvtParamEx = new MvCCDll.MV_CC_PIXEL_CONVERT_PARAM_EX();
      pstCvtParamEx.nWidth = inImage.Width;
      pstCvtParamEx.nHeight = inImage.Height;
      pstCvtParamEx.enSrcPixelType = (MvCCDll.MvGvspPixelType) inImage.PixelType;
      pstCvtParamEx.pSrcData = inImage.PixelDataPtr;
      pstCvtParamEx.nSrcDataLen = (uint) inImage.ImageSize;
      MvPooledImage mvPooledImage = new MvPooledImage(inImage.Width, inImage.Height, dstPixelType, this._deviceHandle, this._byteBlockPool);
      pstCvtParamEx.pDstBuffer = mvPooledImage.PixelDataPtr;
      pstCvtParamEx.nDstBufferSize = (uint) mvPooledImage.ImageSize;
      pstCvtParamEx.enDstPixelType = (MvCCDll.MvGvspPixelType) dstPixelType;
      int num = MvCCDll.MV_CC_ConvertPixelTypeEx(this._deviceHandle, ref pstCvtParamEx);
      if (num != 0)
      {
        mvPooledImage.Dispose();
        return num;
      }
      mvPooledImage.ImageSize = (ulong) pstCvtParamEx.nDstLen;
      outImage = (IImage) mvPooledImage;
      return num;
    }

    /// <summary>将图像转换为指定格式，输出Byte数组</summary>
    /// <param name="inImage">输入图像</param>
    /// <param name="outBuffer">输出图像缓存</param>
    /// <param name="outDataLen">输出图像长度</param>
    /// <param name="dstPixelType">目的像素格式</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>outBuffer设置为null时, outDataLen会给出结果图像需要的缓存长度</remarks>
    public int ConvertPixelType(
      IImage inImage,
      byte[] outBuffer,
      out ulong outDataLen,
      MvGvspPixelType dstPixelType)
    {
      outDataLen = 0UL;
      if (inImage == null)
        return -2147483644;
      MvCCDll.MV_CC_PIXEL_CONVERT_PARAM_EX pstCvtParamEx = new MvCCDll.MV_CC_PIXEL_CONVERT_PARAM_EX();
      pstCvtParamEx.nWidth = inImage.Width;
      pstCvtParamEx.nHeight = inImage.Height;
      pstCvtParamEx.enSrcPixelType = (MvCCDll.MvGvspPixelType) inImage.PixelType;
      pstCvtParamEx.pSrcData = inImage.PixelDataPtr;
      pstCvtParamEx.nSrcDataLen = (uint) inImage.ImageSize;
      pstCvtParamEx.enDstPixelType = (MvCCDll.MvGvspPixelType) dstPixelType;
      if (outBuffer == null)
      {
        pstCvtParamEx.pDstBuffer = IntPtr.Zero;
        pstCvtParamEx.nDstBufferSize = 0U;
      }
      else
      {
        pstCvtParamEx.pDstBuffer = Marshal.UnsafeAddrOfPinnedArrayElement((Array) outBuffer, 0);
        pstCvtParamEx.nDstBufferSize = (uint) outBuffer.Length;
      }
      int num = MvCCDll.MV_CC_ConvertPixelTypeEx(this._deviceHandle, ref pstCvtParamEx);
      outDataLen = (ulong) pstCvtParamEx.nDstLen;
      return num != 0 ? num : num;
    }

    /// <summary>获取像素格式转换所需的缓存大小</summary>
    /// <param name="dstPixelType">目标像素格式</param>
    /// <param name="width">图像宽</param>
    /// <param name="height">图像高</param>
    /// <returns>缓存大小</returns>
    public ulong GetBufferSizeForConvert(MvGvspPixelType dstPixelType, uint width, uint height)
    {
      return InnerTools.GetImageSize(width, height, dstPixelType);
    }
  }
}
