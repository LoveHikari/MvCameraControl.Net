// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IStreamGrabber
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供取流相关接口</summary>
  public interface IStreamGrabber
  {
    /// <summary>设备流异常事件，只有USB设备支持</summary>
    /// <remarks>在StartGrabbing前调用</remarks>
    event EventHandler<StreamExceptionEventArgs> StreamExceptionEvent;

    /// <summary>采集一帧图像的事件，获取图像数据</summary>
    /// <remarks>在StartGrabbing前调用</remarks>
    event EventHandler<FrameGrabbedEventArgs> FrameGrabedEvent;

    /// <summary>设置SDK内部图像缓存节点个数，大于等于1</summary>
    /// <param name="num">缓存节点个数 </param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 调用该接口可以设置SDK内部图像缓存节点个数，在 IStreamGrabber.StartGrabbing() 前调用。
    /// 不同相机因为取流方式不同，不调用SetImageNodeNum方法的情况下，不同相机默认缓存节点的个数不同：比如 双U内部分配默认3个节点。
    /// SDK实际分配的节点个数 = SDK内部预分配的个数 + 用户分配的节点(SetImageNodeNum);
    /// </remarks>
    int SetImageNodeNum(uint num);

    /// <summary>获取当前图像缓存区的有效图像个数</summary>
    /// <param name="num">有效图像个数</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetValidImageNum(out uint num);

    /// <summary>开始取流</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int StartGrabbing();

    /// <summary>开始取流，支持设置取流策略</summary>
    /// <param name="strategy">策略枚举值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int StartGrabbing(StreamGrabStrategy strategy);

    /// <summary>
    /// 设置输出缓存个数（只有在 StreamGrabStrategy.LatestImages 策略下才有效，范围：1-ImageNodeNum）
    /// </summary>
    /// <param name="size">输出缓存个数</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetOutputQueueSize(uint size);

    /// <summary>停止取流</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int StopGrabbing();

    /// <summary>获取一帧图像</summary>
    /// <param name="timeoutInMS">等待超时时间</param>
    /// <param name="frameOut">图像数据和图像信息</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetImageBuffer(uint timeoutInMS, out IFrameOut frameOut);

    /// <summary>
    /// 释放图像缓存（此接口用于释放不再使用的图像缓存，与 IStreamGrabber.FreeImageBuffer() 配套使用）
    /// </summary>
    /// <param name="frame">图像数据和图像数据</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int FreeImageBuffer(IFrameOut frame);

    /// <summary>清除取流数据缓存</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>
    /// 该接口允许用户在不停止取流的时候，就能清除缓存中不需要的图像。
    /// 该接口在连续模式切触发模式后，可以清除历史数据。
    /// </remarks>
    int ClearImageBuffer();
  }
}
