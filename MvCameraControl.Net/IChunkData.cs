// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IChunkData
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>Chunk数据</summary>
  public interface IChunkData
  {
    /// <summary>Chunk数据指针（非托管内存）</summary>
    IntPtr DataPtr { get; }

    /// <summary>Chunk数据，内部会进行一次拷贝，将非托管内存拷贝到托管内存</summary>
    byte[] Data { get; }

    /// <summary>ChunkID</summary>
    uint ChunkID { get; }

    /// <summary>Chunk数据长度</summary>
    uint Length { get; }
  }
}
