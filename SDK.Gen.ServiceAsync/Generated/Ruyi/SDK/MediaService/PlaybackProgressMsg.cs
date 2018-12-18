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


namespace Ruyi.SDK.MediaService
{

  /// <summary>
  /// @PlaybackProgressMsg_desc
  /// </summary>
  public partial class PlaybackProgressMsg : TBase
  {
    private string _url;
    private double _CurrentTime;
    private double _TotalTime;

    /// <summary>
    /// @PlaybackProgressMsg_url_desc
    /// </summary>
    public string Url
    {
      get
      {
        return _url;
      }
      set
      {
        __isset.url = true;
        this._url = value;
      }
    }

    /// <summary>
    /// @PlaybackProgressMsg_CurrentTime_desc
    /// </summary>
    public double CurrentTime
    {
      get
      {
        return _CurrentTime;
      }
      set
      {
        __isset.CurrentTime = true;
        this._CurrentTime = value;
      }
    }

    /// <summary>
    /// @PlaybackProgressMsg_TotalTime_desc
    /// </summary>
    public double TotalTime
    {
      get
      {
        return _TotalTime;
      }
      set
      {
        __isset.TotalTime = true;
        this._TotalTime = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool url;
      public bool CurrentTime;
      public bool TotalTime;
    }

    public PlaybackProgressMsg()
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
                Url = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Double)
              {
                CurrentTime = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Double)
              {
                TotalTime = await iprot.ReadDoubleAsync(cancellationToken);
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
        var struc = new TStruct("PlaybackProgressMsg");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (Url != null && __isset.url)
        {
          field.Name = "url";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Url, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.CurrentTime)
        {
          field.Name = "CurrentTime";
          field.Type = TType.Double;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteDoubleAsync(CurrentTime, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.TotalTime)
        {
          field.Name = "TotalTime";
          field.Type = TType.Double;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteDoubleAsync(TotalTime, cancellationToken);
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
      var sb = new StringBuilder("PlaybackProgressMsg(");
      bool __first = true;
      if (Url != null && __isset.url)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Url: ");
        sb.Append(Url);
      }
      if (__isset.CurrentTime)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("CurrentTime: ");
        sb.Append(CurrentTime);
      }
      if (__isset.TotalTime)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("TotalTime: ");
        sb.Append(TotalTime);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
