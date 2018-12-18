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

namespace Ruyi.SDK.CommonType
{

  /// <summary>
  /// @RuyiFeatures_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class RuyiFeatures : TBase
  {
    private bool _ruyi_xinput;
    private bool _ruyi_dinput;
    private bool _ruyi_sdkinput;

    /// <summary>
    /// @RuyiFeatures_ruyi_xinput_desc
    /// </summary>
    public bool Ruyi_xinput
    {
      get
      {
        return _ruyi_xinput;
      }
      set
      {
        __isset.ruyi_xinput = true;
        this._ruyi_xinput = value;
      }
    }

    /// <summary>
    /// @RuyiFeatures_ruyi_dinput_desc
    /// </summary>
    public bool Ruyi_dinput
    {
      get
      {
        return _ruyi_dinput;
      }
      set
      {
        __isset.ruyi_dinput = true;
        this._ruyi_dinput = value;
      }
    }

    /// <summary>
    /// @RuyiFeatures_ruyi_sdkinput_desc
    /// </summary>
    public bool Ruyi_sdkinput
    {
      get
      {
        return _ruyi_sdkinput;
      }
      set
      {
        __isset.ruyi_sdkinput = true;
        this._ruyi_sdkinput = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool ruyi_xinput;
      public bool ruyi_dinput;
      public bool ruyi_sdkinput;
    }

    public RuyiFeatures() {
      this._ruyi_xinput = false;
      this.__isset.ruyi_xinput = true;
      this._ruyi_dinput = false;
      this.__isset.ruyi_dinput = true;
      this._ruyi_sdkinput = false;
      this.__isset.ruyi_sdkinput = true;
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
              if (field.Type == TType.Bool) {
                Ruyi_xinput = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Bool) {
                Ruyi_dinput = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Bool) {
                Ruyi_sdkinput = iprot.ReadBool();
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
        TStruct struc = new TStruct("RuyiFeatures");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.ruyi_xinput) {
          field.Name = "ruyi_xinput";
          field.Type = TType.Bool;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Ruyi_xinput);
          oprot.WriteFieldEnd();
        }
        if (__isset.ruyi_dinput) {
          field.Name = "ruyi_dinput";
          field.Type = TType.Bool;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Ruyi_dinput);
          oprot.WriteFieldEnd();
        }
        if (__isset.ruyi_sdkinput) {
          field.Name = "ruyi_sdkinput";
          field.Type = TType.Bool;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Ruyi_sdkinput);
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
      StringBuilder __sb = new StringBuilder("RuyiFeatures(");
      bool __first = true;
      if (__isset.ruyi_xinput) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Ruyi_xinput: ");
        __sb.Append(Ruyi_xinput);
      }
      if (__isset.ruyi_dinput) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Ruyi_dinput: ");
        __sb.Append(Ruyi_dinput);
      }
      if (__isset.ruyi_sdkinput) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Ruyi_sdkinput: ");
        __sb.Append(Ruyi_sdkinput);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
