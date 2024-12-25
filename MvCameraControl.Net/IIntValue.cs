// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IIntValue
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>整形参数</summary>
  public interface IIntValue
  {
    /// <summary>当前值</summary>
    long CurValue { get; }

    /// <summary>最大值</summary>
    long Max { get; }

    /// <summary>最小值</summary>
    long Min { get; }

    /// <summary>Increment</summary>
    long Inc { get; }
  }
}
