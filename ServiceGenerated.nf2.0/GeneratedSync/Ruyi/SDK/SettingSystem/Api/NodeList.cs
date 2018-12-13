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

namespace Ruyi.SDK.SettingSystem.Api
{

  /// <summary>
  /// @NodeList_desc
  /// </summary>
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class NodeList : TBase
  {
    private List<Ruyi.SDK.CommonType.SettingCategory> _SettingCategories;
    private List<Ruyi.SDK.CommonType.SettingItem> _SettingItems;

    /// <summary>
    /// @NodeList_SettingCategories_desc
    /// </summary>
    public List<Ruyi.SDK.CommonType.SettingCategory> SettingCategories
    {
      get
      {
        return _SettingCategories;
      }
      set
      {
        __isset.SettingCategories = true;
        this._SettingCategories = value;
      }
    }

    /// <summary>
    /// @NodeList_SettingItems_desc
    /// </summary>
    public List<Ruyi.SDK.CommonType.SettingItem> SettingItems
    {
      get
      {
        return _SettingItems;
      }
      set
      {
        __isset.SettingItems = true;
        this._SettingItems = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool SettingCategories;
      public bool SettingItems;
    }

    public NodeList() {
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
              if (field.Type == TType.List) {
                {
                  SettingCategories = new List<Ruyi.SDK.CommonType.SettingCategory>();
                  TList _list18 = iprot.ReadListBegin();
                  for( int _i19 = 0; _i19 < _list18.Count; ++_i19)
                  {
                    Ruyi.SDK.CommonType.SettingCategory _elem20;
                    _elem20 = new Ruyi.SDK.CommonType.SettingCategory();
                    _elem20.Read(iprot);
                    SettingCategories.Add(_elem20);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.List) {
                {
                  SettingItems = new List<Ruyi.SDK.CommonType.SettingItem>();
                  TList _list21 = iprot.ReadListBegin();
                  for( int _i22 = 0; _i22 < _list21.Count; ++_i22)
                  {
                    Ruyi.SDK.CommonType.SettingItem _elem23;
                    _elem23 = new Ruyi.SDK.CommonType.SettingItem();
                    _elem23.Read(iprot);
                    SettingItems.Add(_elem23);
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
        TStruct struc = new TStruct("NodeList");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (SettingCategories != null && __isset.SettingCategories) {
          field.Name = "SettingCategories";
          field.Type = TType.List;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, SettingCategories.Count));
            foreach (Ruyi.SDK.CommonType.SettingCategory _iter24 in SettingCategories)
            {
              _iter24.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (SettingItems != null && __isset.SettingItems) {
          field.Name = "SettingItems";
          field.Type = TType.List;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, SettingItems.Count));
            foreach (Ruyi.SDK.CommonType.SettingItem _iter25 in SettingItems)
            {
              _iter25.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("NodeList(");
      bool __first = true;
      if (SettingCategories != null && __isset.SettingCategories) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SettingCategories: ");
        __sb.Append(SettingCategories);
      }
      if (SettingItems != null && __isset.SettingItems) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SettingItems: ");
        __sb.Append(SettingItems);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
