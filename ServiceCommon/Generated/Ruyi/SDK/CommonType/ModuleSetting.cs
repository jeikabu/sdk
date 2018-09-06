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
  public partial class ModuleSetting : TBase
  {
    private ModuleBaseInfo _baseInfo;
    private List<SettingItem> _settings;
    private List<SettingCategory> _categories;

    public ModuleBaseInfo BaseInfo
    {
      get
      {
        return _baseInfo;
      }
      set
      {
        __isset.baseInfo = true;
        this._baseInfo = value;
      }
    }

    public List<SettingItem> Settings
    {
      get
      {
        return _settings;
      }
      set
      {
        __isset.settings = true;
        this._settings = value;
      }
    }

    public List<SettingCategory> Categories
    {
      get
      {
        return _categories;
      }
      set
      {
        __isset.categories = true;
        this._categories = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool baseInfo;
      public bool settings;
      public bool categories;
    }

    public ModuleSetting() {
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
                BaseInfo = new ModuleBaseInfo();
                BaseInfo.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.List) {
                {
                  Settings = new List<SettingItem>();
                  TList _list25 = iprot.ReadListBegin();
                  for( int _i26 = 0; _i26 < _list25.Count; ++_i26)
                  {
                    SettingItem _elem27;
                    _elem27 = new SettingItem();
                    _elem27.Read(iprot);
                    Settings.Add(_elem27);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.List) {
                {
                  Categories = new List<SettingCategory>();
                  TList _list28 = iprot.ReadListBegin();
                  for( int _i29 = 0; _i29 < _list28.Count; ++_i29)
                  {
                    SettingCategory _elem30;
                    _elem30 = new SettingCategory();
                    _elem30.Read(iprot);
                    Categories.Add(_elem30);
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
        TStruct struc = new TStruct("ModuleSetting");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (BaseInfo != null && __isset.baseInfo) {
          field.Name = "baseInfo";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          BaseInfo.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Settings != null && __isset.settings) {
          field.Name = "settings";
          field.Type = TType.List;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Settings.Count));
            foreach (SettingItem _iter31 in Settings)
            {
              _iter31.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Categories != null && __isset.categories) {
          field.Name = "categories";
          field.Type = TType.List;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Categories.Count));
            foreach (SettingCategory _iter32 in Categories)
            {
              _iter32.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("ModuleSetting(");
      bool __first = true;
      if (BaseInfo != null && __isset.baseInfo) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("BaseInfo: ");
        __sb.Append(BaseInfo== null ? "<null>" : BaseInfo.ToString());
      }
      if (Settings != null && __isset.settings) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Settings: ");
        __sb.Append(Settings);
      }
      if (Categories != null && __isset.categories) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Categories: ");
        __sb.Append(Categories);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
