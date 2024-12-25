// Decompiled with JetBrains decompiler
// Type: MvCameraControl.InnerTools
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

#nullable disable
namespace MvCameraControl
{
  internal static class InnerTools
  {
    /// <summary>判断像素是否为Mono格式</summary>
    /// <param name="pixelType"></param>
    /// <returns></returns>
    public static bool IsMonoPixel(MvGvspPixelType pixelType)
    {
      switch (pixelType)
      {
        case MvGvspPixelType.PixelType_Gvsp_Mono1p:
        case MvGvspPixelType.PixelType_Gvsp_Mono2p:
        case MvGvspPixelType.PixelType_Gvsp_Mono4p:
        case MvGvspPixelType.PixelType_Gvsp_Mono8:
        case MvGvspPixelType.PixelType_Gvsp_Mono8_Signed:
        case MvGvspPixelType.PixelType_Gvsp_Mono10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_Mono12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_Mono10:
        case MvGvspPixelType.PixelType_Gvsp_Mono12:
        case MvGvspPixelType.PixelType_Gvsp_Mono16:
        case MvGvspPixelType.PixelType_Gvsp_Mono14:
          return true;
        default:
          return false;
      }
    }

    /// <summary>判断图像格式是否为彩色格式</summary>
    /// <param name="pixelType"></param>
    /// <returns></returns>
    public static bool IsColorPixel(MvGvspPixelType pixelType)
    {
      switch (pixelType)
      {
        case MvGvspPixelType.PixelType_Gvsp_BayerGR8:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG8:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB8:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG8:
        case MvGvspPixelType.PixelType_Gvsp_BayerRBGG8:
        case MvGvspPixelType.PixelType_Gvsp_BayerGR10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerGR12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerGR10:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG10:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB10:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG10:
        case MvGvspPixelType.PixelType_Gvsp_BayerGR12:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG12:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB12:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG12:
        case MvGvspPixelType.PixelType_Gvsp_BayerGR16:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG16:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB16:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG16:
        case MvGvspPixelType.PixelType_Gvsp_YUV422_Packed:
        case MvGvspPixelType.PixelType_Gvsp_YUV422_YUYV_Packed:
        case MvGvspPixelType.PixelType_Gvsp_RGB8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BGR8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_RGBA8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BGRA8_Packed:
          return true;
        default:
          return false;
      }
    }

    public static bool IsHBPixelType(MvGvspPixelType pixelType)
    {
      switch (pixelType)
      {
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono8:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGR8:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRG8:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGB8:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerBG8:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRBGG8:
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGR10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRG10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGB10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerBG10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGR12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRG12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGB12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerBG12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono10:
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono12:
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono16:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGR10:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRG10:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGB10:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerBG10:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGR12:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRG12:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGB12:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerBG12:
        case MvGvspPixelType.PixelType_Gvsp_HB_YUV422_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_YUV422_YUYV_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_RGB8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BGR8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_RGBA8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BGRA8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_RGB16_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BGR16_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BGRA16_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_RGBA16_Packed:
          return true;
        default:
          return false;
      }
    }

    /// <summary>获取图像大小</summary>
    /// <param name="width">图像宽度</param>
    /// <param name="height">图像高度</param>
    /// <param name="pixelType">像素格式</param>
    /// <returns></returns>
    public static ulong GetImageSize(uint width, uint height, MvGvspPixelType pixelType)
    {
      ulong imageSize = (ulong) width * (ulong) height;
      switch (pixelType)
      {
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono8:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGR8:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRG8:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGB8:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerBG8:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRBGG8:
        case MvGvspPixelType.PixelType_Gvsp_Mono8:
        case MvGvspPixelType.PixelType_Gvsp_BayerGR8:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG8:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB8:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG8:
        case MvGvspPixelType.PixelType_Gvsp_BayerRBGG8:
          return imageSize;
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGR10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRG10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGB10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerBG10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGR12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRG12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGB12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerBG12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_Mono10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_Mono12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerGR10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG10_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerGR12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB12_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG12_Packed:
          return imageSize * 3UL / 2UL;
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono10:
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono12:
        case MvGvspPixelType.PixelType_Gvsp_HB_Mono16:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGR10:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRG10:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGB10:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerBG10:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGR12:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerRG12:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerGB12:
        case MvGvspPixelType.PixelType_Gvsp_HB_BayerBG12:
        case MvGvspPixelType.PixelType_Gvsp_HB_YUV422_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_YUV422_YUYV_Packed:
        case MvGvspPixelType.PixelType_Gvsp_Mono10:
        case MvGvspPixelType.PixelType_Gvsp_Mono12:
        case MvGvspPixelType.PixelType_Gvsp_Mono16:
        case MvGvspPixelType.PixelType_Gvsp_BayerGR10:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG10:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB10:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG10:
        case MvGvspPixelType.PixelType_Gvsp_BayerGR12:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG12:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB12:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG12:
        case MvGvspPixelType.PixelType_Gvsp_BayerGR16:
        case MvGvspPixelType.PixelType_Gvsp_BayerRG16:
        case MvGvspPixelType.PixelType_Gvsp_BayerGB16:
        case MvGvspPixelType.PixelType_Gvsp_BayerBG16:
        case MvGvspPixelType.PixelType_Gvsp_YUV422_Packed:
        case MvGvspPixelType.PixelType_Gvsp_YUV422_YUYV_Packed:
          return imageSize * 2UL;
        case MvGvspPixelType.PixelType_Gvsp_Coord3D_A32:
        case MvGvspPixelType.PixelType_Gvsp_Coord3D_C32:
        case MvGvspPixelType.PixelType_Gvsp_Coord3D_A32f:
        case MvGvspPixelType.PixelType_Gvsp_Coord3D_C32f:
          return imageSize * 4UL;
        case MvGvspPixelType.PixelType_Gvsp_HB_RGB8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BGR8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_RGB8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BGR8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_RGB8_Planar:
          return imageSize * 3UL;
        case MvGvspPixelType.PixelType_Gvsp_HB_RGBA8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_BGRA8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_RGBA8_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BGRA8_Packed:
          return imageSize * 4UL;
        case MvGvspPixelType.PixelType_Gvsp_HB_BGRA16_Packed:
        case MvGvspPixelType.PixelType_Gvsp_HB_RGBA16_Packed:
        case MvGvspPixelType.PixelType_Gvsp_Coord3D_AB32f:
        case MvGvspPixelType.PixelType_Gvsp_Coord3D_AB32:
        case MvGvspPixelType.PixelType_Gvsp_Coord3D_AC32:
        case MvGvspPixelType.PixelType_Gvsp_RGBA16_Packed:
        case MvGvspPixelType.PixelType_Gvsp_BGRA16_Packed:
        case MvGvspPixelType.PixelType_Gvsp_Coord3D_AC32f:
          return imageSize * 2UL * 4UL;
        case MvGvspPixelType.PixelType_Gvsp_Coord3D_ABC32:
        case MvGvspPixelType.PixelType_Gvsp_Coord3D_ABC32f:
          return imageSize * 3UL * 4UL;
        case MvGvspPixelType.PixelType_Gvsp_Coord3D_ABC16:
          return imageSize * 3UL * 2UL;
        default:
          return imageSize * 3UL;
      }
    }

    /// <summary>内存拷贝</summary>
    /// <param name="dest">目标缓存</param>
    /// <param name="src">源缓存</param>
    /// <param name="count">拷贝大小</param>
    [DllImport("kernel32.dll", EntryPoint = "RtlMoveMemory")]
    public static extern void CopyMemory(IntPtr dest, IntPtr src, uint count);

    /// <summary>将FrameOut转成MvCCDll的帧结构体</summary>
    /// <param name="frameOut"></param>
    /// <param name="mvFrameOut"></param>
    /// <returns></returns>
    public static int ConvertFrameOut2MvFrameOut(
      IFrameOut frameOut,
      out MvCCDll.MV_FRAME_OUT mvFrameOut)
    {
      mvFrameOut = new MvCCDll.MV_FRAME_OUT();
      if (frameOut == null)
        return -2147483644;
      mvFrameOut.pBufAddr = frameOut.Image.PixelDataPtr;
      mvFrameOut.stFrameInfo.enPixelType = (MvCCDll.MvGvspPixelType) frameOut.Image.PixelType;
      mvFrameOut.stFrameInfo.nHeight = (ushort) Math.Min(frameOut.Image.Height, (uint) ushort.MaxValue);
      mvFrameOut.stFrameInfo.nWidth = (ushort) Math.Min(frameOut.Image.Height, (uint) ushort.MaxValue);
      mvFrameOut.stFrameInfo.nFrameLen = (uint) frameOut.Image.ImageSize;
      mvFrameOut.stFrameInfo.nFrameLenEx = frameOut.Image.ImageSize;
      mvFrameOut.stFrameInfo.nExtendHeight = frameOut.Image.Height;
      mvFrameOut.stFrameInfo.nExtendWidth = frameOut.Image.Width;
      mvFrameOut.stFrameInfo.fExposureTime = frameOut.ExposureTime;
      mvFrameOut.stFrameInfo.fGain = frameOut.Gain;
      mvFrameOut.stFrameInfo.nAverageBrightness = frameOut.AverageBrightness;
      mvFrameOut.stFrameInfo.nBlue = frameOut.Blue;
      mvFrameOut.stFrameInfo.nSecondCount = frameOut.SecondCount;
      mvFrameOut.stFrameInfo.nCycleCount = frameOut.CycleCount;
      mvFrameOut.stFrameInfo.nCycleOffset = frameOut.CycleOffset;
      mvFrameOut.stFrameInfo.nDevTimeStampHigh = (uint) (frameOut.DevTimeStamp >> 32);
      mvFrameOut.stFrameInfo.nDevTimeStampLow = (uint) frameOut.DevTimeStamp;
      mvFrameOut.stFrameInfo.nFrameCounter = frameOut.FrameCount;
      mvFrameOut.stFrameInfo.nFrameNum = frameOut.FrameNum;
      mvFrameOut.stFrameInfo.nGreen = frameOut.Green;
      mvFrameOut.stFrameInfo.nHostTimeStamp = (long) frameOut.HostTimeStamp;
      mvFrameOut.stFrameInfo.nInput = frameOut.Input;
      mvFrameOut.stFrameInfo.nLostPacket = frameOut.LostPacket;
      mvFrameOut.stFrameInfo.nOffsetX = (ushort) frameOut.OffsetX;
      mvFrameOut.stFrameInfo.nOffsetY = (ushort) frameOut.OffsetY;
      mvFrameOut.stFrameInfo.nOutput = frameOut.Output;
      mvFrameOut.stFrameInfo.nRed = frameOut.Red;
      mvFrameOut.stFrameInfo.nTriggerIndex = frameOut.TriggerIndex;
      return 0;
    }

    /// <summary>将Byte数组转为String，使用UTF-8编码，并去掉结尾的'\0'</summary>
    /// <param name="byteArray"></param>
    /// <returns></returns>
    public static string ByteArrayToString(byte[] byteArray)
    {
      try
      {
        return InnerTools.IsTextUTF8(byteArray) ? Encoding.UTF8.GetString(byteArray).Split(new char[1])[0] : Encoding.Default.GetString(byteArray).Split(new char[1])[0];
      }
      catch (Exception ex)
      {
        return "";
      }
    }

    /// <summary>String字符串拷贝到byte[]</summary>
    /// <param name="srcString"></param>
    /// <param name="dstByteArray"></param>
    public static void StringToByteArray(string srcString, byte[] dstByteArray)
    {
      byte[] bytes = Encoding.UTF8.GetBytes(srcString);
      long length = bytes.Length < dstByteArray.Length ? (long) bytes.Length : (long) dstByteArray.Length;
      Array.Copy((Array) bytes, (Array) dstByteArray, length);
    }

    /// <summary>判断字符数组是否为utf-8</summary>
    /// <param name="inputStream">字符数组</param>
    /// <returns></returns>
    public static bool IsTextUTF8(byte[] inputStream)
    {
      int num1 = 0;
      bool flag = true;
      for (int index = 0; index < inputStream.Length; ++index)
      {
        byte num2 = inputStream[index];
        if (((int) num2 & 128) == 128)
          flag = false;
        if (num1 == 0)
        {
          if (((int) num2 & 128) != 0)
          {
            if (((int) num2 & 192) != 192)
              return false;
            num1 = 1;
            byte num3 = (byte) ((uint) num2 << 2);
            while (((int) num3 & 128) == 128)
            {
              num3 <<= 1;
              ++num1;
            }
          }
        }
        else
        {
          if (((int) num2 & 192) != 128)
            return false;
          --num1;
        }
      }
      return num1 == 0 && !flag;
    }

    /// <summary>将枚举出来的设备信息转化为输出格式</summary>
    /// <param name="stDevlist"></param>
    /// <param name="devInfoList"></param>
    /// <returns></returns>
    public static void DevInfoListStruct2DevInfoList(
      MvCCDll.MV_CC_DEVICE_INFO_LIST stDevlist,
      ref List<IDeviceInfo> devInfoList)
    {
      for (int index = 0; (long) index < (long) stDevlist.nDeviceNum; ++index)
      {
        MvCCDll.MV_CC_DEVICE_INFO structure = (MvCCDll.MV_CC_DEVICE_INFO) Marshal.PtrToStructure(stDevlist.pDeviceInfo[index], typeof (MvCCDll.MV_CC_DEVICE_INFO));
        if (1U == structure.nTLayerType || 16U == structure.nTLayerType || 64U == structure.nTLayerType)
        {
          GigEDeviceInfo gigEdeviceInfo = new GigEDeviceInfo();
          gigEdeviceInfo.MajorVer = structure.nMajorVer;
          gigEdeviceInfo.MinorVer = structure.nMinorVer;
          gigEdeviceInfo.MacAddrHigh = structure.nMacAddrHigh;
          gigEdeviceInfo.MacAddrLow = structure.nMacAddrLow;
          gigEdeviceInfo.TLayerType = (DeviceTLayerType) structure.nTLayerType;
          gigEdeviceInfo.DevTypeInfo = structure.nDevTypeInfo;
          MvCCDll.MV_GIGE_DEVICE_INFO_EX gigeDeviceInfoEx = (MvCCDll.MV_GIGE_DEVICE_INFO_EX) MvCCDll.ByteToStruct(structure.SpecialInfo.stGigEInfo, typeof (MvCCDll.MV_GIGE_DEVICE_INFO_EX));
          gigEdeviceInfo.ManufacturerName = gigeDeviceInfoEx.chManufacturerName;
          gigEdeviceInfo.ModelName = gigeDeviceInfoEx.chModelName;
          gigEdeviceInfo.DeviceVersion = gigeDeviceInfoEx.chDeviceVersion;
          gigEdeviceInfo.SerialNumber = gigeDeviceInfoEx.chSerialNumber;
          gigEdeviceInfo.UserDefinedName = InnerTools.ByteArrayToString(gigeDeviceInfoEx.chUserDefinedName);
          gigEdeviceInfo.IpCfgOption = gigeDeviceInfoEx.nIpCfgOption;
          gigEdeviceInfo.IpCfgCurrent = gigeDeviceInfoEx.nIpCfgCurrent;
          gigEdeviceInfo.CurrentIp = gigeDeviceInfoEx.nCurrentIp;
          gigEdeviceInfo.CurrentSubNetMask = gigeDeviceInfoEx.nCurrentSubNetMask;
          gigEdeviceInfo.DefultGateWay = gigeDeviceInfoEx.nDefultGateWay;
          gigEdeviceInfo.NetExport = gigeDeviceInfoEx.nNetExport;
          gigEdeviceInfo.VirtualDevice = false;
          gigEdeviceInfo.GenTLDevice = false;
          gigEdeviceInfo.HostIp = gigeDeviceInfoEx.nReserved[0];
          gigEdeviceInfo.nMulticastIp = gigeDeviceInfoEx.nReserved[2];
          gigEdeviceInfo.nMulticastPort = gigeDeviceInfoEx.nReserved[3];
          if (1U == gigeDeviceInfoEx.nReserved[1] || 16U == structure.nTLayerType)
            gigEdeviceInfo.VirtualDevice = true;
          else if (2U == gigeDeviceInfoEx.nReserved[1] || 64U == structure.nTLayerType)
            gigEdeviceInfo.GenTLDevice = true;
          devInfoList.Add((IDeviceInfo) gigEdeviceInfo);
        }
        else if (4U == structure.nTLayerType || 32U == structure.nTLayerType)
        {
          USBDeviceInfo usbDeviceInfo = new USBDeviceInfo();
          usbDeviceInfo.TLayerType = (DeviceTLayerType) structure.nTLayerType;
          usbDeviceInfo.DevTypeInfo = structure.nDevTypeInfo;
          MvCCDll.MV_USB3_DEVICE_INFO_EX usB3DeviceInfoEx = (MvCCDll.MV_USB3_DEVICE_INFO_EX) MvCCDll.ByteToStruct(structure.SpecialInfo.stUsb3VInfo, typeof (MvCCDll.MV_USB3_DEVICE_INFO_EX));
          usbDeviceInfo.ManufacturerName = usB3DeviceInfoEx.chManufacturerName;
          usbDeviceInfo.ModelName = usB3DeviceInfoEx.chModelName;
          usbDeviceInfo.DeviceVersion = usB3DeviceInfoEx.chDeviceVersion;
          usbDeviceInfo.SerialNumber = usB3DeviceInfoEx.chSerialNumber;
          usbDeviceInfo.UserDefinedName = InnerTools.ByteArrayToString(usB3DeviceInfoEx.chUserDefinedName);
          usbDeviceInfo.CrtlInEndPoint = usB3DeviceInfoEx.CrtlInEndPoint;
          usbDeviceInfo.CrtlOutEndPoint = usB3DeviceInfoEx.CrtlOutEndPoint;
          usbDeviceInfo.StreamEndPoint = usB3DeviceInfoEx.StreamEndPoint;
          usbDeviceInfo.EventEndPoint = usB3DeviceInfoEx.EventEndPoint;
          usbDeviceInfo.VendorID = usB3DeviceInfoEx.idVendor;
          usbDeviceInfo.ProductID = usB3DeviceInfoEx.idProduct;
          usbDeviceInfo.DeviceNumber = usB3DeviceInfoEx.nDeviceNumber;
          usbDeviceInfo.DeviceGUID = usB3DeviceInfoEx.chDeviceGUID;
          usbDeviceInfo.FamilyName = usB3DeviceInfoEx.chFamilyName;
          usbDeviceInfo.nbcdUSB = usB3DeviceInfoEx.nbcdUSB;
          usbDeviceInfo.DeviceAddress = usB3DeviceInfoEx.nDeviceAddress;
          usbDeviceInfo.VirtualDevice = false;
          if (1U == usB3DeviceInfoEx.nReserved[1] || 32U == structure.nTLayerType)
            usbDeviceInfo.VirtualDevice = true;
          devInfoList.Add((IDeviceInfo) usbDeviceInfo);
        }
        else if (8U == structure.nTLayerType)
        {
          CamlDeviceInfo camlDeviceInfo = new CamlDeviceInfo();
          camlDeviceInfo.TLayerType = (DeviceTLayerType) structure.nTLayerType;
          camlDeviceInfo.DevTypeInfo = structure.nDevTypeInfo;
          MvCCDll.MV_CamL_DEV_INFO mvCamLDevInfo = (MvCCDll.MV_CamL_DEV_INFO) MvCCDll.ByteToStruct(structure.SpecialInfo.stCamLInfo, typeof (MvCCDll.MV_CamL_DEV_INFO));
          camlDeviceInfo.PortID = mvCamLDevInfo.chPortID;
          camlDeviceInfo.ModelName = mvCamLDevInfo.chModelName;
          camlDeviceInfo.DeviceVersion = mvCamLDevInfo.chDeviceVersion;
          camlDeviceInfo.FamilyName = mvCamLDevInfo.chFamilyName;
          camlDeviceInfo.ManufacturerName = mvCamLDevInfo.chManufacturerName;
          camlDeviceInfo.SerialNumber = mvCamLDevInfo.chSerialNumber;
          devInfoList.Add((IDeviceInfo) camlDeviceInfo);
        }
        else if (256U == structure.nTLayerType)
        {
          CXPDeviceInfo cxpDeviceInfo = new CXPDeviceInfo();
          cxpDeviceInfo.TLayerType = (DeviceTLayerType) structure.nTLayerType;
          cxpDeviceInfo.DevTypeInfo = structure.nDevTypeInfo;
          MvCCDll.MV_CXP_DEVICE_INFO mvCxpDeviceInfo = (MvCCDll.MV_CXP_DEVICE_INFO) MvCCDll.ByteToStruct(structure.SpecialInfo.stCXPInfo, typeof (MvCCDll.MV_CXP_DEVICE_INFO));
          cxpDeviceInfo.ManufacturerName = mvCxpDeviceInfo.chManufacturerInfo;
          cxpDeviceInfo.ModelName = mvCxpDeviceInfo.chModelName;
          cxpDeviceInfo.DeviceVersion = mvCxpDeviceInfo.chDeviceVersion;
          cxpDeviceInfo.SerialNumber = mvCxpDeviceInfo.chSerialNumber;
          cxpDeviceInfo.UserDefinedName = InnerTools.ByteArrayToString(mvCxpDeviceInfo.chUserDefinedName);
          cxpDeviceInfo.DeviceID = mvCxpDeviceInfo.chDeviceID;
          cxpDeviceInfo.InterfaceID = mvCxpDeviceInfo.chInterfaceID;
          devInfoList.Add((IDeviceInfo) cxpDeviceInfo);
        }
        else if (128U == structure.nTLayerType)
        {
          CameraLinkDeviceInfo cameraLinkDeviceInfo = new CameraLinkDeviceInfo();
          cameraLinkDeviceInfo.TLayerType = (DeviceTLayerType) structure.nTLayerType;
          cameraLinkDeviceInfo.DevTypeInfo = structure.nDevTypeInfo;
          MvCCDll.MV_CML_DEVICE_INFO mvCmlDeviceInfo = (MvCCDll.MV_CML_DEVICE_INFO) MvCCDll.ByteToStruct(structure.SpecialInfo.stCMLInfo, typeof (MvCCDll.MV_CML_DEVICE_INFO));
          cameraLinkDeviceInfo.ManufacturerName = mvCmlDeviceInfo.chManufacturerInfo;
          cameraLinkDeviceInfo.ModelName = mvCmlDeviceInfo.chModelName;
          cameraLinkDeviceInfo.DeviceVersion = mvCmlDeviceInfo.chDeviceVersion;
          cameraLinkDeviceInfo.SerialNumber = mvCmlDeviceInfo.chSerialNumber;
          cameraLinkDeviceInfo.UserDefinedName = InnerTools.ByteArrayToString(mvCmlDeviceInfo.chUserDefinedName);
          cameraLinkDeviceInfo.DeviceID = mvCmlDeviceInfo.chDeviceID;
          cameraLinkDeviceInfo.InterfaceID = mvCmlDeviceInfo.chInterfaceID;
          devInfoList.Add((IDeviceInfo) cameraLinkDeviceInfo);
        }
        else if (512U == structure.nTLayerType)
        {
          XoFDeviceInfo xoFdeviceInfo = new XoFDeviceInfo();
          xoFdeviceInfo.TLayerType = (DeviceTLayerType) structure.nTLayerType;
          xoFdeviceInfo.DevTypeInfo = structure.nDevTypeInfo;
          MvCCDll.MV_XOF_DEVICE_INFO mvXofDeviceInfo = (MvCCDll.MV_XOF_DEVICE_INFO) MvCCDll.ByteToStruct(structure.SpecialInfo.stXoFInfo, typeof (MvCCDll.MV_XOF_DEVICE_INFO));
          xoFdeviceInfo.ManufacturerName = mvXofDeviceInfo.chManufacturerInfo;
          xoFdeviceInfo.ModelName = mvXofDeviceInfo.chModelName;
          xoFdeviceInfo.DeviceVersion = mvXofDeviceInfo.chDeviceVersion;
          xoFdeviceInfo.SerialNumber = mvXofDeviceInfo.chSerialNumber;
          xoFdeviceInfo.UserDefinedName = InnerTools.ByteArrayToString(mvXofDeviceInfo.chUserDefinedName);
          xoFdeviceInfo.DeviceID = mvXofDeviceInfo.chDeviceID;
          xoFdeviceInfo.InterfaceID = mvXofDeviceInfo.chInterfaceID;
          devInfoList.Add((IDeviceInfo) xoFdeviceInfo);
        }
      }
    }
  }
}
