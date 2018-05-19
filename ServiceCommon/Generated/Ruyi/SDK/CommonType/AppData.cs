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

  public partial class AppData : TBase
  {
    private string _appId;
    private List<AppDataCollection> _data;

    /// <summary>
    /// The App ID
    /// </summary>
    public string AppId
    {
      get
      {
        return _appId;
      }
      set
      {
        __isset.appId = true;
        this._appId = value;
      }
    }

    /// <summary>
    /// The user data of the App. See AppDataCollection
    /// </summary>
    public List<AppDataCollection> Data
    {
      get
      {
        return _data;
      }
      set
      {
        __isset.data = true;
        this._data = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool appId;
      public bool data;
    }

    public AppData()
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
                AppId = await iprot.ReadStringAsync(cancellationToken);
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
                  Data = new List<AppDataCollection>();
                  TList _list33 = await iprot.ReadListBeginAsync(cancellationToken);
                  for(int _i34 = 0; _i34 < _list33.Count; ++_i34)
                  {
                    AppDataCollection _elem35;
                    _elem35 = new AppDataCollection();
                    await _elem35.ReadAsync(iprot, cancellationToken);
                    Data.Add(_elem35);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
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
        var struc = new TStruct("AppData");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (AppId != null && __isset.appId)
        {
          field.Name = "appId";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(AppId, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Data != null && __isset.data)
        {
          field.Name = "data";
          field.Type = TType.List;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Data.Count), cancellationToken);
            foreach (AppDataCollection _iter36 in Data)
            {
              await _iter36.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
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
      var sb = new StringBuilder("AppData(");
      bool __first = true;
      if (AppId != null && __isset.appId)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("AppId: ");
        sb.Append(AppId);
      }
      if (Data != null && __isset.data)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Data: ");
        sb.Append(Data);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
