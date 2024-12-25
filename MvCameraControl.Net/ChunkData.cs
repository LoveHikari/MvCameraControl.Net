// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ChunkData
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  internal class ChunkData : IChunkData
  {
    private byte[] _data;

    public IntPtr DataPtr { get; set; }

    public byte[] Data
    {
      get
      {
        this._data = new byte[this.Length];
        Marshal.Copy(this.DataPtr, this._data, 0, (int) this.Length);
        return this._data;
      }
      protected set
      {
        Marshal.Copy(value, 0, this.DataPtr, Math.Min((int) this.Length, value.Length));
        this._data = value;
      }
    }

    public uint ChunkID { get; set; }

    public uint Length { get; set; }
  }
}
