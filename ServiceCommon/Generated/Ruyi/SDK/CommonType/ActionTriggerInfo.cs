/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocols;
using Thrift.Protocols.Entities;
using Thrift.Protocols.Utilities;
using Thrift.Transports;
using Thrift.Transports.Client;
using Thrift.Transports.Server;


namespace Ruyi.SDK.CommonType
{

  public partial class ActionTriggerInfo : TBase
  {
    private InputCagetory _InputCagetory;
    private List<InputIdentifier> _TriggerConditions;
    private bool _AutoTrigger;
    private int _TriggerInterval;

    /// <summary>
    /// 
    /// <seealso cref="InputCagetory"/>
    /// </summary>
    public InputCagetory InputCagetory
    {
      get
      {
        return _InputCagetory;
      }
      set
      {
        __isset.InputCagetory = true;
        this._InputCagetory = value;
      }
    }

    public List<InputIdentifier> TriggerConditions
    {
      get
      {
        return _TriggerConditions;
      }
      set
      {
        __isset.TriggerConditions = true;
        this._TriggerConditions = value;
      }
    }

    public bool AutoTrigger
    {
      get
      {
        return _AutoTrigger;
      }
      set
      {
        __isset.AutoTrigger = true;
        this._AutoTrigger = value;
      }
    }

    public int TriggerInterval
    {
      get
      {
        return _TriggerInterval;
      }
      set
      {
        __isset.TriggerInterval = true;
        this._TriggerInterval = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool InputCagetory;
      public bool TriggerConditions;
      public bool AutoTrigger;
      public bool TriggerInterval;
    }

    public ActionTriggerInfo()
    {
    }

    public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                InputCagetory = (InputCagetory)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TriggerConditions = new List<InputIdentifier>();
                  TList _list0 = await iprot.ReadListBeginAsync(cancellationToken);
                  for(int _i1 = 0; _i1 < _list0.Count; ++_i1)
                  {
                    InputIdentifier _elem2;
                    _elem2 = new InputIdentifier();
                    await _elem2.ReadAsync(iprot, cancellationToken);
                    TriggerConditions.Add(_elem2);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Bool)
              {
                AutoTrigger = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I32)
              {
                TriggerInterval = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var struc = new TStruct("ActionTriggerInfo");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (__isset.InputCagetory)
        {
          field.Name = "InputCagetory";
          field.Type = TType.I32;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async((int)InputCagetory, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (TriggerConditions != null && __isset.TriggerConditions)
        {
          field.Name = "TriggerConditions";
          field.Type = TType.List;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, TriggerConditions.Count), cancellationToken);
            foreach (InputIdentifier _iter3 in TriggerConditions)
            {
              await _iter3.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.AutoTrigger)
        {
          field.Name = "AutoTrigger";
          field.Type = TType.Bool;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBoolAsync(AutoTrigger, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.TriggerInterval)
        {
          field.Name = "TriggerInterval";
          field.Type = TType.I32;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(TriggerInterval, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString()
    {
      var sb = new StringBuilder("ActionTriggerInfo(");
      bool __first = true;
      if (__isset.InputCagetory)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("InputCagetory: ");
        sb.Append(InputCagetory);
      }
      if (TriggerConditions != null && __isset.TriggerConditions)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("TriggerConditions: ");
        sb.Append(TriggerConditions);
      }
      if (__isset.AutoTrigger)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("AutoTrigger: ");
        sb.Append(AutoTrigger);
      }
      if (__isset.TriggerInterval)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("TriggerInterval: ");
        sb.Append(TriggerInterval);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
