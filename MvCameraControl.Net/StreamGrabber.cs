// Decompiled with JetBrains decompiler
// Type: MvCameraControl.StreamGrabber
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  internal class StreamGrabber : IStreamGrabber
  {
    private IntPtr _devHandle;
    private MvCCDll.cbOutputExdelegate _outputDelegate;
    private MvCCDll.cbStreamException _streamExceptionDelegate;
    private bool _outputDelegateIsRegistered;
    private bool _streamExceptionIsRegistered;

    private event EventHandler<FrameGrabbedEventArgs> _FrameGrabedEvent;

    /// <summary>USB流异常回调</summary>
    private event EventHandler<StreamExceptionEventArgs> _StreamExceptionEvent;

    public StreamGrabber(IntPtr deviceHandle)
    {
      this._devHandle = deviceHandle;
      this._FrameGrabedEvent = (EventHandler<FrameGrabbedEventArgs>) null;
      this._StreamExceptionEvent = (EventHandler<StreamExceptionEventArgs>) null;
      this._outputDelegate = new MvCCDll.cbOutputExdelegate(this.OutputCallback);
      this._streamExceptionDelegate = new MvCCDll.cbStreamException(this.StreamExceptionCallback);
    }

    public event EventHandler<StreamExceptionEventArgs> StreamExceptionEvent
    {
      add => this._StreamExceptionEvent += value;
      remove => this._StreamExceptionEvent -= value;
    }

    public event EventHandler<FrameGrabbedEventArgs> FrameGrabedEvent
    {
      add => this._FrameGrabedEvent += value;
      remove => this._FrameGrabedEvent -= value;
    }

    public int SetImageNodeNum(uint num) => MvCCDll.MV_CC_SetImageNodeNum(this._devHandle, num);

    public int GetValidImageNum(out uint num)
    {
      num = 0U;
      return MvCCDll.MV_CC_GetValidImageNum(this._devHandle, ref num);
    }

    public int StartGrabbing()
    {
      if (this._FrameGrabedEvent != null && !this._outputDelegateIsRegistered)
      {
        int num = MvCCDll.MV_CC_RegisterImageCallBackEx(this._devHandle, this._outputDelegate, IntPtr.Zero);
        if (num != 0)
          return num;
        this._outputDelegateIsRegistered = true;
      }
      else if (this._FrameGrabedEvent == null && this._outputDelegateIsRegistered)
      {
        int num = MvCCDll.MV_CC_RegisterImageCallBackEx(this._devHandle, (MvCCDll.cbOutputExdelegate) null, IntPtr.Zero);
        if (num != 0)
          return num;
        this._outputDelegateIsRegistered = false;
      }
      if (this._StreamExceptionEvent != null && !this._streamExceptionIsRegistered)
      {
        int num = MvCCDll.MV_USB_RegisterStreamExceptionCallBack(this._devHandle, this._streamExceptionDelegate, IntPtr.Zero);
        if (num != 0)
          return num;
        this._streamExceptionIsRegistered = true;
      }
      else if (this._StreamExceptionEvent == null && this._streamExceptionIsRegistered)
      {
        int num = MvCCDll.MV_USB_RegisterStreamExceptionCallBack(this._devHandle, (MvCCDll.cbStreamException) null, IntPtr.Zero);
        if (num != 0)
          return num;
        this._streamExceptionIsRegistered = false;
      }
      int num1 = MvCCDll.MV_CC_StartGrabbing(this._devHandle);
      return num1 != 0 ? num1 : num1;
    }

    public int StartGrabbing(StreamGrabStrategy strategy)
    {
      int num = MvCCDll.MV_CC_SetGrabStrategy(this._devHandle, (MvCCDll.MV_GRAB_STRATEGY) strategy);
      return num != 0 ? num : this.StartGrabbing();
    }

    public int SetOutputQueueSize(uint size)
    {
      MvCCDll.MV_CC_SetGrabStrategy(this._devHandle, MvCCDll.MV_GRAB_STRATEGY.MV_GrabStrategy_LatestImages);
      return MvCCDll.MV_CC_SetOutputQueueSize(this._devHandle, size);
    }

    public int StopGrabbing() => MvCCDll.MV_CC_StopGrabbing(this._devHandle);

    public int GetImageBuffer(uint timeoutInMS, out IFrameOut frameOut)
    {
      frameOut = (IFrameOut) null;
      FrameOut frameOut1 = new FrameOut(this._devHandle);
      MvCCDll.MV_FRAME_OUT mvFrameOut = new MvCCDll.MV_FRAME_OUT();
      int imageBuffer1 = MvCCDll.MV_CC_GetImageBuffer(this._devHandle, ref mvFrameOut, (int) timeoutInMS);
      if (imageBuffer1 != 0)
        return imageBuffer1;
      int imageBuffer2 = this.ConvertMvFrameOut2FrameOut(ref mvFrameOut, ref frameOut1);
      if (imageBuffer2 != 0)
      {
        MvCCDll.MV_CC_FreeImageBuffer(this._devHandle, ref mvFrameOut);
        return imageBuffer2;
      }
      frameOut = (IFrameOut) frameOut1;
      return imageBuffer2;
    }

    public int FreeImageBuffer(IFrameOut frame)
    {
      MvCCDll.MV_FRAME_OUT mvFrameOut;
      int num1 = InnerTools.ConvertFrameOut2MvFrameOut(frame, out mvFrameOut);
      if (num1 != 0)
        return num1;
      int num2 = MvCCDll.MV_CC_FreeImageBuffer(this._devHandle, ref mvFrameOut);
      return num2 != 0 ? num2 : num2;
    }

    public int ClearImageBuffer() => MvCCDll.MV_CC_ClearImageBuffer(this._devHandle);

    /// <summary>内部回调图像回调函数</summary>
    /// <param name="pData"></param>
    /// <param name="pFrameInfo"></param>
    /// <param name="pUser"></param>
    private void OutputCallback(
      IntPtr pData,
      ref MvCCDll.MV_FRAME_OUT_INFO_EX pFrameInfo,
      IntPtr pUser)
    {
      FrameOut frameOut = new FrameOut(this._devHandle);
      var v = new MvCCDll.MV_FRAME_OUT()
      {
          stFrameInfo = pFrameInfo,
          pBufAddr = pData
      };
      if (this.ConvertMvFrameOut2FrameOut(ref v, ref frameOut) != 0 || this._FrameGrabedEvent == null)
        return;
      this._FrameGrabedEvent((object) this, new FrameGrabbedEventArgs((IFrameOut) frameOut));
    }

    /// <summary>内部流异常回调函数</summary>
    /// <param name="enExceptionType"></param>
    /// <param name="pUser"></param>
    private void StreamExceptionCallback(
      MvCCDll.MV_CC_STREAM_EXCEPTION_TYPE enExceptionType,
      IntPtr pUser)
    {
      if (this._StreamExceptionEvent == null)
        return;
      this._StreamExceptionEvent((object) this, new StreamExceptionEventArgs((StreamExceptionType) enExceptionType));
    }

    /// <summary>将MvCCDll中的帧结构体转为FrameOut类</summary>
    /// <param name="mvFrameOut"></param>
    /// <param name="frameOut"></param>
    /// <returns></returns>
    public int ConvertMvFrameOut2FrameOut(
      ref MvCCDll.MV_FRAME_OUT mvFrameOut,
      ref FrameOut frameOut)
    {
      if (frameOut == null)
        return -2147483644;
      MvNativeImage mvNativeImage = new MvNativeImage(mvFrameOut.stFrameInfo.nExtendWidth, mvFrameOut.stFrameInfo.nExtendHeight, (MvGvspPixelType) mvFrameOut.stFrameInfo.enPixelType, mvFrameOut.pBufAddr, mvFrameOut.stFrameInfo.nFrameLenEx, this._devHandle);
      frameOut.Image = (IImage) mvNativeImage;
      frameOut.FrameNum = mvFrameOut.stFrameInfo.nFrameNum;
      frameOut.DevTimeStamp = (ulong) (mvFrameOut.stFrameInfo.nDevTimeStampHigh | mvFrameOut.stFrameInfo.nDevTimeStampLow);
      frameOut.HostTimeStamp = (ulong) mvFrameOut.stFrameInfo.nHostTimeStamp;
      frameOut.FrameLen = mvFrameOut.stFrameInfo.nFrameLenEx;
      frameOut.SecondCount = mvFrameOut.stFrameInfo.nSecondCount;
      frameOut.CycleCount = mvFrameOut.stFrameInfo.nCycleCount;
      frameOut.CycleOffset = mvFrameOut.stFrameInfo.nCycleOffset;
      frameOut.Gain = mvFrameOut.stFrameInfo.fGain;
      frameOut.ExposureTime = mvFrameOut.stFrameInfo.fExposureTime;
      frameOut.AverageBrightness = mvFrameOut.stFrameInfo.nAverageBrightness;
      frameOut.Red = mvFrameOut.stFrameInfo.nRed;
      frameOut.Green = mvFrameOut.stFrameInfo.nGreen;
      frameOut.Blue = mvFrameOut.stFrameInfo.nBlue;
      frameOut.FrameCount = mvFrameOut.stFrameInfo.nFrameCounter;
      frameOut.TriggerIndex = mvFrameOut.stFrameInfo.nTriggerIndex;
      frameOut.Input = mvFrameOut.stFrameInfo.nInput;
      frameOut.Output = mvFrameOut.stFrameInfo.nOutput;
      frameOut.OffsetX = (uint) mvFrameOut.stFrameInfo.nOffsetX;
      frameOut.OffsetY = (uint) mvFrameOut.stFrameInfo.nOffsetY;
      frameOut.LostPacket = mvFrameOut.stFrameInfo.nLostPacket;
      ChunkInfo chunkInfo = new ChunkInfo();
      int num = Marshal.SizeOf((object) new MvCCDll.MV_CHUNK_DATA_CONTENT());
      for (int index = 0; (long) index < (long) mvFrameOut.stFrameInfo.nUnparsedChunkNum; ++index)
      {
        MvCCDll.MV_CHUNK_DATA_CONTENT structure = (MvCCDll.MV_CHUNK_DATA_CONTENT) Marshal.PtrToStructure(mvFrameOut.stFrameInfo.UnparsedChunkList.pUnparsedChunkContent + index * num, typeof (MvCCDll.MV_CHUNK_DATA_CONTENT));
        ChunkData chunkData = new ChunkData()
        {
          ChunkID = structure.nChunkID,
          DataPtr = structure.pChunkData,
          Length = structure.nChunkLen
        };
        chunkInfo[chunkData.ChunkID] = (IChunkData) chunkData;
      }
      frameOut.ChunkInfo = (IChunkInfo) chunkInfo;
      return 0;
    }
  }
}
