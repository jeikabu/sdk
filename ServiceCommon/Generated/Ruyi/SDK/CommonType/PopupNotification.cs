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
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ruyi.SDK.CommonType
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class PopupNotification : TBase
  {
    private NotificationType _NotificationType;
    private bool _HasInteractiveBar;
    private bool _isLargeMainIcon;
    private string _NotificationData;

    /// <summary>
    /// 
    /// <seealso cref="NotificationType"/>
    /// </summary>
    public NotificationType NotificationType
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

    public bool HasInteractiveBar
    {
      get
      {
        return _HasInteractiveBar;
      }
      set
      {
        __isset.HasInteractiveBar = true;
        this._HasInteractiveBar = value;
      }
    }

    public bool IsLargeMainIcon
    {
      get
      {
        return _isLargeMainIcon;
      }
      set
      {
        __isset.isLargeMainIcon = true;
        this._isLargeMainIcon = value;
      }
    }

    public string NotificationData
    {
      get
      {
        return _NotificationData;
      }
      set
      {
        __isset.NotificationData = true;
        this._NotificationData = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool NotificationType;
      public bool HasInteractiveBar;
      public bool isLargeMainIcon;
      public bool NotificationData;
    }

    public PopupNotification() {
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
              if (field.Type == TType.I32) {
                NotificationType = (NotificationType)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Bool) {
                HasInteractiveBar = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Bool) {
                IsLargeMainIcon = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                NotificationData = iprot.ReadString();
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
        TStruct struc = new TStruct("PopupNotification");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.NotificationType) {
          field.Name = "NotificationType";
          field.Type = TType.I32;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)NotificationType);
          oprot.WriteFieldEnd();
        }
        if (__isset.HasInteractiveBar) {
          field.Name = "HasInteractiveBar";
          field.Type = TType.Bool;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(HasInteractiveBar);
          oprot.WriteFieldEnd();
        }
        if (__isset.isLargeMainIcon) {
          field.Name = "isLargeMainIcon";
          field.Type = TType.Bool;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IsLargeMainIcon);
          oprot.WriteFieldEnd();
        }
        if (NotificationData != null && __isset.NotificationData) {
          field.Name = "NotificationData";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(NotificationData);
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
      StringBuilder __sb = new StringBuilder("PopupNotification(");
      bool __first = true;
      if (__isset.NotificationType) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NotificationType: ");
        __sb.Append(NotificationType);
      }
      if (__isset.HasInteractiveBar) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("HasInteractiveBar: ");
        __sb.Append(HasInteractiveBar);
      }
      if (__isset.isLargeMainIcon) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IsLargeMainIcon: ");
        __sb.Append(IsLargeMainIcon);
      }
      if (NotificationData != null && __isset.NotificationData) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NotificationData: ");
        __sb.Append(NotificationData);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
