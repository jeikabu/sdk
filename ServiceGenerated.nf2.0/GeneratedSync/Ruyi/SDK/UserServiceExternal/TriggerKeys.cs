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
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace Ruyi.SDK.UserServiceExternal
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TriggerKeys : TBase
  {
    private sbyte _DeviceType;
    private int _Key;
    private sbyte _NewValue;
    private sbyte _OldValue;

    public sbyte DeviceType
    {
      get
      {
        return _DeviceType;
      }
      set
      {
        __isset.DeviceType = true;
        this._DeviceType = value;
      }
    }

    public int Key
    {
      get
      {
        return _Key;
      }
      set
      {
        __isset.Key = true;
        this._Key = value;
      }
    }

    public sbyte NewValue
    {
      get
      {
        return _NewValue;
      }
      set
      {
        __isset.NewValue = true;
        this._NewValue = value;
      }
    }

    public sbyte OldValue
    {
      get
      {
        return _OldValue;
      }
      set
      {
        __isset.OldValue = true;
        this._OldValue = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool DeviceType;
      public bool Key;
      public bool NewValue;
      public bool OldValue;
    }

    public TriggerKeys() {
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
              if (field.Type == TType.Byte) {
                DeviceType = iprot.ReadByte();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                Key = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Byte) {
                NewValue = iprot.ReadByte();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Byte) {
                OldValue = iprot.ReadByte();
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
        TStruct struc = new TStruct("TriggerKeys");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.DeviceType) {
          field.Name = "DeviceType";
          field.Type = TType.Byte;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(DeviceType);
          oprot.WriteFieldEnd();
        }
        if (__isset.Key) {
          field.Name = "Key";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Key);
          oprot.WriteFieldEnd();
        }
        if (__isset.NewValue) {
          field.Name = "NewValue";
          field.Type = TType.Byte;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(NewValue);
          oprot.WriteFieldEnd();
        }
        if (__isset.OldValue) {
          field.Name = "OldValue";
          field.Type = TType.Byte;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(OldValue);
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
      StringBuilder __sb = new StringBuilder("TriggerKeys(");
      bool __first = true;
      if (__isset.DeviceType) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DeviceType: ");
        __sb.Append(DeviceType);
      }
      if (__isset.Key) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Key: ");
        __sb.Append(Key);
      }
      if (__isset.NewValue) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NewValue: ");
        __sb.Append(NewValue);
      }
      if (__isset.OldValue) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("OldValue: ");
        __sb.Append(OldValue);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
