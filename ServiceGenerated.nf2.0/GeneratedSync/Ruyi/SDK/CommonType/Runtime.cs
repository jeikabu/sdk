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
  /// @Runtime_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class Runtime : TBase
  {
    private Features _features;
    private RuyiFeatures _ruyifeatures;

    /// <summary>
    /// @Runtime_features_desc
    /// </summary>
    public Features Features
    {
      get
      {
        return _features;
      }
      set
      {
        __isset.features = true;
        this._features = value;
      }
    }

    /// <summary>
    /// @Runtime_ruyifeatures_desc
    /// </summary>
    public RuyiFeatures Ruyifeatures
    {
      get
      {
        return _ruyifeatures;
      }
      set
      {
        __isset.ruyifeatures = true;
        this._ruyifeatures = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool features;
      public bool ruyifeatures;
    }

    public Runtime() {
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
              if (field.Type == TType.Struct) {
                Features = new Features();
                Features.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                Ruyifeatures = new RuyiFeatures();
                Ruyifeatures.Read(iprot);
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
        TStruct struc = new TStruct("Runtime");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Features != null && __isset.features) {
          field.Name = "features";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Features.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Ruyifeatures != null && __isset.ruyifeatures) {
          field.Name = "ruyifeatures";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          Ruyifeatures.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("Runtime(");
      bool __first = true;
      if (Features != null && __isset.features) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Features: ");
        __sb.Append(Features== null ? "<null>" : Features.ToString());
      }
      if (Ruyifeatures != null && __isset.ruyifeatures) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Ruyifeatures: ");
        __sb.Append(Ruyifeatures== null ? "<null>" : Ruyifeatures.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
