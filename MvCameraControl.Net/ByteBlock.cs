// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ByteBlock
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  /// <summary>内存块</summary>
  internal class ByteBlock
  {
    private byte[] _byteArray;
    private int _blockFlag;
    private double _rentTime;
    private double _returnTime;

    public ByteBlock(long size) => this._byteArray = new byte[size];

    public ByteBlock(long size, int flag)
    {
      this._byteArray = new byte[size];
      this._blockFlag = flag;
    }

    public byte[] ByteArray => this._byteArray;

    public IntPtr NativePtr => Marshal.UnsafeAddrOfPinnedArrayElement((Array) this._byteArray, 0);

    public long Length => this._byteArray.LongLength;

    public double RentTime
    {
      get => this._rentTime;
      set => this._rentTime = value;
    }

    public double ReturnTime
    {
      get => this._returnTime;
      set => this._returnTime = value;
    }

    public int Flag => this._blockFlag;
  }
}
