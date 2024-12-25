// Decompiled with JetBrains decompiler
// Type: MvCameraControl.GenTLManager
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System.Collections.Generic;

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供GenTL相关接口</summary>
  public static class GenTLManager
  {
    /// <summary>通过GenTL枚举Interfaces</summary>
    /// <param name="ctiPath">GenTL的cti文件路径 </param>
    /// <param name="IFList">Interfaces列表 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public static int EnumInterfacesByGenTL(string ctiPath, out List<IGenTLIFInfo> IFList)
    {
      return GenTLManagerImpl.EnumInterfacesByGenTLImpl(ctiPath, out IFList);
    }

    /// <summary>通过GenTL Interface枚举设备</summary>
    /// <param name="IFInfo">Interface信息 </param>
    /// <param name="devList">设备列表</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 枚举到设备后，通过<see cref="T:MvCameraControl.DeviceFactory" />创建设备实例。
    /// </remarks>
    public static int EnumDevicesByGenTL(IGenTLIFInfo IFInfo, out List<IGenTLDevInfo> devList)
    {
      return GenTLManagerImpl.EnumDevicesByGenTLImpl(IFInfo, out devList);
    }

    /// <summary>卸载cti库</summary>
    /// <param name="ctiPath">枚举卡时加载的cti文件路径 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>卸载前需要保证通过该cti枚举出的相机已全部关闭，否则报错前置条件错误。</remarks>
    public static int UnloadGenTLLibrary(string ctiPath)
    {
      return GenTLManagerImpl.UnloadGenTLLibraryImpl(ctiPath);
    }
  }
}
