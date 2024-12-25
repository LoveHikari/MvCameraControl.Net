// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IImageRender
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供图像渲染、图形绘制接口</summary>
  public interface IImageRender
  {
    /// <summary>显示一帧图像</summary>
    /// <param name="hWnd">窗口句柄</param>
    /// <param name="image">图像信息</param>
    /// <param name="mode">渲染模式</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 渲染方式可选择GDI或D3D，默认选择为GDI模式。渲染引擎仅在客户端不连接相机的情况下可以进行设置。GDI模式对电脑的显卡性能没有要求，适用于所有电脑。 D3D模式适用于安装显卡驱动且显卡内存大于1GB的电脑，该模式下客户端预览的图像效果会优于GDI模式下的图像效果。
    /// 渲染模式为RenderMode.OPENGL时支持4G以上超大图渲染
    /// </remarks>
    int DisplayOneFrame(IntPtr hWnd, IImage image, RenderMode mode = RenderMode.Default);

    /// <summary>显示一帧图像</summary>
    /// <param name="hWnd">窗口句柄</param>
    /// <param name="imageDataPtr">图像数据指针</param>
    /// <param name="imageLen">图像数据长度</param>
    /// <param name="width">图像宽</param>
    /// <param name="height">图像高</param>
    /// <param name="PixelType">像素格式</param>
    /// <param name="mode">渲染模式</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 渲染方式可选择GDI或D3D，默认选择为GDI模式。渲染引擎仅在客户端不连接相机的情况下可以进行设置。GDI模式对电脑的显卡性能没有要求，适用于所有电脑。 D3D模式适用于安装显卡驱动且显卡内存大于1GB的电脑，该模式下客户端预览的图像效果会优于GDI模式下的图像效果。
    /// </remarks>
    int DisplayOneFrame(
      IntPtr hWnd,
      IntPtr imageDataPtr,
      uint imageLen,
      uint width,
      uint height,
      MvGvspPixelType PixelType,
      RenderMode mode = RenderMode.Default);

    /// <summary>在图像上绘制矩形</summary>
    /// <param name="rect">矩形框</param>
    /// <param name="color">线条颜色</param>
    /// <param name="lineWidth">线条宽度，只能是1或2</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int DrawRect(MvRect rect, MvColor color, uint lineWidth);

    /// <summary>在图像上绘制圆形</summary>
    /// <param name="circle">圆形信息</param>
    /// <param name="color">线条颜色</param>
    /// <param name="lineWidth">线条宽度，只能是1或2</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int DrawCircle(MvCircle circle, MvColor color, uint lineWidth);

    /// <summary>在图像上绘制线条</summary>
    /// <param name="line">线条信息</param>
    /// <param name="color">线条颜色</param>
    /// <param name="lineWidth">线条宽度，只能是1或2</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int DrawLine(MvLine line, MvColor color, uint lineWidth);
  }
}
