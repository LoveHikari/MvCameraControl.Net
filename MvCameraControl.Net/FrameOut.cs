// Decompiled with JetBrains decompiler
// Type: MvCameraControl.FrameOut
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  internal class FrameOut : IFrameOut, IDisposable, ICloneable
  {
    private IImage _imageBuffer;
    private IntPtr _deviceHandle;
    private bool _isDisposed;

    /// <summary>相机句柄</summary>
    internal IntPtr DeviceHandle => this._deviceHandle;

    /// <summary>图像类</summary>
    public IImage Image
    {
      get => this._imageBuffer;
      set => this._imageBuffer = value;
    }

    public uint FrameNum { get; set; }

    public ulong DevTimeStamp { get; set; }

    public ulong HostTimeStamp { get; set; }

    public ulong FrameLen { get; set; }

    public uint SecondCount { get; set; }

    public uint CycleCount { get; set; }

    public uint CycleOffset { get; set; }

    public float Gain { get; set; }

    public float ExposureTime { get; set; }

    public uint AverageBrightness { get; set; }

    public uint Red { get; set; }

    public uint Green { get; set; }

    public uint Blue { get; set; }

    public uint FrameCount { get; set; }

    public uint TriggerIndex { get; set; }

    public uint Input { get; set; }

    public uint Output { get; set; }

    public uint OffsetX { get; set; }

    public uint OffsetY { get; set; }

    public uint LostPacket { get; set; }

    public IChunkInfo ChunkInfo { get; set; }

    public FrameOut(IntPtr devHandle) => this._deviceHandle = devHandle;

    ~FrameOut() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (this._isDisposed)
        return;
      int num = disposing ? 1 : 0;
      if (this._imageBuffer != null)
        this._imageBuffer.Dispose();
      this._isDisposed = true;
    }

    /// <summary>深拷贝</summary>
    /// <returns></returns>
    public object Clone()
    {
      FrameOut frameOut = this.MemberwiseClone() as FrameOut;
      frameOut.Image = this.Image.Clone() as IImage;
      return (object) frameOut;
    }
  }
}
