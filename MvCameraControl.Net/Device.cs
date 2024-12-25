// Decompiled with JetBrains decompiler
// Type: MvCameraControl.Device
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;

#nullable disable
namespace MvCameraControl
{
  internal class Device : IDevice, IDisposable
  {
    private IntPtr _devHandle = IntPtr.Zero;
    private IDeviceInfo _deviceInfo;
    private IStreamGrabber _streamGrabber;
    private IEventGrabber _eventGrabber;
    private IParameters _parameters;
    private IImageSaver _imageSaver;
    private IImageDecoder _imageDecoder;
    private IVideoRecorder _videoRecorder;
    private IImageProcess _imageProcess;
    private IPixelTypeConverter _pixelTypeConverter;
    private IImageRender _imageRender;
    private ByteBlockPool _byteBlockPool;
    private bool _isDisposed;
    private MvCCDll.cbExceptiondelegate _exceptionDelegate;

    private event EventHandler<DeviceExceptionArgs> _deviceExceptionEvent;

    public event EventHandler<DeviceExceptionArgs> DeviceExceptionEvent
    {
      add
      {
        if (this._deviceExceptionEvent == null)
          MvCCDll.MV_CC_RegisterExceptionCallBack(this._devHandle, this._exceptionDelegate, IntPtr.Zero);
        this._deviceExceptionEvent += value;
      }
      remove
      {
        this._deviceExceptionEvent -= value;
        if (this._deviceExceptionEvent != null)
          return;
        MvCCDll.MV_CC_RegisterExceptionCallBack(this._devHandle, (MvCCDll.cbExceptiondelegate) null, IntPtr.Zero);
      }
    }

    protected IntPtr DevHandle => this._devHandle;

    /// <summary>判断设备是否处于连接状态</summary>
    public bool IsConnected => MvCCDll.MV_CC_IsDeviceConnected(this._devHandle) != (byte) 0;

    /// <summary>获取设备对应的图像采集对象</summary>
    public IStreamGrabber StreamGrabber => this._streamGrabber;

    public IEventGrabber EventGrabber => this._eventGrabber;

    /// <summary>获取设备信息</summary>
    public IDeviceInfo DeviceInfo
    {
      get
      {
        if (this is IGigEDevice)
        {
          MvCCDll.MV_CC_DEVICE_INFO pstDevInfo = new MvCCDll.MV_CC_DEVICE_INFO();
          if (MvCCDll.MV_CC_GetDeviceInfo(this._devHandle, ref pstDevInfo) == 0)
          {
            GigEDeviceInfo deviceInfo = this._deviceInfo as GigEDeviceInfo;
            deviceInfo.MajorVer = pstDevInfo.nMajorVer;
            deviceInfo.MinorVer = pstDevInfo.nMinorVer;
            deviceInfo.MacAddrHigh = pstDevInfo.nMacAddrHigh;
            deviceInfo.MacAddrLow = pstDevInfo.nMacAddrLow;
            deviceInfo.TLayerType = (DeviceTLayerType) pstDevInfo.nTLayerType;
            deviceInfo.DevTypeInfo = pstDevInfo.nDevTypeInfo;
            MvCCDll.MV_GIGE_DEVICE_INFO_EX gigeDeviceInfoEx = (MvCCDll.MV_GIGE_DEVICE_INFO_EX) MvCCDll.ByteToStruct(pstDevInfo.SpecialInfo.stGigEInfo, typeof (MvCCDll.MV_GIGE_DEVICE_INFO_EX));
            deviceInfo.ManufacturerName = gigeDeviceInfoEx.chManufacturerName;
            deviceInfo.ModelName = gigeDeviceInfoEx.chModelName;
            deviceInfo.DeviceVersion = gigeDeviceInfoEx.chDeviceVersion;
            deviceInfo.SerialNumber = gigeDeviceInfoEx.chSerialNumber;
            deviceInfo.UserDefinedName = InnerTools.ByteArrayToString(gigeDeviceInfoEx.chUserDefinedName);
            deviceInfo.IpCfgOption = gigeDeviceInfoEx.nIpCfgOption;
            deviceInfo.IpCfgCurrent = gigeDeviceInfoEx.nIpCfgCurrent;
            deviceInfo.CurrentIp = gigeDeviceInfoEx.nCurrentIp;
            deviceInfo.CurrentSubNetMask = gigeDeviceInfoEx.nCurrentSubNetMask;
            deviceInfo.DefultGateWay = gigeDeviceInfoEx.nDefultGateWay;
            deviceInfo.NetExport = gigeDeviceInfoEx.nNetExport;
            deviceInfo.VirtualDevice = false;
            deviceInfo.GenTLDevice = false;
            deviceInfo.HostIp = gigeDeviceInfoEx.nReserved[0];
            deviceInfo.nMulticastIp = gigeDeviceInfoEx.nReserved[2];
            deviceInfo.nMulticastPort = gigeDeviceInfoEx.nReserved[3];
            if (1U == gigeDeviceInfoEx.nReserved[1] || 16U == pstDevInfo.nTLayerType)
              deviceInfo.VirtualDevice = true;
            else if (2U == gigeDeviceInfoEx.nReserved[1] || 64U == pstDevInfo.nTLayerType)
              deviceInfo.GenTLDevice = true;
          }
        }
        return this._deviceInfo;
      }
    }

    /// <summary>获取设备对应的参数配置对象</summary>
    public IParameters Parameters => this._parameters;

    public IPixelTypeConverter PixelTypeConverter => this._pixelTypeConverter;

    public IImageRender ImageRender => this._imageRender;

    public IImageSaver ImageSaver => this._imageSaver;

    public IImageDecoder ImageDecoder => this._imageDecoder;

    public IVideoRecorder VideoRecorder => this._videoRecorder;

    public IImageProcess ImageProcess => this._imageProcess;

    public Device(IDeviceInfo deviceInfo)
    {
      this._deviceInfo = deviceInfo;
      int handle = this.CreateHandle(deviceInfo);
      if (handle != 0)
        throw new MvException(handle, string.Format("CreateHandle failed! ErrorCode:{0:x}", (object) handle));
      this.Init();
    }

    public Device(IGenTLDevInfo gentlDevInfo)
    {
      int errorCode = gentlDevInfo != null ? this.CreateHandleByGenTL(gentlDevInfo) : throw new MvException(-2147483644, string.Format("CreateDevice failed! ErrorCode:{0:x}", (object) -2147483644));
      if (errorCode != 0)
        throw new MvException(errorCode, string.Format("CreateHandle failed! ErrorCode:{0:x}", (object) errorCode));
      this.Init();
    }

    ~Device() => this.Dispose(false);

    protected virtual void Dispose(bool disposing)
    {
      if (this._isDisposed)
        return;
      if (disposing)
        this._byteBlockPool.ClosePool();
      if (this._devHandle != IntPtr.Zero)
      {
        this.Close();
        MvCCDll.MV_CC_DestroyHandle(this._devHandle);
        this._devHandle = IntPtr.Zero;
      }
      this._isDisposed = true;
    }

    public int Open() => MvCCDll.MV_CC_OpenDevice(this._devHandle, 1U, (ushort) 0);

    public int Open(DeviceAccessMode AccessMode, uint switchoverKey)
    {
      return MvCCDll.MV_CC_OpenDevice(this._devHandle, (uint) AccessMode, (ushort) switchoverKey);
    }

    public int Close() => MvCCDll.MV_CC_CloseDevice(this._devHandle);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    public int LocalUpgrade(string filePath)
    {
      return MvCCDll.MV_CC_LocalUpgrade(this._devHandle, filePath);
    }

    public int GetUpgradeProcess(out uint process)
    {
      process = 0U;
      return MvCCDll.MV_CC_GetUpgradeProcess(this._devHandle, ref process);
    }

    public int EventNotificationOn(string eventName)
    {
      return MvCCDll.MV_CC_EventNotificationOn(this._devHandle, eventName);
    }

    public int EventNotificationOff(string eventName)
    {
      return MvCCDll.MV_CC_EventNotificationOff(this._devHandle, eventName);
    }

    /// <summary>初始化属性值，在构造函数中使用</summary>
    private void Init()
    {
      this._exceptionDelegate = new MvCCDll.cbExceptiondelegate(this.ExceptionCallback);
      this._streamGrabber = (IStreamGrabber) new MvCameraControl.StreamGrabber(this._devHandle);
      this._eventGrabber = (IEventGrabber) new MvCameraControl.EventGrabber(this._devHandle);
      this._parameters = (IParameters) new MvCameraControl.Parameters(this._devHandle);
      this._byteBlockPool = new ByteBlockPool();
      this._pixelTypeConverter = (IPixelTypeConverter) new MvCameraControl.PixelTypeConverter(this._devHandle, this._byteBlockPool);
      this._imageSaver = (IImageSaver) new MvCameraControl.ImageSaver(this._devHandle);
      this._imageDecoder = (IImageDecoder) new MvCameraControl.ImageDecoder(this._devHandle, this._byteBlockPool);
      this._videoRecorder = (IVideoRecorder) new MvCameraControl.VideoRecorder(this._devHandle);
      this._imageProcess = (IImageProcess) new MvCameraControl.ImageProcess(this._devHandle, this._byteBlockPool);
      this._imageRender = (IImageRender) new MvCameraControl.ImageRender(this._devHandle);
    }

    /// <summary>创建相机句柄</summary>
    /// <param name="deviceInfo"></param>
    /// <returns>错误码</returns>
    private int CreateHandle(IDeviceInfo deviceInfo)
    {
      MvCCDll.MV_CC_DEVICE_INFO stDevInfo = new MvCCDll.MV_CC_DEVICE_INFO(0U);
      if (DeviceTLayerType.MvGigEDevice == deviceInfo.TLayerType || DeviceTLayerType.MvGenTLGigEDevice == deviceInfo.TLayerType || DeviceTLayerType.MvVirGigEDevice == deviceInfo.TLayerType)
      {
        GigEDeviceInfo gigEdeviceInfo = deviceInfo as GigEDeviceInfo;
        stDevInfo.nMajorVer = gigEdeviceInfo.MajorVer;
        stDevInfo.nMinorVer = gigEdeviceInfo.MinorVer;
        stDevInfo.nMacAddrHigh = gigEdeviceInfo.MacAddrHigh;
        stDevInfo.nMacAddrLow = gigEdeviceInfo.MacAddrLow;
        stDevInfo.nTLayerType = (uint) gigEdeviceInfo.TLayerType;
        stDevInfo.nDevTypeInfo = gigEdeviceInfo.DevTypeInfo;
        MvCCDll.MV_GIGE_DEVICE_INFO mvGigeDeviceInfo = new MvCCDll.MV_GIGE_DEVICE_INFO();
        mvGigeDeviceInfo.chDeviceVersion = gigEdeviceInfo.DeviceVersion;
        mvGigeDeviceInfo.chManufacturerName = gigEdeviceInfo.ManufacturerName;
        mvGigeDeviceInfo.chManufacturerSpecificInfo = gigEdeviceInfo.ManufacturerSpecificInfo;
        mvGigeDeviceInfo.chModelName = gigEdeviceInfo.ModelName;
        mvGigeDeviceInfo.chSerialNumber = gigEdeviceInfo.SerialNumber;
        mvGigeDeviceInfo.chUserDefinedName = gigEdeviceInfo.UserDefinedName;
        mvGigeDeviceInfo.nCurrentIp = gigEdeviceInfo.CurrentIp;
        mvGigeDeviceInfo.nCurrentSubNetMask = gigEdeviceInfo.CurrentSubNetMask;
        mvGigeDeviceInfo.nDefultGateWay = gigEdeviceInfo.DefultGateWay;
        mvGigeDeviceInfo.nIpCfgCurrent = gigEdeviceInfo.IpCfgCurrent;
        mvGigeDeviceInfo.nIpCfgOption = gigEdeviceInfo.IpCfgOption;
        mvGigeDeviceInfo.nNetExport = gigEdeviceInfo.NetExport;
        if (mvGigeDeviceInfo.nReserved == null)
          mvGigeDeviceInfo.nReserved = new uint[4];
        mvGigeDeviceInfo.nReserved[0] = gigEdeviceInfo.HostIp;
        mvGigeDeviceInfo.nReserved[1] = 0U;
        mvGigeDeviceInfo.nReserved[2] = gigEdeviceInfo.nMulticastIp;
        mvGigeDeviceInfo.nReserved[3] = gigEdeviceInfo.nMulticastPort;
        if (gigEdeviceInfo.VirtualDevice)
          mvGigeDeviceInfo.nReserved[1] = 1U;
        else if (gigEdeviceInfo.GenTLDevice)
          mvGigeDeviceInfo.nReserved[1] = 2U;
        MvCCDll.StructToBytes<MvCCDll.MV_GIGE_DEVICE_INFO>(mvGigeDeviceInfo, stDevInfo.SpecialInfo.stGigEInfo);
      }
      else if (DeviceTLayerType.MvUsbDevice == deviceInfo.TLayerType || DeviceTLayerType.MvVirUsbDevice == deviceInfo.TLayerType)
      {
        USBDeviceInfo usbDeviceInfo = deviceInfo as USBDeviceInfo;
        stDevInfo.nMajorVer = (ushort) 0;
        stDevInfo.nMinorVer = (ushort) 0;
        stDevInfo.nMacAddrHigh = 0U;
        stDevInfo.nMacAddrLow = 0U;
        stDevInfo.nTLayerType = (uint) deviceInfo.TLayerType;
        stDevInfo.nDevTypeInfo = deviceInfo.DevTypeInfo;
        MvCCDll.MV_USB3_DEVICE_INFO mvUsB3DeviceInfo = new MvCCDll.MV_USB3_DEVICE_INFO();
        mvUsB3DeviceInfo.chDeviceGUID = usbDeviceInfo.DeviceGUID;
        mvUsB3DeviceInfo.chDeviceVersion = usbDeviceInfo.DeviceVersion;
        mvUsB3DeviceInfo.chFamilyName = usbDeviceInfo.FamilyName;
        mvUsB3DeviceInfo.chManufacturerName = usbDeviceInfo.ManufacturerName;
        mvUsB3DeviceInfo.chModelName = usbDeviceInfo.ModelName;
        mvUsB3DeviceInfo.chSerialNumber = usbDeviceInfo.SerialNumber;
        mvUsB3DeviceInfo.chUserDefinedName = usbDeviceInfo.UserDefinedName;
        mvUsB3DeviceInfo.chVendorName = usbDeviceInfo.VendorName;
        mvUsB3DeviceInfo.CrtlInEndPoint = usbDeviceInfo.CrtlInEndPoint;
        mvUsB3DeviceInfo.CrtlOutEndPoint = usbDeviceInfo.CrtlOutEndPoint;
        mvUsB3DeviceInfo.EventEndPoint = usbDeviceInfo.EventEndPoint;
        mvUsB3DeviceInfo.idProduct = usbDeviceInfo.ProductID;
        mvUsB3DeviceInfo.idVendor = usbDeviceInfo.VendorID;
        mvUsB3DeviceInfo.nbcdUSB = usbDeviceInfo.nbcdUSB;
        mvUsB3DeviceInfo.nDeviceNumber = usbDeviceInfo.DeviceNumber;
        mvUsB3DeviceInfo.StreamEndPoint = usbDeviceInfo.StreamEndPoint;
        mvUsB3DeviceInfo.nDeviceAddress = usbDeviceInfo.DeviceAddress;
        if (mvUsB3DeviceInfo.nReserved == null)
          mvUsB3DeviceInfo.nReserved = new uint[2];
        mvUsB3DeviceInfo.nReserved[1] = 0U;
        mvUsB3DeviceInfo.nReserved[1] = usbDeviceInfo.VirtualDevice ? 1U : 0U;
        MvCCDll.StructToBytes<MvCCDll.MV_USB3_DEVICE_INFO>(mvUsB3DeviceInfo, stDevInfo.SpecialInfo.stUsb3VInfo);
      }
      else if (DeviceTLayerType.MvCameraLinkDevice == deviceInfo.TLayerType)
      {
        CamlDeviceInfo camlDeviceInfo = (CamlDeviceInfo) deviceInfo;
        stDevInfo.nMajorVer = (ushort) 0;
        stDevInfo.nMinorVer = (ushort) 0;
        stDevInfo.nMacAddrHigh = 0U;
        stDevInfo.nMacAddrLow = 0U;
        stDevInfo.nTLayerType = (uint) camlDeviceInfo.TLayerType;
        MvCCDll.StructToBytes<MvCCDll.MV_CamL_DEV_INFO>(new MvCCDll.MV_CamL_DEV_INFO()
        {
          chDeviceVersion = camlDeviceInfo.DeviceVersion,
          chFamilyName = camlDeviceInfo.FamilyName,
          chManufacturerName = camlDeviceInfo.ManufacturerName,
          chModelName = camlDeviceInfo.ModelName,
          chPortID = camlDeviceInfo.PortID,
          chSerialNumber = camlDeviceInfo.SerialNumber
        }, stDevInfo.SpecialInfo.stCamLInfo);
      }
      else if (DeviceTLayerType.MvGenTLCameraLinkDevice == deviceInfo.TLayerType)
      {
        CameraLinkDeviceInfo cameraLinkDeviceInfo = (CameraLinkDeviceInfo) deviceInfo;
        stDevInfo.nTLayerType = (uint) cameraLinkDeviceInfo.TLayerType;
        stDevInfo.nDevTypeInfo = cameraLinkDeviceInfo.DevTypeInfo;
        MvCCDll.MV_CML_DEVICE_INFO mvCmlDeviceInfo = new MvCCDll.MV_CML_DEVICE_INFO();
        mvCmlDeviceInfo.chManufacturerInfo = cameraLinkDeviceInfo.ManufacturerName;
        mvCmlDeviceInfo.chModelName = cameraLinkDeviceInfo.ModelName;
        mvCmlDeviceInfo.chDeviceVersion = cameraLinkDeviceInfo.DeviceVersion;
        mvCmlDeviceInfo.chSerialNumber = cameraLinkDeviceInfo.SerialNumber;
        mvCmlDeviceInfo.chUserDefinedName = new byte[64];
        InnerTools.StringToByteArray(cameraLinkDeviceInfo.UserDefinedName, mvCmlDeviceInfo.chUserDefinedName);
        mvCmlDeviceInfo.chDeviceID = cameraLinkDeviceInfo.DeviceID;
        mvCmlDeviceInfo.chInterfaceID = cameraLinkDeviceInfo.InterfaceID;
        MvCCDll.StructToBytes<MvCCDll.MV_CML_DEVICE_INFO>(mvCmlDeviceInfo, stDevInfo.SpecialInfo.stCMLInfo);
      }
      else if (DeviceTLayerType.MvGenTLCXPDevice == deviceInfo.TLayerType)
      {
        CXPDeviceInfo cxpDeviceInfo = (CXPDeviceInfo) deviceInfo;
        stDevInfo.nTLayerType = (uint) cxpDeviceInfo.TLayerType;
        stDevInfo.nDevTypeInfo = cxpDeviceInfo.DevTypeInfo;
        MvCCDll.MV_CXP_DEVICE_INFO mvCxpDeviceInfo = new MvCCDll.MV_CXP_DEVICE_INFO();
        mvCxpDeviceInfo.chManufacturerInfo = cxpDeviceInfo.ManufacturerName;
        mvCxpDeviceInfo.chModelName = cxpDeviceInfo.ModelName;
        mvCxpDeviceInfo.chDeviceVersion = cxpDeviceInfo.DeviceVersion;
        mvCxpDeviceInfo.chSerialNumber = cxpDeviceInfo.SerialNumber;
        mvCxpDeviceInfo.chUserDefinedName = new byte[64];
        InnerTools.StringToByteArray(cxpDeviceInfo.UserDefinedName, mvCxpDeviceInfo.chUserDefinedName);
        mvCxpDeviceInfo.chDeviceID = cxpDeviceInfo.DeviceID;
        mvCxpDeviceInfo.chInterfaceID = cxpDeviceInfo.InterfaceID;
        MvCCDll.StructToBytes<MvCCDll.MV_CXP_DEVICE_INFO>(mvCxpDeviceInfo, stDevInfo.SpecialInfo.stCXPInfo);
      }
      else
      {
        if (DeviceTLayerType.MvGenTLXoFDevice != deviceInfo.TLayerType)
          return -2147483644;
        XoFDeviceInfo xoFdeviceInfo = (XoFDeviceInfo) deviceInfo;
        stDevInfo.nTLayerType = (uint) xoFdeviceInfo.TLayerType;
        stDevInfo.nDevTypeInfo = xoFdeviceInfo.DevTypeInfo;
        MvCCDll.MV_XOF_DEVICE_INFO mvXofDeviceInfo = new MvCCDll.MV_XOF_DEVICE_INFO();
        mvXofDeviceInfo.chManufacturerInfo = xoFdeviceInfo.ManufacturerName;
        mvXofDeviceInfo.chModelName = xoFdeviceInfo.ModelName;
        mvXofDeviceInfo.chDeviceVersion = xoFdeviceInfo.DeviceVersion;
        mvXofDeviceInfo.chSerialNumber = xoFdeviceInfo.SerialNumber;
        mvXofDeviceInfo.chUserDefinedName = new byte[64];
        InnerTools.StringToByteArray(xoFdeviceInfo.UserDefinedName, mvXofDeviceInfo.chUserDefinedName);
        mvXofDeviceInfo.chDeviceID = xoFdeviceInfo.DeviceID;
        mvXofDeviceInfo.chInterfaceID = xoFdeviceInfo.InterfaceID;
        MvCCDll.StructToBytes<MvCCDll.MV_XOF_DEVICE_INFO>(mvXofDeviceInfo, stDevInfo.SpecialInfo.stXoFInfo);
      }
      IntPtr zero = IntPtr.Zero;
      int handle = MvCCDll.MV_CC_CreateHandle(ref zero, ref stDevInfo);
      if (handle == 0)
        this._devHandle = zero;
      return handle;
    }

    private int CreateHandleByGenTL(IGenTLDevInfo gentlDevInfo)
    {
      MvCCDll.MV_GENTL_DEV_INFO stDevInfo = new MvCCDll.MV_GENTL_DEV_INFO();
      stDevInfo.chInterfaceID = gentlDevInfo.InterfaceID;
      stDevInfo.chDeviceID = gentlDevInfo.DeviceID;
      stDevInfo.chVendorName = gentlDevInfo.VendorName;
      stDevInfo.chModelName = gentlDevInfo.ModelName;
      stDevInfo.chTLType = gentlDevInfo.TLType;
      stDevInfo.chDisplayName = gentlDevInfo.DisplayName;
      stDevInfo.chUserDefinedName = gentlDevInfo.UserDefinedName;
      stDevInfo.chSerialNumber = gentlDevInfo.SerialNumber;
      stDevInfo.chDeviceVersion = gentlDevInfo.DeviceVersion;
      stDevInfo.nCtiIndex = gentlDevInfo.CtiIndex;
      IntPtr zero = IntPtr.Zero;
      int handleByGenTl = MvCCDll.MV_CC_CreateHandleByGenTL(ref zero, ref stDevInfo);
      if (handleByGenTl == 0)
        this._devHandle = zero;
      return handleByGenTl;
    }

    private void ExceptionCallback(uint nMsgType, IntPtr pUser)
    {
      if (this._deviceExceptionEvent == null)
        return;
      this._deviceExceptionEvent((object) this, new DeviceExceptionArgs((DeviceExceptionType) nMsgType));
    }
  }
}
