// Decompiled with JetBrains decompiler
// Type: MvCameraControl.MvError
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

#nullable disable
namespace MvCameraControl
{
  /// <summary>错误码定义</summary>
  public static class MvError
  {
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
  }
}
