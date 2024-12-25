// Decompiled with JetBrains decompiler
// Type: MvCameraControl.Parameters
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  /// <summary>参数实现类</summary>
  internal class Parameters : IParameters
  {
    /// <summary>设备句柄</summary>
    private IntPtr _deviceHandle;
    /// <summary>FileAccessRead到Byte数组时的默认文件大小</summary>
    private static uint defaultFileAccessReadBufferSize = 1048576;

    /// <summary>构造函数</summary>
    /// <param name="deviceHandle"></param>
    public Parameters(IntPtr deviceHandle) => this._deviceHandle = deviceHandle;

    public int InvalidateNodes() => MvCCDll.MV_CC_InvalidateNodes(this._deviceHandle);

    public int GetIntValue(string key, out IIntValue value)
    {
      IntValue intValue = new IntValue();
      value = (IIntValue) intValue;
      MvCCDll.MVCC_INTVALUE_EX pIntValue = new MvCCDll.MVCC_INTVALUE_EX();
      pIntValue.nReserved = new uint[16];
      int intValueEx = MvCCDll.MV_CC_GetIntValueEx(this._deviceHandle, key, ref pIntValue);
      intValue.CurValue = pIntValue.nCurValue;
      intValue.Inc = pIntValue.nInc;
      intValue.Min = pIntValue.nMin;
      intValue.Max = pIntValue.nMax;
      return intValueEx;
    }

    public int SetIntValue(string key, long value)
    {
      return MvCCDll.MV_CC_SetIntValueEx(this._deviceHandle, key, value);
    }

    public int GetEnumValue(string key, out IEnumValue value)
    {
      value = (IEnumValue) null;
      int num = 0;
      EnumValue enumValue = new EnumValue();
      int enumEntrySymbolic;
      try
      {
        MvCCDll.MVCC_ENUMVALUE_EX pEnumValue = new MvCCDll.MVCC_ENUMVALUE_EX();
        pEnumValue.nSupportValue = new uint[256];
        pEnumValue.nReserved = new uint[4];
        num = MvCCDll.MV_CC_GetEnumValueEx(this._deviceHandle, key, ref pEnumValue);
        MvCCDll.MVCC_ENUMENTRY pstEnumEntry1 = new MvCCDll.MVCC_ENUMENTRY();
        pstEnumEntry1.nValue = pEnumValue.nCurValue;
        enumEntrySymbolic = MvCCDll.MV_CC_GetEnumEntrySymbolic(this._deviceHandle, key, ref pstEnumEntry1);
        if (enumEntrySymbolic != 0)
          return enumEntrySymbolic;
        EnumEntry enumEntry = new EnumEntry();
        enumEntry.Value = pEnumValue.nCurValue;
        enumEntry.Symbolic = InnerTools.ByteArrayToString(pstEnumEntry1.chSymbolic);
        EnumEntry[] enumEntryArray = new EnumEntry[pEnumValue.nSupportedNum];
        for (int index = 0; (long) index < (long) pEnumValue.nSupportedNum; ++index)
        {
          MvCCDll.MVCC_ENUMENTRY pstEnumEntry2 = new MvCCDll.MVCC_ENUMENTRY();
          pstEnumEntry2.nValue = pEnumValue.nSupportValue[index];
          enumEntrySymbolic = MvCCDll.MV_CC_GetEnumEntrySymbolic(this._deviceHandle, key, ref pstEnumEntry2);
          enumEntryArray[index] = new EnumEntry();
          enumEntryArray[index].Value = pstEnumEntry2.nValue;
          enumEntryArray[index].Symbolic = InnerTools.ByteArrayToString(pstEnumEntry2.chSymbolic);
        }
        enumValue.CurEnumEntry = (IEnumEntry) enumEntry;
        enumValue.SupportedNum = pEnumValue.nSupportedNum;
        enumValue.SupportEnumEntries = (IEnumEntry[]) enumEntryArray;
      }
      catch (EntryPointNotFoundException ex)
      {
        MvCCDll.MVCC_ENUMVALUE pEnumValue = new MvCCDll.MVCC_ENUMVALUE();
        pEnumValue.nSupportValue = new uint[256];
        pEnumValue.nReserved = new uint[4];
        num = MvCCDll.MV_CC_GetEnumValue(this._deviceHandle, key, ref pEnumValue);
        MvCCDll.MVCC_ENUMENTRY pstEnumEntry3 = new MvCCDll.MVCC_ENUMENTRY();
        pstEnumEntry3.nValue = pEnumValue.nCurValue;
        enumEntrySymbolic = MvCCDll.MV_CC_GetEnumEntrySymbolic(this._deviceHandle, key, ref pstEnumEntry3);
        if (enumEntrySymbolic != 0)
          return enumEntrySymbolic;
        EnumEntry enumEntry = new EnumEntry();
        enumEntry.Value = pEnumValue.nCurValue;
        enumEntry.Symbolic = InnerTools.ByteArrayToString(pstEnumEntry3.chSymbolic);
        EnumEntry[] enumEntryArray = new EnumEntry[pEnumValue.nSupportedNum];
        for (int index = 0; (long) index < (long) pEnumValue.nSupportedNum; ++index)
        {
          MvCCDll.MVCC_ENUMENTRY pstEnumEntry4 = new MvCCDll.MVCC_ENUMENTRY();
          pstEnumEntry4.nValue = pEnumValue.nSupportValue[index];
          enumEntrySymbolic = MvCCDll.MV_CC_GetEnumEntrySymbolic(this._deviceHandle, key, ref pstEnumEntry4);
          enumEntryArray[index] = new EnumEntry();
          enumEntryArray[index].Value = pstEnumEntry4.nValue;
          enumEntryArray[index].Symbolic = InnerTools.ByteArrayToString(pstEnumEntry4.chSymbolic);
        }
        enumValue.CurEnumEntry = (IEnumEntry) enumEntry;
        enumValue.SupportedNum = pEnumValue.nSupportedNum;
        enumValue.SupportEnumEntries = (IEnumEntry[]) enumEntryArray;
      }
      value = (IEnumValue) enumValue;
      return enumEntrySymbolic;
    }

    public int SetEnumValue(string key, uint value)
    {
      return MvCCDll.MV_CC_SetEnumValue(this._deviceHandle, key, value);
    }

    public int GetEnumEntrySymbolic(string key, uint value, out string symbolic)
    {
      MvCCDll.MVCC_ENUMENTRY pstEnumEntry = new MvCCDll.MVCC_ENUMENTRY();
      pstEnumEntry.nValue = value;
      pstEnumEntry.chSymbolic = new byte[64];
      pstEnumEntry.nReserved = new uint[4];
      int enumEntrySymbolic = MvCCDll.MV_CC_GetEnumEntrySymbolic(this._deviceHandle, key, ref pstEnumEntry);
      symbolic = InnerTools.ByteArrayToString(pstEnumEntry.chSymbolic);
      return enumEntrySymbolic;
    }

    public int SetEnumValueByString(string key, string value)
    {
      return MvCCDll.MV_CC_SetEnumValueByString(this._deviceHandle, key, value);
    }

    public int GetFloatValue(string key, out IFloatValue value)
    {
      FloatValue floatValue1 = new FloatValue();
      value = (IFloatValue) floatValue1;
      MvCCDll.MVCC_FLOATVALUE pFloatValue = new MvCCDll.MVCC_FLOATVALUE();
      pFloatValue.nReserved = new uint[4];
      int floatValue2 = MvCCDll.MV_CC_GetFloatValue(this._deviceHandle, key, ref pFloatValue);
      floatValue1.CurValue = pFloatValue.fCurValue;
      floatValue1.Min = pFloatValue.fMin;
      floatValue1.Max = pFloatValue.fMax;
      return floatValue2;
    }

    public int SetFloatValue(string key, float value)
    {
      return MvCCDll.MV_CC_SetFloatValue(this._deviceHandle, key, value);
    }

    public int GetBoolValue(string key, out bool value)
    {
      value = false;
      return MvCCDll.MV_CC_GetBoolValue(this._deviceHandle, key, ref value);
    }

    public int SetBoolValue(string key, bool value)
    {
      return MvCCDll.MV_CC_SetBoolValue(this._deviceHandle, key, value);
    }

    public int GetStringValue(string key, out IStringValue value)
    {
      StringValue stringValue1 = new StringValue();
      value = (IStringValue) stringValue1;
      MvCCDll.MVCC_STRINGVALUE pStringValue = new MvCCDll.MVCC_STRINGVALUE();
      pStringValue.nReserved = new uint[2];
      int stringValue2 = MvCCDll.MV_CC_GetStringValue(this._deviceHandle, key, ref pStringValue);
      stringValue1.CurValue = pStringValue.chCurValue;
      stringValue1.MaxLength = (ulong) pStringValue.nMaxLength;
      return stringValue2;
    }

    public int SetStringValue(string key, string value)
    {
      return MvCCDll.MV_CC_SetStringValue(this._deviceHandle, key, value);
    }

    public int SetCommandValue(string key)
    {
      return MvCCDll.MV_CC_SetCommandValue(this._deviceHandle, key);
    }

    public int FeatureLoad(string filePath)
    {
      return MvCCDll.MV_CC_FeatureLoad(this._deviceHandle, filePath);
    }

    public int FeatureSave(string filePath)
    {
      return MvCCDll.MV_CC_FeatureSave(this._deviceHandle, filePath);
    }

    public int ReadMemory(long address, long length, out byte[] buffer)
    {
      buffer = new byte[length];
      return MvCCDll.MV_CC_ReadMemory(this._deviceHandle, Marshal.UnsafeAddrOfPinnedArrayElement((Array) buffer, 0), address, length);
    }

    public int WriteMemory(long address, long length, byte[] buffer)
    {
      return buffer == null ? -2147483644 : MvCCDll.MV_CC_WriteMemory(this._deviceHandle, Marshal.UnsafeAddrOfPinnedArrayElement((Array) buffer, 0), address, length);
    }

    public int GetGenICamXML(out string xmlData)
    {
      byte[] numArray = (byte[]) null;
      uint pnDataLen = 0;
      xmlData = string.Empty;
      int genIcamXml = MvCCDll.MV_XML_GetGenICamXML(this._deviceHandle, IntPtr.Zero, 0U, ref pnDataLen);
      if (pnDataLen > 0U)
      {
        numArray = new byte[pnDataLen];
        genIcamXml = MvCCDll.MV_XML_GetGenICamXML(this._deviceHandle, Marshal.UnsafeAddrOfPinnedArrayElement((Array) numArray, 0), pnDataLen, ref pnDataLen);
      }
      if (genIcamXml == 0)
        xmlData = InnerTools.ByteArrayToString(numArray);
      return genIcamXml;
    }

    public int GetNodeAccessMode(string name, out XmlAccessMode mode)
    {
      mode = XmlAccessMode.Undefined;
      MvCCDll.MV_XML_AccessMode pAccessMode = MvCCDll.MV_XML_AccessMode.AM_Undefined;
      int nodeAccessMode = MvCCDll.MV_XML_GetNodeAccessMode(this._deviceHandle, name, ref pAccessMode);
      if (nodeAccessMode == 0)
        mode = (XmlAccessMode) pAccessMode;
      return nodeAccessMode;
    }

    public int GetNodeInterfaceType(string name, out XmlInterfaceType type)
    {
      type = XmlInterfaceType.IValue;
      MvCCDll.MV_XML_InterfaceType pInterfaceType = MvCCDll.MV_XML_InterfaceType.IFT_IValue;
      int nodeInterfaceType = MvCCDll.MV_XML_GetNodeInterfaceType(this._deviceHandle, name, ref pInterfaceType);
      if (nodeInterfaceType == 0)
        type = (XmlInterfaceType) pInterfaceType;
      return nodeInterfaceType;
    }

    public int FileAccessRead(string deviceFileName, string localFilePath)
    {
        var v = new MvCCDll.MV_CC_FILE_ACCESS()
        {
            nReserved = new uint[32],
            pUserFileName = localFilePath,
            pDevFileName = deviceFileName
        };
      return MvCCDll.MV_CC_FileAccessRead(this._deviceHandle, ref v);
    }

    public int FileAccessRead(string devFileName, out byte[] buffer)
    {
      buffer = new byte[Parameters.defaultFileAccessReadBufferSize];
      MvCCDll.MV_CC_FILE_ACCESS_EX pstFileAccessEx = new MvCCDll.MV_CC_FILE_ACCESS_EX();
      pstFileAccessEx.nReserved = new uint[32];
      pstFileAccessEx.pDevFileName = devFileName;
      pstFileAccessEx.pUserFileBuf = Marshal.UnsafeAddrOfPinnedArrayElement((Array) buffer, 0);
      pstFileAccessEx.nFileBufSize = Parameters.defaultFileAccessReadBufferSize;
      int num = MvCCDll.MV_CC_FileAccessReadEx(this._deviceHandle, ref pstFileAccessEx);
      if (num == -2147483638)
      {
        buffer = new byte[pstFileAccessEx.nFileBufLen];
        pstFileAccessEx.pUserFileBuf = Marshal.UnsafeAddrOfPinnedArrayElement((Array) buffer, 0);
        pstFileAccessEx.nFileBufSize = Parameters.defaultFileAccessReadBufferSize;
        num = MvCCDll.MV_CC_FileAccessReadEx(this._deviceHandle, ref pstFileAccessEx);
      }
      Array.Resize<byte>(ref buffer, (int) pstFileAccessEx.nFileBufLen);
      return num;
    }

    public int FileAccessWrite(string deviceFileName, string localFilePath)
    {
        var v = new MvCCDll.MV_CC_FILE_ACCESS()
        {
            nReserved = new uint[32],
            pUserFileName = localFilePath,
            pDevFileName = deviceFileName
        };
      return MvCCDll.MV_CC_FileAccessWrite(this._deviceHandle, ref v);
    }

    public int FileAccessWrite(string devFileName, byte[] buffer)
    {
      if (buffer == null)
        return -2147483644;
      var v = new MvCCDll.MV_CC_FILE_ACCESS_EX()
      {
          pUserFileBuf = Marshal.UnsafeAddrOfPinnedArrayElement((Array)buffer, 0),
          nFileBufLen = (uint)buffer.Length,
          nFileBufSize = (uint)buffer.Length,
          pDevFileName = devFileName,
          nReserved = new uint[32]
      };
      return MvCCDll.MV_CC_FileAccessWriteEx(this._deviceHandle, ref v);
    }

    public int GetFileAccessProgress(out long completed, out long total)
    {
      MvCCDll.MV_CC_FILE_ACCESS_PROGRESS pstFileAccessProgress = new MvCCDll.MV_CC_FILE_ACCESS_PROGRESS();
      pstFileAccessProgress.nReserved = new uint[8];
      int fileAccessProgress = MvCCDll.MV_CC_GetFileAccessProgress(this._deviceHandle, ref pstFileAccessProgress);
      completed = pstFileAccessProgress.nCompleted;
      total = pstFileAccessProgress.nTotal;
      return fileAccessProgress;
    }

    public int FeatureLoadEx(string filePath, out List<INodeError> nodeErrors)
    {
      nodeErrors = new List<INodeError>();
      MvCCDll.MVCC_NODE_ERROR_LIST pNodeErrorList = new MvCCDll.MVCC_NODE_ERROR_LIST();
      int num = MvCCDll.MV_CC_FeatureLoadEx(this._deviceHandle, filePath, ref pNodeErrorList);
      for (int index = 0; (long) index < (long) pNodeErrorList.nErrorNum; ++index)
        nodeErrors.Add((INodeError) new NodeError()
        {
          NodeName = pNodeErrorList.stNodeError[index].strName,
          ErrorType = (NodeErrorType) pNodeErrorList.stNodeError[index].enErrCode
        });
      return num;
    }

    public int FeatureSaveEx(string filePath, List<string> nodeNames)
    {
      if (nodeNames == null)
        return -2147483644;
      MvCCDll.MVCC_NODE_NAME_LIST pNodeNameList = new MvCCDll.MVCC_NODE_NAME_LIST();
      pNodeNameList.stNodeName = new MvCCDll.MVCC_NODE_NAME[256];
      pNodeNameList.nReserved = new uint[4];
      for (int index = 0; index < nodeNames.Count; ++index)
      {
        pNodeNameList.stNodeName[index].strName = nodeNames[index];
        ++pNodeNameList.nNodeNum;
      }
      return MvCCDll.MV_CC_FeatureSaveEx(this._deviceHandle, filePath, ref pNodeNameList);
    }
  }
}
