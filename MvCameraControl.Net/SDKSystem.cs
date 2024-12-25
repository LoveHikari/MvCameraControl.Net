// Decompiled with JetBrains decompiler
// Type: MvCameraControl.SDKSystem
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>SDk全局信息及操作接口</summary>
  public static class SDKSystem
  {
    private static string GetSDKVersionImpl()
    {
      uint sdkVersion = MvCCDll.MV_CC_GetSDKVersion();
      return string.Format("{0}.{1}.{2}.{3}", (object) (sdkVersion >> 24), (object) (uint) ((int) (sdkVersion >> 16) & (int) byte.MaxValue), (object) (uint) ((int) (sdkVersion >> 8) & (int) byte.MaxValue), (object) (uint) ((int) sdkVersion & (int) byte.MaxValue));
    }

    private static int InitializeImpl() => MvCCDll.MV_CC_Initialize();

    private static int FinalizeImpl() => MvCCDll.MV_CC_Finalize();

    /// <summary>获取SDK版本信息</summary>
    /// <returns>SDK版本号，格式x.y.z.a</returns>
    public static string GetSDKVersion() => SDKSystem.GetSDKVersionImpl();

    /// <summary>初始化SDK</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public static int Initialize() => SDKSystem.InitializeImpl();

    /// <summary>反初始化SDK，释放资源</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    public static int Finalize() => SDKSystem.FinalizeImpl();
  }
}
