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
  /// @dataListItem_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class dataListItem : TBase
  {
    private string _elementType;
    private List<string> _values;
    private notification _removeNotification;

    /// <summary>
    /// @dataListItem_elementType_desc
    /// </summary>
    public string ElementType
    {
      get
      {
        return _elementType;
      }
      set
      {
        __isset.elementType = true;
        this._elementType = value;
      }
    }

    /// <summary>
    /// @dataListItem_values_desc
    /// </summary>
    public List<string> Values
    {
      get
      {
        return _values;
      }
      set
      {
        __isset.values = true;
        this._values = value;
      }
    }

    /// <summary>
    /// @dataListItem_removeNotification_desc
    /// </summary>
    public notification RemoveNotification
    {
      get
      {
        return _removeNotification;
      }
      set
      {
        __isset.removeNotification = true;
        this._removeNotification = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool elementType;
      public bool values;
      public bool removeNotification;
    }

    public dataListItem() {
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
                ElementType = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.List) {
                {
                  Values = new List<string>();
                  TList _list12 = iprot.ReadListBegin();
                  for( int _i13 = 0; _i13 < _list12.Count; ++_i13)
                  {
                    string _elem14;
                    _elem14 = iprot.ReadString();
                    Values.Add(_elem14);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Struct) {
                RemoveNotification = new notification();
                RemoveNotification.Read(iprot);
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
        TStruct struc = new TStruct("dataListItem");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (ElementType != null && __isset.elementType) {
          field.Name = "elementType";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(ElementType);
          oprot.WriteFieldEnd();
        }
        if (Values != null && __isset.values) {
          field.Name = "values";
          field.Type = TType.List;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.String, Values.Count));
            foreach (string _iter15 in Values)
            {
              oprot.WriteString(_iter15);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (RemoveNotification != null && __isset.removeNotification) {
          field.Name = "removeNotification";
          field.Type = TType.Struct;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          RemoveNotification.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("dataListItem(");
      bool __first = true;
      if (ElementType != null && __isset.elementType) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ElementType: ");
        __sb.Append(ElementType);
      }
      if (Values != null && __isset.values) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Values: ");
        __sb.Append(Values);
      }
      if (RemoveNotification != null && __isset.removeNotification) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("RemoveNotification: ");
        __sb.Append(RemoveNotification== null ? "<null>" : RemoveNotification.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
