// Decompiled with JetBrains decompiler
// Type: MvCameraControl.CCMParam
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>CCM参数</summary>
  public struct CCMParam
  {
    /// <summary>是否启用CCM</summary>
    public bool CCMEnable;
    /// <summary>CCM矩阵[-65536~65536],必须是Int32[9]</summary>
    public int[] CCMat;
    /// <summary>量化系数（2的整数幂，最大65536）</summary>
    public uint CCMScale;
  }
}
