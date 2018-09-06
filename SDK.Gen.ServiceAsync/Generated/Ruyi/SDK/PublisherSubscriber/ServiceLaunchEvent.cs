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


namespace Ruyi.SDK.PublisherSubscriber
{

  /// <summary>
  /// The event will be fired when service state changed.
  /// </summary>
  public partial class ServiceLaunchEvent : TBase
  {
    private int _EventType;
    private string _LastServiceID;

    /// <summary>
    /// The event type.
    /// </summary>
    public int EventType
    {
      get
      {
        return _EventType;
      }
      set
      {
        __isset.EventType = true;
        this._EventType = value;
      }
    }

    /// <summary>
    /// The last service that cause the state change.
    /// </summary>
    public string LastServiceID
    {
      get
      {
        return _LastServiceID;
      }
      set
      {
        __isset.LastServiceID = true;
        this._LastServiceID = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool EventType;
      public bool LastServiceID;
    }

    public ServiceLaunchEvent()
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
                EventType = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                LastServiceID = await iprot.ReadStringAsync(cancellationToken);
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
        var struc = new TStruct("ServiceLaunchEvent");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (__isset.EventType)
        {
          field.Name = "EventType";
          field.Type = TType.I32;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(EventType, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (LastServiceID != null && __isset.LastServiceID)
        {
          field.Name = "LastServiceID";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(LastServiceID, cancellationToken);
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
      var sb = new StringBuilder("ServiceLaunchEvent(");
      bool __first = true;
      if (__isset.EventType)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("EventType: ");
        sb.Append(EventType);
      }
      if (LastServiceID != null && __isset.LastServiceID)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("LastServiceID: ");
        sb.Append(LastServiceID);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
