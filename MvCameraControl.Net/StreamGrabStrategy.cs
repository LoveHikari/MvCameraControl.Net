// Decompiled with JetBrains decompiler
// Type: MvCameraControl.StreamGrabStrategy
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>取流策略</summary>
  public enum StreamGrabStrategy
  {
    /// <summary>从旧到新一帧一帧的获取图像（默认为该策略）</summary>
    OneByOne,
    /// <summary>获取列表中最新的一帧图像，同时清除列表中的其余图像</summary>
    LatestImageOnly,
    /// <summary>
    /// 从输出缓存列表中获取最新的OutputQueueSize帧图像，其中OutputQueueSize范围为1-ImageNodeNum，可用 SetOutputQueueSize()接口设置。ImageNodeNum默认为1，可调用SetImageNodeNum()接口设置。 OutputQueueSize设置成1等同于LatestImagesOnly策略，OutputQueueSize设置成ImageNodeNum等同于OneByOne策略。
    /// </summary>
    LatestImages,
    /// <summary>
    /// 在调用取流接口时忽略输出缓存列表中所有图像，并等待设备即将生成的一帧图像。该策略只支持GigE设备，不支持U3V设备
    /// </summary>
    UpcomingImage,
  }
}
