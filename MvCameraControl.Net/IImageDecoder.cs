// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IImageDecoder
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>图像解码</summary>
  public interface IImageDecoder
  {
    /// <summary>无损解码</summary>
    /// <param name="inFrameInfo">输入图像及帧信息</param>
    /// <param name="outFrameInfo">输出图像及帧信息。图像使用完之后需调用Dispose方法及时释放内存，防止内存快速上涨。</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 将从相机中取到的无损压缩码流解码成裸数据，同时支持解析当前相机实时图像的水印信息（如果输入的无损码流不是当前相机或者不是实时取流的，则水印解析可能异常)。
    /// 若解码失败，请检查以下情况：（1）需要CPU支持 SSE AVX指令集（2）若当前帧异常（丢包等），可能导致解码异常（3）相机出图异常，即使不丢包也会异常。
    /// </remarks>
    int HBDecode(IFrameOut inFrameInfo, out IFrameOut outFrameInfo);
  }
}
