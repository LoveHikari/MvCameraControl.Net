// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IFrameOut
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>图像数据和帧信息</summary>
  public interface IFrameOut : IDisposable, ICloneable
  {
    /// <summary>图像数据</summary>
    IImage Image { get; }

    /// <summary>帧号</summary>
    uint FrameNum { get; }

    /// <summary>设备时间戳</summary>
    ulong DevTimeStamp { get; }

    /// <summary>主机时间戳</summary>
    ulong HostTimeStamp { get; }

    /// <summary>帧长度</summary>
    ulong FrameLen { get; }

    /// <summary>设备水印时标</summary>
    uint SecondCount { get; }

    /// <summary>周期数</summary>
    uint CycleCount { get; }

    /// <summary>周期偏移量</summary>
    uint CycleOffset { get; }

    /// <summary>增益</summary>
    float Gain { get; }

    /// <summary>曝光时间</summary>
    float ExposureTime { get; }

    /// <summary>平均亮度</summary>
    uint AverageBrightness { get; }

    /// <summary>白平衡红色通道</summary>
    uint Red { get; }

    /// <summary>白平衡绿色通道</summary>
    uint Green { get; }

    /// <summary>白平衡蓝色通道</summary>
    uint Blue { get; }

    /// <summary>总帧数</summary>
    uint FrameCount { get; }

    /// <summary>触发计数</summary>
    uint TriggerIndex { get; }

    /// <summary>输入</summary>
    uint Input { get; }

    /// <summary>输出</summary>
    uint Output { get; }

    /// <summary>ROI区域，水平偏移量</summary>
    uint OffsetX { get; }

    /// <summary>ROI区域，垂直偏移量</summary>
    uint OffsetY { get; }

    /// <summary>本帧丢包数</summary>
    uint LostPacket { get; }

    /// <summary>Chunk数据</summary>
    IChunkInfo ChunkInfo { get; }
  }
}
