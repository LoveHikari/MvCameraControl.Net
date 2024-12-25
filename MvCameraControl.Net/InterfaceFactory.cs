// Decompiled with JetBrains decompiler
// Type: MvCameraControl.InterfaceFactory
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>采集卡工厂类，创建采集卡实例</summary>
  public static class InterfaceFactory
  {
    /// <summary>根据采集卡信息创建采集卡实例</summary>
    /// <param name="interfaceInfo">采集卡信息</param>
    /// <returns>成功-返回采集卡实例，失败-抛出异常 <see cref="T:MvCameraControl.MvException" /></returns>
    public static IInterface CreateInterface(IInterfaceInfo interfaceInfo)
    {
      return InterfaceFactoryImpl.CreateInterface(interfaceInfo);
    }

    /// <summary>根据采集卡ID创建采集卡实例</summary>
    /// <param name="interfaceID">采集卡ID</param>
    /// <returns>成功-返回采集卡实例，失败-抛出异常 <see cref="T:MvCameraControl.MvException" /></returns>
    public static IInterface CreateInterface(string interfaceID)
    {
      return InterfaceFactoryImpl.CreateInterface(interfaceID);
    }
  }
}
