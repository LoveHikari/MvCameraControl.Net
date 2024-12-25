// Decompiled with JetBrains decompiler
// Type: MvCameraControl.IParameters
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System.Collections.Generic;

#nullable disable
namespace MvCameraControl
{
  /// <summary>提供设备参数配置相关接口</summary>
  public interface IParameters
  {
    /// <summary>清除GenICam节点缓存</summary>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>在加载工业相机节点时需要读取GenICam配置文件，该接口可以起到清除GenICam缓存的功能。</remarks>
    int InvalidateNodes();

    /// <summary>获取Integer属性值</summary>
    /// <param name="key">属性键值，如获取宽度信息则为"Width" </param>
    /// <param name="value">属性值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetIntValue(string key, out IIntValue value);

    /// <summary>设置Integer型属性值</summary>
    /// <param name="key">属性键值，如设置宽度信息则为"Width" </param>
    /// <param name="value">属性值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetIntValue(string key, long value);

    /// <summary>获取Enumeration属性值</summary>
    /// <param name="key">属性键值，如获取像素格式信息则为"PixelFormat" </param>
    /// <param name="value">属性值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetEnumValue(string key, out IEnumValue value);

    /// <summary>设置Enumeration属性值</summary>
    /// <param name="key">属性键值，如设置像素格式信息则为"PixelFormat" </param>
    /// <param name="value">Enum型节点的值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetEnumValue(string key, uint value);

    /// <summary>设置Enumeration属性</summary>
    /// <param name="key">属性键值，如设置像素格式信息则为"PixelFormat" </param>
    /// <param name="value">EnumEntry的名称</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetEnumValueByString(string key, string value);

    /// <summary>获取Float属性值</summary>
    /// <param name="key">属性键值</param>
    /// <param name="value">属性值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetFloatValue(string key, out IFloatValue value);

    /// <summary>设置Float型属性值</summary>
    /// <param name="key">属性键值</param>
    /// <param name="value">属性值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetFloatValue(string key, float value);

    /// <summary>获取Boolean属性值</summary>
    /// <param name="key">属性键值</param>
    /// <param name="value">属性值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetBoolValue(string key, out bool value);

    /// <summary>设置Boolean型属性值</summary>
    /// <param name="key">属性键值</param>
    /// <param name="value">属性值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetBoolValue(string key, bool value);

    /// <summary>获取String属性值</summary>
    /// <param name="key">属性键值</param>
    /// <param name="value">属性值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetStringValue(string key, out IStringValue value);

    /// <summary>设置String型属性值</summary>
    /// <param name="key">属性键值</param>
    /// <param name="value">属性值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetStringValue(string key, string value);

    /// <summary>设置Command型属性值</summary>
    /// <param name="key">属性键值</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int SetCommandValue(string key);

    /// <summary>导入设备属性文件</summary>
    /// <param name="filePath">文件路径</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int FeatureLoad(string filePath);

    /// <summary>导入设备属性文件并保存错误信息列表</summary>
    /// <param name="filePath">文件路径</param>
    /// <param name="nodeErrors">导入失败的节点信息</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>部分节点导入失败时也会返回MV_OK，通过nodeErrors返回导入失败的节点及错误原因</remarks>
    int FeatureLoadEx(string filePath, out List<INodeError> nodeErrors);

    /// <summary>保存设备属性到文件</summary>
    /// <param name="filePath">文件路径</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int FeatureSave(string filePath);

    /// <summary>通过设备寄存器地址读取寄存器</summary>
    /// <param name="address">待读取的内存地址，该地址可以从设备的Camera.xml文件中获取，形如xxx_RegAddr的xml节点值 </param>
    /// <param name="length">待读取的内存长度 </param>
    /// <param name="buffer">存放读到的内存值（GEV设备内存值是按照大端模式存储的，其它协议设备按照小端存储）</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>访问设备，读取某段寄存器的数据。</remarks>
    int ReadMemory(long address, long length, out byte[] buffer);

    /// <summary>通过设备寄存器地址写寄存器</summary>
    /// <param name="address">待写入的内存地址，该地址可以从设备的Camera.xml文件中获取，形如xxx_RegAddr的xml节点值</param>
    /// <param name="length">待写入的内存长度 </param>
    /// <param name="buffer">待写入的内存值（注意GEV设备内存值要按照大端模式存储，其它协议设备按照小端存储）</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    /// <remarks>访问设备，把一段数据写入某段寄存器。</remarks>
    int WriteMemory(long address, long length, byte[] buffer);

    /// <summary>获取设备属性树XML</summary>
    /// <param name="xmlData">设备xml</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetGenICamXML(out string xmlData);

    /// <summary>获得当前节点的访问模式</summary>
    /// <param name="name">节点名称</param>
    /// <param name="mode">节点的访问模式</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetNodeAccessMode(string name, out XmlAccessMode mode);

    /// <summary>获得当前节点的类型</summary>
    /// <param name="name">节点名称</param>
    /// <param name="type">节点类型</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetNodeInterfaceType(string name, out XmlInterfaceType type);

    /// <summary>从设备读取文件，保存为本地文件</summary>
    /// <param name="deviceFileName">设备文件名</param>
    /// <param name="localFilePath">本地文件路径</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int FileAccessRead(string deviceFileName, string localFilePath);

    /// <summary>从设备读取文件，保存在内存</summary>
    /// <param name="devFileName">设备文件名</param>
    /// <param name="buffer">缓存</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int FileAccessRead(string devFileName, out byte[] buffer);

    /// <summary>将文件写入设备</summary>
    /// <param name="deviceFileName">设备文件名</param>
    /// <param name="localFilePath">本地文件路径</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int FileAccessWrite(string deviceFileName, string localFilePath);

    /// <summary>将内存中的文件写入设备</summary>
    /// <param name="devFileName">设备文件名</param>
    /// <param name="buffer">缓存</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int FileAccessWrite(string devFileName, byte[] buffer);

    /// <summary>获取文件存取的进度</summary>
    /// <param name="completed">已完成的长度</param>
    /// <param name="total">总长度</param>
    /// <returns>成功，返回MV_OK；失败，返回错误码</returns>
    int GetFileAccessProgress(out long completed, out long total);
  }
}
