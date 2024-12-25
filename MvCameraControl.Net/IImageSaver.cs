// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IImageSaver
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供保存图像数据到文件的接口，支持BMP、JPG、PNG、TIFF格式图像</summary>
  public interface IImageSaver
  {
    /// <summary>保存图像到文件，支持BMP、JPG、PNG、TIFF格式图像</summary>
    /// <param name="filePath">文件路径</param>
    /// <param name="image">图像数据</param>
    /// <param name="imageFormatInfo">图像格式信息</param>
    /// <param name="cfaMethod">图像插值方法</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SaveImageToFile(
      string filePath,
      IImage image,
      ImageFormatInfo imageFormatInfo,
      CFAMethod cfaMethod);

    /// <summary>保存图像到缓存，支持BMP、JPG格式图像</summary>
    /// <param name="buffer">图像缓存</param>
    /// <param name="dataLen">转换后的图像数据长度</param>
    /// <param name="image">图像数据</param>
    /// <param name="imageFormatInfo">图像格式信息</param>
    /// <param name="cfaMethod">图像插值方法</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SaveImageToBuffer(
      byte[] buffer,
      out uint dataLen,
      IImage image,
      ImageFormatInfo imageFormatInfo,
      CFAMethod cfaMethod);
  }
}
