// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IChunkInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace MvCameraControl
{
  /// <summary>图像帧里面的chunk信息</summary>
  public interface IChunkInfo : IEnumerable<IChunkData>, IEnumerable
  {
    /// <summary>通过ChunkID获取对应的ChunkData</summary>
    /// <param name="ChunkID"></param>
    /// <returns></returns>
    IChunkData this[uint ChunkID] { get; }
  }
}
