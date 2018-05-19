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


namespace Ruyi.SDK.CommonType
{

  public partial class SettingItem : TBase
  {
    private string _id;
    private string _display;
    private string _dataType;
    private string _dataValue;
    private dataListItem _dataList;
    private ePlatform _platform;
    private string _summary;
    private string _description;
    private eUIType _UIType;
    private bool _devModeOnly;
    private bool _internalOnly;
    private bool _readOnly;
    private bool _isValid;
    private bool _isActive;
    private string _validation;
    private List<activeDependency> _activeDependencies;
    private string _ActionName;
    private string _ActionObject;
    private string _ActionMethodName;

    public string Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public string Display
    {
      get
      {
        return _display;
      }
      set
      {
        __isset.display = true;
        this._display = value;
      }
    }

    public string DataType
    {
      get
      {
        return _dataType;
      }
      set
      {
        __isset.dataType = true;
        this._dataType = value;
      }
    }

    public string DataValue
    {
      get
      {
        return _dataValue;
      }
      set
      {
        __isset.dataValue = true;
        this._dataValue = value;
      }
    }

    public dataListItem DataList
    {
      get
      {
        return _dataList;
      }
      set
      {
        __isset.dataList = true;
        this._dataList = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="ePlatform"/>
    /// </summary>
    public ePlatform Platform
    {
      get
      {
        return _platform;
      }
      set
      {
        __isset.platform = true;
        this._platform = value;
      }
    }

    public string Summary
    {
      get
      {
        return _summary;
      }
      set
      {
        __isset.summary = true;
        this._summary = value;
      }
    }

    public string Description
    {
      get
      {
        return _description;
      }
      set
      {
        __isset.description = true;
        this._description = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="eUIType"/>
    /// </summary>
    public eUIType UIType
    {
      get
      {
        return _UIType;
      }
      set
      {
        __isset.UIType = true;
        this._UIType = value;
      }
    }

    public bool DevModeOnly
    {
      get
      {
        return _devModeOnly;
      }
      set
      {
        __isset.devModeOnly = true;
        this._devModeOnly = value;
      }
    }

    public bool InternalOnly
    {
      get
      {
        return _internalOnly;
      }
      set
      {
        __isset.internalOnly = true;
        this._internalOnly = value;
      }
    }

    public bool ReadOnly
    {
      get
      {
        return _readOnly;
      }
      set
      {
        __isset.@readOnly = true;
        this._readOnly = value;
      }
    }

    public bool IsValid
    {
      get
      {
        return _isValid;
      }
      set
      {
        __isset.isValid = true;
        this._isValid = value;
      }
    }

    public bool IsActive
    {
      get
      {
        return _isActive;
      }
      set
      {
        __isset.isActive = true;
        this._isActive = value;
      }
    }

    public string Validation
    {
      get
      {
        return _validation;
      }
      set
      {
        __isset.validation = true;
        this._validation = value;
      }
    }

    public List<activeDependency> ActiveDependencies
    {
      get
      {
        return _activeDependencies;
      }
      set
      {
        __isset.activeDependencies = true;
        this._activeDependencies = value;
      }
    }

    public string ActionName
    {
      get
      {
        return _ActionName;
      }
      set
      {
        __isset.ActionName = true;
        this._ActionName = value;
      }
    }

    public string ActionObject
    {
      get
      {
        return _ActionObject;
      }
      set
      {
        __isset.ActionObject = true;
        this._ActionObject = value;
      }
    }

    public string ActionMethodName
    {
      get
      {
        return _ActionMethodName;
      }
      set
      {
        __isset.ActionMethodName = true;
        this._ActionMethodName = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool id;
      public bool display;
      public bool dataType;
      public bool dataValue;
      public bool dataList;
      public bool platform;
      public bool summary;
      public bool description;
      public bool UIType;
      public bool devModeOnly;
      public bool internalOnly;
      public bool @readOnly;
      public bool isValid;
      public bool isActive;
      public bool validation;
      public bool activeDependencies;
      public bool ActionName;
      public bool ActionObject;
      public bool ActionMethodName;
    }

    public SettingItem()
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
                Id = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Display = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                DataType = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                DataValue = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Struct)
              {
                DataList = new dataListItem();
                await DataList.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.I32)
              {
                Platform = (ePlatform)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.String)
              {
                Summary = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.String)
              {
                Description = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.I32)
              {
                UIType = (eUIType)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.Bool)
              {
                DevModeOnly = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 11:
              if (field.Type == TType.Bool)
              {
                InternalOnly = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 12:
              if (field.Type == TType.Bool)
              {
                ReadOnly = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 13:
              if (field.Type == TType.Bool)
              {
                IsValid = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 14:
              if (field.Type == TType.Bool)
              {
                IsActive = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 15:
              if (field.Type == TType.String)
              {
                Validation = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 16:
              if (field.Type == TType.List)
              {
                {
                  ActiveDependencies = new List<activeDependency>();
                  TList _list12 = await iprot.ReadListBeginAsync(cancellationToken);
                  for(int _i13 = 0; _i13 < _list12.Count; ++_i13)
                  {
                    activeDependency _elem14;
                    _elem14 = new activeDependency();
                    await _elem14.ReadAsync(iprot, cancellationToken);
                    ActiveDependencies.Add(_elem14);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 17:
              if (field.Type == TType.String)
              {
                ActionName = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 18:
              if (field.Type == TType.String)
              {
                ActionObject = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 19:
              if (field.Type == TType.String)
              {
                ActionMethodName = await iprot.ReadStringAsync(cancellationToken);
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
        var struc = new TStruct("SettingItem");
        await oprot.WriteStructBeginAsync(struc, cancellationToken);
        var field = new TField();
        if (Id != null && __isset.id)
        {
          field.Name = "id";
          field.Type = TType.String;
          field.ID = 1;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Display != null && __isset.display)
        {
          field.Name = "display";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Display, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (DataType != null && __isset.dataType)
        {
          field.Name = "dataType";
          field.Type = TType.String;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(DataType, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (DataValue != null && __isset.dataValue)
        {
          field.Name = "dataValue";
          field.Type = TType.String;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(DataValue, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (DataList != null && __isset.dataList)
        {
          field.Name = "dataList";
          field.Type = TType.Struct;
          field.ID = 5;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await DataList.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.platform)
        {
          field.Name = "platform";
          field.Type = TType.I32;
          field.ID = 6;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async((int)Platform, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Summary != null && __isset.summary)
        {
          field.Name = "summary";
          field.Type = TType.String;
          field.ID = 7;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Summary, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Description != null && __isset.description)
        {
          field.Name = "description";
          field.Type = TType.String;
          field.ID = 8;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Description, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.UIType)
        {
          field.Name = "UIType";
          field.Type = TType.I32;
          field.ID = 9;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async((int)UIType, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.devModeOnly)
        {
          field.Name = "devModeOnly";
          field.Type = TType.Bool;
          field.ID = 10;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBoolAsync(DevModeOnly, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.internalOnly)
        {
          field.Name = "internalOnly";
          field.Type = TType.Bool;
          field.ID = 11;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBoolAsync(InternalOnly, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.@readOnly)
        {
          field.Name = "readOnly";
          field.Type = TType.Bool;
          field.ID = 12;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBoolAsync(ReadOnly, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.isValid)
        {
          field.Name = "isValid";
          field.Type = TType.Bool;
          field.ID = 13;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBoolAsync(IsValid, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.isActive)
        {
          field.Name = "isActive";
          field.Type = TType.Bool;
          field.ID = 14;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteBoolAsync(IsActive, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Validation != null && __isset.validation)
        {
          field.Name = "validation";
          field.Type = TType.String;
          field.ID = 15;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(Validation, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (ActiveDependencies != null && __isset.activeDependencies)
        {
          field.Name = "activeDependencies";
          field.Type = TType.List;
          field.ID = 16;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, ActiveDependencies.Count), cancellationToken);
            foreach (activeDependency _iter15 in ActiveDependencies)
            {
              await _iter15.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (ActionName != null && __isset.ActionName)
        {
          field.Name = "ActionName";
          field.Type = TType.String;
          field.ID = 17;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(ActionName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (ActionObject != null && __isset.ActionObject)
        {
          field.Name = "ActionObject";
          field.Type = TType.String;
          field.ID = 18;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(ActionObject, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (ActionMethodName != null && __isset.ActionMethodName)
        {
          field.Name = "ActionMethodName";
          field.Type = TType.String;
          field.ID = 19;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(ActionMethodName, cancellationToken);
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
      var sb = new StringBuilder("SettingItem(");
      bool __first = true;
      if (Id != null && __isset.id)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Id: ");
        sb.Append(Id);
      }
      if (Display != null && __isset.display)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Display: ");
        sb.Append(Display);
      }
      if (DataType != null && __isset.dataType)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("DataType: ");
        sb.Append(DataType);
      }
      if (DataValue != null && __isset.dataValue)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("DataValue: ");
        sb.Append(DataValue);
      }
      if (DataList != null && __isset.dataList)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("DataList: ");
        sb.Append(DataList== null ? "<null>" : DataList.ToString());
      }
      if (__isset.platform)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Platform: ");
        sb.Append(Platform);
      }
      if (Summary != null && __isset.summary)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Summary: ");
        sb.Append(Summary);
      }
      if (Description != null && __isset.description)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Description: ");
        sb.Append(Description);
      }
      if (__isset.UIType)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("UIType: ");
        sb.Append(UIType);
      }
      if (__isset.devModeOnly)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("DevModeOnly: ");
        sb.Append(DevModeOnly);
      }
      if (__isset.internalOnly)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("InternalOnly: ");
        sb.Append(InternalOnly);
      }
      if (__isset.@readOnly)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("ReadOnly: ");
        sb.Append(ReadOnly);
      }
      if (__isset.isValid)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("IsValid: ");
        sb.Append(IsValid);
      }
      if (__isset.isActive)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("IsActive: ");
        sb.Append(IsActive);
      }
      if (Validation != null && __isset.validation)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Validation: ");
        sb.Append(Validation);
      }
      if (ActiveDependencies != null && __isset.activeDependencies)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("ActiveDependencies: ");
        sb.Append(ActiveDependencies);
      }
      if (ActionName != null && __isset.ActionName)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("ActionName: ");
        sb.Append(ActionName);
      }
      if (ActionObject != null && __isset.ActionObject)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("ActionObject: ");
        sb.Append(ActionObject);
      }
      if (ActionMethodName != null && __isset.ActionMethodName)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("ActionMethodName: ");
        sb.Append(ActionMethodName);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
