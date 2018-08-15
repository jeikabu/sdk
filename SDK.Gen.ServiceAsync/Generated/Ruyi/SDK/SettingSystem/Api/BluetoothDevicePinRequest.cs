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


namespace Ruyi.SDK.SettingSystem.Api
{

  public partial class BluetoothDevicePinRequest : TBase
  {
    private string _DeviceName;
    private string _Pin;

    public string DeviceName
    {
      get
      {
        return _DeviceName;
      }
      set
      {
        __isset.DeviceName = true;
        this._DeviceName = value;
      }
    }

    public string Pin
    {
      get
      {
        return _Pin;
      }
      set
      {
        __isset.Pin = true;
        this._Pin = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool DeviceName;
      public bool Pin;
    }

    public BluetoothDevicePinRequest()
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
              if (field.Type == TType.String)
              {
                DeviceName = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Pin = await iprot.ReadStringAsync(cancellationToken);
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
        var struc = new TStruct("BluetoothDevicePinRequest");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (DeviceName != null && __isset.DeviceName)
        {
          field.Name = "DeviceName";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(DeviceName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Pin != null && __isset.Pin)
        {
          field.Name = "Pin";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Pin, cancellationToken);
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
      var sb = new StringBuilder("BluetoothDevicePinRequest(");
      bool __first = true;
      if (DeviceName != null && __isset.DeviceName)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("DeviceName: ");
        sb.Append(DeviceName);
      }
      if (Pin != null && __isset.Pin)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Pin: ");
        sb.Append(Pin);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
