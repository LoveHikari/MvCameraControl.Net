// Decompiled with JetBrains decompiler
// Type: MvCameraControl.DeviceEnumerator
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  /// <summary>
  /// 设备枚举类，支持枚举GigE Vision、USB3 Vision相机，及采集卡上的相机（GigE Vision、CameraLink、CoaXPress、XoFlink）
  /// </summary>
  public static class DeviceEnumerator
  {
    /// <summary>枚举设备</summary>
    /// <param name="TLayerType">设备接口类型</param>
    /// <param name="devInfoList">设备列表</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 设备接口类型为MV_GIGE_DEVICE时，枚举所有GigE设备，包含虚拟GigE设备和采集卡上的GigE设备。
    /// 设备接口类型为MV_USB_DEVICE时，枚举所有USB设备，包含虚拟USB设备。
    /// 
    /// 设备列表的内存是在SDK内部分配的，调用该接口时会进行设备列表内存的释放和申请，避免多线程枚举操作。
    /// 
    /// 枚举到设备后，通过<see cref="T:MvCameraControl.DeviceFactory" />创建设备实例。
    /// </remarks>
    public static int EnumDevices(DeviceTLayerType TLayerType, out List<IDeviceInfo> devInfoList)
    {
      return DeviceEnumerator.EnumDevicesImpl(TLayerType, out devInfoList);
    }

    /// <summary>枚举设备，支持枚举指定厂商的设备</summary>
    /// <param name="TLayerType">设备接口类型</param>
    /// <param name="manufacturerName">厂商名称</param>
    /// <param name="devInfoList">设备列表</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 设备接口类型为MV_GIGE_DEVICE时，枚举所有GigE设备，包含虚拟GigE设备和采集卡上的GigE设备。
    /// 设备接口类型为MV_USB_DEVICE时，枚举所有USB设备，包含虚拟USB设备。
    /// 
    /// 设备列表的内存是在SDK内部分配的，调用该接口时会进行设备列表内存的释放和申请，避免多线程枚举操作。
    /// 
    /// 枚举到设备后，通过<see cref="T:MvCameraControl.DeviceFactory" />创建设备实例。
    /// </remarks>
    public static int EnumDevicesEx(
      DeviceTLayerType TLayerType,
      string manufacturerName,
      out List<IDeviceInfo> devInfoList)
    {
      return DeviceEnumerator.EnumDevicesExImpl(TLayerType, manufacturerName, out devInfoList);
    }

    /// <summary>枚举设备, 可指定排序方式枚举、根据厂商名字过滤</summary>
    /// <param name="TLayerType">设备接口类型</param>
    /// <param name="sortMethod">排序方式</param>
    /// <param name="manufacturerName">厂商名称</param>
    /// <param name="devInfoList">设备列表</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 设备接口类型为MV_GIGE_DEVICE时，仅枚举网络上的网口相机，不包含虚拟GigE相机和采集卡上的相机
    /// 设备接口类型为MV_USB_DEVICE时，枚举普通USB设备，不包含虚拟USB设备。
    /// 
    /// 设备列表的内存是在SDK内部分配的，调用该接口时会进行设备列表内存的释放和申请，避免多线程枚举操作。
    /// 
    /// 枚举到设备后，通过<see cref="T:MvCameraControl.DeviceFactory" />创建设备实例。
    /// </remarks>
    public static int EnumDevicesEx2(
      DeviceTLayerType TLayerType,
      SortMethod sortMethod,
      string manufacturerName,
      out List<IDeviceInfo> devInfoList)
    {
      return DeviceEnumerator.EnumDevicesEx2Impl(TLayerType, sortMethod, manufacturerName, out devInfoList);
    }

    /// <summary>判断设备是否可达</summary>
    /// <param name="deviceInfo">设备信息</param>
    /// <param name="accessMode">访问权限</param>
    /// <returns>可达，返回true；不可达，返回false </returns>
    public static bool IsDeviceAccessible(IDeviceInfo deviceInfo, DeviceAccessMode accessMode)
    {
      return DeviceEnumerator.IsDeviceAccessibleImpl(deviceInfo, accessMode);
    }

    /// <summary>设置GigE设备枚举超时时间，范围 1-UINT_MAX（包括1，不包括UINT_MAX）</summary>
    /// <param name="timeoutInMS">超时时间</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public static int SetGigEDeviceEnumTimeout(uint timeoutInMS)
    {
      return DeviceEnumerator.SetGigEDeviceEnumTimeoutImpl(timeoutInMS);
    }

    /// <summary>设置枚举命令的回复包类型</summary>
    /// <param name="mode">回复包类型（默认广播），0-单播，1-广播 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public static int SetGigEDeviceDiscoryMode(uint mode)
    {
      return DeviceEnumerator.SetGigEDeviceDiscoryModeImpl(mode);
    }

    /// <summary>获取主机串口列表</summary>
    /// <param name="serialPortList">串口列表</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public static int GetSerialPortList(out List<string> serialPortList)
    {
      return DeviceEnumerator.GetSerialPortListImpl(out serialPortList);
    }

    /// <summary>设置在指定的串口上枚举设备</summary>
    /// <param name="serialPortList">串口列表</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public static int SetEnumSerialPorts(List<string> serialPortList)
    {
      return DeviceEnumerator.SetEnumSerialPortsImpl(serialPortList);
    }

    /// <summary>发出动作命令</summary>
    /// <param name="actionCmdInfo">动作命令信息 </param>
    /// <param name="actionCmdResults">动作命令返回信息列表</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>仅GigEVision相机支持</remarks>
    public static int GigEIssueActionCommand(
      ActionCmdInfo actionCmdInfo,
      out List<ActionCmdResult> actionCmdResults)
    {
      return DeviceEnumerator.IssueActionCommandImpl(actionCmdInfo, out actionCmdResults);
    }

    /// <summary>获取GigE设备组播状态</summary>
    /// <param name="deviceInfo">设备信息</param>
    /// <param name="status">组播状态（true：组播状态；false：非组播）</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>仅GigEVision相机支持</remarks>
    public static int GetGigEMulticastStatus(IDeviceInfo deviceInfo, out bool status)
    {
      return DeviceEnumerator.GetMulticastStatusImpl(deviceInfo, out status);
    }

    private static int EnumDevicesImpl(
      DeviceTLayerType TLayerType,
      out List<IDeviceInfo> devInfoList)
    {
      devInfoList = new List<IDeviceInfo>();
      int num;
      try
      {
        MvCCDll.MV_CC_DEVICE_INFO_LIST stDevList = new MvCCDll.MV_CC_DEVICE_INFO_LIST();
        num = MvCCDll.MV_CC_EnumDevices((uint) TLayerType, ref stDevList);
        if (num == 0)
          InnerTools.DevInfoListStruct2DevInfoList(stDevList, ref devInfoList);
      }
      catch (Exception ex)
      {
        num = -2147483642;
      }
      return num;
    }

    private static int EnumDevicesExImpl(
      DeviceTLayerType TLayerType,
      string manufacturerName,
      out List<IDeviceInfo> devInfoList)
    {
      devInfoList = new List<IDeviceInfo>();
      MvCCDll.MV_CC_DEVICE_INFO_LIST stDevList = new MvCCDll.MV_CC_DEVICE_INFO_LIST();
      int num = MvCCDll.MV_CC_EnumDevicesEx((uint) TLayerType, ref stDevList, manufacturerName);
      if (num == 0)
        InnerTools.DevInfoListStruct2DevInfoList(stDevList, ref devInfoList);
      return num;
    }

    private static int EnumDevicesEx2Impl(
      DeviceTLayerType TLayerType,
      SortMethod sortMethod,
      string manufacturerName,
      out List<IDeviceInfo> devInfoList)
    {
      devInfoList = new List<IDeviceInfo>();
      MvCCDll.MV_CC_DEVICE_INFO_LIST stDevList = new MvCCDll.MV_CC_DEVICE_INFO_LIST();
      int num = MvCCDll.MV_CC_EnumDevicesEx2((uint) TLayerType, ref stDevList, manufacturerName, (MvCCDll.MV_SORT_METHOD) sortMethod);
      if (num == 0)
        InnerTools.DevInfoListStruct2DevInfoList(stDevList, ref devInfoList);
      return num;
    }

    /// <summary>将用户的设备信息格式转换为SDK的内部设备信息格式</summary>
    /// <param name="mvDeviceInfo"></param>
    /// <param name="deviceInfo"></param>
    /// <returns></returns>
    private static int DeviceInfoToMv(
      ref MvCCDll.MV_CC_DEVICE_INFO mvDeviceInfo,
      ref IDeviceInfo deviceInfo)
    {
      if (DeviceTLayerType.MvGigEDevice == deviceInfo.TLayerType || DeviceTLayerType.MvVirGigEDevice == deviceInfo.TLayerType || DeviceTLayerType.MvGenTLGigEDevice == deviceInfo.TLayerType)
      {
        GigEDeviceInfo gigEdeviceInfo = (GigEDeviceInfo) deviceInfo;
        mvDeviceInfo.nMajorVer = gigEdeviceInfo.MajorVer;
        mvDeviceInfo.nMinorVer = gigEdeviceInfo.MinorVer;
        mvDeviceInfo.nMacAddrHigh = gigEdeviceInfo.MacAddrHigh;
        mvDeviceInfo.nMacAddrLow = gigEdeviceInfo.MacAddrLow;
        mvDeviceInfo.nTLayerType = (uint) gigEdeviceInfo.TLayerType;
        mvDeviceInfo.nDevTypeInfo = gigEdeviceInfo.DevTypeInfo;
        MvCCDll.MV_GIGE_DEVICE_INFO mvGigeDeviceInfo = new MvCCDll.MV_GIGE_DEVICE_INFO();
        mvGigeDeviceInfo.nIpCfgOption = gigEdeviceInfo.IpCfgOption;
        mvGigeDeviceInfo.nIpCfgCurrent = gigEdeviceInfo.IpCfgCurrent;
        mvGigeDeviceInfo.nCurrentIp = gigEdeviceInfo.CurrentIp;
        mvGigeDeviceInfo.nCurrentSubNetMask = gigEdeviceInfo.CurrentSubNetMask;
        mvGigeDeviceInfo.nDefultGateWay = gigEdeviceInfo.DefultGateWay;
        mvGigeDeviceInfo.chManufacturerName = gigEdeviceInfo.ManufacturerName;
        mvGigeDeviceInfo.chModelName = gigEdeviceInfo.ModelName;
        mvGigeDeviceInfo.chDeviceVersion = gigEdeviceInfo.DeviceVersion;
        mvGigeDeviceInfo.chSerialNumber = gigEdeviceInfo.SerialNumber;
        mvGigeDeviceInfo.chUserDefinedName = gigEdeviceInfo.UserDefinedName;
        mvGigeDeviceInfo.nNetExport = gigEdeviceInfo.NetExport;
        if (mvGigeDeviceInfo.nReserved == null)
          mvGigeDeviceInfo.nReserved = new uint[4];
        mvGigeDeviceInfo.nReserved[0] = gigEdeviceInfo.HostIp;
        mvGigeDeviceInfo.nReserved[2] = gigEdeviceInfo.nMulticastIp;
        mvGigeDeviceInfo.nReserved[3] = gigEdeviceInfo.nMulticastPort;
        if (gigEdeviceInfo.VirtualDevice || DeviceTLayerType.MvVirGigEDevice == deviceInfo.TLayerType)
          mvGigeDeviceInfo.nReserved[1] = 1U;
        if (gigEdeviceInfo.GenTLDevice || DeviceTLayerType.MvGenTLGigEDevice == deviceInfo.TLayerType)
          mvGigeDeviceInfo.nReserved[1] = 2U;
        MvCCDll.StructToBytes<MvCCDll.MV_GIGE_DEVICE_INFO>(mvGigeDeviceInfo, mvDeviceInfo.SpecialInfo.stGigEInfo);
      }
      else if (DeviceTLayerType.MvUsbDevice == deviceInfo.TLayerType || DeviceTLayerType.MvVirUsbDevice == deviceInfo.TLayerType)
      {
        USBDeviceInfo usbDeviceInfo = (USBDeviceInfo) deviceInfo;
        mvDeviceInfo.nTLayerType = (uint) usbDeviceInfo.TLayerType;
        mvDeviceInfo.nDevTypeInfo = usbDeviceInfo.DevTypeInfo;
        MvCCDll.MV_USB3_DEVICE_INFO mvUsB3DeviceInfo = new MvCCDll.MV_USB3_DEVICE_INFO();
        mvUsB3DeviceInfo.chManufacturerName = usbDeviceInfo.ManufacturerName;
        mvUsB3DeviceInfo.chModelName = usbDeviceInfo.ModelName;
        mvUsB3DeviceInfo.chDeviceVersion = usbDeviceInfo.DeviceVersion;
        mvUsB3DeviceInfo.chSerialNumber = usbDeviceInfo.SerialNumber;
        mvUsB3DeviceInfo.chUserDefinedName = usbDeviceInfo.UserDefinedName;
        mvUsB3DeviceInfo.CrtlInEndPoint = usbDeviceInfo.CrtlInEndPoint;
        mvUsB3DeviceInfo.CrtlOutEndPoint = usbDeviceInfo.CrtlOutEndPoint;
        mvUsB3DeviceInfo.StreamEndPoint = usbDeviceInfo.StreamEndPoint;
        mvUsB3DeviceInfo.EventEndPoint = usbDeviceInfo.EventEndPoint;
        mvUsB3DeviceInfo.idVendor = usbDeviceInfo.VendorID;
        mvUsB3DeviceInfo.idProduct = usbDeviceInfo.ProductID;
        mvUsB3DeviceInfo.nDeviceNumber = usbDeviceInfo.DeviceNumber;
        mvUsB3DeviceInfo.chDeviceGUID = usbDeviceInfo.DeviceGUID;
        mvUsB3DeviceInfo.chFamilyName = usbDeviceInfo.FamilyName;
        mvUsB3DeviceInfo.nbcdUSB = usbDeviceInfo.nbcdUSB;
        if (mvUsB3DeviceInfo.nReserved == null)
          mvUsB3DeviceInfo.nReserved = new uint[3];
        mvUsB3DeviceInfo.nReserved[0] = usbDeviceInfo.DeviceAddress;
        if (usbDeviceInfo.VirtualDevice || DeviceTLayerType.MvVirUsbDevice == deviceInfo.TLayerType)
          mvUsB3DeviceInfo.nReserved[1] = 1U;
        MvCCDll.StructToBytes<MvCCDll.MV_USB3_DEVICE_INFO>(mvUsB3DeviceInfo, mvDeviceInfo.SpecialInfo.stUsb3VInfo);
      }
      else if (DeviceTLayerType.MvCameraLinkDevice == deviceInfo.TLayerType)
      {
        CamlDeviceInfo camlDeviceInfo = (CamlDeviceInfo) deviceInfo;
        mvDeviceInfo.nTLayerType = (uint) camlDeviceInfo.TLayerType;
        mvDeviceInfo.nDevTypeInfo = camlDeviceInfo.DevTypeInfo;
        MvCCDll.StructToBytes<MvCCDll.MV_CamL_DEV_INFO>(new MvCCDll.MV_CamL_DEV_INFO()
        {
          chPortID = camlDeviceInfo.PortID,
          chModelName = camlDeviceInfo.ModelName,
          chDeviceVersion = camlDeviceInfo.DeviceVersion,
          chFamilyName = camlDeviceInfo.FamilyName,
          chManufacturerName = camlDeviceInfo.ManufacturerName,
          chSerialNumber = camlDeviceInfo.SerialNumber
        }, mvDeviceInfo.SpecialInfo.stCamLInfo);
      }
      else if (DeviceTLayerType.MvGenTLCXPDevice == deviceInfo.TLayerType)
      {
        CXPDeviceInfo cxpDeviceInfo = (CXPDeviceInfo) deviceInfo;
        mvDeviceInfo.nTLayerType = (uint) cxpDeviceInfo.TLayerType;
        mvDeviceInfo.nDevTypeInfo = cxpDeviceInfo.DevTypeInfo;
        MvCCDll.MV_CXP_DEVICE_INFO mvCxpDeviceInfo = new MvCCDll.MV_CXP_DEVICE_INFO();
        mvCxpDeviceInfo.chManufacturerInfo = cxpDeviceInfo.ManufacturerName;
        mvCxpDeviceInfo.chModelName = cxpDeviceInfo.ModelName;
        mvCxpDeviceInfo.chDeviceVersion = cxpDeviceInfo.DeviceVersion;
        mvCxpDeviceInfo.chSerialNumber = cxpDeviceInfo.SerialNumber;
        mvCxpDeviceInfo.chUserDefinedName = new byte[64];
        InnerTools.StringToByteArray(cxpDeviceInfo.UserDefinedName, mvCxpDeviceInfo.chUserDefinedName);
        mvCxpDeviceInfo.chDeviceID = cxpDeviceInfo.DeviceID;
        mvCxpDeviceInfo.chInterfaceID = cxpDeviceInfo.InterfaceID;
        MvCCDll.StructToBytes<MvCCDll.MV_CXP_DEVICE_INFO>(mvCxpDeviceInfo, mvDeviceInfo.SpecialInfo.stCXPInfo);
      }
      else if (DeviceTLayerType.MvGenTLCameraLinkDevice == deviceInfo.TLayerType)
      {
        CameraLinkDeviceInfo cameraLinkDeviceInfo = (CameraLinkDeviceInfo) deviceInfo;
        mvDeviceInfo.nTLayerType = (uint) cameraLinkDeviceInfo.TLayerType;
        mvDeviceInfo.nDevTypeInfo = cameraLinkDeviceInfo.DevTypeInfo;
        MvCCDll.MV_CML_DEVICE_INFO mvCmlDeviceInfo = new MvCCDll.MV_CML_DEVICE_INFO();
        mvCmlDeviceInfo.chManufacturerInfo = cameraLinkDeviceInfo.ManufacturerName;
        mvCmlDeviceInfo.chModelName = cameraLinkDeviceInfo.ModelName;
        mvCmlDeviceInfo.chDeviceVersion = cameraLinkDeviceInfo.DeviceVersion;
        mvCmlDeviceInfo.chSerialNumber = cameraLinkDeviceInfo.SerialNumber;
        mvCmlDeviceInfo.chUserDefinedName = new byte[64];
        InnerTools.StringToByteArray(cameraLinkDeviceInfo.UserDefinedName, mvCmlDeviceInfo.chUserDefinedName);
        mvCmlDeviceInfo.chDeviceID = cameraLinkDeviceInfo.DeviceID;
        mvCmlDeviceInfo.chInterfaceID = cameraLinkDeviceInfo.InterfaceID;
        MvCCDll.StructToBytes<MvCCDll.MV_CML_DEVICE_INFO>(mvCmlDeviceInfo, mvDeviceInfo.SpecialInfo.stCMLInfo);
      }
      else if (DeviceTLayerType.MvGenTLXoFDevice == deviceInfo.TLayerType)
      {
        XoFDeviceInfo xoFdeviceInfo = (XoFDeviceInfo) deviceInfo;
        mvDeviceInfo.nTLayerType = (uint) xoFdeviceInfo.TLayerType;
        mvDeviceInfo.nDevTypeInfo = xoFdeviceInfo.DevTypeInfo;
        MvCCDll.MV_XOF_DEVICE_INFO mvXofDeviceInfo = new MvCCDll.MV_XOF_DEVICE_INFO();
        mvXofDeviceInfo.chManufacturerInfo = xoFdeviceInfo.ManufacturerName;
        mvXofDeviceInfo.chModelName = xoFdeviceInfo.ModelName;
        mvXofDeviceInfo.chDeviceVersion = xoFdeviceInfo.DeviceVersion;
        mvXofDeviceInfo.chSerialNumber = xoFdeviceInfo.SerialNumber;
        mvXofDeviceInfo.chUserDefinedName = new byte[64];
        InnerTools.StringToByteArray(xoFdeviceInfo.UserDefinedName, mvXofDeviceInfo.chUserDefinedName);
        mvXofDeviceInfo.chDeviceID = xoFdeviceInfo.DeviceID;
        mvXofDeviceInfo.chInterfaceID = xoFdeviceInfo.InterfaceID;
        MvCCDll.StructToBytes<MvCCDll.MV_XOF_DEVICE_INFO>(mvXofDeviceInfo, mvDeviceInfo.SpecialInfo.stXoFInfo);
      }
      return 0;
    }

    private static bool IsDeviceAccessibleImpl(IDeviceInfo deviceInfo, DeviceAccessMode accessMode)
    {
      if (deviceInfo == null)
        throw new MvException(-2147483644, string.Format("IsDeviceAccessibleImpl failed! ErrorCode:{0:x}", (object) -2147483644));
      MvCCDll.MV_CC_DEVICE_INFO mvCcDeviceInfo = new MvCCDll.MV_CC_DEVICE_INFO(0U);
      DeviceEnumerator.DeviceInfoToMv(ref mvCcDeviceInfo, ref deviceInfo);
      return MvCCDll.MV_CC_IsDeviceAccessible(ref mvCcDeviceInfo, (uint) accessMode) != (byte) 0;
    }

    private static int SetGigEDeviceEnumTimeoutImpl(uint timeoutInMS)
    {
      return MvCCDll.MV_GIGE_SetEnumDevTimeout(timeoutInMS);
    }

    private static int SetGigEDeviceDiscoryModeImpl(uint mode)
    {
      return MvCCDll.MV_GIGE_SetDiscoveryMode(mode);
    }

    private static int GetSerialPortListImpl(out List<string> serialPortList)
    {
      serialPortList = new List<string>();
      MvCCDll.MV_CAML_SERIAL_PORT_LIST pstSerialPortList = new MvCCDll.MV_CAML_SERIAL_PORT_LIST();
      int serialPortList1 = MvCCDll.MV_CAML_GetSerialPortList(ref pstSerialPortList);
      if (serialPortList1 == 0)
      {
        for (int index = 0; (long) index < (long) pstSerialPortList.nSerialPortNum; ++index)
          serialPortList.Add(pstSerialPortList.stSerialPort[index].strSerialPort);
      }
      return serialPortList1;
    }

    private static int SetEnumSerialPortsImpl(List<string> serialPortList)
    {
      if (serialPortList == null)
        return -2147483644;
      MvCCDll.MV_CAML_SERIAL_PORT_LIST pstSerialPortList = new MvCCDll.MV_CAML_SERIAL_PORT_LIST();
      if (pstSerialPortList.stSerialPort == null)
        pstSerialPortList.stSerialPort = new MvCCDll.MV_CAML_SERIAL_PORT[64];
      if (pstSerialPortList.nReserved == null)
        pstSerialPortList.nReserved = new uint[4];
      pstSerialPortList.nSerialPortNum = serialPortList.Count > 64 ? 64U : (uint) serialPortList.Count;
      for (int index = 0; index < serialPortList.Count && index < 64; ++index)
        pstSerialPortList.stSerialPort[index].strSerialPort = serialPortList[index];
      return MvCCDll.MV_CAML_SetEnumSerialPorts(ref pstSerialPortList);
    }

    private static int IssueActionCommandImpl(
      ActionCmdInfo actionCmdInfo,
      out List<ActionCmdResult> actionCmdResults)
    {
      actionCmdResults = new List<ActionCmdResult>();
      MvCCDll.MV_ACTION_CMD_INFO pstActionCmdInfo = new MvCCDll.MV_ACTION_CMD_INFO();
      MvCCDll.MV_ACTION_CMD_RESULT_LIST pstActionCmdResults = new MvCCDll.MV_ACTION_CMD_RESULT_LIST();
      pstActionCmdInfo.nDeviceKey = actionCmdInfo.DeviceKey;
      pstActionCmdInfo.nGroupKey = actionCmdInfo.GroupKey;
      pstActionCmdInfo.nGroupMask = actionCmdInfo.GroupMask;
      pstActionCmdInfo.bActionTimeEnable = actionCmdInfo.ActionTimeEnable;
      pstActionCmdInfo.nActionTime = actionCmdInfo.ActionTime;
      pstActionCmdInfo.pBroadcastAddress = actionCmdInfo.BroadcastAddress;
      pstActionCmdInfo.nTimeOut = actionCmdInfo.TimeOut;
      pstActionCmdInfo.bSpecialNetEnable = actionCmdInfo.SpecialNetEnable;
      if (pstActionCmdInfo.bSpecialNetEnable == 1U)
        pstActionCmdInfo.nSpecialNetIP = BitConverter.ToUInt32(IPAddress.Parse(actionCmdInfo.SpecialNetIP).GetAddressBytes(), 0);
      if (pstActionCmdInfo.nReserved == null)
        pstActionCmdInfo.nReserved = new uint[14];
      int num = MvCCDll.MV_GIGE_IssueActionCommand(ref pstActionCmdInfo, ref pstActionCmdResults);
      if (num != 0)
        return num;
      for (int index = 0; (long) index < (long) pstActionCmdResults.nNumResults; ++index)
      {
        int length = Marshal.SizeOf(typeof (MvCCDll.MV_ACTION_CMD_RESULT));
        byte[] numArray = new byte[length];
        Marshal.Copy(pstActionCmdResults.pResults + length * index, numArray, 0, length);
        MvCCDll.MV_ACTION_CMD_RESULT mvActionCmdResult = (MvCCDll.MV_ACTION_CMD_RESULT) MvCCDll.ByteToStruct(numArray, typeof (MvCCDll.MV_ACTION_CMD_RESULT));
        actionCmdResults.Add(new ActionCmdResult()
        {
          DeviceAddress = mvActionCmdResult.strDeviceAddress,
          Status = mvActionCmdResult.nStatus
        });
      }
      return 0;
    }

    private static int GetMulticastStatusImpl(IDeviceInfo deviceInfo, out bool status)
    {
      status = false;
      if (deviceInfo == null)
        return -2147483644;
      MvCCDll.MV_CC_DEVICE_INFO mvCcDeviceInfo = new MvCCDll.MV_CC_DEVICE_INFO(0U);
      DeviceEnumerator.DeviceInfoToMv(ref mvCcDeviceInfo, ref deviceInfo);
      return MvCCDll.MV_GIGE_GetMulticastStatus(ref mvCcDeviceInfo, ref status);
    }
  }
}
