// Decompiled with JetBrains decompiler
// Type: MvCameraControl.DeviceFactoryImpl
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System.Text.RegularExpressions;

#nullable disable
namespace MvCameraControl
{
  /// <summary>创建设备对象</summary>
  internal static class DeviceFactoryImpl
  {
    /// <summary>创建设备对象</summary>
    /// <param name="deviceInfo">设备信息</param>
    /// <returns>设备实例</returns>
    public static IDevice CreateDevice(IDeviceInfo deviceInfo)
    {
      if (deviceInfo == null)
        throw new MvException(-2147483644, string.Format("CreateDevice failed! ErrorCode:{0:x}", (object) -2147483644));
      return DeviceTLayerType.MvGigEDevice == deviceInfo.TLayerType || DeviceTLayerType.MvGenTLGigEDevice == deviceInfo.TLayerType || DeviceTLayerType.MvVirGigEDevice == deviceInfo.TLayerType ? (IDevice) new GigEDevice(deviceInfo) : (DeviceTLayerType.MvUsbDevice == deviceInfo.TLayerType || DeviceTLayerType.MvVirUsbDevice == deviceInfo.TLayerType ? (IDevice) new USBDevice(deviceInfo) : (DeviceTLayerType.MvCameraLinkDevice != deviceInfo.TLayerType ? (IDevice) new Device(deviceInfo) : (IDevice) new CamlDevice(deviceInfo)));
    }

    /// <summary>通过设备IP地址创建设备，适用于GigE设备</summary>
    /// <param name="deviceIp">设备IP地址</param>
    /// <param name="netExportIp">网口IP地址</param>
    /// <returns>设备实例</returns>
    public static IDevice CreateDeviceByIp(string deviceIp, string netExportIp)
    {
      return deviceIp != null && netExportIp != null && DeviceFactoryImpl.IsValidIPv4(deviceIp) && DeviceFactoryImpl.IsValidIPv4(netExportIp) ? DeviceFactoryImpl.CreateDevice((IDeviceInfo) new GigEDeviceInfo()
      {
        TLayerType = DeviceTLayerType.MvGigEDevice,
        CurrentIp = DeviceFactoryImpl.IpStringToUInt(deviceIp),
        NetExport = DeviceFactoryImpl.IpStringToUInt(netExportIp)
      }) : throw new MvException(-2147483644, string.Format("CreateDeviceByIp failed! ErrorCode:{0:x}", (object) -2147483644));
    }

    /// <summary>通过GenTL设备信息创建设备句柄</summary>
    /// <param name="devInfo">设备信息</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public static IDevice CreateDeviceByGenTL(IGenTLDevInfo devInfo)
    {
      return (IDevice) new Device(devInfo);
    }

    private static bool IsValidIPv4(string ip)
    {
      string pattern = "^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
      return Regex.IsMatch(ip, pattern);
    }

    private static uint IpStringToUInt(string ip)
    {
      string[] strArray = ip.Split('.');
      return strArray.Length != 4 ? 0U : (uint) ((int) uint.Parse(strArray[0]) << 24 | (int) uint.Parse(strArray[1]) << 16 | (int) uint.Parse(strArray[2]) << 8) | uint.Parse(strArray[3]);
    }
  }
}
