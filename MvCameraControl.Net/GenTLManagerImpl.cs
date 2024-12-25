// Decompiled with JetBrains decompiler
// Type: MvCameraControl.GenTLManagerImpl
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  internal static class GenTLManagerImpl
  {
    public static int EnumInterfacesByGenTLImpl(string ctiPath, out List<IGenTLIFInfo> IFList)
    {
      IFList = new List<IGenTLIFInfo>();
      MvCCDll.MV_GENTL_IF_INFO_LIST pstIFInfoList = new MvCCDll.MV_GENTL_IF_INFO_LIST();
      int num = MvCCDll.MV_CC_EnumInterfacesByGenTL(ref pstIFInfoList, ctiPath);
      if (num != 0)
        return num;
      for (int index = 0; (long) index < (long) pstIFInfoList.nInterfaceNum; ++index)
      {
        MvCCDll.MV_GENTL_IF_INFO structure = (MvCCDll.MV_GENTL_IF_INFO) Marshal.PtrToStructure(pstIFInfoList.pIFInfo[index], typeof (MvCCDll.MV_GENTL_IF_INFO));
        IFList.Add((IGenTLIFInfo) new GenTLIFInfo()
        {
          CtiIndex = structure.nCtiIndex,
          DisplayName = structure.chDisplayName,
          InterfaceID = structure.chInterfaceID,
          TLType = structure.chTLType
        });
      }
      return 0;
    }

    public static int EnumDevicesByGenTLImpl(IGenTLIFInfo IFInfo, out List<IGenTLDevInfo> devList)
    {
      devList = new List<IGenTLDevInfo>();
      MvCCDll.MV_GENTL_IF_INFO stIFInfo = new MvCCDll.MV_GENTL_IF_INFO();
      stIFInfo.nCtiIndex = IFInfo.CtiIndex;
      stIFInfo.chDisplayName = IFInfo.DisplayName;
      stIFInfo.chInterfaceID = IFInfo.InterfaceID;
      stIFInfo.chTLType = IFInfo.TLType;
      MvCCDll.MV_GENTL_DEV_INFO_LIST pstDevList = new MvCCDll.MV_GENTL_DEV_INFO_LIST();
      int num = MvCCDll.MV_CC_EnumDevicesByGenTL(ref stIFInfo, ref pstDevList);
      if (num != 0)
        return num;
      for (int index = 0; (long) index < (long) pstDevList.nDeviceNum; ++index)
      {
        MvCCDll.MV_GENTL_DEV_INFO_EX structure = (MvCCDll.MV_GENTL_DEV_INFO_EX) Marshal.PtrToStructure(pstDevList.pDeviceInfo[index], typeof (MvCCDll.MV_GENTL_DEV_INFO_EX));
        devList.Add((IGenTLDevInfo) new GenTLDevInfo()
        {
          InterfaceID = structure.chInterfaceID,
          DeviceID = structure.chDeviceID,
          VendorName = structure.chVendorName,
          ModelName = structure.chModelName,
          TLType = structure.chTLType,
          DisplayName = structure.chDisplayName,
          UserDefinedName = InnerTools.ByteArrayToString(structure.chUserDefinedName),
          SerialNumber = structure.chSerialNumber,
          DeviceVersion = structure.chDeviceVersion,
          CtiIndex = structure.nCtiIndex
        });
      }
      return 0;
    }

    public static int UnloadGenTLLibraryImpl(string ctiPath)
    {
      return MvCCDll.MV_CC_UnloadGenTLLibrary(ctiPath);
    }
  }
}
