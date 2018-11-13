/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
#ifndef GamesDBSDKDataTypes_TYPES_H
#define GamesDBSDKDataTypes_TYPES_H

#include <iosfwd>

#include <thrift/Thrift.h>
#include <thrift/TApplicationException.h>
#include <thrift/TBase.h>
#include <thrift/protocol/TProtocol.h>
#include <thrift/transport/TTransport.h>

#include <thrift/stdcxx.h>


namespace Ruyi { namespace SDK { namespace CommonType {

struct CondType {
  enum type {
    ExePresent = 0,
    FilePresent = 1,
    FileAbsent = 2,
    ArgPresent = 3,
    ArgAbsent = 4
  };
};

extern const std::map<int, const char*> _CondType_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const CondType::type& val);

class Runtime;

class GameDB;

class Cond;

class Variant;

class If;


class Runtime : public virtual ::apache::thrift::TBase {
 public:

  Runtime(const Runtime&);
  Runtime& operator=(const Runtime&);
  Runtime() {
  }

  virtual ~Runtime() throw();

  bool operator == (const Runtime & /* rhs */) const
  {
    return true;
  }
  bool operator != (const Runtime &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const Runtime & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(Runtime &a, Runtime &b);

std::ostream& operator<<(std::ostream& out, const Runtime& obj);

typedef struct _GameDB__isset {
  _GameDB__isset() : id(false), name(false), conditions(false), detection(false), runtime(false) {}
  bool id :1;
  bool name :1;
  bool conditions :1;
  bool detection :1;
  bool runtime :1;
} _GameDB__isset;

class GameDB : public virtual ::apache::thrift::TBase {
 public:

  GameDB(const GameDB&);
  GameDB& operator=(const GameDB&);
  GameDB() : id(0), name() {
  }

  virtual ~GameDB() throw();
  int32_t id;
  std::string name;
  std::vector<Cond>  conditions;
  std::vector<Variant>  detection;
  Runtime runtime;

  _GameDB__isset __isset;

  void __set_id(const int32_t val);

  void __set_name(const std::string& val);

  void __set_conditions(const std::vector<Cond> & val);

  void __set_detection(const std::vector<Variant> & val);

  void __set_runtime(const Runtime& val);

  bool operator == (const GameDB & rhs) const
  {
    if (!(id == rhs.id))
      return false;
    if (!(name == rhs.name))
      return false;
    if (!(conditions == rhs.conditions))
      return false;
    if (!(detection == rhs.detection))
      return false;
    if (!(runtime == rhs.runtime))
      return false;
    return true;
  }
  bool operator != (const GameDB &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const GameDB & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(GameDB &a, GameDB &b);

std::ostream& operator<<(std::ostream& out, const GameDB& obj);

typedef struct _Cond__isset {
  _Cond__isset() : name(false), type(false), additionalArg(false) {}
  bool name :1;
  bool type :1;
  bool additionalArg :1;
} _Cond__isset;

class Cond : public virtual ::apache::thrift::TBase {
 public:

  Cond(const Cond&);
  Cond& operator=(const Cond&);
  Cond() : name(), type((CondType::type)0), additionalArg() {
  }

  virtual ~Cond() throw();
  std::string name;
  CondType::type type;
  std::string additionalArg;

  _Cond__isset __isset;

  void __set_name(const std::string& val);

  void __set_type(const CondType::type val);

  void __set_additionalArg(const std::string& val);

  bool operator == (const Cond & rhs) const
  {
    if (!(name == rhs.name))
      return false;
    if (!(type == rhs.type))
      return false;
    if (!(additionalArg == rhs.additionalArg))
      return false;
    return true;
  }
  bool operator != (const Cond &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const Cond & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(Cond &a, Cond &b);

std::ostream& operator<<(std::ostream& out, const Cond& obj);

typedef struct _Variant__isset {
  _Variant__isset() : name(false), id(false), order(false), rules(false) {}
  bool name :1;
  bool id :1;
  bool order :1;
  bool rules :1;
} _Variant__isset;

class Variant : public virtual ::apache::thrift::TBase {
 public:

  Variant(const Variant&);
  Variant& operator=(const Variant&);
  Variant() : name(), id(), order() {
  }

  virtual ~Variant() throw();
  std::string name;
  std::string id;
  std::string order;
  std::vector<If>  rules;

  _Variant__isset __isset;

  void __set_name(const std::string& val);

  void __set_id(const std::string& val);

  void __set_order(const std::string& val);

  void __set_rules(const std::vector<If> & val);

  bool operator == (const Variant & rhs) const
  {
    if (!(name == rhs.name))
      return false;
    if (!(id == rhs.id))
      return false;
    if (!(order == rhs.order))
      return false;
    if (!(rules == rhs.rules))
      return false;
    return true;
  }
  bool operator != (const Variant &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const Variant & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(Variant &a, Variant &b);

std::ostream& operator<<(std::ostream& out, const Variant& obj);

typedef struct _If__isset {
  _If__isset() : cond(false) {}
  bool cond :1;
} _If__isset;

class If : public virtual ::apache::thrift::TBase {
 public:

  If(const If&);
  If& operator=(const If&);
  If() : cond() {
  }

  virtual ~If() throw();
  std::string cond;

  _If__isset __isset;

  void __set_cond(const std::string& val);

  bool operator == (const If & rhs) const
  {
    if (!(cond == rhs.cond))
      return false;
    return true;
  }
  bool operator != (const If &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const If & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(If &a, If &b);

std::ostream& operator<<(std::ostream& out, const If& obj);

}}} // namespace

#endif
