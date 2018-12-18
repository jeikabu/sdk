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


namespace Ruyi.SDK.BrainCloudApi
{

  /// <summary>
  /// @FileUploadFailedResult_desc
  /// </summary>
  public partial class FileUploadFailedResult : TBase
  {
    private string _fileUploadId;
    private int _statusCode;
    private int _reasonCode;
    private string _jsonResponse;

    /// <summary>
    /// @FileUploadFailedResult_fileUploadId_desc
    /// </summary>
    public string FileUploadId
    {
      get
      {
        return _fileUploadId;
      }
      set
      {
        __isset.fileUploadId = true;
        this._fileUploadId = value;
      }
    }

    /// <summary>
    /// @FileUploadFailedResult_statusCode_desc
    /// </summary>
    public int StatusCode
    {
      get
      {
        return _statusCode;
      }
      set
      {
        __isset.statusCode = true;
        this._statusCode = value;
      }
    }

    /// <summary>
    /// @FileUploadFailedResult_reasonCode_desc
    /// </summary>
    public int ReasonCode
    {
      get
      {
        return _reasonCode;
      }
      set
      {
        __isset.reasonCode = true;
        this._reasonCode = value;
      }
    }

    /// <summary>
    /// @FileUploadFailedResult_jsonResponse_desc
    /// </summary>
    public string JsonResponse
    {
      get
      {
        return _jsonResponse;
      }
      set
      {
        __isset.jsonResponse = true;
        this._jsonResponse = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool fileUploadId;
      public bool statusCode;
      public bool reasonCode;
      public bool jsonResponse;
    }

    public FileUploadFailedResult()
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
                FileUploadId = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I32)
              {
                StatusCode = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                ReasonCode = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                JsonResponse = await iprot.ReadStringAsync(cancellationToken);
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
        var struc = new TStruct("FileUploadFailedResult");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (FileUploadId != null && __isset.fileUploadId)
        {
          field.Name = "fileUploadId";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(FileUploadId, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.statusCode)
        {
          field.Name = "statusCode";
          field.Type = TType.I32;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(StatusCode, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.reasonCode)
        {
          field.Name = "reasonCode";
          field.Type = TType.I32;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(ReasonCode, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (JsonResponse != null && __isset.jsonResponse)
        {
          field.Name = "jsonResponse";
          field.Type = TType.String;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(JsonResponse, cancellationToken);
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
      var sb = new StringBuilder("FileUploadFailedResult(");
      bool __first = true;
      if (FileUploadId != null && __isset.fileUploadId)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("FileUploadId: ");
        sb.Append(FileUploadId);
      }
      if (__isset.statusCode)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("StatusCode: ");
        sb.Append(StatusCode);
      }
      if (__isset.reasonCode)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("ReasonCode: ");
        sb.Append(ReasonCode);
      }
      if (JsonResponse != null && __isset.jsonResponse)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("JsonResponse: ");
        sb.Append(JsonResponse);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
