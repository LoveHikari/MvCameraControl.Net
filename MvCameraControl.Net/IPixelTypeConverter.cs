// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IPixelTypeConverter
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供像素格式转换相关接口</summary>
  public interface IPixelTypeConverter
  {
    /// <summary>设置图像插值算法类型</summary>
    /// <param name="method">图像插值算法</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 设置内部图像转换接口的Bayer插值算法类型参数，<see cref="T:MvCameraControl.IPixelTypeConverter" />、<see cref="T:MvCameraControl.IImageSaver" />使用的插值算法是该接口所设定的
    /// </remarks>
    int SetBayerCvtQuality(CFAMethod method);

    /// <summary>插值算法平滑使能设置</summary>
    /// <param name="enable">平滑使能（默认关闭） </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 设置内部图像转换接口的Bayer插值平滑使能参数，<see cref="T:MvCameraControl.IPixelTypeConverter" />、<see cref="T:MvCameraControl.IImageSaver" />使用的插值算法是该接口所设定的。
    /// </remarks>
    int SetBayerFilterEnable(bool enable);

    /// <summary>设置Bayer格式的Gamma值</summary>
    /// <param name="gammaValue">Gamma值：0.1 ~ 4.0 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 设置该值后，<see cref="T:MvCameraControl.IPixelTypeConverter" />、<see cref="T:MvCameraControl.IImageSaver" />将Bayer8/10/12/16格式转成RGB24/48， RGBA32/64，BGR24/48，BGRA32/64时起效。
    /// </remarks>
    int SetBayerGammaValue(float gammaValue);

    /// <summary>设置Mono8/Bayer8/10/12/16格式的Gamma值</summary>
    /// <param name="pixelType">像素格式</param>
    /// <param name="gammaValue">Gamma值:0.1 ~ 4.0 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 设置Mono8的gamma值后，再调用<see cref="M:MvCameraControl.IPixelTypeConverter.ConvertPixelType(MvCameraControl.IImage,System.Byte[],System.UInt64@,MvCameraControl.MvGvspPixelType)" />将Mono8转成Mono8时gamma值起效。
    /// 设置Bayer8/10/12/16的gamma值后,<see cref="T:MvCameraControl.IPixelTypeConverter" />、<see cref="T:MvCameraControl.IImageSaver" />将Bayer8/10/12/16格式转成RGB24/48， RGBA32/64，BGR24/48，BGRA32/64时起效。
    /// 该接口兼容<see cref="M:MvCameraControl.IPixelTypeConverter.SetBayerGammaValue(System.Single)" />接口，新增支持Mono8像素格式
    /// </remarks>
    int SetGammaValue(MvGvspPixelType pixelType, float gammaValue);

    /// <summary>设置Bayer格式的Gamma信息</summary>
    /// <param name="gammaParam">Gamma参数</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 设置该信息后，在<see cref="T:MvCameraControl.IPixelTypeConverter" />、<see cref="T:MvCameraControl.IImageSaver" />将Bayer8/10/12/16格式转成RGB24/48， RGBA32/64，BGR24/48，BGRA32/64时起效。
    /// </remarks>
    int SetBayerGammaParam(GammaParam gammaParam);

    /// <summary>设置Bayer格式的CCM使能和矩阵，量化系数默认1024</summary>
    /// <param name="ccmParam">CCM参数</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 开启CCM并设置CCM矩阵后，在<see cref="T:MvCameraControl.IPixelTypeConverter" />、<see cref="T:MvCameraControl.IImageSaver" />将Bayer8/10/12/16格式转成RGB24/48， RGBA32/64，BGR24/48，BGRA32/64时起效。
    /// </remarks>
    int SetBayerCCMParam(CCMParam ccmParam);

    /// <summary>像素格式转换</summary>
    /// <param name="inImage">输入图像</param>
    /// <param name="outImage">输出图像。图像使用完之后需调用Dispose方法及时释放内存，防止内存快速上涨。</param>
    /// <param name="dstPixelType">目标像素格式</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int ConvertPixelType(IImage inImage, out IImage outImage, MvGvspPixelType dstPixelType);

    /// <summary>像素格式转换</summary>
    /// <param name="inImage">输入图像</param>
    /// <param name="outBuffer">输出图像缓存</param>
    /// <param name="outDataLen">输出图像长度</param>
    /// <param name="dstPixelType">目标像素格式</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int ConvertPixelType(
      IImage inImage,
      byte[] outBuffer,
      out ulong outDataLen,
      MvGvspPixelType dstPixelType);

    /// <summary>获取像素格式转换所需的缓存大小</summary>
    /// <param name="dstPixelType">目标像素格式</param>
    /// <param name="width">图像宽</param>
    /// <param name="height">图像高</param>
    /// <returns>缓存大小</returns>
    ulong GetBufferSizeForConvert(MvGvspPixelType dstPixelType, uint width, uint height);
  }
}
