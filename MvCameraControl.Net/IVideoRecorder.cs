// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IVideoRecorder
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>录像,将图片录制成AVI格式视频</summary>
  public interface IVideoRecorder
  {
    /// <summary>开始录像</summary>
    /// <param name="filePath">录像文件存放路径</param>
    /// <param name="recordParam">录像参数</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int StartRecord(string filePath, RecordParam recordParam);

    /// <summary>输入录像数据</summary>
    /// <param name="image">图像数据</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int InputOneFrame(IImage image);

    /// <summary>停止录像</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int StopRecord();
  }
}
