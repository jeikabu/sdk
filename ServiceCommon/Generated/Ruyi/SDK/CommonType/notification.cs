/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ruyi.SDK.CommonType
{

  /// <summary>
  /// @notification_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class notification : TBase
  {
    private string _title;
    private string _detail;
    private List<string> _option;

    /// <summary>
    /// @notification_title_desc
    /// </summary>
    public string Title
    {
      get
      {
        return _title;
      }
      set
      {
        __isset.title = true;
        this._title = value;
      }
    }

    /// <summary>
    /// @notification_detail_desc
    /// </summary>
    public string Detail
    {
      get
      {
        return _detail;
      }
      set
      {
        __isset.detail = true;
        this._detail = value;
      }
    }

    /// <summary>
    /// @notification_option_desc
    /// </summary>
    public List<string> Option
    {
      get
      {
        return _option;
      }
      set
      {
        __isset.option = true;
        this._option = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool title;
      public bool detail;
      public bool option;
    }

    public notification() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Title = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Detail = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.List) {
                {
                  Option = new List<string>();
                  TList _list8 = iprot.ReadListBegin();
                  for( int _i9 = 0; _i9 < _list8.Count; ++_i9)
                  {
                    string _elem10;
                    _elem10 = iprot.ReadString();
                    Option.Add(_elem10);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("notification");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Title != null && __isset.title) {
          field.Name = "title";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Title);
          oprot.WriteFieldEnd();
        }
        if (Detail != null && __isset.detail) {
          field.Name = "detail";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Detail);
          oprot.WriteFieldEnd();
        }
        if (Option != null && __isset.option) {
          field.Name = "option";
          field.Type = TType.List;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.String, Option.Count));
            foreach (string _iter11 in Option)
            {
              oprot.WriteString(_iter11);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("notification(");
      bool __first = true;
      if (Title != null && __isset.title) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Title: ");
        __sb.Append(Title);
      }
      if (Detail != null && __isset.detail) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Detail: ");
        __sb.Append(Detail);
      }
      if (Option != null && __isset.option) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Option: ");
        __sb.Append(Option);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
