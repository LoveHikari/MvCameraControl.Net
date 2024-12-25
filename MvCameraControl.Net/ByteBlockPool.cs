// Decompiled with JetBrains decompiler
// Type: MvCameraControl.ByteBlockPool
// Assembly: MvCameraControl.Net, Version=4.4.1.3, Culture=neutral, PublicKeyToken=a3c7c5e3a730cd12
// MVID: 732C6CBB-113A-494B-B026-2AA15BBA112D
// Assembly location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.dll
// XML documentation location: D:\project\72fa_mid\WpfApp1\bin\Debug\net9.0-windows\MvCameraControl.Net.xml

using System;
using System.Collections.Generic;
using System.Timers;

#nullable disable
namespace MvCameraControl
{
  /// <summary>内存池</summary>
  internal class ByteBlockPool
  {
    private const int _LOHMinSize = 85000;
    private const int _blockFlag = 153;
    private const double _maxIdleTime = 10000.0;
    private const double _timeInterval = 1000.0;
    private Dictionary<long, LinkedList<ByteBlock>> _idleBlockDict;
    private DateTime _utcTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
    private System.Timers.Timer _timer;
    private volatile bool _isClosed;

    public ByteBlockPool() => this._idleBlockDict = new Dictionary<long, LinkedList<ByteBlock>>();

    /// <summary>关闭内存池，清空内部缓存</summary>
    public void ClosePool()
    {
      lock (this)
      {
        this._idleBlockDict.Clear();
        if (this._timer != null)
        {
          this._timer.Close();
          this._timer = (System.Timers.Timer) null;
        }
        this._isClosed = true;
      }
    }

    public ByteBlock GetByteBlock(long needSize)
    {
      if (needSize < 85000L)
        needSize = 85000L;
      ByteBlock byteBlock = (ByteBlock) null;
      lock (this)
      {
        if (this._isClosed)
          return new ByteBlock(needSize);
        if (this._idleBlockDict.ContainsKey(needSize))
        {
          LinkedList<ByteBlock> linkedList = this._idleBlockDict[needSize];
          byteBlock = linkedList.First.Value;
          linkedList.RemoveFirst();
          if (linkedList.Count == 0)
            this._idleBlockDict.Remove(needSize);
        }
      }
      if (byteBlock == null)
        byteBlock = new ByteBlock(needSize, 153);
      TimeSpan timeSpan = DateTime.UtcNow - this._utcTime;
      byteBlock.RentTime = timeSpan.TotalMilliseconds;
      byteBlock.ReturnTime = 0.0;
      return byteBlock;
    }

    /// <summary>归还内存块到内存池</summary>
    /// <param name="byteBlock">内存块</param>
    /// <param name="isDispose">是否手动释放</param>
    public void FreeByteBlock(ByteBlock byteBlock, bool isDispose)
    {
      if (!isDispose || byteBlock.Flag != 153)
        return;
      TimeSpan timeSpan = DateTime.UtcNow - this._utcTime;
      byteBlock.ReturnTime = timeSpan.TotalMilliseconds;
      byteBlock.RentTime = 0.0;
      lock (this)
      {
        if (this._isClosed)
          return;
        if (this._idleBlockDict.ContainsKey(byteBlock.Length))
        {
          this._idleBlockDict[byteBlock.Length].AddFirst(byteBlock);
        }
        else
        {
          LinkedList<ByteBlock> linkedList = new LinkedList<ByteBlock>();
          linkedList.AddFirst(byteBlock);
          this._idleBlockDict[byteBlock.Length] = linkedList;
        }
        if (this._timer == null)
        {
          this._timer = new System.Timers.Timer(1000.0);
          this._timer.Elapsed += new ElapsedEventHandler(this.OnTimedEvent);
          this._timer.AutoReset = true;
        }
        if (this._timer.Enabled)
          return;
        this._timer.Enabled = true;
      }
    }

    private void OnTimedEvent(object sender, ElapsedEventArgs e)
    {
      TimeSpan timeSpan = DateTime.UtcNow - this._utcTime;
      lock (this)
      {
        this.UpdateBlockList(timeSpan.TotalMilliseconds);
        if (this._idleBlockDict.Count != 0)
          return;
        this._timer.Enabled = false;
      }
    }

    /// <summary>更新内存块列表，释放过期内存。方法内部不加锁</summary>
    /// <param name="timesNow"></param>
    private void UpdateBlockList(double timesNow)
    {
      List<long> longList = new List<long>();
      foreach (KeyValuePair<long, LinkedList<ByteBlock>> keyValuePair in this._idleBlockDict)
      {
        this.UpdateBlockListByIdleTime(keyValuePair.Value, timesNow);
        if (keyValuePair.Value.Count == 0)
          longList.Add(keyValuePair.Key);
      }
      foreach (long key in longList)
        this._idleBlockDict.Remove(key);
    }

    /// <summary>更新内存块的空闲时间并删除过期内存块。 方法内部不加锁</summary>
    /// <param name="blockList"></param>
    /// <param name="timesNow"></param>
    private void UpdateBlockListByIdleTime(LinkedList<ByteBlock> blockList, double timesNow)
    {
      LinkedList<ByteBlock> linkedList = new LinkedList<ByteBlock>();
      foreach (ByteBlock block in blockList)
      {
        if (timesNow - block.ReturnTime > 10000.0)
          linkedList.AddLast(block);
      }
      foreach (ByteBlock byteBlock in linkedList)
        blockList.Remove(byteBlock);
      linkedList.Clear();
    }

    /// <summary>打印统计信息</summary>
    private void PrintPoolBlockStatics()
    {
      if (this._idleBlockDict.Count == 0)
      {
        Console.WriteLine("IdleBlockDict: No blocks");
      }
      else
      {
        foreach (KeyValuePair<long, LinkedList<ByteBlock>> keyValuePair in this._idleBlockDict)
        {
          uint num1 = 0;
          ulong num2 = 0;
          foreach (ByteBlock byteBlock in keyValuePair.Value)
          {
            ++num1;
            num2 += (ulong) byteBlock.Length;
          }
          Console.WriteLine("PrintPoolBlockStatics: IdleBlockDict: Length[{0}], BlockCount[{1}], TotoalBytes[{2}]", (object) keyValuePair.Key, (object) num1, (object) num2);
        }
      }
    }
  }
}
