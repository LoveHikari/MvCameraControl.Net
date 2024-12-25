// Decompiled with JetBrains decompiler
// Type: MvCameraControl.MvCCDll
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Runtime.InteropServices;

#nullable disable
namespace MvCameraControl
{
  /// <summary>MyCamera</summary>
  internal static class MvCCDll
  {
    /// <summary>ch GigE Vision采集卡 |en GigE Vision interface</summary>
    public const int MV_GIGE_INTERFACE = 1;
    /// <summary>ch Camera Link采集卡 |en Camera Link interface</summary>
    public const int MV_CAMERALINK_INTERFACE = 4;
    /// <summary>ch CoaXPress采集卡 |en CoaXPress interface</summary>
    public const int MV_CXP_INTERFACE = 8;
    /// <summary>ch XoFLink采集卡 |en XoFLink interface</summary>
    public const int MV_XOF_INTERFACE = 16;
    /// <summary>Unknown Device Type, Reserved</summary>
    public const int MV_UNKNOW_DEVICE = 0;
    /// <summary>GigE Device</summary>
    public const int MV_GIGE_DEVICE = 1;
    /// <summary>1394-a/b Device</summary>
    public const int MV_1394_DEVICE = 2;
    /// <summary>USB3.0 Device</summary>
    public const int MV_USB_DEVICE = 4;
    /// <summary>CameraLink Device</summary>
    public const int MV_CAMERALINK_DEVICE = 8;
    /// <summary>Virtual GigE Device</summary>
    public const int MV_VIR_GIGE_DEVICE = 16;
    /// <summary>Virtual USB Device</summary>
    public const int MV_VIR_USB_DEVICE = 32;
    /// <summary>GenTL GigE Device</summary>
    public const int MV_GENTL_GIGE_DEVICE = 64;
    /// <summary>GenTL CML Device</summary>
    public const int MV_GENTL_CAMERALINK_DEVICE = 128;
    /// <summary>GenTL CXP Device</summary>
    public const int MV_GENTL_CXP_DEVICE = 256;
    /// <summary>GenTL XOF Device</summary>
    public const int MV_GENTL_XOF_DEVICE = 512;
    /// <summary>
    /// ch:信息结构体的最大缓存 | en: Max buffer size of information structs
    /// </summary>
    public const int INFO_MAX_BUFFER_SIZE = 64;
    /// <summary>最大的相机数量</summary>
    public const int MV_MAX_DEVICE_NUM = 256;
    /// <summary>ch:最大Interface数量 | en:Max num of interfaces</summary>
    public const int MV_MAX_GENTL_IF_NUM = 256;
    /// <summary>ch:最大GenTL设备数量 | en:Max num of GenTL devices</summary>
    public const int MV_MAX_GENTL_DEV_NUM = 256;
    /// <summary>XML节点描述最大长度</summary>
    public const int MV_MAX_XML_DISC_STRLEN_C = 512;
    /// <summary>XML节点最大长度</summary>
    public const int MV_MAX_XML_NODE_STRLEN_C = 64;
    /// <summary>XML节点最大数量</summary>
    public const int MV_MAX_XML_NODE_NUM_C = 128;
    /// <summary>XML节点显示名最大数量</summary>
    public const int MV_MAX_XML_SYMBOLIC_NUM = 64;
    /// <summary>枚举类型最大的EnumEntry个数</summary>
    public const int MV_MAX_ENUM_SYMBOLIC_NUM = 256;
    /// <summary>string类型节点值的最大长度</summary>
    public const int MV_MAX_XML_STRVALUE_STRLEN_C = 64;
    /// <summary>最大父节点数</summary>
    public const int MV_MAX_XML_PARENTS_NUM = 8;
    /// <summary>最大节点描述长度</summary>
    public const int MV_MAX_XML_SYMBOLIC_STRLEN_C = 64;
    /// <summary>参数导出允许配置的最大节点个数</summary>
    public const int MV_MAX_NODE_NUM = 256;
    /// <summary>参数导入时节点导入失败的最大错误个数</summary>
    public const int MV_MAX_NODE_ERROR_NUM = 64;
    /// <summary>设备断开连接</summary>
    public const int MV_EXCEPTION_DEV_DISCONNECT = 32769;
    /// <summary>SDK与驱动版本不匹配</summary>
    public const int MV_EXCEPTION_VERSION_CHECK = 32770;
    /// <summary>相机Event事件名称最大长度</summary>
    public const int MAX_EVENT_NAME_SIZE = 128;
    /// <summary>最大枚举条目对应的符号长度</summary>
    public const int MV_MAX_SYMBOLIC_LEN = 64;
    /// <summary>分时曝光时最多将源图像拆分的个数</summary>
    public const int MV_MAX_SPLIT_NUM = 8;
    /// <summary>最大支持的串口数量</summary>
    public const int MV_MAX_SERIAL_PORT_NUM = 64;
    /// <summary>
    /// ch:最大支持的采集卡数量 | en:The maximum number of Frame Grabber interface supported
    /// </summary>
    public const int MV_MAX_INTERFACE_NUM = 64;
    /// <summary>ch 静态 |en Static</summary>
    public const int MV_IP_CFG_STATIC = 83886080;
    /// <summary>ch DHCP |en DHCP</summary>
    public const int MV_IP_CFG_DHCP = 100663296;
    /// <summary>ch LLA  |en LLA</summary>
    public const int MV_IP_CFG_LLA = 67108864;
    /// <summary>9600</summary>
    public const int MV_CAML_BAUDRATE_9600 = 1;
    /// <summary>19200</summary>
    public const int MV_CAML_BAUDRATE_19200 = 2;
    /// <summary>38400</summary>
    public const int MV_CAML_BAUDRATE_38400 = 4;
    /// <summary>57600</summary>
    public const int MV_CAML_BAUDRATE_57600 = 8;
    /// <summary>115200</summary>
    public const int MV_CAML_BAUDRATE_115200 = 16;
    /// <summary>230400</summary>
    public const int MV_CAML_BAUDRATE_230400 = 32;
    /// <summary>460800</summary>
    public const int MV_CAML_BAUDRATE_460800 = 64;
    /// <summary>921600</summary>
    public const int MV_CAML_BAUDRATE_921600 = 128;
    /// <summary>ch 最大值 |en Auto Max</summary>
    public const int MV_CAML_BAUDRATE_AUTOMAX = 1073741824;
    /// <summary>
    /// ch 网络流量和丢包信息 |en Network traffic and packet loss information
    /// </summary>
    public const int MV_MATCH_TYPE_NET_DETECT = 1;
    /// <summary>
    /// ch host接收到来自U3V设备的字节总数 |en The total number of bytes host received from U3V device
    /// </summary>
    public const int MV_MATCH_TYPE_USB_DETECT = 2;
    /// <summary>
    /// ch独占权限，其他APP只允许读CCP寄存器 |en Exclusive authority, other APP is only allowed to read the CCP register
    /// </summary>
    public const int MV_ACCESS_Exclusive = 1;
    /// <summary>
    /// ch 可以从5模式下抢占权限，然后以独占权限打开 |en You can seize the authority from the 5 mode, and then open with exclusive authority
    /// </summary>
    public const int MV_ACCESS_ExclusiveWithSwitch = 2;
    /// <summary>
    /// ch 控制权限，其他APP允许读所有寄存器 |en Control authority, allows other APP reading all registers
    /// </summary>
    public const int MV_ACCESS_Control = 3;
    /// <summary>
    /// ch 可以从5的模式下抢占权限，然后以控制权限打开 |en You can seize the authority from the 5 mode, and then open with control authority
    /// </summary>
    public const int MV_ACCESS_ControlWithSwitch = 4;
    /// <summary>
    /// ch 以可被抢占的控制权限打开 |en Open with seized control authority
    /// </summary>
    public const int MV_ACCESS_ControlSwitchEnable = 5;
    /// <summary>
    /// ch 可以从5的模式下抢占权限，然后以可被抢占的控制权限打开 |en You can seize the authority from the 5 mode, and then open with seized control authority
    /// </summary>
    public const int MV_ACCESS_ControlSwitchEnableWithKey = 6;
    /// <summary>
    /// ch 读模式打开设备，适用于控制权限下 |en Open with read mode and is available under control authority
    /// </summary>
    public const int MV_ACCESS_Monitor = 7;
    /// <summary>成功，无错误</summary>
    public const int MV_OK = 0;
    /// <summary>错误或无效的句柄</summary>
    public const int MV_E_HANDLE = -2147483648;
    /// <summary>不支持的功能</summary>
    public const int MV_E_SUPPORT = -2147483647;
    /// <summary>缓存已满</summary>
    public const int MV_E_BUFOVER = -2147483646;
    /// <summary>函数调用顺序错误</summary>
    public const int MV_E_CALLORDER = -2147483645;
    /// <summary>错误的参数</summary>
    public const int MV_E_PARAMETER = -2147483644;
    /// <summary>资源申请失败</summary>
    public const int MV_E_RESOURCE = -2147483642;
    /// <summary>无数据</summary>
    public const int MV_E_NODATA = -2147483641;
    /// <summary>前置条件有误，或运行环境已发生变化</summary>
    public const int MV_E_PRECONDITION = -2147483640;
    /// <summary>版本不匹配</summary>
    public const int MV_E_VERSION = -2147483639;
    /// <summary>传入的内存空间不足</summary>
    public const int MV_E_NOENOUGH_BUF = -2147483638;
    /// <summary>异常图像，可能是丢包导致图像不完整</summary>
    public const int MV_E_ABNORMAL_IMAGE = -2147483637;
    /// <summary>动态导入DLL失败</summary>
    public const int MV_E_LOAD_LIBRARY = -2147483636;
    /// <summary>没有可输出的缓存</summary>
    public const int MV_E_NOOUTBUF = -2147483635;
    /// <summary>加密错误</summary>
    public const int MV_E_ENCRYPT = -2147483634;
    /// <summary>打开文件出现错误</summary>
    public const int MV_E_OPENFILE = -2147483633;
    /// <summary>未知的错误</summary>
    public const int MV_E_UNKNOW = -2147483393;
    /// <summary>通用错误</summary>
    public const int MV_E_GC_GENERIC = -2147483392;
    /// <summary>参数非法</summary>
    public const int MV_E_GC_ARGUMENT = -2147483391;
    /// <summary>值超出范围</summary>
    public const int MV_E_GC_RANGE = -2147483390;
    /// <summary>属性</summary>
    public const int MV_E_GC_PROPERTY = -2147483389;
    /// <summary>运行环境有问题</summary>
    public const int MV_E_GC_RUNTIME = -2147483388;
    /// <summary>逻辑错误</summary>
    public const int MV_E_GC_LOGICAL = -2147483387;
    /// <summary>节点访问条件有误</summary>
    public const int MV_E_GC_ACCESS = -2147483386;
    /// <summary>超时</summary>
    public const int MV_E_GC_TIMEOUT = -2147483385;
    /// <summary>转换异常</summary>
    public const int MV_E_GC_DYNAMICCAST = -2147483384;
    /// <summary>GenICam未知错误</summary>
    public const int MV_E_GC_UNKNOW = -2147483137;
    /// <summary>命令不被设备支持</summary>
    public const int MV_E_NOT_IMPLEMENTED = -2147483136;
    /// <summary>访问的目标地址不存在</summary>
    public const int MV_E_INVALID_ADDRESS = -2147483135;
    /// <summary>目标地址不可写</summary>
    public const int MV_E_WRITE_PROTECT = -2147483134;
    /// <summary>设备无访问权限</summary>
    public const int MV_E_ACCESS_DENIED = -2147483133;
    /// <summary>设备忙，或网络断开</summary>
    public const int MV_E_BUSY = -2147483132;
    /// <summary>网络包数据错误</summary>
    public const int MV_E_PACKET = -2147483131;
    /// <summary>网络相关错误</summary>
    public const int MV_E_NETER = -2147483130;
    /// <summary>设备IP冲突</summary>
    public const int MV_E_IP_CONFLICT = -2147483103;
    /// <summary>读usb出错</summary>
    public const int MV_E_USB_READ = -2147482880;
    /// <summary>写usb出错</summary>
    public const int MV_E_USB_WRITE = -2147482879;
    /// <summary>设备异常</summary>
    public const int MV_E_USB_DEVICE = -2147482878;
    /// <summary>GenICam相关错误</summary>
    public const int MV_E_USB_GENICAM = -2147482877;
    /// <summary>带宽不足</summary>
    public const int MV_E_USB_BANDWIDTH = -2147482876;
    /// <summary>驱动不匹配或者未装驱动</summary>
    public const int MV_E_USB_DRIVER = -2147482875;
    /// <summary>USB未知的错误</summary>
    public const int MV_E_USB_UNKNOW = -2147482625;
    /// <summary>升级固件不匹配</summary>
    public const int MV_E_UPG_FILE_MISMATCH = -2147482624;
    /// <summary>升级固件语言不匹配</summary>
    public const int MV_E_UPG_LANGUSGE_MISMATCH = -2147482623;
    /// <summary>升级冲突（设备已经在升级了再次请求升级即返回此错误）</summary>
    public const int MV_E_UPG_CONFLICT = -2147482622;
    /// <summary>升级时设备内部出现错误</summary>
    public const int MV_E_UPG_INNER_ERR = -2147482621;
    /// <summary>升级时未知错误</summary>
    public const int MV_E_UPG_UNKNOW = -2147482369;
    /// <summary>处理正确</summary>
    public const int MV_ALG_OK = 0;
    /// <summary>不确定类型错误</summary>
    public const int MV_ALG_ERR = 268435456;
    /// <summary>能力集中存在无效参数</summary>
    public const int MV_ALG_E_ABILITY_ARG = 268435457;
    /// <summary>内存地址为空</summary>
    public const int MV_ALG_E_MEM_NULL = 268435458;
    /// <summary>内存对齐不满足要求</summary>
    public const int MV_ALG_E_MEM_ALIGN = 268435459;
    /// <summary>内存空间大小不够</summary>
    public const int MV_ALG_E_MEM_LACK = 268435460;
    /// <summary>内存空间大小不满足对齐要求</summary>
    public const int MV_ALG_E_MEM_SIZE_ALIGN = 268435461;
    /// <summary>内存地址不满足对齐要求</summary>
    public const int MV_ALG_E_MEM_ADDR_ALIGN = 268435462;
    /// <summary>图像格式不正确或者不支持</summary>
    public const int MV_ALG_E_IMG_FORMAT = 268435463;
    /// <summary>图像宽高不正确或者超出范围</summary>
    public const int MV_ALG_E_IMG_SIZE = 268435464;
    /// <summary>图像宽高与step参数不匹配</summary>
    public const int MV_ALG_E_IMG_STEP = 268435465;
    /// <summary>图像数据存储地址为空</summary>
    public const int MV_ALG_E_IMG_DATA_NULL = 268435466;
    /// <summary>设置或者获取参数类型不正确</summary>
    public const int MV_ALG_E_CFG_TYPE = 268435467;
    /// <summary>设置或者获取参数的输入、输出结构体大小不正确</summary>
    public const int MV_ALG_E_CFG_SIZE = 268435468;
    /// <summary>处理类型不正确</summary>
    public const int MV_ALG_E_PRC_TYPE = 268435469;
    /// <summary>处理时输入、输出参数大小不正确</summary>
    public const int MV_ALG_E_PRC_SIZE = 268435470;
    /// <summary>子处理类型不正确</summary>
    public const int MV_ALG_E_FUNC_TYPE = 268435471;
    /// <summary>子处理时输入、输出参数大小不正确</summary>
    public const int MV_ALG_E_FUNC_SIZE = 268435472;
    /// <summary>index参数不正确</summary>
    public const int MV_ALG_E_PARAM_INDEX = 268435473;
    /// <summary>value参数不正确或者超出范围</summary>
    public const int MV_ALG_E_PARAM_VALUE = 268435474;
    /// <summary>param_num参数不正确</summary>
    public const int MV_ALG_E_PARAM_NUM = 268435475;
    /// <summary>函数参数指针为空</summary>
    public const int MV_ALG_E_NULL_PTR = 268435476;
    /// <summary>超过限定的最大内存</summary>
    public const int MV_ALG_E_OVER_MAX_MEM = 268435477;
    /// <summary>回调函数出错</summary>
    public const int MV_ALG_E_CALL_BACK = 268435478;
    /// <summary>加密错误</summary>
    public const int MV_ALG_E_ENCRYPT = 268435479;
    /// <summary>算法库使用期限错误</summary>
    public const int MV_ALG_E_EXPIRE = 268435480;
    /// <summary>参数范围不正确</summary>
    public const int MV_ALG_E_BAD_ARG = 268435481;
    /// <summary>数据大小不正确</summary>
    public const int MV_ALG_E_DATA_SIZE = 268435482;
    /// <summary>数据step不正确</summary>
    public const int MV_ALG_E_STEP = 268435483;
    /// <summary>cpu不支持优化代码中的指令集</summary>
    public const int MV_ALG_E_CPUID = 268435484;
    /// <summary>警告</summary>
    public const int MV_ALG_WARNING = 268435485;
    /// <summary>算法库超时</summary>
    public const int MV_ALG_E_TIME_OUT = 268435486;
    /// <summary>算法版本号出错</summary>
    public const int MV_ALG_E_LIB_VERSION = 268435487;
    /// <summary>模型版本号出错</summary>
    public const int MV_ALG_E_MODEL_VERSION = 268435488;
    /// <summary>GPU内存分配错误</summary>
    public const int MV_ALG_E_GPU_MEM_ALLOC = 268435489;
    /// <summary>文件不存在</summary>
    public const int MV_ALG_E_FILE_NON_EXIST = 268435490;
    /// <summary>字符串为空</summary>
    public const int MV_ALG_E_NONE_STRING = 268435491;
    /// <summary>图像解码器错误</summary>
    public const int MV_ALG_E_IMAGE_CODEC = 268435492;
    /// <summary>打开文件错误</summary>
    public const int MV_ALG_E_FILE_OPEN = 268435493;
    /// <summary>文件读取错误</summary>
    public const int MV_ALG_E_FILE_READ = 268435494;
    /// <summary>文件写错误</summary>
    public const int MV_ALG_E_FILE_WRITE = 268435495;
    /// <summary>文件读取大小错误</summary>
    public const int MV_ALG_E_FILE_READ_SIZE = 268435496;
    /// <summary>文件类型错误</summary>
    public const int MV_ALG_E_FILE_TYPE = 268435497;
    /// <summary>模型类型错误</summary>
    public const int MV_ALG_E_MODEL_TYPE = 268435498;
    /// <summary>分配内存错误</summary>
    public const int MV_ALG_E_MALLOC_MEM = 268435499;
    /// <summary>线程绑核失败</summary>
    public const int MV_ALG_E_BIND_CORE_FAILED = 268435500;
    /// <summary>噪声特性图像格式错误</summary>
    public const int MV_ALG_E_DENOISE_NE_IMG_FORMAT = 272637953;
    /// <summary>噪声特性类型错误</summary>
    public const int MV_ALG_E_DENOISE_NE_FEATURE_TYPE = 272637954;
    /// <summary>噪声特性个数错误</summary>
    public const int MV_ALG_E_DENOISE_NE_PROFILE_NUM = 272637955;
    /// <summary>噪声特性增益个数错误</summary>
    public const int MV_ALG_E_DENOISE_NE_GAIN_NUM = 272637956;
    /// <summary>噪声曲线增益值输入错误</summary>
    public const int MV_ALG_E_DENOISE_NE_GAIN_VAL = 272637957;
    /// <summary>噪声曲线柱数错误</summary>
    public const int MV_ALG_E_DENOISE_NE_BIN_NUM = 272637958;
    /// <summary>噪声估计初始化增益设置错误</summary>
    public const int MV_ALG_E_DENOISE_NE_INIT_GAIN = 272637959;
    /// <summary>噪声估计未初始化</summary>
    public const int MV_ALG_E_DENOISE_NE_NOT_INIT = 272637960;
    /// <summary>颜色空间模式错误</summary>
    public const int MV_ALG_E_DENOISE_COLOR_MODE = 272637961;
    /// <summary>图像ROI个数错误</summary>
    public const int MV_ALG_E_DENOISE_ROI_NUM = 272637962;
    /// <summary>图像ROI原点错误</summary>
    public const int MV_ALG_E_DENOISE_ROI_ORI_PT = 272637963;
    /// <summary>图像ROI大小错误</summary>
    public const int MV_ALG_E_DENOISE_ROI_SIZE = 272637964;
    /// <summary>输入的相机增益不存在(增益个数已达上限)</summary>
    public const int MV_ALG_E_DENOISE_GAIN_NOT_EXIST = 272637965;
    /// <summary>输入的相机增益不在范围内</summary>
    public const int MV_ALG_E_DENOISE_GAIN_BEYOND_RANGE = 272637966;
    /// <summary>输入的噪声特性内存大小错误</summary>
    public const int MV_ALG_E_DENOISE_NP_BUF_SIZE = 272637967;

    /// <summary>Byte array to struct</summary>
    /// <param name="bytes">Byte array</param>
    /// <param name="type">Struct type</param>
    /// <returns>Struct object</returns>
    public static object ByteToStruct(byte[] bytes, Type type)
    {
      int num1 = Marshal.SizeOf(type);
      if (num1 > bytes.Length)
        return (object) null;
      IntPtr num2 = Marshal.AllocHGlobal(num1);
      Marshal.Copy(bytes, 0, num2, num1);
      object structure = Marshal.PtrToStructure(num2, type);
      Marshal.FreeHGlobal(num2);
      return structure;
    }

    /// <summary>Struct to Byte array</summary>
    /// <param name="obj">Struct object</param>
    /// <param name="byteArr">Byte</param>
    /// <returns>Bytes </returns>
    public static void StructToBytes<T>(T obj, byte[] byteArr)
    {
      int num1 = Marshal.SizeOf(typeof (T));
      IntPtr num2 = Marshal.AllocHGlobal(num1);
      Marshal.StructureToPtr((object) obj, num2, false);
      Marshal.Copy(num2, byteArr, 0, num1);
      Marshal.FreeHGlobal(num2);
    }

    /// <summary>判断字符数组是否为utf-8</summary>
    /// <param name="inputStream">字符数组</param>
    /// <returns></returns>
    public static bool IsTextUTF8(byte[] inputStream)
    {
      int num1 = 0;
      bool flag = true;
      for (int index = 0; index < inputStream.Length; ++index)
      {
        byte num2 = inputStream[index];
        if (((int) num2 & 128) == 128)
          flag = false;
        if (num1 == 0)
        {
          if (((int) num2 & 128) != 0)
          {
            if (((int) num2 & 192) != 192)
              return false;
            num1 = 1;
            byte num3 = (byte) ((uint) num2 << 2);
            while (((int) num3 & 128) == 128)
            {
              num3 <<= 1;
              ++num1;
            }
          }
        }
        else
        {
          if (((int) num2 & 192) != 128)
            return false;
          --num1;
        }
      }
      return num1 == 0 && !flag;
    }

    /// <summary>Write Error Message</summary>
    /// <param name="csMessage">Message</param>
    /// <param name="nErrorNum">ErrorNum</param>
    public static void WriteErrorMsg(string csMessage, int nErrorNum)
    {
      if (nErrorNum == 0)
        return;
      string str = csMessage + ": Error =" + string.Format("{0:X}", (object) nErrorNum);
    }

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    public static extern void OutputDebugString(string message);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_EnumInterfaces(
      uint nTLayerType,
      ref MvCCDll.MV_INTERFACE_INFO_LIST pInterfaceInfoList);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_CreateInterface(
      ref IntPtr handle,
      ref MvCCDll.MV_INTERFACE_INFO pInterfaceInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_CreateInterfaceByID(ref IntPtr handle, string pInterfaceID);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_OpenInterface(IntPtr handle, string pConfigFile);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_CloseInterface(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_DestroyInterface(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_Initialize();

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_Finalize();

    [DllImport("MvCameraControl.dll")]
    public static extern uint MV_CC_GetSDKVersion();

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_EnumerateTls();

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_EnumDevices(
      uint nTLayerType,
      ref MvCCDll.MV_CC_DEVICE_INFO_LIST stDevList);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_EnumDevicesEx(
      uint nTLayerType,
      ref MvCCDll.MV_CC_DEVICE_INFO_LIST stDevList,
      string pManufacturerName);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_EnumDevicesEx2(
      uint nTLayerType,
      ref MvCCDll.MV_CC_DEVICE_INFO_LIST stDevList,
      string pManufacturerName,
      MvCCDll.MV_SORT_METHOD enSortMethod);

    [DllImport("MvCameraControl.dll")]
    public static extern byte MV_CC_IsDeviceAccessible(
      ref MvCCDll.MV_CC_DEVICE_INFO stDevInfo,
      uint nAccessMode);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetSDKLogPath(string pSDKLogPath);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_CreateHandle(
      ref IntPtr handle,
      ref MvCCDll.MV_CC_DEVICE_INFO stDevInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_CreateHandleWithoutLog(
      ref IntPtr handle,
      ref MvCCDll.MV_CC_DEVICE_INFO stDevInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_DestroyHandle(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_OpenDevice(
      IntPtr handle,
      uint nAccessMode,
      ushort nSwitchoverKey);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_CloseDevice(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern byte MV_CC_IsDeviceConnected(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_RegisterImageCallBackEx(
      IntPtr handle,
      MvCCDll.cbOutputExdelegate cbOutput,
      IntPtr pUser);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_RegisterImageCallBackForRGB(
      IntPtr handle,
      MvCCDll.cbOutputExdelegate cbOutput,
      IntPtr pUser);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_RegisterImageCallBackForBGR(
      IntPtr handle,
      MvCCDll.cbOutputExdelegate cbOutput,
      IntPtr pUser);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_StartGrabbing(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_StopGrabbing(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetImageForRGB(
      IntPtr handle,
      IntPtr pData,
      uint nDataSize,
      ref MvCCDll.MV_FRAME_OUT_INFO_EX pFrameInfo,
      int nMsec);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetImageForBGR(
      IntPtr handle,
      IntPtr pData,
      uint nDataSize,
      ref MvCCDll.MV_FRAME_OUT_INFO_EX pFrameInfo,
      int nMsec);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetImageBuffer(
      IntPtr handle,
      ref MvCCDll.MV_FRAME_OUT pFrame,
      int nMsec);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_FreeImageBuffer(IntPtr handle, ref MvCCDll.MV_FRAME_OUT pFrame);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetOneFrameTimeout(
      IntPtr handle,
      IntPtr pData,
      uint nDataSize,
      ref MvCCDll.MV_FRAME_OUT_INFO_EX pFrameInfo,
      int nMsec);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_ClearImageBuffer(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetValidImageNum(IntPtr handle, ref uint pnValidImageNum);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_DisplayOneFrame(
      IntPtr handle,
      ref MvCCDll.MV_DISPLAY_FRAME_INFO pDisplayInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_DisplayOneFrameEx(
      IntPtr handle,
      IntPtr hWnd,
      ref MvCCDll.MV_DISPLAY_FRAME_INFO_EX pDisplayInfoEx);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_DisplayOneFrameEx2(
      IntPtr handle,
      IntPtr hWnd,
      ref MvCCDll.MV_CC_IMAGE pDisplayInfoEx,
      uint enRenderMode);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetImageNodeNum(IntPtr handle, uint nNum);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetGrabStrategy(
      IntPtr handle,
      MvCCDll.MV_GRAB_STRATEGY enGrabStrategy);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetOutputQueueSize(IntPtr handle, uint nOutputQueueSize);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetDeviceInfo(
      IntPtr handle,
      ref MvCCDll.MV_CC_DEVICE_INFO pstDevInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetAllMatchInfo(
      IntPtr handle,
      ref MvCCDll.MV_ALL_MATCH_INFO pstInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_EnumDevicesByInterface(
      IntPtr handle,
      ref MvCCDll.MV_CC_DEVICE_INFO_LIST pstDevInfoList);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetIntValueEx(
      IntPtr handle,
      string strValue,
      ref MvCCDll.MVCC_INTVALUE_EX pIntValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetIntValueEx(IntPtr handle, string strValue, long nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetEnumValue(
      IntPtr handle,
      string strValue,
      ref MvCCDll.MVCC_ENUMVALUE pEnumValue);

    /// <summary>获取枚举类型节点(支持的枚举个数扩展到256) V4.4.1新增</summary>
    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetEnumValueEx(
      IntPtr handle,
      string strValue,
      ref MvCCDll.MVCC_ENUMVALUE_EX pEnumValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetEnumValue(IntPtr handle, string strValue, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetEnumEntrySymbolic(
      IntPtr handle,
      string strKey,
      ref MvCCDll.MVCC_ENUMENTRY pstEnumEntry);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetEnumValueByString(
      IntPtr handle,
      string strValue,
      string sValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetFloatValue(
      IntPtr handle,
      string strValue,
      ref MvCCDll.MVCC_FLOATVALUE pFloatValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetFloatValue(IntPtr handle, string strValue, float fValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetBoolValue(
      IntPtr handle,
      string strValue,
      ref bool pBoolValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBoolValue(IntPtr handle, string strValue, bool bValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetStringValue(
      IntPtr handle,
      string strKey,
      ref MvCCDll.MVCC_STRINGVALUE pStringValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetStringValue(IntPtr handle, string strKey, string sValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetCommandValue(IntPtr handle, string strValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_InvalidateNodes(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_LocalUpgrade(IntPtr handle, string pFilePathName);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetUpgradeProcess(IntPtr handle, ref uint pnProcess);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_ReadMemory(
      IntPtr handle,
      IntPtr pBuffer,
      long nAddress,
      long nLength);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_WriteMemory(
      IntPtr handle,
      IntPtr pBuffer,
      long nAddress,
      long nLength);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_RegisterExceptionCallBack(
      IntPtr handle,
      MvCCDll.cbExceptiondelegate cbException,
      IntPtr pUser);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_RegisterEventCallBack(
      IntPtr handle,
      MvCCDll.cbEventdelegate cbEvent,
      IntPtr pUser);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_RegisterAllEventCallBack(
      IntPtr handle,
      MvCCDll.cbEventdelegateEx cbEvent,
      IntPtr pUser);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_RegisterEventCallBackEx(
      IntPtr handle,
      string pEventName,
      MvCCDll.cbEventdelegateEx cbEvent,
      IntPtr pUser);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_EventNotificationOn(IntPtr handle, string pEventName);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_EventNotificationOff(IntPtr handle, string pEventName);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetEnumDevTimeout(uint nMilTimeout);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_ForceIpEx(
      IntPtr handle,
      uint nIP,
      uint nSubNetMask,
      uint nDefaultGateWay);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetIpConfig(IntPtr handle, uint nType);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetNetTransMode(IntPtr handle, uint nType);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_GetNetTransInfo(
      IntPtr handle,
      ref MvCCDll.MV_NETTRANS_INFO pstInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetDiscoveryMode(uint nMode);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetGvspTimeout(IntPtr handle, uint nMillisec);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_GetGvspTimeout(IntPtr handle, ref uint pMillisec);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetGvcpTimeout(IntPtr handle, uint nMillisec);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_GetGvcpTimeout(IntPtr handle, ref uint pMillisec);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetRetryGvcpTimes(IntPtr handle, uint nRetryGvcpTimes);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_GetRetryGvcpTimes(IntPtr handle, ref uint pRetryGvcpTimes);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetOptimalPacketSize(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetResend(
      IntPtr handle,
      uint bEnable,
      uint nMaxResendPercent,
      uint nResendTimeout);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetResendMaxRetryTimes(IntPtr handle, uint nRetryTimes);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_GetResendMaxRetryTimes(IntPtr handle, ref uint pnRetryTimes);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetResendTimeInterval(IntPtr handle, uint nMillisec);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_GetResendTimeInterval(IntPtr handle, ref uint pnMillisec);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetTransmissionType(
      IntPtr handle,
      ref MvCCDll.MV_CC_TRANSMISSION_TYPE pstTransmissionType);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_IssueActionCommand(
      ref MvCCDll.MV_ACTION_CMD_INFO pstActionCmdInfo,
      ref MvCCDll.MV_ACTION_CMD_RESULT_LIST pstActionCmdResults);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_GetMulticastStatus(
      ref MvCCDll.MV_CC_DEVICE_INFO pstDevInfo,
      ref bool pStatus);

    [DllImport("MvCameraControl.dll", EntryPoint = "MV_CAML_SetDeviceBauderate")]
    public static extern int MV_CAML_SetDeviceBaudrate(IntPtr handle, uint nBaudrate);

    [DllImport("MvCameraControl.dll", EntryPoint = "MV_CAML_GetDeviceBauderate")]
    public static extern int MV_CAML_GetDeviceBaudrate(IntPtr handle, ref uint pnCurrentBaudrate);

    [DllImport("MvCameraControl.dll", EntryPoint = "MV_CAML_GetSupportBauderates")]
    public static extern int MV_CAML_GetSupportBaudrates(IntPtr handle, ref uint pnBaudrateAblity);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CAML_SetGenCPTimeOut(IntPtr handle, uint nMillisec);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CAML_GetSerialPortList(
      ref MvCCDll.MV_CAML_SERIAL_PORT_LIST pstSerialPortList);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CAML_SetEnumSerialPorts(
      ref MvCCDll.MV_CAML_SERIAL_PORT_LIST pstSerialPortList);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_USB_SetTransferSize(IntPtr handle, uint nTransferSize);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_USB_GetTransferSize(IntPtr handle, ref uint pTransferSize);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_USB_SetTransferWays(IntPtr handle, uint nTransferWays);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_USB_GetTransferWays(IntPtr handle, ref uint pTransferWays);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_USB_RegisterStreamExceptionCallBack(
      IntPtr handle,
      MvCCDll.cbStreamException cbException,
      IntPtr pUser);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_USB_SetEventNodeNum(IntPtr handle, uint nEventNodeNum);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_USB_SetSyncTimeOut(IntPtr handle, uint nMills);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_USB_GetSyncTimeOut(IntPtr handle, ref uint pnMills);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_EnumInterfacesByGenTL(
      ref MvCCDll.MV_GENTL_IF_INFO_LIST pstIFInfoList,
      string sGenTLPath);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_EnumDevicesByGenTL(
      ref MvCCDll.MV_GENTL_IF_INFO stIFInfo,
      ref MvCCDll.MV_GENTL_DEV_INFO_LIST pstDevList);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_UnloadGenTLLibrary(string strGenTLPath);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_CreateHandleByGenTL(
      ref IntPtr handle,
      ref MvCCDll.MV_GENTL_DEV_INFO stDevInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_XML_GetGenICamXML(
      IntPtr handle,
      IntPtr pData,
      uint nDataSize,
      ref uint pnDataLen);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_XML_GetNodeAccessMode(
      IntPtr handle,
      string pstrName,
      ref MvCCDll.MV_XML_AccessMode pAccessMode);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_XML_GetNodeInterfaceType(
      IntPtr handle,
      string pstrName,
      ref MvCCDll.MV_XML_InterfaceType pInterfaceType);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_XML_GetRootNode(
      IntPtr handle,
      ref MvCCDll.MV_XML_NODE_FEATURE pstNode);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_XML_GetChildren(
      IntPtr handle,
      ref MvCCDll.MV_XML_NODE_FEATURE pstNode,
      IntPtr pstNodesList);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_XML_GetChildren(
      IntPtr handle,
      ref MvCCDll.MV_XML_NODE_FEATURE pstNode,
      ref MvCCDll.MV_XML_NODES_LIST pstNodesList);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_XML_GetNodeFeature(
      IntPtr handle,
      ref MvCCDll.MV_XML_NODE_FEATURE pstNode,
      IntPtr pstFeature);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_XML_UpdateNodeFeature(
      IntPtr handle,
      MvCCDll.MV_XML_InterfaceType enType,
      IntPtr pstFeature);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_XML_RegisterUpdateCallBack(
      IntPtr handle,
      MvCCDll.cbXmlUpdatedelegate cbXmlUpdate,
      IntPtr pUser);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SaveImageEx3(
      IntPtr handle,
      ref MvCCDll.MV_SAVE_IMAGE_PARAM_EX3 stSaveParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SaveImageToFileEx(
      IntPtr handle,
      ref MvCCDll.MV_SAVE_IMG_TO_FILE_PARAM_EX pstSaveFileParamEx);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SaveImageToFileEx2(
      IntPtr handle,
      ref MvCCDll.MV_CC_IMAGE pstImage,
      ref MvCCDll.MV_CC_SAVE_IMAGE_PARAM pSaveImageParam,
      string pcImagePath);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SavePointCloudData(
      IntPtr handle,
      ref MvCCDll.MV_SAVE_POINT_CLOUD_PARAM pstPointDataParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_RotateImage(
      IntPtr handle,
      ref MvCCDll.MV_CC_ROTATE_IMAGE_PARAM pstRotateParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_FlipImage(
      IntPtr handle,
      ref MvCCDll.MV_CC_FLIP_IMAGE_PARAM pstFlipParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_ConvertPixelTypeEx(
      IntPtr handle,
      ref MvCCDll.MV_CC_PIXEL_CONVERT_PARAM_EX pstCvtParamEx);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetGammaValue(
      IntPtr handle,
      MvCCDll.MvGvspPixelType enSrcPixelType,
      float fGammaValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBayerCvtQuality(IntPtr handle, uint BayerCvtQuality);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBayerFilterEnable(IntPtr handle, byte bFilterEnable);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBayerGammaParam(
      IntPtr handle,
      ref MvCCDll.MV_CC_GAMMA_PARAM pstGammaParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBayerCCMParam(
      IntPtr handle,
      ref MvCCDll.MV_CC_CCM_PARAM pstCCMParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBayerCCMParamEx(
      IntPtr handle,
      ref MvCCDll.MV_CC_CCM_PARAM_EX pstCCMParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_ImageContrast(
      IntPtr handle,
      ref MvCCDll.MV_CC_CONTRAST_PARAM pstContrastParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_HB_Decode(
      IntPtr handle,
      ref MvCCDll.MV_CC_HB_DECODE_PARAM pstDecodeParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_DrawRect(IntPtr handle, ref MvCCDll.MVCC_RECT_INFO pRectInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_DrawCircle(
      IntPtr handle,
      ref MvCCDll.MVCC_CIRCLE_INFO pCircleInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_DrawLines(IntPtr handle, ref MvCCDll.MVCC_LINES_INFO pLinesInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_FeatureSave(IntPtr handle, string pFileName);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_FeatureSaveEx(
      IntPtr handle,
      string pFileName,
      ref MvCCDll.MVCC_NODE_NAME_LIST pNodeNameList);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_FeatureLoad(IntPtr handle, string pFileName);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_FeatureLoadEx(
      IntPtr handle,
      string pFileName,
      ref MvCCDll.MVCC_NODE_ERROR_LIST pNodeErrorList);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_FileAccessRead(
      IntPtr handle,
      ref MvCCDll.MV_CC_FILE_ACCESS pstFileAccess);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_FileAccessReadEx(
      IntPtr handle,
      ref MvCCDll.MV_CC_FILE_ACCESS_EX pstFileAccessEx);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_FileAccessWrite(
      IntPtr handle,
      ref MvCCDll.MV_CC_FILE_ACCESS pstFileAccess);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_FileAccessWriteEx(
      IntPtr handle,
      ref MvCCDll.MV_CC_FILE_ACCESS_EX pstFileAccessEx);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetFileAccessProgress(
      IntPtr handle,
      ref MvCCDll.MV_CC_FILE_ACCESS_PROGRESS pstFileAccessProgress);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_StartRecord(
      IntPtr handle,
      ref MvCCDll.MV_CC_RECORD_PARAM pstRecordParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_InputOneFrame(
      IntPtr handle,
      ref MvCCDll.MV_CC_INPUT_FRAME_INFO pstInputFrameInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_StopRecord(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_OpenParamsGUI(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_ReconstructImage(
      IntPtr handle,
      ref MvCCDll.MV_RECONSTRUCT_IMAGE_PARAM pstReconstructParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SaveImageEx2(
      IntPtr handle,
      ref MvCCDll.MV_SAVE_IMAGE_PARAM_EX2 stSaveParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SaveImageToFile(
      IntPtr handle,
      ref MvCCDll.MV_SAVE_IMG_TO_FILE_PARAM pstSaveFileParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_ConvertPixelType(
      IntPtr handle,
      ref MvCCDll.MV_PIXEL_CONVERT_PARAM pstCvtParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetOneFrame(
      IntPtr handle,
      IntPtr pData,
      uint nDataSize,
      ref MvCCDll.MV_FRAME_OUT_INFO pFrameInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetOneFrameEx(
      IntPtr handle,
      IntPtr pData,
      uint nDataSize,
      ref MvCCDll.MV_FRAME_OUT_INFO_EX pFrameInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_RegisterImageCallBack(
      IntPtr handle,
      MvCCDll.cbOutputdelegate cbOutput,
      IntPtr pUser);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SaveImage(ref MvCCDll.MV_SAVE_IMAGE_PARAM stSaveParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_ForceIp(IntPtr handle, uint nIP);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_BayerNoiseEstimate(
      IntPtr handle,
      ref MvCCDll.MV_CC_BAYER_NOISE_ESTIMATE_PARAM pstNoiseEstimateParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_BayerSpatialDenoise(
      IntPtr handle,
      ref MvCCDll.MV_CC_BAYER_SPATIAL_DENOISE_PARAM pstSpatialDenoiseParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_Display(IntPtr handle, IntPtr hWnd);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetImageInfo(
      IntPtr handle,
      ref MvCCDll.MV_IMAGE_BASIC_INFO pstInfo);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_GetGevSCPSPacketSize(
      IntPtr handle,
      ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetGevSCPSPacketSize(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_GetGevSCPD(IntPtr handle, ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetGevSCPD(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_GetGevSCDA(IntPtr handle, ref uint pnIP);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetGevSCDA(IntPtr handle, uint nIP);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_GetGevSCSP(IntPtr handle, ref uint pnPort);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_GIGE_SetGevSCSP(IntPtr handle, uint nPort);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBayerCLUTParam(
      IntPtr handle,
      ref MvCCDll.MV_CC_CLUT_PARAM pstCLUTParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_ImageSharpen(
      IntPtr handle,
      ref MvCCDll.MV_CC_SHARPEN_PARAM pstSharpenParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_ColorCorrect(
      IntPtr handle,
      ref MvCCDll.MV_CC_COLOR_CORRECT_PARAM pstColorCorrectParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_NoiseEstimate(
      IntPtr handle,
      ref MvCCDll.MV_CC_NOISE_ESTIMATE_PARAM pstNoiseEstimateParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SpatialDenoise(
      IntPtr handle,
      ref MvCCDll.MV_CC_SPATIAL_DENOISE_PARAM pstSpatialDenoiseParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_LSCCalib(
      IntPtr handle,
      ref MvCCDll.MV_CC_LSC_CALIB_PARAM pstLSCCalibParam);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_LSCCorrect(
      IntPtr handle,
      ref MvCCDll.MV_CC_LSC_CORRECT_PARAM pstLSCCorrectParam);

    [DllImport("MvCameraControl.dll")]
    public static extern IntPtr MV_CC_GetTlProxy(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_WriteLog(string strLog);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetIntValue(
      IntPtr handle,
      string strValue,
      ref MvCCDll.MVCC_INTVALUE pIntValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetIntValue(IntPtr handle, string strValue, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetWidth(IntPtr handle, ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetWidth(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetHeight(IntPtr handle, ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetHeight(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetAOIoffsetX(IntPtr handle, ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetAOIoffsetX(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetAOIoffsetY(IntPtr handle, ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetAOIoffsetY(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetAutoExposureTimeLower(
      IntPtr handle,
      ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetAutoExposureTimeLower(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetAutoExposureTimeUpper(
      IntPtr handle,
      ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetAutoExposureTimeUpper(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetBrightness(IntPtr handle, ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBrightness(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetFrameRate(IntPtr handle, ref MvCCDll.MVCC_FLOATVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetFrameRate(IntPtr handle, float fValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetGain(IntPtr handle, ref MvCCDll.MVCC_FLOATVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetGain(IntPtr handle, float fValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetExposureTime(
      IntPtr handle,
      ref MvCCDll.MVCC_FLOATVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetExposureTime(IntPtr handle, float fValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetPixelFormat(
      IntPtr handle,
      ref MvCCDll.MVCC_ENUMVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetPixelFormat(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetAcquisitionMode(
      IntPtr handle,
      ref MvCCDll.MVCC_ENUMVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetAcquisitionMode(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetGainMode(IntPtr handle, ref MvCCDll.MVCC_ENUMVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetGainMode(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetExposureAutoMode(
      IntPtr handle,
      ref MvCCDll.MVCC_ENUMVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetExposureAutoMode(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetTriggerMode(
      IntPtr handle,
      ref MvCCDll.MVCC_ENUMVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetTriggerMode(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetTriggerDelay(
      IntPtr handle,
      ref MvCCDll.MVCC_FLOATVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetTriggerDelay(IntPtr handle, float fValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetTriggerSource(
      IntPtr handle,
      ref MvCCDll.MVCC_ENUMVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetTriggerSource(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_TriggerSoftwareExecute(IntPtr handle);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetGammaSelector(
      IntPtr handle,
      ref MvCCDll.MVCC_ENUMVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetGammaSelector(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetGamma(IntPtr handle, ref MvCCDll.MVCC_FLOATVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetGamma(IntPtr handle, float fValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetSharpness(IntPtr handle, ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetSharpness(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetHue(IntPtr handle, ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetHue(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetSaturation(IntPtr handle, ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetSaturation(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetBalanceWhiteAuto(
      IntPtr handle,
      ref MvCCDll.MVCC_ENUMVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBalanceWhiteAuto(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetBalanceRatioRed(
      IntPtr handle,
      ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBalanceRatioRed(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetBalanceRatioGreen(
      IntPtr handle,
      ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBalanceRatioGreen(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetBalanceRatioBlue(
      IntPtr handle,
      ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBalanceRatioBlue(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetDeviceUserID(
      IntPtr handle,
      ref MvCCDll.MVCC_STRINGVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetDeviceUserID(IntPtr handle, string chValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetBurstFrameCount(
      IntPtr handle,
      ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBurstFrameCount(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetAcquisitionLineRate(
      IntPtr handle,
      ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetAcquisitionLineRate(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_GetHeartBeatTimeout(
      IntPtr handle,
      ref MvCCDll.MVCC_INTVALUE pstValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetHeartBeatTimeout(IntPtr handle, uint nValue);

    [DllImport("MvCameraControl.dll")]
    public static extern int MV_CC_SetBayerGammaValue(IntPtr handle, float fBayerGammaValue);

    /// <summary>Grab callback</summary>
    /// <param name="pData">Image data</param>
    /// <param name="pFrameInfo">Frame info</param>
    /// <param name="pUser">User defined variable</param>
    public delegate void cbOutputdelegate(
      IntPtr pData,
      ref MvCCDll.MV_FRAME_OUT_INFO pFrameInfo,
      IntPtr pUser);

    /// <summary>Grab callback</summary>
    /// <param name="pData">Image data</param>
    /// <param name="pFrameInfo">Frame info</param>
    /// <param name="pUser">User defined variable</param>
    public delegate void cbOutputExdelegate(
      IntPtr pData,
      ref MvCCDll.MV_FRAME_OUT_INFO_EX pFrameInfo,
      IntPtr pUser);

    /// <summary>Xml Update callback(Interfaces not recommended)</summary>
    /// <param name="enType">Node type</param>
    /// <param name="pstFeature">Current node feature structure</param>
    /// <param name="pstNodesList">Nodes list</param>
    /// <param name="pUser">User defined variable</param>
    public delegate void cbXmlUpdatedelegate(
      MvCCDll.MV_XML_InterfaceType enType,
      IntPtr pstFeature,
      ref MvCCDll.MV_XML_NODES_LIST pstNodesList,
      IntPtr pUser);

    /// <summary>Exception callback</summary>
    /// <param name="nMsgType">Msg type</param>
    /// <param name="pUser">User defined variable</param>
    public delegate void cbExceptiondelegate(uint nMsgType, IntPtr pUser);

    /// <summary>Event callback (Interfaces not recommended)</summary>
    /// <param name="nUserDefinedId">User defined ID</param>
    /// <param name="pUser">User defined variable</param>
    public delegate void cbEventdelegate(uint nUserDefinedId, IntPtr pUser);

    /// <summary>Event callback</summary>
    /// <param name="pEventInfo">Event Info</param>
    /// <param name="pUser">User defined variable</param>
    public delegate void cbEventdelegateEx(ref MvCCDll.MV_EVENT_OUT_INFO pEventInfo, IntPtr pUser);

    /// <summary>Stream Exception callback</summary>
    /// <param name="enExceptionType">Msg type</param>
    /// <param name="pUser">User defined variable</param>
    public delegate void cbStreamException(
      MvCCDll.MV_CC_STREAM_EXCEPTION_TYPE enExceptionType,
      IntPtr pUser);

    /// <summary>ch:采集卡信息列表 | en: Interface Information List</summary>
    public struct MV_INTERFACE_INFO_LIST
    {
      /// <summary>ch:在线设备数量 | en:Online Interface Number</summary>
      public uint nInterfaceNum;
      /// <summary>ch:支持最多64个设备 | en:Support up to 64 Interfaces</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public IntPtr[] pInterfaceInfo;
    }

    /// <summary>ch:采集卡信息 | en: Interface information</summary>
    public struct MV_INTERFACE_INFO
    {
      /// <summary>
      /// ch: 采集卡类型; 低16位有效: bits(0~2)代表功能, bits(3~7)代表相机, bits(8-15)代表总线| en: Interface type
      /// </summary>
      public uint nTLayerType;
      /// <summary>
      /// ch: 采集卡的PCIE插槽信息 | en: PCIe slot information of interface
      /// </summary>
      public uint nPCIEInfo;
      /// <summary>ch: 采集卡ID  | en: Interface ID</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chInterfaceID;
      /// <summary>ch 显示名称 | en: Display name</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDisplayName;
      /// <summary>ch 序列号 |en: Serial number</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chSerialNumber;
      /// <summary>ch 型号 | en: model name</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chModelName;
      /// <summary>ch: 厂商 |en: manufacturer name</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chManufacturer;
      /// <summary>ch: 版本号| en: device version</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceVersion;
      /// <summary>ch: 自定义名称 |en: user defined name</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public byte[] chUserDefinedName;
      /// <summary>ch 保留字段 | en Reserved</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public uint[] nReserved;
    }

    /// <summary>排序方式</summary>
    public enum MV_SORT_METHOD
    {
      /// <summary>按序列号排序</summary>
      SORTMETHOD_SERIALNUMBER,
      /// <summary>按用户自定义名字排序</summary>
      SORTMETHOD_USERID,
      /// <summary>按当前IP地址排序（升序）</summary>
      SORTMETHOD_CURRENTIP_ASC,
      /// <summary>按当前IP地址排序（降序）</summary>
      SORTMETHOD_CURRENTIP_DESC,
    }

    /// <summary>ch: GigE设备信息 | en: GigE device information</summary>
    public struct MV_GIGE_DEVICE_INFO
    {
      /// <summary>IP 配置选项</summary>
      public uint nIpCfgOption;
      /// <summary>IP configuration:bit31-static bit30-dhcp bit29-lla</summary>
      public uint nIpCfgCurrent;
      /// <summary>curtent ip</summary>
      public uint nCurrentIp;
      /// <summary>curtent subnet mask</summary>
      public uint nCurrentSubNetMask;
      /// <summary>current gateway</summary>
      public uint nDefultGateWay;
      /// <summary>制造商名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
      public string chManufacturerName;
      /// <summary>型号名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
      public string chModelName;
      /// <summary>设备版本信息</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
      public string chDeviceVersion;
      /// <summary>制造商特殊信息</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
      public string chManufacturerSpecificInfo;
      /// <summary>序列号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
      public string chSerialNumber;
      /// <summary>用户自定义名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
      public string chUserDefinedName;
      /// <summary>网口IP地址</summary>
      public uint nNetExport;
      /// <summary>预留</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>ch: GigE设备信息 | en: GigE device information</summary>
    public struct MV_GIGE_DEVICE_INFO_EX
    {
      /// <summary>IP 配置选项</summary>
      public uint nIpCfgOption;
      /// <summary>IP configuration:bit31-static bit30-dhcp bit29-lla</summary>
      public uint nIpCfgCurrent;
      /// <summary>curtent ip</summary>
      public uint nCurrentIp;
      /// <summary>curtent subnet mask</summary>
      public uint nCurrentSubNetMask;
      /// <summary>current gateway</summary>
      public uint nDefultGateWay;
      /// <summary>制造商名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
      public string chManufacturerName;
      /// <summary>型号名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
      public string chModelName;
      /// <summary>设备版本信息</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
      public string chDeviceVersion;
      /// <summary>制造商特殊信息</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
      public string chManufacturerSpecificInfo;
      /// <summary>序列号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
      public string chSerialNumber;
      /// <summary>用户自定义名</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public byte[] chUserDefinedName;
      /// <summary>网口IP地址</summary>
      public uint nNetExport;
      /// <summary>预留</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>ch:USB3 设备信息 | en:USB3 device information</summary>
    public struct MV_USB3_DEVICE_INFO
    {
      /// <summary>控制输入端点</summary>
      public byte CrtlInEndPoint;
      /// <summary>控制输出端点</summary>
      public byte CrtlOutEndPoint;
      /// <summary>流端点</summary>
      public byte StreamEndPoint;
      /// <summary>事件端点</summary>
      public byte EventEndPoint;
      /// <summary>供应商ID号</summary>
      public ushort idVendor;
      /// <summary>产品ID号</summary>
      public ushort idProduct;
      /// <summary>设备索引号</summary>
      public uint nDeviceNumber;
      /// <summary>设备GUID号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceGUID;
      /// <summary>供应商名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chVendorName;
      /// <summary>型号名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chModelName;
      /// <summary>家族名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chFamilyName;
      /// <summary>设备版本号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceVersion;
      /// <summary>制造商名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chManufacturerName;
      /// <summary>序列号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chSerialNumber;
      /// <summary>用户自定义名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chUserDefinedName;
      /// <summary>支持的USB协议</summary>
      public uint nbcdUSB;
      /// <summary>设备地址</summary>
      public uint nDeviceAddress;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public uint[] nReserved;
    }

    /// <summary>ch:USB3 设备信息 | en:USB3 device information</summary>
    public struct MV_USB3_DEVICE_INFO_EX
    {
      /// <summary>控制输入端点</summary>
      public byte CrtlInEndPoint;
      /// <summary>控制输出端点</summary>
      public byte CrtlOutEndPoint;
      /// <summary>流端点</summary>
      public byte StreamEndPoint;
      /// <summary>事件端点</summary>
      public byte EventEndPoint;
      /// <summary>供应商ID号</summary>
      public ushort idVendor;
      /// <summary>产品ID号</summary>
      public ushort idProduct;
      /// <summary>设备索引号</summary>
      public uint nDeviceNumber;
      /// <summary>设备GUID号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceGUID;
      /// <summary>供应商名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chVendorName;
      /// <summary>型号名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chModelName;
      /// <summary>家族名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chFamilyName;
      /// <summary>设备版本号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceVersion;
      /// <summary>制造商名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chManufacturerName;
      /// <summary>序列号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chSerialNumber;
      /// <summary>用户自定义名字</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public byte[] chUserDefinedName;
      /// <summary>支持的USB协议</summary>
      public uint nbcdUSB;
      /// <summary>设备地址</summary>
      public uint nDeviceAddress;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public uint[] nReserved;
    }

    /// <summary>ch:CamLink设备信息 | en:CamLink device information</summary>
    public struct MV_CamL_DEV_INFO
    {
      /// <summary>端口号ID</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chPortID;
      /// <summary>模型名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chModelName;
      /// <summary>家族名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chFamilyName;
      /// <summary>设备版本信息</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceVersion;
      /// <summary>制造商名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chManufacturerName;
      /// <summary>序列号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chSerialNumber;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 38)]
      public uint[] nReserved;
    }

    /// <summary>
    /// ch:采集卡Camera Link相机信息 | en:Camera Link device information on frame grabber
    /// </summary>
    public struct MV_CML_DEVICE_INFO
    {
      /// <summary>ch 采集卡ID |en Interface ID of Frame Grabber</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chInterfaceID;
      /// <summary>ch 供应商名字 |en Vendor name</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chVendorName;
      /// <summary>ch 型号名字 |en Model name</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chModelName;
      /// <summary>ch 厂商信息 |en Manufacturer information</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chManufacturerInfo;
      /// <summary>ch 相机版本 |en Device version</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceVersion;
      /// <summary>ch 序列号 |en Serial number</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chSerialNumber;
      /// <summary>ch 用户自定义名字 |en User defined name</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public byte[] chUserDefinedName;
      /// <summary>ch 相机ID |en Device ID</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceID;
      /// <summary>ch 保留字段 |en Reserved</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
      public uint[] nReserved;
    }

    /// <summary>ch:CoaXPress相机信息 | en:CoaXPress device information</summary>
    public struct MV_CXP_DEVICE_INFO
    {
      /// <summary>ch 采集卡ID |en Interface ID of Frame Grabber</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chInterfaceID;
      /// <summary>ch 供应商名字 |en Vendor name</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chVendorName;
      /// <summary>ch 型号名字 |en Model name</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chModelName;
      /// <summary>ch 厂商信息 |en Manufacturer information</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chManufacturerInfo;
      /// <summary>ch 相机版本 |en Device version</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceVersion;
      /// <summary>ch 序列号 |en Serial number</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chSerialNumber;
      /// <summary>ch 用户自定义名字 |en User defined name</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public byte[] chUserDefinedName;
      /// <summary>ch 相机ID |en Device ID</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceID;
      /// <summary>ch 保留字段 |en Reserved</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
      public uint[] nReserved;
    }

    /// <summary>ch:XoFLink相机信息 | en:XoFLink device information</summary>
    public struct MV_XOF_DEVICE_INFO
    {
      /// <summary>ch 采集卡ID |en Interface ID of Frame Grabber</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chInterfaceID;
      /// <summary>ch 供应商名字 |en Vendor name</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chVendorName;
      /// <summary>ch 型号名字 |en Model name</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chModelName;
      /// <summary>ch 厂商信息 |en Manufacturer information</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chManufacturerInfo;
      /// <summary>ch 相机版本 |en Device version</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceVersion;
      /// <summary>ch 序列号 |en Serial number</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chSerialNumber;
      /// <summary>ch 用户自定义名字 |en User defined name</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public byte[] chUserDefinedName;
      /// <summary>ch 相机ID |en Device ID</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceID;
      /// <summary>ch 保留字段 |en Reserved</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
      public uint[] nReserved;
    }

    /// <summary>ch:设备信息 | en:Device information</summary>
    public struct MV_CC_DEVICE_INFO
    {
      /// <summary>主版本号</summary>
      public ushort nMajorVer;
      /// <summary>次版本号</summary>
      public ushort nMinorVer;
      /// <summary>MAC高地址</summary>
      public uint nMacAddrHigh;
      /// <summary>MAC低地址</summary>
      public uint nMacAddrLow;
      /// <summary>设备传输层协议类型，e.g. MV_GIGE_DEVICE</summary>
      public uint nTLayerType;
      /// <summary>ch 设备类型信息 | en Device Type Info</summary>
      public uint nDevTypeInfo;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public uint[] nReserved;
      /// <summary>设备类型</summary>
      public MvCCDll.MV_CC_DEVICE_INFO.SPECIAL_INFO SpecialInfo;

      /// <summary>构造函数</summary>
      /// <param name="nAnyNum">输入任意数，因为不接受无参构造函数</param>
      public MV_CC_DEVICE_INFO(uint nAnyNum)
      {
        this.nMajorVer = (ushort) 0;
        this.nMinorVer = (ushort) 0;
        this.nMacAddrHigh = 0U;
        this.nMacAddrLow = 0U;
        this.nTLayerType = 0U;
        this.nDevTypeInfo = 0U;
        this.nReserved = new uint[3];
        this.SpecialInfo.stGigEInfo = new byte[216];
        this.SpecialInfo.stCamLInfo = new byte[536];
        this.SpecialInfo.stUsb3VInfo = new byte[540];
        this.SpecialInfo.stCMLInfo = new byte[540];
        this.SpecialInfo.stCXPInfo = new byte[540];
        this.SpecialInfo.stXoFInfo = new byte[540];
      }

      /// <summary>ch:特定类型的设备信息 | en:Special devcie information</summary>
      [StructLayout(LayoutKind.Explicit, Size = 540)]
      public struct SPECIAL_INFO
      {
        /// <summary>GigE</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 216)]
        [FieldOffset(0)]
        public byte[] stGigEInfo;
        /// <summary>Camera Link</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 536)]
        [FieldOffset(0)]
        public byte[] stCamLInfo;
        /// <summary>Usb</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 540)]
        [FieldOffset(0)]
        public byte[] stUsb3VInfo;
        /// <summary>CML</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 540)]
        [FieldOffset(0)]
        public byte[] stCMLInfo;
        /// <summary>CXP</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 540)]
        [FieldOffset(0)]
        public byte[] stCXPInfo;
        /// <summary>XOF</summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 540)]
        [FieldOffset(0)]
        public byte[] stXoFInfo;
      }
    }

    /// <summary>相机列表</summary>
    public struct MV_CC_DEVICE_INFO_LIST
    {
      /// <summary>在线设备数量</summary>
      public uint nDeviceNum;
      /// <summary>支持最多256个设备</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
      public IntPtr[] pDeviceInfo;
    }

    /// <summary>
    /// ch:通过GenTL枚举到的Interface信息 | en:Interface Information with GenTL
    /// </summary>
    public struct MV_GENTL_IF_INFO
    {
      /// <summary>GenTL接口ID</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chInterfaceID;
      /// <summary>传输层类型</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chTLType;
      /// <summary>设备显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDisplayName;
      /// <summary>GenTL的cti文件索引</summary>
      public uint nCtiIndex;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nReserved;
    }

    /// <summary>
    /// ch:通过GenTL枚举到的设备信息列表 | en:Interface Information List with GenTL
    /// </summary>
    public struct MV_GENTL_IF_INFO_LIST
    {
      /// <summary>ch:在线设备数量 | en:Online Interface Number</summary>
      public uint nInterfaceNum;
      /// <summary>ch:支持最多256个设备 | en:Support up to 256 Interfaces</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
      public IntPtr[] pIFInfo;
    }

    /// <summary>
    /// ch:通过GenTL枚举到的设备信息 | en:Device Information discovered by with GenTL
    /// </summary>
    public struct MV_GENTL_DEV_INFO
    {
      /// <summary>采集卡ID</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chInterfaceID;
      /// <summary>设备ID</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceID;
      /// <summary>供应商名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chVendorName;
      /// <summary>模型名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chModelName;
      /// <summary>传输类型</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chTLType;
      /// <summary>显示名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDisplayName;
      /// <summary>用户自定义名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chUserDefinedName;
      /// <summary>序列号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chSerialNumber;
      /// <summary>设备版本信息</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceVersion;
      /// <summary>cti文件序号</summary>
      public uint nCtiIndex;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nReserved;
    }

    /// <summary>
    /// ch:通过GenTL枚举到的设备信息 | en:Device Information discovered by with GenTL
    /// </summary>
    public struct MV_GENTL_DEV_INFO_EX
    {
      /// <summary>采集卡ID</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chInterfaceID;
      /// <summary>设备ID</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceID;
      /// <summary>供应商名字</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chVendorName;
      /// <summary>模型名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chModelName;
      /// <summary>传输类型</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chTLType;
      /// <summary>显示名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDisplayName;
      /// <summary>用户自定义名</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public byte[] chUserDefinedName;
      /// <summary>序列号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chSerialNumber;
      /// <summary>设备版本信息</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string chDeviceVersion;
      /// <summary>cti文件序号</summary>
      public uint nCtiIndex;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nReserved;
    }

    /// <summary>ch:GenTL设备列表 | en:GenTL devices list</summary>
    public struct MV_GENTL_DEV_INFO_LIST
    {
      /// <summary>在线设备数量</summary>
      public uint nDeviceNum;
      /// <summary>支持最多256个设备</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
      public IntPtr[] pDeviceInfo;
    }

    /// <summary>Net Trans Info</summary>
    public struct MV_NETTRANS_INFO
    {
      /// <summary>已接收数据大小  [统计StartGrabbing和StopGrabbing之间的数据量]</summary>
      public long nReviceDataSize;
      /// <summary>丢帧数量</summary>
      public int nThrowFrameCount;
      /// <summary>接收帧数</summary>
      public uint nNetRecvFrameCount;
      /// <summary>请求重发包数</summary>
      public long nRequestResendPacketCount;
      /// <summary>重发包数</summary>
      public long nResendPacketCount;
    }

    /// <summary>Frame Out Info</summary>
    public struct MV_FRAME_OUT_INFO
    {
      /// <summary>图像宽</summary>
      public ushort nWidth;
      /// <summary>图像高</summary>
      public ushort nHeight;
      /// <summary>像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>帧号</summary>
      public uint nFrameNum;
      /// <summary>时间戳高32位</summary>
      public uint nDevTimeStampHigh;
      /// <summary>时间戳低32位</summary>
      public uint nDevTimeStampLow;
      /// <summary>保留，8字节对齐</summary>
      public uint nReserved0;
      /// <summary>主机生成的时间戳</summary>
      public long nHostTimeStamp;
      /// <summary>帧数据大小</summary>
      public uint nFrameLen;
      /// <summary>丢包数量</summary>
      public uint nLostPacket;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public uint[] nReserved;
    }

    /// <summary>Chunk数据信息</summary>
    public struct MV_CHUNK_DATA_CONTENT
    {
      /// <summary>Chunk数据</summary>
      public IntPtr pChunkData;
      /// <summary>ChunkID</summary>
      public uint nChunkID;
      /// <summary>Chunk大小</summary>
      public uint nChunkLen;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nReserved;
    }

    /// <summary>Frame Out Info Ex</summary>
    public struct MV_FRAME_OUT_INFO_EX
    {
      /// <summary>图像宽</summary>
      public ushort nWidth;
      /// <summary>图像高</summary>
      public ushort nHeight;
      /// <summary>像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>帧号</summary>
      public uint nFrameNum;
      /// <summary>时间戳高32位</summary>
      public uint nDevTimeStampHigh;
      /// <summary>时间戳低32位</summary>
      public uint nDevTimeStampLow;
      /// <summary>保留，8字节对齐</summary>
      public uint nReserved0;
      /// <summary>主机生成的时间戳</summary>
      public long nHostTimeStamp;
      /// <summary>Frame大小</summary>
      public uint nFrameLen;
      /// <summary>秒数</summary>
      public uint nSecondCount;
      /// <summary>周期数</summary>
      public uint nCycleCount;
      /// <summary>周期偏移量</summary>
      public uint nCycleOffset;
      /// <summary>增益</summary>
      public float fGain;
      /// <summary>曝光时间</summary>
      public float fExposureTime;
      /// <summary>平均亮度</summary>
      public uint nAverageBrightness;
      /// <summary>Red</summary>
      public uint nRed;
      /// <summary>Green</summary>
      public uint nGreen;
      /// <summary>Blue</summary>
      public uint nBlue;
      /// <summary>帧计数器</summary>
      public uint nFrameCounter;
      /// <summary>触发计数</summary>
      public uint nTriggerIndex;
      /// <summary>输入</summary>
      public uint nInput;
      /// <summary>输出</summary>
      public uint nOutput;
      /// <summary>水平偏移量</summary>
      public ushort nOffsetX;
      /// <summary>垂直偏移量</summary>
      public ushort nOffsetY;
      /// <summary>Chunk宽度</summary>
      public ushort nChunkWidth;
      /// <summary>Chunk高度</summary>
      public ushort nChunkHeight;
      /// <summary>丢包数</summary>
      public uint nLostPacket;
      /// <summary>为解析的Chunk数量</summary>
      public uint nUnparsedChunkNum;
      /// <summary>为解析的Chunk列表</summary>
      public MvCCDll.MV_FRAME_OUT_INFO_EX.UNPARSED_CHUNK_LIST UnparsedChunkList;
      /// <summary>图像宽扩展</summary>
      public uint nExtendWidth;
      /// <summary>图像高扩展</summary>
      public uint nExtendHeight;
      /// <summary>帧长度扩展</summary>
      public ulong nFrameLenEx;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
      public uint[] nReserved;

      /// <summary>为解析的Chunk列表</summary>
      [StructLayout(LayoutKind.Explicit)]
      public struct UNPARSED_CHUNK_LIST
      {
        /// <summary>为解析的Chunk内容</summary>
        [FieldOffset(0)]
        public IntPtr pUnparsedChunkContent;
        /// <summary>对齐结构体，无实际用途</summary>
        [FieldOffset(0)]
        public long nAligning;
      }
    }

    /// <summary>输出帧信息</summary>
    public struct MV_FRAME_OUT
    {
      /// <summary>帧数据地址</summary>
      public IntPtr pBufAddr;
      /// <summary>帧信息</summary>
      public MvCCDll.MV_FRAME_OUT_INFO_EX stFrameInfo;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public uint[] nReserved;
    }

    /// <summary>取流策略</summary>
    public enum MV_GRAB_STRATEGY
    {
      /// <summary>从旧到新一帧一帧的获取图像（默认为该策略）</summary>
      MV_GrabStrategy_OneByOne,
      /// <summary>获取列表中最新的一帧图像（同时清除列表中的其余图像）</summary>
      MV_GrabStrategy_LatestImagesOnly,
      /// <summary>
      /// 获取列表中最新的图像，个数由OutputQueueSize决定，范围为1-ImageNodeNum，设置成1等同于LatestImagesOnly，设置成ImageNodeNum等同于OneByOne
      /// </summary>
      MV_GrabStrategy_LatestImages,
      /// <summary>等待下一帧图像</summary>
      MV_GrabStrategy_UpcomingImage,
    }

    /// <summary>显示帧信息</summary>
    public struct MV_DISPLAY_FRAME_INFO
    {
      /// <summary>显示窗口的句柄</summary>
      public IntPtr hWnd;
      /// <summary>显示的帧数据</summary>
      public IntPtr pData;
      /// <summary>显示的帧数据大小</summary>
      public uint nDataLen;
      /// <summary>图像宽</summary>
      public ushort nWidth;
      /// <summary>图像高</summary>
      public ushort nHeight;
      /// <summary>像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>显示帧信息</summary>
    public struct MV_DISPLAY_FRAME_INFO_EX
    {
      /// <summary>图像宽</summary>
      public uint nWidth;
      /// <summary>图像高</summary>
      public uint nHeight;
      /// <summary>像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>显示的帧数据</summary>
      public IntPtr pData;
      /// <summary>显示的帧数据大小</summary>
      public uint nDataLen;
      /// <summary>
      /// 图像渲染方式 0-默认模式(Windows GDI/Linux OPENGL), 1-D3D模式(Windows有效)
      /// </summary>
      public uint enRenderMode;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public uint[] nReserved;
    }

    /// <summary>图像信息</summary>
    public struct MV_CC_IMAGE
    {
      /// <summary>图像宽</summary>
      public uint nWidth;
      /// <summary>图像高</summary>
      public uint nHeight;
      /// <summary>像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>图像缓存</summary>
      public IntPtr pImageBuf;
      /// <summary>图像缓存大小</summary>
      public ulong nImageBufSize;
      /// <summary>图像长度</summary>
      public ulong nImageBufLen;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>ch:保存3D数据格式 | en:Save 3D file</summary>
    public enum MV_SAVE_POINT_CLOUD_FILE_TYPE
    {
      /// <summary>未定义数据格式</summary>
      MV_PointCloudFile_Undefined,
      /// <summary>PLY数据格式</summary>
      MV_PointCloudFile_PLY,
      /// <summary>CSV数据格式</summary>
      MV_PointCloudFile_CSV,
      /// <summary>OBJ数据格式</summary>
      MV_PointCloudFile_OBJ,
    }

    /// <summary>保存的点阵参数</summary>
    public struct MV_SAVE_POINT_CLOUD_PARAM
    {
      /// <summary>[IN]     每一行点的数量</summary>
      public uint nLinePntNum;
      /// <summary>[IN]     行数</summary>
      public uint nLineNum;
      /// <summary>[IN]     输入数据的像素格式</summary>
      public MvCCDll.MvGvspPixelType enSrcPixelType;
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pSrcData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nSrcDataLen;
      /// <summary>[OUT]    输出像素数据缓存</summary>
      public IntPtr pDstBuf;
      /// <summary>
      /// [IN]     提供的输出缓冲区大小(nLinePntNum * nLineNum * (16*3 + 4) + 2048)
      /// </summary>
      public uint nDstBufSize;
      /// <summary>[OUT]    输出像素数据缓存长度</summary>
      public uint nDstBufLen;
      /// <summary>保存的点阵文件类型</summary>
      public MvCCDll.MV_SAVE_POINT_CLOUD_FILE_TYPE enPointCloudFileType;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>保存的图像格式</summary>
    public enum MV_SAVE_IAMGE_TYPE
    {
      /// <summary>未定义类型</summary>
      MV_Image_Undefined,
      /// <summary>Bmp图像格式</summary>
      MV_Image_Bmp,
      /// <summary>Jpeg图像格式</summary>
      MV_Image_Jpeg,
      /// <summary>Png图像格式</summary>
      MV_Image_Png,
      /// <summary>Tif图像格式</summary>
      MV_Image_Tif,
    }

    /// <summary>保存的图像参数</summary>
    public struct MV_SAVE_IMAGE_PARAM
    {
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nDataLen;
      /// <summary>[IN]     输入数据的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     图像宽</summary>
      public ushort nWidth;
      /// <summary>[IN]     图像高</summary>
      public ushort nHeight;
      /// <summary>[OUT]    输出图片缓存</summary>
      public IntPtr pImageBuffer;
      /// <summary>[OUT]    输出图片大小</summary>
      public uint nImageLen;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nBufferSize;
      /// <summary>[IN]     输出图片格式</summary>
      public MvCCDll.MV_SAVE_IAMGE_TYPE enImageType;
    }

    /// <summary>保存的图像参数</summary>
    public struct MV_SAVE_IMAGE_PARAM_EX2
    {
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nDataLen;
      /// <summary>[IN]     输入数据的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     图像宽</summary>
      public ushort nWidth;
      /// <summary>[IN]     图像高</summary>
      public ushort nHeight;
      /// <summary>[OUT]    输出图片缓存</summary>
      public IntPtr pImageBuffer;
      /// <summary>[OUT]    输出图片大小</summary>
      public uint nImageLen;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nBufferSize;
      /// <summary>[IN]     输出图片格式</summary>
      public MvCCDll.MV_SAVE_IAMGE_TYPE enImageType;
      /// <summary>[IN]     编码质量, (50-99]</summary>
      public uint nJpgQuality;
      /// <summary>[IN]     Bayer的插值方法 0-快速 1-均衡 2-最优（如果传入其它值则默认为最优）</summary>
      public uint iMethodValue;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public uint[] nReserved;
    }

    /// <summary>保存的图像信息扩展</summary>
    public struct MV_SAVE_IMAGE_PARAM_EX3
    {
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nDataLen;
      /// <summary>[IN]     输入数据的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     图像宽</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高</summary>
      public uint nHeight;
      /// <summary>[OUT]    输出图片缓存</summary>
      public IntPtr pImageBuffer;
      /// <summary>[OUT]    输出图片大小</summary>
      public uint nImageLen;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nBufferSize;
      /// <summary>[IN]     输出图片格式</summary>
      public MvCCDll.MV_SAVE_IAMGE_TYPE enImageType;
      /// <summary>[IN]     编码质量, (50-99]</summary>
      public uint nJpgQuality;
      /// <summary>[IN]     Bayer的插值方法 0-快速 1-均衡 2-最优（如果传入其它值则默认为最优）</summary>
      public uint iMethodValue;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
      public uint[] nReserved;
    }

    /// <summary>保存图像到文件的参数</summary>
    public struct MV_SAVE_IMG_TO_FILE_PARAM
    {
      /// <summary>[IN]     输入数据的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nDataLen;
      /// <summary>[IN]     图像宽</summary>
      public ushort nWidth;
      /// <summary>[IN]     图像高</summary>
      public ushort nHeight;
      /// <summary>[IN]     输入图片格式</summary>
      public MvCCDll.MV_SAVE_IAMGE_TYPE enImageType;
      /// <summary>[IN]     编码质量, (0-100]</summary>
      public uint nQuality;
      /// <summary>[IN]     输入文件路径</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string pImagePath;
      /// <summary>[IN]     Bayer的插值方法 0-快速 1-均衡 2-最优（如果传入其它值则默认为最优）</summary>
      public uint iMethodValue;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>保存图像到文件信息扩展</summary>
    public struct MV_SAVE_IMG_TO_FILE_PARAM_EX
    {
      /// <summary>[IN]     图像宽</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高</summary>
      public uint nHeight;
      /// <summary>[IN]     输入数据的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nDataLen;
      /// <summary>[IN]     输入图片格式</summary>
      public MvCCDll.MV_SAVE_IAMGE_TYPE enImageType;
      /// <summary>[IN]     输入文件路径</summary>
      public string pImagePath;
      /// <summary>[IN]     编码质量, (0-100]</summary>
      public uint nQuality;
      /// <summary>[IN]     Bayer的插值方法 0-快速 1-均衡 2-最优（如果传入其它值则默认为最优）</summary>
      public uint iMethodValue;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>保存图片所需参数</summary>
    public struct MV_CC_SAVE_IMAGE_PARAM
    {
      /// <summary>[IN]     输入图片格式</summary>
      public MvCCDll.MV_SAVE_IAMGE_TYPE enImageType;
      /// <summary>[IN]     编码质量, (0-100]</summary>
      public uint nQuality;
      /// <summary>[IN]     Bayer的插值方法 0-快速 1-均衡 2-最优（如果传入其它值则默认为最优）</summary>
      public uint iMethodValue;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>旋转角度</summary>
    public enum MV_IMG_ROTATION_ANGLE
    {
      /// <summary>旋转90度</summary>
      MV_IMAGE_ROTATE_90 = 1,
      /// <summary>旋转180度</summary>
      MV_IMAGE_ROTATE_180 = 2,
      /// <summary>旋转270度</summary>
      MV_IMAGE_ROTATE_270 = 3,
    }

    /// <summary>旋转图像参数</summary>
    public struct MV_CC_ROTATE_IMAGE_PARAM
    {
      /// <summary>[IN]     像素格式(仅支持Mono8/RGB24/BGR24)</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN][OUT]     图像宽</summary>
      public uint nWidth;
      /// <summary>[IN][OUT]     图像高</summary>
      public uint nHeight;
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pSrcData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nSrcDataLen;
      /// <summary>[OUT]    输出图片缓存</summary>
      public IntPtr pDstBuf;
      /// <summary>[OUT]    输出图片大小</summary>
      public uint nDstBufLen;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nDstBufSize;
      /// <summary>[IN]     旋转角度</summary>
      public MvCCDll.MV_IMG_ROTATION_ANGLE enRotationAngle;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>图像翻转类型</summary>
    public enum MV_IMG_FLIP_TYPE
    {
      /// <summary>垂直方向翻转</summary>
      MV_FLIP_VERTICAL = 1,
      /// <summary>水平方向翻转</summary>
      MV_FLIP_HORIZONTAL = 2,
    }

    /// <summary>翻转图像参数</summary>
    public struct MV_CC_FLIP_IMAGE_PARAM
    {
      /// <summary>[IN]     像素格式(仅支持Mono8/RGB24/BGR24)</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     图像宽</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高</summary>
      public uint nHeight;
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pSrcData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nSrcDataLen;
      /// <summary>[OUT]    输出图片缓存</summary>
      public IntPtr pDstBuf;
      /// <summary>[OUT]    输出图片大小</summary>
      public uint nDstBufLen;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nDstBufSize;
      /// <summary>[IN]     翻转类型</summary>
      public MvCCDll.MV_IMG_FLIP_TYPE enFlipType;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>像素转换参数</summary>
    public struct MV_PIXEL_CONVERT_PARAM
    {
      /// <summary>[IN]     图像宽</summary>
      public ushort nWidth;
      /// <summary>[IN]     图像高</summary>
      public ushort nHeight;
      /// <summary>[IN]     源像素格式</summary>
      public MvCCDll.MvGvspPixelType enSrcPixelType;
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pSrcData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nSrcDataLen;
      /// <summary>[IN]     目标像素格式</summary>
      public MvCCDll.MvGvspPixelType enDstPixelType;
      /// <summary>[OUT]    输出数据缓存</summary>
      public IntPtr pDstBuffer;
      /// <summary>[OUT]    输出数据大小</summary>
      public uint nDstLen;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nDstBufferSize;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nRes;
    }

    /// <summary>图像像素转换信息扩展</summary>
    public struct MV_CC_PIXEL_CONVERT_PARAM_EX
    {
      /// <summary>[IN]     图像宽</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高</summary>
      public uint nHeight;
      /// <summary>[IN]     源像素格式</summary>
      public MvCCDll.MvGvspPixelType enSrcPixelType;
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pSrcData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nSrcDataLen;
      /// <summary>[IN]     目标像素格式</summary>
      public MvCCDll.MvGvspPixelType enDstPixelType;
      /// <summary>[OUT]    输出数据缓存</summary>
      public IntPtr pDstBuffer;
      /// <summary>[OUT]    输出数据大小</summary>
      public uint nDstLen;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nDstBufferSize;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nRes;
    }

    /// <summary>Gamma类型</summary>
    public enum MV_CC_GAMMA_TYPE
    {
      /// <summary>不启用</summary>
      MV_CC_GAMMA_TYPE_NONE,
      /// <summary>GAMMA值</summary>
      MV_CC_GAMMA_TYPE_VALUE,
      /// <summary>
      /// GAMMA曲线，8位需要的长度：256*sizeof(unsigned char)
      /// 10位需要的长度：1024*sizeof(unsigned short)
      /// 12位需要的长度：4096*sizeof(unsigned short)
      /// 16位需要的长度：65536*sizeof(unsigned short)
      /// </summary>
      MV_CC_GAMMA_TYPE_USER_CURVE,
      /// <summary>线性RGB转非线性RGB</summary>
      MV_CC_GAMMA_TYPE_LRGB2SRGB,
      /// <summary>非线性RGB转线性RGB</summary>
      MV_CC_GAMMA_TYPE_SRGB2LRGB,
    }

    /// <summary>Gamma参数</summary>
    public struct MV_CC_GAMMA_PARAM
    {
      /// <summary>[IN]     Gamma类型</summary>
      public MvCCDll.MV_CC_GAMMA_TYPE enGammaType;
      /// <summary>[IN]     Gamma值</summary>
      public float fGammaValue;
      /// <summary>[IN]     Gamma曲线缓存</summary>
      public IntPtr pGammaCurveBuf;
      /// <summary>[IN]     Gamma曲线长度</summary>
      public uint nGammaCurveBufLen;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>CCM参数</summary>
    public struct MV_CC_CCM_PARAM
    {
      /// <summary>[IN]     是否启用CCM</summary>
      public bool bCCMEnable;
      /// <summary>[IN]     CCM矩阵(-8192~8192)</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
      public int[] nCCMat;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>CCM参数</summary>
    public struct MV_CC_CCM_PARAM_EX
    {
      /// <summary>[IN]     是否启用CCM</summary>
      public bool bCCMEnable;
      /// <summary>[IN]     量化3x3矩阵</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
      public int[] nCCMat;
      /// <summary>[IN]     量化系数（2的整数幂）</summary>
      public uint nCCMScale;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>CLUT参数</summary>
    public struct MV_CC_CLUT_PARAM
    {
      /// <summary>[IN]     是否启用CLUT</summary>
      public bool bCLUTEnable;
      /// <summary>[IN]     量化系数(2的整数幂)</summary>
      public uint nCLUTScale;
      /// <summary>[IN]     CLUT大小，建议值17</summary>
      public uint nCLUTSize;
      /// <summary>[OUT]    量化CLUT</summary>
      public IntPtr pCLUTBuf;
      /// <summary>
      /// [IN]     量化CLUT缓存大小（nCLUTSize*nCLUTSize*nCLUTSize*sizeof(int)*3）
      /// </summary>
      public uint nCLUTBufLen;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>对比度调节参数</summary>
    public struct MV_CC_CONTRAST_PARAM
    {
      /// <summary>[IN]     图像宽度(最小8)</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高度(最小8)</summary>
      public uint nHeight;
      /// <summary>[IN]     输入图像缓存</summary>
      public IntPtr pSrcBuf;
      /// <summary>[IN]     输入图像缓存长度</summary>
      public uint nSrcBufLen;
      /// <summary>[IN]     输入的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[OUT]    输出像素数据缓存</summary>
      public IntPtr pDstBuf;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nDstBufSize;
      /// <summary>[OUT]    输出像素数据缓存长度</summary>
      public uint nDstBufLen;
      /// <summary>[IN]     对比度值，范围:[1, 10000]</summary>
      public uint nContrastFactor;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>锐化参数</summary>
    public struct MV_CC_SHARPEN_PARAM
    {
      /// <summary>[IN]     图像宽度(最小8)</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高度(最小8)</summary>
      public uint nHeight;
      /// <summary>[IN]     输入图像缓存</summary>
      public IntPtr pSrcBuf;
      /// <summary>[IN]     输入图像缓存长度</summary>
      public uint nSrcBufLen;
      /// <summary>[IN]     输入的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[OUT]    输出像素数据缓存</summary>
      public IntPtr pDstBuf;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nDstBufSize;
      /// <summary>[OUT]    输出像素数据缓存长度</summary>
      public uint nDstBufLen;
      /// <summary>[IN]     锐度调节强度，范围:[0, 500]</summary>
      public uint nSharpenAmount;
      /// <summary>[IN]     锐度调节半径（半径越大，耗时越长），范围:[1, 21]</summary>
      public uint nSharpenRadius;
      /// <summary>[IN]     锐度调节阈值，范围:[0, 255]</summary>
      public uint nSharpenThreshold;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>色彩校正参数（包括CCM和CLUT）</summary>
    public struct MV_CC_COLOR_CORRECT_PARAM
    {
      /// <summary>[IN]     图像宽度</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高度</summary>
      public uint nHeight;
      /// <summary>[IN]     输入图像缓存</summary>
      public IntPtr pSrcBuf;
      /// <summary>[IN]     输入图像缓存长度</summary>
      public uint nSrcBufLen;
      /// <summary>[IN]     输入的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[OUT]    输出像素数据缓存</summary>
      public IntPtr pDstBuf;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nDstBufSize;
      /// <summary>[OUT]    输出像素数据缓存长度</summary>
      public uint nDstBufLen;
      /// <summary>[IN]     输入有效图像位数，8 or 10 or 12 or 16</summary>
      public uint nImageBit;
      /// <summary>[IN]     输入Gamma信息</summary>
      public MvCCDll.MV_CC_GAMMA_PARAM stGammaParam;
      /// <summary>[IN]     输入CCM信息</summary>
      public MvCCDll.MV_CC_CCM_PARAM_EX stCCMParam;
      /// <summary>[IN]     输入CLUT信息</summary>
      public MvCCDll.MV_CC_CLUT_PARAM stCLUTParam;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>矩形ROI参数</summary>
    public struct MV_CC_RECT_I
    {
      /// <summary>[IN]     矩形左上角X轴坐标</summary>
      public uint nX;
      /// <summary>[IN]     矩形左上角Y轴坐标</summary>
      public uint nY;
      /// <summary>[IN]     矩形宽度</summary>
      public uint nWidth;
      /// <summary>[IN]     矩形高度</summary>
      public uint nHeight;
    }

    /// <summary>噪声估计参数</summary>
    public struct MV_CC_NOISE_ESTIMATE_PARAM
    {
      /// <summary>[IN]     图像宽度</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高度</summary>
      public uint nHeight;
      /// <summary>[IN]     输入的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     输入图像缓存</summary>
      public IntPtr pSrcBuf;
      /// <summary>[IN]     输入图像缓存长度</summary>
      public uint nSrcBufLen;
      /// <summary>[IN]     图像ROI</summary>
      public IntPtr pstROIRect;
      /// <summary>[IN]     ROI个数</summary>
      public uint nROINum;
      /// <summary>[IN]     噪声阈值[0-4095]</summary>
      public uint nNoiseThreshold;
      /// <summary>[OUT]    输出噪声特性</summary>
      public IntPtr pNoiseProfile;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nNoiseProfileSize;
      /// <summary>[OUT]    输出噪声特性长度</summary>
      public uint nNoiseProfileLen;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>空域降噪参数</summary>
    public struct MV_CC_SPATIAL_DENOISE_PARAM
    {
      /// <summary>[IN]     图像宽度</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高度</summary>
      public uint nHeight;
      /// <summary>[IN]     输入的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     输入图像缓存</summary>
      public IntPtr pSrcBuf;
      /// <summary>[IN]     输入图像缓存长度</summary>
      public uint nSrcBufLen;
      /// <summary>[OUT]    输出降噪后的数据</summary>
      public IntPtr pDstBuf;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nDstBufSize;
      /// <summary>[OUT]    输出降噪后的数据长度</summary>
      public uint nDstBufLen;
      /// <summary>[IN]     输入噪声特性</summary>
      public IntPtr pNoiseProfile;
      /// <summary>[IN]     输入噪声特性长度</summary>
      public uint nNoiseProfileLen;
      /// <summary>[IN]     降噪强度(0-100)</summary>
      public uint nBayerDenoiseStrength;
      /// <summary>[IN]     锐化强度(0-32)</summary>
      public uint nBayerSharpenStrength;
      /// <summary>[IN]     噪声校正系数(0-1280)</summary>
      public uint nBayerNoiseCorrect;
      /// <summary>[IN]     亮度校正系数(1-2000)</summary>
      public uint nNoiseCorrectLum;
      /// <summary>[IN]     色调校正系数(1-2000)</summary>
      public uint nNoiseCorrectChrom;
      /// <summary>[IN]     亮度降噪强度(0-100)</summary>
      public uint nStrengthLum;
      /// <summary>[IN]     色调降噪强度(0-100)</summary>
      public uint nStrengthChrom;
      /// <summary>[IN]     锐化强度(1-1000)</summary>
      public uint nStrengthSharpen;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>LSC标定参数</summary>
    public struct MV_CC_LSC_CALIB_PARAM
    {
      /// <summary>[IN]     图像宽度(16~65536)</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高度(16~65536)</summary>
      public uint nHeight;
      /// <summary>[IN]     输入的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     输入图像缓存</summary>
      public IntPtr pSrcBuf;
      /// <summary>[IN]     输入图像缓存长度</summary>
      public uint nSrcBufLen;
      /// <summary>[OUT]    输出标定表缓存</summary>
      public IntPtr pCalibBuf;
      /// <summary>
      /// [IN]     提供的标定表缓冲大小（nWidth*nHeight*sizeof(unsigned short)）
      /// </summary>
      public uint nCalibBufSize;
      /// <summary>[OUT]    输出标定表缓存长度</summary>
      public uint nCalibBufLen;
      /// <summary>[IN]     宽度分块数</summary>
      public uint nSecNumW;
      /// <summary>[IN]     高度分块数</summary>
      public uint nSecNumH;
      /// <summary>[IN]     边缘填充系数，范围1~5</summary>
      public uint nPadCoef;
      /// <summary>
      /// [IN]     标定方式，0-中心为基准
      ///                    1-最亮区域为基准
      ///                    2-目标亮度
      /// </summary>
      public uint nCalibMethod;
      /// <summary>
      /// [IN]     目标亮度（8bits，[0,255])
      ///         （10bits，[0,1023])
      ///         （12bits，[0,4095])
      ///         （16bits，[0,65535])
      /// </summary>
      public uint nTargetGray;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>LSC校正参数</summary>
    public struct MV_CC_LSC_CORRECT_PARAM
    {
      /// <summary>[IN]     图像宽度(16~65536)</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高度(16~65536)</summary>
      public uint nHeight;
      /// <summary>[IN]     输入的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     输入图像缓存</summary>
      public IntPtr pSrcBuf;
      /// <summary>[IN]     输入图像缓存长度</summary>
      public uint nSrcBufLen;
      /// <summary>[OUT]    输出像素数据缓存</summary>
      public IntPtr pDstBuf;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nDstBufSize;
      /// <summary>[OUT]    输出像素数据缓存长度</summary>
      public uint nDstBufLen;
      /// <summary>[IN]     输入校正表缓存</summary>
      public IntPtr pCalibBuf;
      /// <summary>[IN]     输入校正表缓存长度</summary>
      public uint nCalibBufLen;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>噪声特性类型</summary>
    public enum MV_CC_BAYER_NOISE_FEATURE_TYPE
    {
      /// <summary>无效</summary>
      MV_CC_BAYER_NOISE_FEATURE_TYPE_INVALID = 0,
      /// <summary>噪声曲线</summary>
      MV_CC_BAYER_NOISE_FEATURE_TYPE_PROFILE = 1,
      /// <summary>默认值</summary>
      MV_CC_BAYER_NOISE_FEATURE_TYPE_DEFAULT = 2,
      /// <summary>噪声水平</summary>
      MV_CC_BAYER_NOISE_FEATURE_TYPE_LEVEL = 2,
    }

    /// <summary>噪声基本信息</summary>
    public struct MV_CC_BAYER_NOISE_PROFILE_INFO
    {
      /// <summary>版本</summary>
      public uint nVersion;
      /// <summary>噪声特性类型</summary>
      public MvCCDll.MV_CC_BAYER_NOISE_FEATURE_TYPE enNoiseFeatureType;
      /// <summary>图像格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>平均噪声水平</summary>
      public int nNoiseLevel;
      /// <summary>曲线点数</summary>
      public uint nCurvePointNum;
      /// <summary>噪声曲线</summary>
      public IntPtr nNoiseCurve;
      /// <summary>亮度曲线</summary>
      public IntPtr nLumCurve;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>噪声估计参数</summary>
    public struct MV_CC_BAYER_NOISE_ESTIMATE_PARAM
    {
      /// <summary>[IN]     图像宽(大于等于8)</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高(大于等于8)</summary>
      public uint nHeight;
      /// <summary>[IN]     像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pSrcData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nSrcDataLen;
      /// <summary>[IN]     噪声阈值(0-4095)</summary>
      public uint nNoiseThreshold;
      /// <summary>
      /// [IN]     用于存储噪声曲线和亮度曲线（需要外部分配，缓存大小：4096 * sizeof(int) * 2）
      /// </summary>
      public IntPtr pCurveBuf;
      /// <summary>[OUT]    降噪特性信息</summary>
      public MvCCDll.MV_CC_BAYER_NOISE_PROFILE_INFO stNoiseProfile;
      /// <summary>[IN]     线程数量，0表示算法库根据硬件自适应；1表示单线程（默认）；大于1表示线程数目</summary>
      public uint nThreadNum;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>降噪参数</summary>
    public struct MV_CC_BAYER_SPATIAL_DENOISE_PARAM
    {
      /// <summary>[IN]     图像宽(大于等于8)</summary>
      public uint nWidth;
      /// <summary>[IN]     图像高(大于等于8)</summary>
      public uint nHeight;
      /// <summary>[IN]     像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pSrcData;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nSrcDataLen;
      /// <summary>[OUT]    输出降噪后的数据</summary>
      public IntPtr pDstBuf;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nDstBufSize;
      /// <summary>[OUT]    输出降噪后的数据长度</summary>
      public uint nDstBufLen;
      /// <summary>[IN]    降噪特性信息(来源于噪声估计)</summary>
      public MvCCDll.MV_CC_BAYER_NOISE_PROFILE_INFO stNoiseProfile;
      /// <summary>[IN]     降噪强度(0-100)</summary>
      public uint nDenoiseStrength;
      /// <summary>[IN]     锐化强度(0-32)</summary>
      public uint nSharpenStrength;
      /// <summary>[IN]     噪声校正系数(0-1280)</summary>
      public uint nNoiseCorrect;
      /// <summary>[IN]     线程数量，0表示算法库根据硬件自适应；1表示单线程（默认）；大于1表示线程数目</summary>
      public uint nThreadNum;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>帧特殊信息</summary>
    public struct MV_CC_FRAME_SPEC_INFO
    {
      /// <summary>[OUT]     秒数</summary>
      public uint nSecondCount;
      /// <summary>[OUT]     周期数</summary>
      public uint nCycleCount;
      /// <summary>[OUT]     周期偏移量</summary>
      public uint nCycleOffset;
      /// <summary>[OUT]     增益</summary>
      public float fGain;
      /// <summary>[OUT]     曝光时间</summary>
      public float fExposureTime;
      /// <summary>[OUT]     平均亮度</summary>
      public uint nAverageBrightness;
      /// <summary>[OUT]     红色</summary>
      public uint nRed;
      /// <summary>[OUT]     绿色</summary>
      public uint nGreen;
      /// <summary>[OUT]     蓝色</summary>
      public uint nBlue;
      /// <summary>[OUT]     总帧数</summary>
      public uint nFrameCounter;
      /// <summary>[OUT]     触发计数</summary>
      public uint nTriggerIndex;
      /// <summary>[OUT]     输入</summary>
      public uint nInput;
      /// <summary>[OUT]     输出</summary>
      public uint nOutput;
      /// <summary>[OUT]     水平偏移量</summary>
      public ushort nOffsetX;
      /// <summary>[OUT]     垂直偏移量</summary>
      public ushort nOffsetY;
      /// <summary>[OUT]     水印宽</summary>
      public ushort nFrameWidth;
      /// <summary>[OUT]     水印高</summary>
      public ushort nFrameHeight;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public uint[] nRes;
    }

    /// <summary>HB解码参数</summary>
    public struct MV_CC_HB_DECODE_PARAM
    {
      /// <summary>[IN]     输入数据缓存</summary>
      public IntPtr pSrcBuf;
      /// <summary>[IN]     输入数据大小</summary>
      public uint nSrcLen;
      /// <summary>[OUT]    图像宽</summary>
      public uint nWidth;
      /// <summary>[OUT]    图像高</summary>
      public uint nHeight;
      /// <summary>[OUT]    输出数据缓存</summary>
      public IntPtr pDstBuf;
      /// <summary>[IN]     提供的输出缓冲区大小</summary>
      public uint nDstBufSize;
      /// <summary>[OUT]    输出数据大小</summary>
      public uint nDstBufLen;
      /// <summary>[OUT]     输出的像素格式</summary>
      public MvCCDll.MvGvspPixelType enDstPixelType;
      /// <summary>[OUT]    水印信息</summary>
      public MvCCDll.MV_CC_FRAME_SPEC_INFO stFrameSpecInfo;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>录像格式定义</summary>
    public enum MV_RECORD_FORMAT_TYPE
    {
      /// <summary>未定义格式</summary>
      MV_FormatType_Undefined,
      /// <summary>AVI格式</summary>
      MV_FormatType_AVI,
    }

    /// <summary>录像参数</summary>
    public struct MV_CC_RECORD_PARAM
    {
      /// <summary>[IN]     输入数据的像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>[IN]     图像宽(指定目标参数时需为8的倍数)</summary>
      public ushort nWidth;
      /// <summary>[IN]     图像高(指定目标参数时需为8的倍数)</summary>
      public ushort nHeight;
      /// <summary>[IN]     帧率fps(大于1/16)</summary>
      public float fFrameRate;
      /// <summary>[IN]     码率kbps(128kbps-16Mbps)</summary>
      public uint nBitRate;
      /// <summary>[IN]     录像格式</summary>
      public MvCCDll.MV_RECORD_FORMAT_TYPE enRecordFmtType;
      /// <summary>[IN]     录像文件存放路径</summary>
      public string strFilePath;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>输入帧信息</summary>
    public struct MV_CC_INPUT_FRAME_INFO
    {
      /// <summary>[IN]     图像数据指针</summary>
      public IntPtr pData;
      /// <summary>[IN]     图像大小</summary>
      public uint nDataLen;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nRes;
    }

    /// <summary>采集模式</summary>
    public enum MV_CAM_ACQUISITION_MODE
    {
      /// <summary>单帧模式</summary>
      MV_ACQ_MODE_SINGLE,
      /// <summary>多帧模式</summary>
      MV_ACQ_MODE_MUTLI,
      /// <summary>持续采集模式</summary>
      MV_ACQ_MODE_CONTINUOUS,
    }

    /// <summary>增益模式</summary>
    public enum MV_CAM_GAIN_MODE
    {
      /// <summary>关闭</summary>
      MV_GAIN_MODE_OFF,
      /// <summary>一次</summary>
      MV_GAIN_MODE_ONCE,
      /// <summary>连续</summary>
      MV_GAIN_MODE_CONTINUOUS,
    }

    /// <summary>曝光模式</summary>
    public enum MV_CAM_EXPOSURE_MODE
    {
      /// <summary>Timed</summary>
      MV_EXPOSURE_MODE_TIMED,
      /// <summary>TriggerWidth</summary>
      MV_EXPOSURE_MODE_TRIGGER_WIDTH,
    }

    /// <summary>自动曝光模式</summary>
    public enum MV_CAM_EXPOSURE_AUTO_MODE
    {
      /// <summary>关闭</summary>
      MV_EXPOSURE_AUTO_MODE_OFF,
      /// <summary>一次</summary>
      MV_EXPOSURE_AUTO_MODE_ONCE,
      /// <summary>连续</summary>
      MV_EXPOSURE_AUTO_MODE_CONTINUOUS,
    }

    /// <summary>相机触发模式</summary>
    public enum MV_CAM_TRIGGER_MODE
    {
      /// <summary>关闭</summary>
      MV_TRIGGER_MODE_OFF,
      /// <summary>打开</summary>
      MV_TRIGGER_MODE_ON,
    }

    /// <summary>Gamma选择器</summary>
    public enum MV_CAM_GAMMA_SELECTOR
    {
      /// <summary>USER</summary>
      MV_GAMMA_SELECTOR_USER = 1,
      /// <summary>SRGB</summary>
      MV_GAMMA_SELECTOR_SRGB = 2,
    }

    /// <summary>自动白平衡</summary>
    public enum MV_CAM_BALANCEWHITE_AUTO
    {
      /// <summary>关闭自动白平衡</summary>
      MV_BALANCEWHITE_AUTO_OFF,
      /// <summary>连续自动白平衡</summary>
      MV_BALANCEWHITE_AUTO_CONTINUOUS,
      /// <summary>一次自动白平衡</summary>
      MV_BALANCEWHITE_AUTO_ONCE,
    }

    /// <summary>触发源</summary>
    public enum MV_CAM_TRIGGER_SOURCE
    {
      /// <summary>LINE0</summary>
      MV_TRIGGER_SOURCE_LINE0 = 0,
      /// <summary>LINE1</summary>
      MV_TRIGGER_SOURCE_LINE1 = 1,
      /// <summary>LINE2</summary>
      MV_TRIGGER_SOURCE_LINE2 = 2,
      /// <summary>LINE3</summary>
      MV_TRIGGER_SOURCE_LINE3 = 3,
      /// <summary>COUNTER0</summary>
      MV_TRIGGER_SOURCE_COUNTER0 = 4,
      /// <summary>SOFTWARE</summary>
      MV_TRIGGER_SOURCE_SOFTWARE = 7,
      /// <summary>FrequencyConverter</summary>
      MV_TRIGGER_SOURCE_FrequencyConverter = 8,
    }

    /// <summary>ALL MATHCH INFO</summary>
    public struct MV_ALL_MATCH_INFO
    {
      /// <summary>需要输出的信息类型，e.g. MV_MATCH_TYPE_NET_DETECT</summary>
      public uint nType;
      /// <summary>输出的信息缓存，由调用者分配</summary>
      public IntPtr pInfo;
      /// <summary>信息缓存的大小</summary>
      public uint nInfoSize;
    }

    /// <summary>
    /// 
    /// </summary>
    public struct MV_MATCH_INFO_NET_DETECT
    {
      /// <summary>已接收数据大小  [统计StartGrabbing和StopGrabbing之间的数据量]</summary>
      public long nReviceDataSize;
      /// <summary>丢失的包数量</summary>
      public long nLostPacketCount;
      /// <summary>丢帧数量</summary>
      public uint nLostFrameCount;
      /// <summary>帧数</summary>
      public uint nNetRecvFrameCount;
      /// <summary>请求重发包数</summary>
      public long nRequestResendPacketCount;
      /// <summary>重发包数</summary>
      public long nResendPacketCount;
    }

    /// <summary>USB</summary>
    public struct MV_MATCH_INFO_USB_DETECT
    {
      /// <summary>已接收数据大小    [统计OpenDevicce和CloseDevice之间的数据量]</summary>
      public long nReviceDataSize;
      /// <summary>已收到的帧数</summary>
      public uint nRevicedFrameCount;
      /// <summary>错误帧数</summary>
      public uint nErrorFrameCount;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public uint[] nReserved;
    }

    /// <summary>图像的基本信息</summary>
    public struct MV_IMAGE_BASIC_INFO
    {
      /// <summary>宽度值</summary>
      public ushort nWidthValue;
      /// <summary>宽度最小值</summary>
      public ushort nWidthMin;
      /// <summary>宽度最大值</summary>
      public uint nWidthMax;
      /// <summary>Width Inc</summary>
      public uint nWidthInc;
      /// <summary>高度值</summary>
      public uint nHeightValue;
      /// <summary>高度最小值</summary>
      public uint nHeightMin;
      /// <summary>高度最大值</summary>
      public uint nHeightMax;
      /// <summary>Height Inc</summary>
      public uint nHeightInc;
      /// <summary>帧率</summary>
      public float fFrameRateValue;
      /// <summary>最小帧率</summary>
      public float fFrameRateMin;
      /// <summary>最大帧率</summary>
      public float fFrameRateMax;
      /// <summary>当前的像素格式</summary>
      public uint enPixelType;
      /// <summary>支持的像素格式种类</summary>
      public uint nSupportedPixelFmtNum;
      /// <summary>像素列表</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public uint[] enPixelList;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nReserved;
    }

    /// <summary>节点是否可见的权限等级</summary>
    public enum MV_XML_Visibility
    {
      /// <summary>Always visible</summary>
      V_Beginner = 0,
      /// <summary>Visible for experts or Gurus</summary>
      V_Expert = 1,
      /// <summary>Visible for Gurus</summary>
      V_Guru = 2,
      /// <summary>Not Visible</summary>
      V_Invisible = 3,
      /// <summary>Object is not yet initialized</summary>
      V_Undefined = 99, // 0x00000063
    }

    /// <summary>事件信息</summary>
    public struct MV_EVENT_OUT_INFO
    {
      /// <summary>事件名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
      public string EventName;
      /// <summary>Event号</summary>
      public ushort nEventID;
      /// <summary>流通到序号</summary>
      public ushort nStreamChannel;
      /// <summary>帧号高位</summary>
      public uint nBlockIdHigh;
      /// <summary>帧号低位</summary>
      public uint nBlockIdLow;
      /// <summary>时间戳高位</summary>
      public uint nTimestampHigh;
      /// <summary>时间戳低位</summary>
      public uint nTimestampLow;
      /// <summary>Event数据</summary>
      public IntPtr pEventData;
      /// <summary>Event数据长度</summary>
      public uint nEventDataSize;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public uint[] nReserved;
    }

    /// <summary>节点错误类型</summary>
    public enum MVCC_NODE_ERR_TYPE
    {
      /// <summary>节点不存在</summary>
      MVCC_NODE_ERR_NODE_INVALID = 1,
      /// <summary>访问条件错误,通常是节点不可读写</summary>
      MVCC_NODE_ERR_ACCESS = 2,
      /// <summary>写入越界,超出该节点支持的范围</summary>
      MVCC_NODE_ERR_OUT_RANGE = 3,
      /// <summary>校验失败,通常是写入的值与文件中的值不匹配</summary>
      MVCC_NODE_ERR_VERIFY_FAILD = 4,
      /// <summary>其它错误,可查阅日志</summary>
      MVCC_NODE_ERR_OTHER = 100, // 0x00000064
    }

    /// <summary>节点错误信息</summary>
    public struct MVCC_NODE_ERROR
    {
      /// <summary>节点名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>错误类型</summary>
      public MvCCDll.MVCC_NODE_ERR_TYPE enErrCode;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>错误信息列表</summary>
    public struct MVCC_NODE_ERROR_LIST
    {
      /// <summary>错误个数</summary>
      public uint nErrorNum;
      /// <summary>错误信息</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public MvCCDll.MVCC_NODE_ERROR[] stNodeError;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>节点名称</summary>
    public struct MVCC_NODE_NAME
    {
      /// <summary>节点名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>节点列表</summary>
    public struct MVCC_NODE_NAME_LIST
    {
      /// <summary>错误信息</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
      public MvCCDll.MVCC_NODE_NAME[] stNodeName;
      /// <summary>节点个数</summary>
      public uint nNodeNum;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>文件存取</summary>
    public struct MV_CC_FILE_ACCESS
    {
      /// <summary>用户文件名</summary>
      public string pUserFileName;
      /// <summary>设备文件名</summary>
      public string pDevFileName;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
      public uint[] nReserved;
    }

    /// <summary>文件存取</summary>
    public struct MV_CC_FILE_ACCESS_EX
    {
      /// <summary>用户文件数据缓存空间</summary>
      public IntPtr pUserFileBuf;
      /// <summary>用户数据缓存大小</summary>
      public uint nFileBufSize;
      /// <summary>文件实际缓存大小</summary>
      public uint nFileBufLen;
      /// <summary>设备文件名</summary>
      public string pDevFileName;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
      public uint[] nReserved;
    }

    /// <summary>文件存取进度</summary>
    public struct MV_CC_FILE_ACCESS_PROGRESS
    {
      /// <summary>已完成的长度</summary>
      public long nCompleted;
      /// <summary>总长度</summary>
      public long nTotal;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nReserved;
    }

    /// <summary>GigE传输类型</summary>
    public enum MV_GIGE_TRANSMISSION_TYPE
    {
      /// <summary>表示单播(默认)</summary>
      MV_GIGE_TRANSTYPE_UNICAST = 0,
      /// <summary>表示组播</summary>
      MV_GIGE_TRANSTYPE_MULTICAST = 1,
      /// <summary>表示局域网内广播，暂不支持</summary>
      MV_GIGE_TRANSTYPE_LIMITEDBROADCAST = 2,
      /// <summary>表示子网内广播，暂不支持</summary>
      MV_GIGE_TRANSTYPE_SUBNETBROADCAST = 3,
      /// <summary>表示从相机获取，暂不支持</summary>
      MV_GIGE_TRANSTYPE_CAMERADEFINED = 4,
      /// <summary>表示用户自定义应用端接收图像数据Port号</summary>
      MV_GIGE_TRANSTYPE_UNICAST_DEFINED_PORT = 5,
      /// <summary>表示设置了单播，但本实例不接收图像数据</summary>
      MV_GIGE_TRANSTYPE_UNICAST_WITHOUT_RECV = 65536, // 0x00010000
      /// <summary>表示组播模式，但本实例不接收图像数据</summary>
      MV_GIGE_TRANSTYPE_MULTICAST_WITHOUT_RECV = 65537, // 0x00010001
    }

    /// <summary>传输模式，可以为单播模式、组播模式等</summary>
    public struct MV_CC_TRANSMISSION_TYPE
    {
      /// <summary>传输模式</summary>
      public MvCCDll.MV_GIGE_TRANSMISSION_TYPE enTransmissionType;
      /// <summary>目标IP，组播模式下有意义</summary>
      public uint nDestIp;
      /// <summary>目标Port，组播模式下有意义</summary>
      public ushort nDestPort;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
      public uint[] nReserved;
    }

    /// <summary>动作命令信息</summary>
    public struct MV_ACTION_CMD_INFO
    {
      /// <summary>设备密钥</summary>
      public uint nDeviceKey;
      /// <summary>组键</summary>
      public uint nGroupKey;
      /// <summary>组掩码</summary>
      public uint nGroupMask;
      /// <summary>只有设置成1时Action Time才有效，非1时无效</summary>
      public uint bActionTimeEnable;
      /// <summary>预定的时间，和主频有关</summary>
      public long nActionTime;
      /// <summary>广播包地址</summary>
      public string pBroadcastAddress;
      /// <summary>等待ACK的超时时间，如果为0表示不需要ACK</summary>
      public uint nTimeOut;
      /// <summary>只有设置成1时指定的网卡IP才有效，非1时无效</summary>
      public uint bSpecialNetEnable;
      /// <summary>指定的网卡IP</summary>
      public uint nSpecialNetIP;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
      public uint[] nReserved;
    }

    /// <summary>动作命令结果</summary>
    public struct MV_ACTION_CMD_RESULT
    {
      /// <summary>IP address of the device</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
      public string strDeviceAddress;
      /// <summary>status code returned by the device</summary>
      public int nStatus;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>动作命令结果列表</summary>
    public struct MV_ACTION_CMD_RESULT_LIST
    {
      /// <summary>返回值个数</summary>
      public uint nNumResults;
      /// <summary>返回的结果</summary>
      public IntPtr pResults;
    }

    /// <summary>每个节点对应的接口类型</summary>
    public enum MV_XML_InterfaceType
    {
      /// <summary>IValue接口类型</summary>
      IFT_IValue,
      /// <summary>IBase接口类型</summary>
      IFT_IBase,
      /// <summary>IInteger接口类型</summary>
      IFT_IInteger,
      /// <summary>IBoolean接口类型</summary>
      IFT_IBoolean,
      /// <summary>ICommand接口类型</summary>
      IFT_ICommand,
      /// <summary>IFloat接口类型</summary>
      IFT_IFloat,
      /// <summary>IString接口类型</summary>
      IFT_IString,
      /// <summary>IRegister接口类型</summary>
      IFT_IRegister,
      /// <summary>ICategory接口类型</summary>
      IFT_ICategory,
      /// <summary>IEnumeration接口类型</summary>
      IFT_IEnumeration,
      /// <summary>IEnumEntry接口类型</summary>
      IFT_IEnumEntry,
      /// <summary>IPort接口类型</summary>
      IFT_IPort,
    }

    /// <summary>XML节点特点</summary>
    public struct MV_XML_NODE_FEATURE
    {
      /// <summary>节点类型</summary>
      public MvCCDll.MV_XML_InterfaceType enType;
      /// <summary>是否可见</summary>
      public MvCCDll.MV_XML_Visibility enVisivility;
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strDescription;
      /// <summary>显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strDisplayName;
      /// <summary>节点名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>提示</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strToolTip;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>XML节点列表</summary>
    public struct MV_XML_NODES_LIST
    {
      /// <summary>节点个数</summary>
      public uint nNodeNum;
      /// <summary>节点列表</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
      public MvCCDll.MV_XML_NODE_FEATURE[] stNodes;
    }

    /// <summary>整型节点值</summary>
    public struct MVCC_INTVALUE
    {
      /// <summary>当前值</summary>
      public uint nCurValue;
      /// <summary>最大值</summary>
      public uint nMax;
      /// <summary>最小值</summary>
      public uint nMin;
      /// <summary>Inc</summary>
      public uint nInc;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>整型节点值</summary>
    public struct MVCC_INTVALUE_EX
    {
      /// <summary>当前值</summary>
      public long nCurValue;
      /// <summary>最大值</summary>
      public long nMax;
      /// <summary>最小值</summary>
      public long nMin;
      /// <summary>Inc</summary>
      public long nInc;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
      public uint[] nReserved;
    }

    /// <summary>浮点型节点值</summary>
    public struct MVCC_FLOATVALUE
    {
      /// <summary>当前值</summary>
      public float fCurValue;
      /// <summary>最大值</summary>
      public float fMax;
      /// <summary>最小值</summary>
      public float fMin;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>枚举型节点值</summary>
    public struct MVCC_ENUMVALUE
    {
      /// <summary>当前值</summary>
      public uint nCurValue;
      /// <summary>有效数据个数</summary>
      public uint nSupportedNum;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public uint[] nSupportValue;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>枚举型节点值</summary>
    public struct MVCC_ENUMVALUE_EX
    {
      /// <summary>当前值</summary>
      public uint nCurValue;
      /// <summary>有效数据个数</summary>
      public uint nSupportedNum;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
      public uint[] nSupportValue;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>字符串型节点值</summary>
    public struct MVCC_STRINGVALUE
    {
      /// <summary>当前值</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
      public string chCurValue;
      /// <summary>节点值的最大长度</summary>
      public long nMaxLength;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
      public uint[] nReserved;
    }

    /// <summary>节点的读写性</summary>
    public enum MV_XML_AccessMode
    {
      /// <summary>未实现</summary>
      AM_NI,
      /// <summary>不可获取</summary>
      AM_NA,
      /// <summary>只写</summary>
      AM_WO,
      /// <summary>只读</summary>
      AM_RO,
      /// <summary>可读可写</summary>
      AM_RW,
      /// <summary>未定义</summary>
      AM_Undefined,
      /// <summary>内部用于AccessMode循环检测</summary>
      AM_CycleDetect,
    }

    /// <summary>整型节点</summary>
    public struct MV_XML_FEATURE_Integer
    {
      /// <summary>节点名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strDisplayName;
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strDescription;
      /// <summary>提示</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strToolTip;
      /// <summary>是否可见</summary>
      public MvCCDll.MV_XML_Visibility enVisivility;
      /// <summary>访问模式</summary>
      public MvCCDll.MV_XML_AccessMode enAccessMode;
      /// <summary>是否锁定。0-否；1-是</summary>
      public int bIsLocked;
      /// <summary>当前值</summary>
      public long nValue;
      /// <summary>最小值</summary>
      public long nMinValue;
      /// <summary>最大值</summary>
      public long nMaxValue;
      /// <summary>增量</summary>
      public long nIncrement;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>布尔型节点</summary>
    public struct MV_XML_FEATURE_Boolean
    {
      /// <summary>节点名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strDisplayName;
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strDescription;
      /// <summary>提示</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strToolTip;
      /// <summary>是否可见</summary>
      public MvCCDll.MV_XML_Visibility enVisivility;
      /// <summary>访问模式</summary>
      public MvCCDll.MV_XML_AccessMode enAccessMode;
      /// <summary>是否锁定。0-否；1-是</summary>
      public int bIsLocked;
      /// <summary>当前值</summary>
      public bool bValue;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>命令型节点</summary>
    public struct MV_XML_FEATURE_Command
    {
      /// <summary>节点名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strDisplayName;
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strDescription;
      /// <summary>提示</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strToolTip;
      /// <summary>是否可见</summary>
      public MvCCDll.MV_XML_Visibility enVisivility;
      /// <summary>访问模式</summary>
      public MvCCDll.MV_XML_AccessMode enAccessMode;
      /// <summary>是否锁定。0-否；1-是</summary>
      public int bIsLocked;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>浮点型节点</summary>
    public struct MV_XML_FEATURE_Float
    {
      /// <summary>节点名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strDisplayName;
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strDescription;
      /// <summary>提示</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strToolTip;
      /// <summary>是否可见</summary>
      public MvCCDll.MV_XML_Visibility enVisivility;
      /// <summary>访问模式</summary>
      public MvCCDll.MV_XML_AccessMode enAccessMode;
      /// <summary>是否锁定。0-否；1-是</summary>
      public int bIsLocked;
      /// <summary>当前值</summary>
      public double dfValue;
      /// <summary>最小值</summary>
      public double dfMinValue;
      /// <summary>最大值</summary>
      public double dfMaxValue;
      /// <summary>增量</summary>
      public double dfIncrement;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>字符串类型节点</summary>
    public struct MV_XML_FEATURE_String
    {
      /// <summary>节点名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strDisplayName;
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strDescription;
      /// <summary>提示</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strToolTip;
      /// <summary>是否可见</summary>
      public MvCCDll.MV_XML_Visibility enVisivility;
      /// <summary>访问模式</summary>
      public MvCCDll.MV_XML_AccessMode enAccessMode;
      /// <summary>是否锁定。0-否；1-是</summary>
      public int bIsLocked;
      /// <summary>当前值</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strValue;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>寄存器型节点</summary>
    public struct MV_XML_FEATURE_Register
    {
      /// <summary>节点名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strDisplayName;
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strDescription;
      /// <summary>提示</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strToolTip;
      /// <summary>是否可见</summary>
      public MvCCDll.MV_XML_Visibility enVisivility;
      /// <summary>访问模式</summary>
      public MvCCDll.MV_XML_AccessMode enAccessMode;
      /// <summary>是否锁定。0-否；1-是</summary>
      public int bIsLocked;
      /// <summary>当前值</summary>
      public long nAddrValue;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>类别属性</summary>
    public struct MV_XML_FEATURE_Category
    {
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strDescription;
      /// <summary>显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strDisplayName;
      /// <summary>节点名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>提示</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strToolTip;
      /// <summary>是否可见</summary>
      public MvCCDll.MV_XML_Visibility enVisivility;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>EnumEntry属性节点</summary>
    public struct MV_XML_FEATURE_EnumEntry
    {
      /// <summary>节点名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strDisplayName;
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strDescription;
      /// <summary>提示</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strToolTip;
      /// <summary>
      /// 
      /// </summary>
      public int bIsImplemented;
      /// <summary>父节点数</summary>
      public int nParentsNum;
      /// <summary>父节点列表</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public MvCCDll.MV_XML_NODE_FEATURE[] stParentsList;
      /// <summary>是否可见</summary>
      public MvCCDll.MV_XML_Visibility enVisivility;
      /// <summary>当前值</summary>
      public long nValue;
      /// <summary>访问模式</summary>
      public MvCCDll.MV_XML_AccessMode enAccessMode;
      /// <summary>是否锁定。0-否；1-是</summary>
      public int bIsLocked;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nReserved;
    }

    /// <summary>节点描述</summary>
    public struct StrSymbolic
    {
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string str;
    }

    /// <summary>Enumeration属性节点</summary>
    public struct MV_XML_FEATURE_Enumeration
    {
      /// <summary>是否可见</summary>
      public MvCCDll.MV_XML_Visibility enVisivility;
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strDescription;
      /// <summary>显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strDisplayName;
      /// <summary>节点名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>提示</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strToolTip;
      /// <summary>Symbolic数</summary>
      public int nSymbolicNum;
      /// <summary>当前Symbolic索引</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strCurrentSymbolic;
      /// <summary>Symbolic索引</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public MvCCDll.StrSymbolic[] strSymbolic;
      /// <summary>访问模式</summary>
      public MvCCDll.MV_XML_AccessMode enAccessMode;
      /// <summary>是否锁定。0-否；1-是</summary>
      public int bIsLocked;
      /// <summary>当前值</summary>
      public long nValue;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>Port属性节点</summary>
    public struct MV_XML_FEATURE_Port
    {
      /// <summary>是否可见</summary>
      public MvCCDll.MV_XML_Visibility enVisivility;
      /// <summary>节点描述</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strDescription;
      /// <summary>显示名称</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strDisplayName;
      /// <summary>节点名</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strName;
      /// <summary>提示</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
      public string strToolTip;
      /// <summary>访问模式</summary>
      public MvCCDll.MV_XML_AccessMode enAccessMode;
      /// <summary>是否锁定。0-否；1-是</summary>
      public int bIsLocked;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>辅助线颜色</summary>
    public struct MVCC_COLORF
    {
      /// <summary>[0.0 , 1.0]</summary>
      public float fR;
      /// <summary>[0.0 , 1.0]</summary>
      public float fG;
      /// <summary>[0.0 , 1.0]</summary>
      public float fB;
      /// <summary>[0.0 , 1.0]</summary>
      public float fAlpha;
      /// <summary>预留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>自定义点坐标</summary>
    public struct MVCC_POINTF
    {
      /// <summary>[0.0 , 1.0]</summary>
      public float fX;
      /// <summary>[0.0 , 1.0]</summary>
      public float fY;
      /// <summary>预留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>矩形框区域信息</summary>
    public struct MVCC_RECT_INFO
    {
      /// <summary>[0.0 , 1.0]</summary>
      public float fTop;
      /// <summary>[0.0 , 1.0]</summary>
      public float fBottom;
      /// <summary>[0.0 , 1.0]</summary>
      public float fLeft;
      /// <summary>[0.0 , 1.0]</summary>
      public float fRight;
      /// <summary>辅助线颜色</summary>
      public MvCCDll.MVCC_COLORF stColor;
      /// <summary>辅助线宽度</summary>
      public uint nLineWidth;
      /// <summary>预留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>圆形框区域信息</summary>
    public struct MVCC_CIRCLE_INFO
    {
      /// <summary>圆心信息</summary>
      public MvCCDll.MVCC_POINTF stCenterPoint;
      /// <summary>宽向半径，根据图像的相对位置[0, 1.0]</summary>
      public float fR1;
      /// <summary>高向半径，根据图像的相对位置[0, 1.0]</summary>
      public float fR2;
      /// <summary>辅助线颜色信息</summary>
      public MvCCDll.MVCC_COLORF stColor;
      /// <summary>辅助线宽度</summary>
      public uint nLineWidth;
      /// <summary>预留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>线条辅助线信息</summary>
    public struct MVCC_LINES_INFO
    {
      /// <summary>线条辅助线的起始点坐标</summary>
      public MvCCDll.MVCC_POINTF stStartPoint;
      /// <summary>线条辅助线的终点坐标</summary>
      public MvCCDll.MVCC_POINTF stEndPoint;
      /// <summary>辅助线颜色信息</summary>
      public MvCCDll.MVCC_COLORF stColor;
      /// <summary>辅助线宽度</summary>
      public uint nLineWidth;
      /// <summary>预留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>枚举类型指定条目信息</summary>
    public struct MVCC_ENUMENTRY
    {
      /// <summary>指定值</summary>
      public uint nValue;
      /// <summary>指定值对应的符号</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public byte[] chSymbolic;
      /// <summary>预留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>U3V流异常类型</summary>
    public enum MV_CC_STREAM_EXCEPTION_TYPE
    {
      /// <summary>异常的图像，该帧被丢弃</summary>
      MV_CC_STREAM_EXCEPTION_ABNORMAL_IMAGE = 16385, // 0x00004001
      /// <summary>缓存列表溢出，清除最旧的一帧</summary>
      MV_CC_STREAM_EXCEPTION_LIST_OVERFLOW = 16386, // 0x00004002
      /// <summary>缓存列表为空，该帧被丢弃</summary>
      MV_CC_STREAM_EXCEPTION_LIST_EMPTY = 16387, // 0x00004003
      /// <summary>断流恢复</summary>
      MV_CC_STREAM_EXCEPTION_RECONNECTION = 16388, // 0x00004004
      /// <summary>断流,恢复失败,取流被中止</summary>
      MV_CC_STREAM_EXCEPTION_DISCONNECTED = 16389, // 0x00004005
      /// <summary>设备异常,取流被中止</summary>
      MV_CC_STREAM_EXCEPTION_DEVICE = 16390, // 0x00004006
    }

    /// <summary>重构后的图像列表</summary>
    public struct MV_OUTPUT_IMAGE_INFO
    {
      /// <summary>源图像宽</summary>
      public uint nWidth;
      /// <summary>源图像高</summary>
      public uint nHeight;
      /// <summary>像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>输出数据缓存</summary>
      public IntPtr pBuf;
      /// <summary>输出数据长度</summary>
      public uint nBufLen;
      /// <summary>提供的输出缓冲区大小</summary>
      public uint nBufSize;
      /// <summary>预留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public uint[] nReserved;
    }

    /// <summary>分时曝光的图像处理方式</summary>
    public enum MV_IMAGE_RECONSTRUCTION_METHOD
    {
      /// <summary>源图像按行拆分成多张图像</summary>
      MV_SPLIT_BY_LINE = 1,
      /// <summary>源图像两行拆分成多张图像</summary>
      MV_SPLIT_BY_DOUBLE_LINES = 2,
    }

    /// <summary>重构图像参数信息</summary>
    public struct MV_RECONSTRUCT_IMAGE_PARAM
    {
      /// <summary>源图像宽</summary>
      public uint nWidth;
      /// <summary>源图像高</summary>
      public uint nHeight;
      /// <summary>像素格式</summary>
      public MvCCDll.MvGvspPixelType enPixelType;
      /// <summary>输入数据缓存</summary>
      public IntPtr pSrcData;
      /// <summary>输入数据长度</summary>
      public uint nSrcDataLen;
      /// <summary>曝光个数(1-8]</summary>
      public uint nExposureNum;
      /// <summary>图像重构方式</summary>
      public MvCCDll.MV_IMAGE_RECONSTRUCTION_METHOD enReconstructMethod;
      /// <summary>输出数据缓存信息</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
      public MvCCDll.MV_OUTPUT_IMAGE_INFO[] stDstBufList;
      /// <summary>预留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>串口信息 </summary>
    public struct MV_CAML_SERIAL_PORT
    {
      /// <summary>串口号</summary>
      [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
      public string strSerialPort;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>串口列表 </summary>
    public struct MV_CAML_SERIAL_PORT_LIST
    {
      /// <summary>串口数量</summary>
      public uint nSerialPortNum;
      /// <summary>串口信息</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
      public MvCCDll.MV_CAML_SERIAL_PORT[] stSerialPort;
      /// <summary>保留字节</summary>
      [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
      public uint[] nReserved;
    }

    /// <summary>像素格式定义</summary>
    public enum MvGvspPixelType
    {
      /// <summary>Jpeg</summary>
      PixelType_Gvsp_Jpeg = -2145910783, // 0x80180001
      /// <summary>HB_Mono8</summary>
      PixelType_Gvsp_HB_Mono8 = -2130182143, // 0x81080001
      /// <summary>HB_BayerGR8</summary>
      PixelType_Gvsp_HB_BayerGR8 = -2130182136, // 0x81080008
      /// <summary>HB_BayerRG8</summary>
      PixelType_Gvsp_HB_BayerRG8 = -2130182135, // 0x81080009
      /// <summary>HB_BayerGB8</summary>
      PixelType_Gvsp_HB_BayerGB8 = -2130182134, // 0x8108000A
      /// <summary>HB_BayerBG8</summary>
      PixelType_Gvsp_HB_BayerBG8 = -2130182133, // 0x8108000B
      /// <summary>HB_BayerRBGG8</summary>
      PixelType_Gvsp_HB_BayerRBGG8 = -2130182074, // 0x81080046
      /// <summary>HB_Mono10_Packed</summary>
      PixelType_Gvsp_HB_Mono10_Packed = -2129919996, // 0x810C0004
      /// <summary>HB_Mono12_Packed</summary>
      PixelType_Gvsp_HB_Mono12_Packed = -2129919994, // 0x810C0006
      /// <summary>HB_BayerGR10_Packed</summary>
      PixelType_Gvsp_HB_BayerGR10_Packed = -2129919962, // 0x810C0026
      /// <summary>HB_BayerRG10_Packed</summary>
      PixelType_Gvsp_HB_BayerRG10_Packed = -2129919961, // 0x810C0027
      /// <summary>HB_BayerGB10_Packed</summary>
      PixelType_Gvsp_HB_BayerGB10_Packed = -2129919960, // 0x810C0028
      /// <summary>HB_BayerBG10_Packed</summary>
      PixelType_Gvsp_HB_BayerBG10_Packed = -2129919959, // 0x810C0029
      /// <summary>HB_BayerGR12_Packed</summary>
      PixelType_Gvsp_HB_BayerGR12_Packed = -2129919958, // 0x810C002A
      /// <summary>HB_BayerRG12_Packed</summary>
      PixelType_Gvsp_HB_BayerRG12_Packed = -2129919957, // 0x810C002B
      /// <summary>HB_BayerGB12_Packed</summary>
      PixelType_Gvsp_HB_BayerGB12_Packed = -2129919956, // 0x810C002C
      /// <summary>HB_BayerBG12_Packed</summary>
      PixelType_Gvsp_HB_BayerBG12_Packed = -2129919955, // 0x810C002D
      /// <summary>HB_Mono10</summary>
      PixelType_Gvsp_HB_Mono10 = -2129657853, // 0x81100003
      /// <summary>HB_Mono12</summary>
      PixelType_Gvsp_HB_Mono12 = -2129657851, // 0x81100005
      /// <summary>HB_Mono16</summary>
      PixelType_Gvsp_HB_Mono16 = -2129657849, // 0x81100007
      /// <summary>HB_BayerGR10</summary>
      PixelType_Gvsp_HB_BayerGR10 = -2129657844, // 0x8110000C
      /// <summary>HB_BayerRG10</summary>
      PixelType_Gvsp_HB_BayerRG10 = -2129657843, // 0x8110000D
      /// <summary>HB_BayerGB10</summary>
      PixelType_Gvsp_HB_BayerGB10 = -2129657842, // 0x8110000E
      /// <summary>HB_BayerBG10</summary>
      PixelType_Gvsp_HB_BayerBG10 = -2129657841, // 0x8110000F
      /// <summary>HB_BayerGR12</summary>
      PixelType_Gvsp_HB_BayerGR12 = -2129657840, // 0x81100010
      /// <summary>HB_BayerRG12</summary>
      PixelType_Gvsp_HB_BayerRG12 = -2129657839, // 0x81100011
      /// <summary>HB_BayerGB12</summary>
      PixelType_Gvsp_HB_BayerGB12 = -2129657838, // 0x81100012
      /// <summary>HB_BayerBG12</summary>
      PixelType_Gvsp_HB_BayerBG12 = -2129657837, // 0x81100013
      /// <summary>Float32</summary>
      PixelType_Gvsp_Float32 = -2128609279, // 0x81200001
      /// <summary>Coord3D_A32</summary>
      PixelType_Gvsp_Coord3D_A32 = -2128596987, // 0x81203005
      /// <summary>Coord3D_C32</summary>
      PixelType_Gvsp_Coord3D_C32 = -2128596986, // 0x81203006
      /// <summary>HB_YUV422_Packed</summary>
      PixelType_Gvsp_HB_YUV422_Packed = -2112880609, // 0x8210001F
      /// <summary>HB_YUV422_YUYV_Packed</summary>
      PixelType_Gvsp_HB_YUV422_YUYV_Packed = -2112880590, // 0x82100032
      /// <summary>HB_RGB8_Packed</summary>
      PixelType_Gvsp_HB_RGB8_Packed = -2112356332, // 0x82180014
      /// <summary>HB_BGR8_Packed</summary>
      PixelType_Gvsp_HB_BGR8_Packed = -2112356331, // 0x82180015
      /// <summary>COORD3D_DEPTH_PLUS_MASK</summary>
      PixelType_Gvsp_COORD3D_DEPTH_PLUS_MASK = -2112094207, // 0x821C0001
      /// <summary>HB_RGBA8_Packed</summary>
      PixelType_Gvsp_HB_RGBA8_Packed = -2111832042, // 0x82200016
      /// <summary>HB_BGRA8_Packed</summary>
      PixelType_Gvsp_HB_BGRA8_Packed = -2111832041, // 0x82200017
      /// <summary>HB_RGB16_Packed</summary>
      PixelType_Gvsp_HB_RGB16_Packed = -2110783437, // 0x82300033
      /// <summary>HB_BGR16_Packed</summary>
      PixelType_Gvsp_HB_BGR16_Packed = -2110783413, // 0x8230004B
      /// <summary>HB_BGRA16_Packed</summary>
      PixelType_Gvsp_HB_BGRA16_Packed = -2109734831, // 0x82400051
      /// <summary>HB_RGBA16_Packed</summary>
      PixelType_Gvsp_HB_RGBA16_Packed = -2109734812, // 0x82400064
      /// <summary>Coord3D_AB32f</summary>
      PixelType_Gvsp_Coord3D_AB32f = -2109722622, // 0x82403002
      /// <summary>Coord3D_AB32</summary>
      PixelType_Gvsp_Coord3D_AB32 = -2109722621, // 0x82403003
      /// <summary>Coord3D_AC32</summary>
      PixelType_Gvsp_Coord3D_AC32 = -2109722620, // 0x82403004
      /// <summary>Coord3D_ABC32</summary>
      PixelType_Gvsp_Coord3D_ABC32 = -2107625471, // 0x82603001
      /// <summary>未定义像素格式</summary>
      PixelType_Gvsp_Undefined = -1, // 0xFFFFFFFF
      /// <summary>Mono1p</summary>
      PixelType_Gvsp_Mono1p = 16842807, // 0x01010037
      /// <summary>Mono2p</summary>
      PixelType_Gvsp_Mono2p = 16908344, // 0x01020038
      /// <summary>Mono4p</summary>
      PixelType_Gvsp_Mono4p = 17039417, // 0x01040039
      /// <summary>Mono8</summary>
      PixelType_Gvsp_Mono8 = 17301505, // 0x01080001
      /// <summary>Mono8_Signed</summary>
      PixelType_Gvsp_Mono8_Signed = 17301506, // 0x01080002
      /// <summary>BayerGR8</summary>
      PixelType_Gvsp_BayerGR8 = 17301512, // 0x01080008
      /// <summary>BayerRG8</summary>
      PixelType_Gvsp_BayerRG8 = 17301513, // 0x01080009
      /// <summary>BayerGB8</summary>
      PixelType_Gvsp_BayerGB8 = 17301514, // 0x0108000A
      /// <summary>BayerBG8</summary>
      PixelType_Gvsp_BayerBG8 = 17301515, // 0x0108000B
      /// <summary>BayerRBGG8</summary>
      PixelType_Gvsp_BayerRBGG8 = 17301574, // 0x01080046
      /// <summary>Mono10_Packed</summary>
      PixelType_Gvsp_Mono10_Packed = 17563652, // 0x010C0004
      /// <summary>Mono12_Packed</summary>
      PixelType_Gvsp_Mono12_Packed = 17563654, // 0x010C0006
      /// <summary>BayerGR10_Packed</summary>
      PixelType_Gvsp_BayerGR10_Packed = 17563686, // 0x010C0026
      /// <summary>BayerRG10_Packed</summary>
      PixelType_Gvsp_BayerRG10_Packed = 17563687, // 0x010C0027
      /// <summary>BayerGB10_Packed</summary>
      PixelType_Gvsp_BayerGB10_Packed = 17563688, // 0x010C0028
      /// <summary>BayerBG10_Packed</summary>
      PixelType_Gvsp_BayerBG10_Packed = 17563689, // 0x010C0029
      /// <summary>BayerGR12_Packed</summary>
      PixelType_Gvsp_BayerGR12_Packed = 17563690, // 0x010C002A
      /// <summary>BayerRG12_Packed</summary>
      PixelType_Gvsp_BayerRG12_Packed = 17563691, // 0x010C002B
      /// <summary>BayerGB12_Packed</summary>
      PixelType_Gvsp_BayerGB12_Packed = 17563692, // 0x010C002C
      /// <summary>BayerBG12_Packed</summary>
      PixelType_Gvsp_BayerBG12_Packed = 17563693, // 0x010C002D
      /// <summary>Mono10</summary>
      PixelType_Gvsp_Mono10 = 17825795, // 0x01100003
      /// <summary>Mono12</summary>
      PixelType_Gvsp_Mono12 = 17825797, // 0x01100005
      /// <summary>Mono16</summary>
      PixelType_Gvsp_Mono16 = 17825799, // 0x01100007
      /// <summary>BayerGR10</summary>
      PixelType_Gvsp_BayerGR10 = 17825804, // 0x0110000C
      /// <summary>BayerRG10</summary>
      PixelType_Gvsp_BayerRG10 = 17825805, // 0x0110000D
      /// <summary>BayerGB10</summary>
      PixelType_Gvsp_BayerGB10 = 17825806, // 0x0110000E
      /// <summary>BayerBG10</summary>
      PixelType_Gvsp_BayerBG10 = 17825807, // 0x0110000F
      /// <summary>BayerGR12</summary>
      PixelType_Gvsp_BayerGR12 = 17825808, // 0x01100010
      /// <summary>BayerRG12</summary>
      PixelType_Gvsp_BayerRG12 = 17825809, // 0x01100011
      /// <summary>BayerGB12</summary>
      PixelType_Gvsp_BayerGB12 = 17825810, // 0x01100012
      /// <summary>BayerBG12</summary>
      PixelType_Gvsp_BayerBG12 = 17825811, // 0x01100013
      /// <summary>Mono14</summary>
      PixelType_Gvsp_Mono14 = 17825829, // 0x01100025
      /// <summary>BayerGR16</summary>
      PixelType_Gvsp_BayerGR16 = 17825838, // 0x0110002E
      /// <summary>BayerRG16</summary>
      PixelType_Gvsp_BayerRG16 = 17825839, // 0x0110002F
      /// <summary>BayerGB16</summary>
      PixelType_Gvsp_BayerGB16 = 17825840, // 0x01100030
      /// <summary>BayerBG16</summary>
      PixelType_Gvsp_BayerBG16 = 17825841, // 0x01100031
      /// <summary>Coord3D_C16</summary>
      PixelType_Gvsp_Coord3D_C16 = 17825976, // 0x011000B8
      /// <summary>Coord3D_A32f</summary>
      PixelType_Gvsp_Coord3D_A32f = 18874557, // 0x012000BD
      /// <summary>Coord3D_C32f</summary>
      PixelType_Gvsp_Coord3D_C32f = 18874559, // 0x012000BF
      /// <summary>YUV411_Packed</summary>
      PixelType_Gvsp_YUV411_Packed = 34340894, // 0x020C001E
      /// <summary>YCBCR411_8_CBYYCRYY</summary>
      PixelType_Gvsp_YCBCR411_8_CBYYCRYY = 34340924, // 0x020C003C
      /// <summary>YCBCR601_411_8_CBYYCRYY</summary>
      PixelType_Gvsp_YCBCR601_411_8_CBYYCRYY = 34340927, // 0x020C003F
      /// <summary>YCBCR709_411_8_CBYYCRYY</summary>
      PixelType_Gvsp_YCBCR709_411_8_CBYYCRYY = 34340930, // 0x020C0042
      /// <summary>YUV420SP_NV12</summary>
      PixelType_Gvsp_YUV420SP_NV12 = 34373633, // 0x020C8001
      /// <summary>YUV420SP_NV21</summary>
      PixelType_Gvsp_YUV420SP_NV21 = 34373634, // 0x020C8002
      /// <summary>YUV422_Packed</summary>
      PixelType_Gvsp_YUV422_Packed = 34603039, // 0x0210001F
      /// <summary>YUV422_YUYV_Packed</summary>
      PixelType_Gvsp_YUV422_YUYV_Packed = 34603058, // 0x02100032
      /// <summary>RGB565_Packed</summary>
      PixelType_Gvsp_RGB565_Packed = 34603061, // 0x02100035
      /// <summary>BGR565_Packed</summary>
      PixelType_Gvsp_BGR565_Packed = 34603062, // 0x02100036
      /// <summary>YCBCR422_8</summary>
      PixelType_Gvsp_YCBCR422_8 = 34603067, // 0x0210003B
      /// <summary>YCBCR601_422_8</summary>
      PixelType_Gvsp_YCBCR601_422_8 = 34603070, // 0x0210003E
      /// <summary>YCBCR709_422_8</summary>
      PixelType_Gvsp_YCBCR709_422_8 = 34603073, // 0x02100041
      /// <summary>YCBCR422_8_CBYCRY</summary>
      PixelType_Gvsp_YCBCR422_8_CBYCRY = 34603075, // 0x02100043
      /// <summary>YCBCR601_422_8_CBYCRY</summary>
      PixelType_Gvsp_YCBCR601_422_8_CBYCRY = 34603076, // 0x02100044
      /// <summary>YCBCR709_422_8_CBYCRY</summary>
      PixelType_Gvsp_YCBCR709_422_8_CBYCRY = 34603077, // 0x02100045
      /// <summary>RGB8_Packed</summary>
      PixelType_Gvsp_RGB8_Packed = 35127316, // 0x02180014
      /// <summary>BGR8_Packed</summary>
      PixelType_Gvsp_BGR8_Packed = 35127317, // 0x02180015
      /// <summary>YUV444_Packed</summary>
      PixelType_Gvsp_YUV444_Packed = 35127328, // 0x02180020
      /// <summary>RGB8_Planar</summary>
      PixelType_Gvsp_RGB8_Planar = 35127329, // 0x02180021
      /// <summary>YCBCR8_CBYCR</summary>
      PixelType_Gvsp_YCBCR8_CBYCR = 35127354, // 0x0218003A
      /// <summary>YCBCR601_8_CBYCR</summary>
      PixelType_Gvsp_YCBCR601_8_CBYCR = 35127357, // 0x0218003D
      /// <summary>YCBCR709_8_CBYCR</summary>
      PixelType_Gvsp_YCBCR709_8_CBYCR = 35127360, // 0x02180040
      /// <summary>RGBA8_Packed</summary>
      PixelType_Gvsp_RGBA8_Packed = 35651606, // 0x02200016
      /// <summary>BGRA8_Packed</summary>
      PixelType_Gvsp_BGRA8_Packed = 35651607, // 0x02200017
      /// <summary>RGB10V1_Packe</summary>
      PixelType_Gvsp_RGB10V1_Packed = 35651612, // 0x0220001C
      /// <summary>RGB10V2_Packed</summary>
      PixelType_Gvsp_RGB10V2_Packed = 35651613, // 0x0220001D
      /// <summary>RGB12V1_Packed</summary>
      PixelType_Gvsp_RGB12V1_Packed = 35913780, // 0x02240034
      /// <summary>RGB10_Packed</summary>
      PixelType_Gvsp_RGB10_Packed = 36700184, // 0x02300018
      /// <summary>BGR10_Packed</summary>
      PixelType_Gvsp_BGR10_Packed = 36700185, // 0x02300019
      /// <summary>RGB12_Packed</summary>
      PixelType_Gvsp_RGB12_Packed = 36700186, // 0x0230001A
      /// <summary>BGR12_Packed</summary>
      PixelType_Gvsp_BGR12_Packed = 36700187, // 0x0230001B
      /// <summary>RGB10_Planar</summary>
      PixelType_Gvsp_RGB10_Planar = 36700194, // 0x02300022
      /// <summary>RGB12_Planar</summary>
      PixelType_Gvsp_RGB12_Planar = 36700195, // 0x02300023
      /// <summary>RGB16_Planar</summary>
      PixelType_Gvsp_RGB16_Planar = 36700196, // 0x02300024
      /// <summary>RGB16_Packed</summary>
      PixelType_Gvsp_RGB16_Packed = 36700211, // 0x02300033
      /// <summary>BGR16_Packed/// </summary>
      PixelType_Gvsp_BGR16_Packed = 36700235, // 0x0230004B
      /// <summary>Coord3D_ABC16</summary>
      PixelType_Gvsp_Coord3D_ABC16 = 36700345, // 0x023000B9
      /// <summary>RGBA16_Packed</summary>
      PixelType_Gvsp_RGBA16_Packed = 37748800, // 0x02400040
      /// <summary>BGRA16_Packed</summary>
      PixelType_Gvsp_BGRA16_Packed = 37748817, // 0x02400051
      /// <summary>Coord3D_AC32f</summary>
      PixelType_Gvsp_Coord3D_AC32f = 37748930, // 0x024000C2
      /// <summary>Coord3D_AC32f_64</summary>
      PixelType_Gvsp_Coord3D_AC32f_64 = 37748930, // 0x024000C2
      /// <summary>Coord3D_AC32f_Planar</summary>
      PixelType_Gvsp_Coord3D_AC32f_Planar = 37748931, // 0x024000C3
      /// <summary>Coord3D_ABC32f</summary>
      PixelType_Gvsp_Coord3D_ABC32f = 39846080, // 0x026000C0
      /// <summary>Coord3D_ABC32f_Planar</summary>
      PixelType_Gvsp_Coord3D_ABC32f_Planar = 39846081, // 0x026000C1
    }
  }
}
