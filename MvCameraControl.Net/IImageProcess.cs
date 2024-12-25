// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IImageProcess
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System.Collections.Generic;

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供图像处理相关接口，比如旋转、翻转、对比度、饱和度等</summary>
  public interface IImageProcess
  {
    /// <summary>图像旋转</summary>
    /// <param name="inImage">输入图像</param>
    /// <param name="outImage">输出图像。图像使用完之后需调用Dispose方法及时释放内存，防止内存快速上涨。</param>
    /// <param name="angle">旋转角度</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>该接口只支持MONO8/RGB24/BGR24格式数据的90/180/270度旋转。</remarks>
    int RotateImage(IImage inImage, out IImage outImage, ImageRotateAngle angle);

    /// <summary>图像翻转</summary>
    /// <param name="inImage">输入图像</param>
    /// <param name="outImage">输出图像。图像使用完之后需调用Dispose方法及时释放内存，防止内存快速上涨。</param>
    /// <param name="flipType">翻转类型</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>该接口只支持MONO8/RGB24/BGR24格式数据的垂直和水平翻转。</remarks>
    int FlipImage(IImage inImage, out IImage outImage, ImageFlipType flipType);

    /// <summary>图像对比度调节</summary>
    /// <param name="inImage">输入图像</param>
    /// <param name="outImage">输出图像。图像使用完之后需调用Dispose方法及时释放内存，防止内存快速上涨。</param>
    /// <param name="contrastFactor">对比度值，[1, 10000] </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int ImageContrast(IImage inImage, out IImage outImage, uint contrastFactor);

    /// <summary>重构图像（用于分时曝光功能）</summary>
    /// <param name="inImage">输入图像</param>
    /// <param name="exposureNum">曝光个数(1-8]</param>
    /// <param name="method">图像重构方式</param>
    /// <param name="outImages">输出图像列表。图像使用完之后需调用Dispose方法及时释放内存，防止内存快速上涨。</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int ReconstructImage(
      IImage inImage,
      uint exposureNum,
      ImageReconstructionMethod method,
      out List<IImage> outImages);

    /// <summary>重构图像（用于分时曝光功能，图像拆分后再拼接）</summary>
    /// <param name="inImage">输入图像</param>
    /// <param name="exposureNum">曝光个数(1-8]</param>
    /// <param name="method">图像重构的方式</param>
    /// <param name="imageStitchingMethod">图像拼接的方式</param>
    /// <param name="outImage">输出图像。图像使用完之后需调用Dispose方法及时释放内存，防止内存快速上涨。</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int ReconstructImage(
      IImage inImage,
      uint exposureNum,
      ImageReconstructionMethod method,
      ImageStitchingMethod imageStitchingMethod,
      out IImage outImage);
  }
}
