// Decompiled with JetBrains decompiler
// Type: MvCameraControl.InterfaceFactoryImpl
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  internal static class InterfaceFactoryImpl
  {
    public static IInterface CreateInterface(IInterfaceInfo interfaceInfo)
    {
      if (interfaceInfo == null)
        throw new MvException(-2147483644, string.Format("CreateHandle failed paramer is null! ErrorCode:{0:x}", (object) -2147483644));
      MvCCDll.MV_INTERFACE_INFO pInterfaceInfo = new MvCCDll.MV_INTERFACE_INFO();
      pInterfaceInfo.nTLayerType = (uint) interfaceInfo.TLayerType;
      pInterfaceInfo.nPCIEInfo = interfaceInfo.PCIEInfo;
      pInterfaceInfo.chDeviceVersion = interfaceInfo.DeviceVersion;
      pInterfaceInfo.chDisplayName = interfaceInfo.DisplayName;
      pInterfaceInfo.chInterfaceID = interfaceInfo.InterfaceID;
      pInterfaceInfo.chManufacturer = interfaceInfo.Manufacturer;
      pInterfaceInfo.chModelName = interfaceInfo.ModelName;
      pInterfaceInfo.chSerialNumber = interfaceInfo.SerialNumber;
      pInterfaceInfo.chUserDefinedName = new byte[64];
      InnerTools.StringToByteArray(interfaceInfo.UserDefinedName, pInterfaceInfo.chUserDefinedName);
      IntPtr zero = IntPtr.Zero;
      int errorCode = MvCCDll.MV_CC_CreateInterface(ref zero, ref pInterfaceInfo);
      if (errorCode != 0)
        throw new MvException(errorCode, string.Format("CreateHandle failed! ErrorCode:{0:x}", (object) errorCode));
      return (IInterface) new Interface(zero);
    }

    public static IInterface CreateInterface(string interfaceID)
    {
      IntPtr zero = IntPtr.Zero;
      int interfaceById = MvCCDll.MV_CC_CreateInterfaceByID(ref zero, interfaceID);
      if (interfaceById != 0)
        throw new MvException(interfaceById, string.Format("CreateHandle failed! ErrorCode:{0:x}", (object) interfaceById));
      return (IInterface) new Interface(zero);
    }
  }
}
