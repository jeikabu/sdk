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
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ruyi.SDK.CommonType
{

  /// <summary>
  /// @TitleMainIconNotification_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TitleMainIconNotification : TBase
  {
    private string _title;
    private string _mainIcon;
    private TitleMainIconNotificationType _NotificationType;

    /// <summary>
    /// @TitleMainIconNotification_Title
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
    /// @TitleMainIconNotification_MainIcon
    /// </summary>
    public string MainIcon
    {
      get
      {
        return _mainIcon;
      }
      set
      {
        __isset.mainIcon = true;
        this._mainIcon = value;
      }
    }

    /// <summary>
    /// @enum.NotificationType_Desc
    /// 
    /// <seealso cref="TitleMainIconNotificationType"/>
    /// </summary>
    public TitleMainIconNotificationType NotificationType
    {
      get
      {
        return _NotificationType;
      }
      set
      {
        __isset.NotificationType = true;
        this._NotificationType = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool title;
      public bool mainIcon;
      public bool NotificationType;
    }

    public TitleMainIconNotification() {
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
                MainIcon = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I32) {
                NotificationType = (TitleMainIconNotificationType)iprot.ReadI32();
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
        TStruct struc = new TStruct("TitleMainIconNotification");
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
        if (MainIcon != null && __isset.mainIcon) {
          field.Name = "mainIcon";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(MainIcon);
          oprot.WriteFieldEnd();
        }
        if (__isset.NotificationType) {
          field.Name = "NotificationType";
          field.Type = TType.I32;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)NotificationType);
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
      StringBuilder __sb = new StringBuilder("TitleMainIconNotification(");
      bool __first = true;
      if (Title != null && __isset.title) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Title: ");
        __sb.Append(Title);
      }
      if (MainIcon != null && __isset.mainIcon) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("MainIcon: ");
        __sb.Append(MainIcon);
      }
      if (__isset.NotificationType) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NotificationType: ");
        __sb.Append(NotificationType);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
