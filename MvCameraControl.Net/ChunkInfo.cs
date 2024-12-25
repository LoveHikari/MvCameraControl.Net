// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ChunkInfo
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace MvCameraControl
{
  internal class ChunkInfo : IChunkInfo, IEnumerable<IChunkData>, IEnumerable
  {
    private Dictionary<uint, IChunkData> _chunkDataList = new Dictionary<uint, IChunkData>();

    public IChunkData this[uint ChunkID]
    {
      get
      {
        return this._chunkDataList.ContainsKey(ChunkID) ? this._chunkDataList[ChunkID] : (IChunkData) null;
      }
      set => this._chunkDataList[value.ChunkID] = value;
    }

    public int Count => this._chunkDataList.Count;

    public IEnumerator<IChunkData> GetEnumerator()
    {
      return (IEnumerator<IChunkData>) this._chunkDataList.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return (IEnumerator) this._chunkDataList.Values.GetEnumerator();
    }
  }
}
