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


namespace Ruyi.SDK.SettingSystem.Api
{

  public partial class CategoryNode : TBase
  {
    private string _id;
    private string _categoryId;
    private int _sortingPriority;
    private List<CategoryNode> _children;

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

    public string CategoryId
    {
      get
      {
        return _categoryId;
      }
      set
      {
        __isset.categoryId = true;
        this._categoryId = value;
      }
    }

    public int SortingPriority
    {
      get
      {
        return _sortingPriority;
      }
      set
      {
        __isset.sortingPriority = true;
        this._sortingPriority = value;
      }
    }

    public List<CategoryNode> Children
    {
      get
      {
        return _children;
      }
      set
      {
        __isset.children = true;
        this._children = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool id;
      public bool categoryId;
      public bool sortingPriority;
      public bool children;
    }

    public CategoryNode()
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
                CategoryId = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                SortingPriority = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.List)
              {
                {
                  Children = new List<CategoryNode>();
                  TList _list4 = await iprot.ReadListBeginAsync(cancellationToken);
                  for(int _i5 = 0; _i5 < _list4.Count; ++_i5)
                  {
                    CategoryNode _elem6;
                    _elem6 = new CategoryNode();
                    await _elem6.ReadAsync(iprot, cancellationToken);
                    Children.Add(_elem6);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
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
        var struc = new TStruct("CategoryNode");
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
        if (CategoryId != null && __isset.categoryId)
        {
          field.Name = "categoryId";
          field.Type = TType.String;
          field.ID = 2;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteStringAsync(CategoryId, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (__isset.sortingPriority)
        {
          field.Name = "sortingPriority";
          field.Type = TType.I32;
          field.ID = 3;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          await oprot.WriteI32Async(SortingPriority, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if (Children != null && __isset.children)
        {
          field.Name = "children";
          field.Type = TType.List;
          field.ID = 4;
          await oprot.WriteFieldBeginAsync(field, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, Children.Count), cancellationToken);
            foreach (CategoryNode _iter7 in Children)
            {
              await _iter7.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
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
      var sb = new StringBuilder("CategoryNode(");
      bool __first = true;
      if (Id != null && __isset.id)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Id: ");
        sb.Append(Id);
      }
      if (CategoryId != null && __isset.categoryId)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("CategoryId: ");
        sb.Append(CategoryId);
      }
      if (__isset.sortingPriority)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("SortingPriority: ");
        sb.Append(SortingPriority);
      }
      if (Children != null && __isset.children)
      {
        if(!__first) { sb.Append(", "); }
        __first = false;
        sb.Append("Children: ");
        sb.Append(Children);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }

}
