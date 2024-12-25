// Decompiled with JetBrains decompiler
// Type: MvCameraControl.VideoRecorder
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>录像功能实现类</summary>
  internal class VideoRecorder : IVideoRecorder
  {
    private IntPtr _devHandle;

    internal VideoRecorder(IntPtr devHandle) => this._devHandle = devHandle;

    public int InputOneFrame(IImage image)
    {
      if (image == null)
        return -2147483644;
      var v = new MvCCDll.MV_CC_INPUT_FRAME_INFO()
      {
          pData = image.PixelDataPtr,
          nDataLen = (uint)image.ImageSize
      };
      return MvCCDll.MV_CC_InputOneFrame(this._devHandle, ref v);
    }

    public int StartRecord(string filePath, RecordParam recordParam)
    {
      MvCCDll.MV_CC_RECORD_PARAM pstRecordParam = new MvCCDll.MV_CC_RECORD_PARAM();
      pstRecordParam.strFilePath = filePath;
      if (recordParam.Width > (uint) ushort.MaxValue || recordParam.Height > (uint) ushort.MaxValue)
        return -2147483644;
      pstRecordParam.nWidth = Convert.ToUInt16(recordParam.Width);
      pstRecordParam.nHeight = Convert.ToUInt16(recordParam.Height);
      pstRecordParam.enPixelType = (MvCCDll.MvGvspPixelType) recordParam.PixelType;
      pstRecordParam.nBitRate = recordParam.BitRate;
      pstRecordParam.fFrameRate = recordParam.FrameRate;
      pstRecordParam.enRecordFmtType = (MvCCDll.MV_RECORD_FORMAT_TYPE) recordParam.FormatType;
      return MvCCDll.MV_CC_StartRecord(this._devHandle, ref pstRecordParam);
    }

    public int StopRecord() => MvCCDll.MV_CC_StopRecord(this._devHandle);
  }
}
