// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ImageRender
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  internal class ImageRender : IImageRender
  {
    private IntPtr _devHandle = IntPtr.Zero;

    public ImageRender(IntPtr devHandle) => this._devHandle = devHandle;

    public int DisplayOneFrame(IntPtr hWnd, IImage image, RenderMode mode = RenderMode.Default)
    {
        var v = new MvCCDll.MV_CC_IMAGE()
        {
            nWidth = image.Width,
            nHeight = image.Height,
            enPixelType = (MvCCDll.MvGvspPixelType)image.PixelType,
            pImageBuf = image.PixelDataPtr,
            nImageBufLen = image.ImageSize
        };
      return MvCCDll.MV_CC_DisplayOneFrameEx2(this._devHandle, hWnd, ref v, (uint) mode);
    }

    public int DisplayOneFrame(
      IntPtr hWnd,
      IntPtr imageDataPtr,
      uint imageLen,
      uint width,
      uint height,
      MvGvspPixelType PixelType,
      RenderMode mode = RenderMode.Default)
    {
        var v = new MvCCDll.MV_DISPLAY_FRAME_INFO_EX()
        {
            nWidth = width,
            nHeight = height,
            enPixelType = (MvCCDll.MvGvspPixelType)PixelType,
            pData = imageDataPtr,
            nDataLen = imageLen,
            enRenderMode = (uint)mode
        };
      return MvCCDll.MV_CC_DisplayOneFrameEx(this._devHandle, hWnd, ref v);
    }

    public int DrawCircle(MvCircle circle, MvColor color, uint lineWidth)
    {
      MvCCDll.MVCC_CIRCLE_INFO pCircleInfo = new MvCCDll.MVCC_CIRCLE_INFO()
      {
        stCenterPoint = new MvCCDll.MVCC_POINTF()
      };
      pCircleInfo.stCenterPoint.fX = circle.CenterPoint.X;
      pCircleInfo.stCenterPoint.fY = circle.CenterPoint.Y;
      pCircleInfo.fR1 = circle.R1;
      pCircleInfo.fR2 = circle.R2;
      pCircleInfo.stColor = new MvCCDll.MVCC_COLORF();
      pCircleInfo.stColor.fR = color.R;
      pCircleInfo.stColor.fG = color.G;
      pCircleInfo.stColor.fB = color.B;
      pCircleInfo.nLineWidth = lineWidth;
      return MvCCDll.MV_CC_DrawCircle(this._devHandle, ref pCircleInfo);
    }

    public int DrawLine(MvLine line, MvColor color, uint lineWidth)
    {
      MvCCDll.MVCC_LINES_INFO pLinesInfo = new MvCCDll.MVCC_LINES_INFO()
      {
        stStartPoint = new MvCCDll.MVCC_POINTF()
      };
      pLinesInfo.stStartPoint.fX = line.StartPoint.X;
      pLinesInfo.stStartPoint.fY = line.StartPoint.Y;
      pLinesInfo.stEndPoint = new MvCCDll.MVCC_POINTF();
      pLinesInfo.stEndPoint.fX = line.EndPoint.X;
      pLinesInfo.stEndPoint.fY = line.EndPoint.Y;
      pLinesInfo.stColor = new MvCCDll.MVCC_COLORF();
      pLinesInfo.stColor.fR = color.R;
      pLinesInfo.stColor.fG = color.G;
      pLinesInfo.stColor.fB = color.B;
      pLinesInfo.nLineWidth = lineWidth;
      return MvCCDll.MV_CC_DrawLines(this._devHandle, ref pLinesInfo);
    }

    public int DrawRect(MvRect rect, MvColor color, uint lineWidth)
    {
      MvCCDll.MVCC_RECT_INFO pRectInfo = new MvCCDll.MVCC_RECT_INFO()
      {
        fTop = rect.Top,
        fBottom = rect.Bottom,
        fLeft = rect.Left,
        fRight = rect.Right,
        stColor = new MvCCDll.MVCC_COLORF()
      };
      pRectInfo.stColor.fR = color.R;
      pRectInfo.stColor.fG = color.G;
      pRectInfo.stColor.fB = color.B;
      pRectInfo.nLineWidth = lineWidth;
      return MvCCDll.MV_CC_DrawRect(this._devHandle, ref pRectInfo);
    }
  }
}
