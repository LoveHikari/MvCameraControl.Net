// Decompiled with JetBrains decompiler
// Type: MvCameraControl.InterfaceEnumerator
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供枚举采集卡接口</summary>
  public static class InterfaceEnumerator
  {
    /// <summary>枚举采集卡</summary>
    /// <param name="TLayerType">采集卡接口类型</param>
    /// <param name="interfaceInfoList">采集卡列表</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 枚举到采集卡后，通过<see cref="T:MvCameraControl.InterfaceFactory" />创建采集卡实例。
    /// </remarks>
    public static int EnumInterfaces(
      InterfaceTLayerType TLayerType,
      out List<IInterfaceInfo> interfaceInfoList)
    {
      return InterfaceEnumerator.EnumInterfacesImpl(TLayerType, out interfaceInfoList);
    }

    private static int EnumInterfacesImpl(
      InterfaceTLayerType TLayerType,
      out List<IInterfaceInfo> interfaceInfoList)
    {
      interfaceInfoList = new List<IInterfaceInfo>();
      MvCCDll.MV_INTERFACE_INFO_LIST pInterfaceInfoList = new MvCCDll.MV_INTERFACE_INFO_LIST();
      int num = MvCCDll.MV_CC_EnumInterfaces((uint) TLayerType, ref pInterfaceInfoList);
      if (num != 0)
        return num;
      for (int index = 0; (long) index < (long) pInterfaceInfoList.nInterfaceNum; ++index)
      {
        MvCCDll.MV_INTERFACE_INFO structure = (MvCCDll.MV_INTERFACE_INFO) Marshal.PtrToStructure(pInterfaceInfoList.pInterfaceInfo[index], typeof (MvCCDll.MV_INTERFACE_INFO));
        interfaceInfoList.Add((IInterfaceInfo) new InterfaceInfo()
        {
          TLayerType = (InterfaceTLayerType) structure.nTLayerType,
          PCIEInfo = structure.nPCIEInfo,
          InterfaceID = structure.chInterfaceID,
          DisplayName = structure.chDisplayName,
          SerialNumber = structure.chSerialNumber,
          ModelName = structure.chModelName,
          Manufacturer = structure.chManufacturer,
          DeviceVersion = structure.chDeviceVersion,
          UserDefinedName = InnerTools.ByteArrayToString(structure.chUserDefinedName)
        });
      }
      return 0;
    }
  }
}
