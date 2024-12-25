// Decompiled with JetBrains decompiler
// Type: MvCameraControl.DeviceFactory
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>设备工厂类，用于创建设备实例</summary>
  public static class DeviceFactory
  {
    /// <summary>创建设备对象</summary>
    /// <param name="deviceInfo">设备信息</param>
    /// <returns>成功-返回设备实例，失败-抛出异常 <see cref="T:MvCameraControl.MvException" /></returns>
    public static IDevice CreateDevice(IDeviceInfo deviceInfo)
    {
      return DeviceFactoryImpl.CreateDevice(deviceInfo);
    }

    /// <summary>通过设备IP地址创建设备，适用于GigE设备,不包含虚拟设备与采集卡设备</summary>
    /// <param name="deviceIp">设备IP地址</param>
    /// <param name="netExportIp">网口IP地址</param>
    /// <returns>成功-返回设备实例，失败-抛出异常 <see cref="T:MvCameraControl.MvException" /></returns>
    public static IDevice CreateDeviceByIp(string deviceIp, string netExportIp)
    {
      return DeviceFactoryImpl.CreateDeviceByIp(deviceIp, netExportIp);
    }

    /// <summary>通过GenTL设备信息创建设备句柄</summary>
    /// <param name="devInfo">设备信息</param>
    /// <returns>成功-返回设备实例，失败-抛出异常 <see cref="T:MvCameraControl.MvException" /></returns>
    public static IDevice CreateDeviceByGenTL(IGenTLDevInfo devInfo)
    {
      return DeviceFactoryImpl.CreateDeviceByGenTL(devInfo);
    }
  }
}
