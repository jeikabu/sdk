/**
 * Autogenerated by Thrift Compiler (0.11.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
#ifndef CommonTypeSDKDataTypes_TYPES_H
#define CommonTypeSDKDataTypes_TYPES_H

#include <iosfwd>

#include <thrift/Thrift.h>
#include <thrift/TApplicationException.h>
#include <thrift/TBase.h>
#include <thrift/protocol/TProtocol.h>
#include <thrift/transport/TTransport.h>

#include <thrift/stdcxx.h>


namespace Ruyi { namespace SDK { namespace CommonType {

struct PowerOperations {
  enum type {
    None = 0,
    RestartDevice = 2,
    ShutdownDevice = 3,
    ShutdownLayer0 = 4,
    RestartLayer0 = 5,
    SwitchToLowPower = 8,
    SwitchToHighPower = 9,
    SleepDevice = 10,
    ShutdownLayer1 = 12,
    Cancel = 15,
    Ping = 16,
    FakeUserLogout = 17
  };
};

extern const std::map<int, const char*> _PowerOperations_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const PowerOperations::type& val);

struct UserType {
  enum type {
    Guest = 0,
    RuyiUser = 1,
    Developer = 2
  };
};

extern const std::map<int, const char*> _UserType_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const UserType::type& val);

struct LoginState {
  enum type {
    Logout = 0,
    Login = 1
  };
};

extern const std::map<int, const char*> _LoginState_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const LoginState::type& val);

struct TitleMainIconNotificationType {
  enum type {
    FriendRequest = 0,
    FriendAccept = 1,
    BluetoothDeviceStatusChanged = 2,
    NetworkStatusChanged = 3
  };
};

extern const std::map<int, const char*> _TitleMainIconNotificationType_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const TitleMainIconNotificationType::type& val);

struct InputCategory {
  enum type {
    GamePad = 0,
    Keyboard = 1,
    Mouse = 2,
    JoyStick = 3,
    MaxCount = 4
  };
};

extern const std::map<int, const char*> _InputCategory_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const InputCategory::type& val);

struct RuyiGamePadButtonFlags {
  enum type {
    GamePad_Up = 1,
    GamePad_Down = 2,
    GamePad_Left = 4,
    GamePad_Right = 8,
    GamePad_Start = 16,
    GamePad_Back = 32,
    GamePad_L3 = 64,
    GamePad_R3 = 128,
    GamePad_LB = 256,
    GamePad_RB = 512,
    GamePad_A = 4096,
    GamePad_B = 8192,
    GamePad_X = 16384,
    GamePad_Y = 32768,
    GamePad_LT = 131072,
    GamePad_RT = 262144,
    GamePad_LJoyX = 524288,
    GamePad_LJoyY = 1048576,
    GamePad_RJoyX = 2097152,
    GamePad_RJoyY = 4194304
  };
};

extern const std::map<int, const char*> _RuyiGamePadButtonFlags_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const RuyiGamePadButtonFlags::type& val);

struct ePlatform {
  enum type {
    None = 0,
    PC = 1,
    Console = 2,
    All = 3
  };
};

extern const std::map<int, const char*> _ePlatform_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const ePlatform::type& val);

struct eUIType {
  enum type {
    None = 0,
    Toggle = 1,
    Text = 2,
    Slider = 3,
    CheckList = 4,
    OptionList = 5,
    DateTime = 6,
    InputTextWithLabel = 7,
    Button = 8,
    InputText = 9
  };
};

extern const std::map<int, const char*> _eUIType_VALUES_TO_NAMES;

std::ostream& operator<<(std::ostream& out, const eUIType::type& val);

typedef std::string JSON;

class ErrorException;

class range;

class InputModifier;

class ActionTrigger;

class notification;

class dataListItem;

class activeDependency;

class SettingValue;

class SettingItem;

class SettingCategory;

class ModuleBaseInfo;

class ModuleSetting;

class AppDataRecord;

class AppDataCollection;

class AppData;

class TitleMainIconNotification;

class AppBaseInfo;

class EventNotification;

typedef struct _ErrorException__isset {
  _ErrorException__isset() : errId(false), errMsg(false) {}
  bool errId :1;
  bool errMsg :1;
} _ErrorException__isset;

class ErrorException : public ::apache::thrift::TException {
 public:

  ErrorException(const ErrorException&);
  ErrorException& operator=(const ErrorException&);
  ErrorException() : errId(0), errMsg() {
  }

  virtual ~ErrorException() throw();
  int32_t errId;
  std::string errMsg;

  _ErrorException__isset __isset;

  void __set_errId(const int32_t val);

  void __set_errMsg(const std::string& val);

  bool operator == (const ErrorException & rhs) const
  {
    if (!(errId == rhs.errId))
      return false;
    if (!(errMsg == rhs.errMsg))
      return false;
    return true;
  }
  bool operator != (const ErrorException &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const ErrorException & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
  mutable std::string thriftTExceptionMessageHolder_;
  const char* what() const throw();
};

void swap(ErrorException &a, ErrorException &b);

std::ostream& operator<<(std::ostream& out, const ErrorException& obj);

typedef struct _range__isset {
  _range__isset() : minimum(false), maximum(false) {}
  bool minimum :1;
  bool maximum :1;
} _range__isset;

class range : public virtual ::apache::thrift::TBase {
 public:

  range(const range&);
  range& operator=(const range&);
  range() : minimum(0), maximum(0) {
  }

  virtual ~range() throw();
  double minimum;
  double maximum;

  _range__isset __isset;

  void __set_minimum(const double val);

  void __set_maximum(const double val);

  bool operator == (const range & rhs) const
  {
    if (!(minimum == rhs.minimum))
      return false;
    if (!(maximum == rhs.maximum))
      return false;
    return true;
  }
  bool operator != (const range &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const range & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(range &a, range &b);

std::ostream& operator<<(std::ostream& out, const range& obj);

typedef struct _InputModifier__isset {
  _InputModifier__isset() : DeadZone(false), Scale(false) {}
  bool DeadZone :1;
  bool Scale :1;
} _InputModifier__isset;

class InputModifier : public virtual ::apache::thrift::TBase {
 public:

  InputModifier(const InputModifier&);
  InputModifier& operator=(const InputModifier&);
  InputModifier() : Scale(0) {
  }

  virtual ~InputModifier() throw();
  range DeadZone;
  double Scale;

  _InputModifier__isset __isset;

  void __set_DeadZone(const range& val);

  void __set_Scale(const double val);

  bool operator == (const InputModifier & rhs) const
  {
    if (__isset.DeadZone != rhs.__isset.DeadZone)
      return false;
    else if (__isset.DeadZone && !(DeadZone == rhs.DeadZone))
      return false;
    if (!(Scale == rhs.Scale))
      return false;
    return true;
  }
  bool operator != (const InputModifier &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const InputModifier & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(InputModifier &a, InputModifier &b);

std::ostream& operator<<(std::ostream& out, const InputModifier& obj);

typedef struct _ActionTrigger__isset {
  _ActionTrigger__isset() : Id(false), InputCagetory(false), TriggerButtons(false), TriggerValue(false) {}
  bool Id :1;
  bool InputCagetory :1;
  bool TriggerButtons :1;
  bool TriggerValue :1;
} _ActionTrigger__isset;

class ActionTrigger : public virtual ::apache::thrift::TBase {
 public:

  ActionTrigger(const ActionTrigger&);
  ActionTrigger& operator=(const ActionTrigger&);
  ActionTrigger() : Id(0), InputCagetory((InputCategory::type)0) {
  }

  virtual ~ActionTrigger() throw();
  int32_t Id;
  InputCategory::type InputCagetory;
  std::vector<int32_t>  TriggerButtons;
  std::vector<int32_t>  TriggerValue;

  _ActionTrigger__isset __isset;

  void __set_Id(const int32_t val);

  void __set_InputCagetory(const InputCategory::type val);

  void __set_TriggerButtons(const std::vector<int32_t> & val);

  void __set_TriggerValue(const std::vector<int32_t> & val);

  bool operator == (const ActionTrigger & rhs) const
  {
    if (!(Id == rhs.Id))
      return false;
    if (!(InputCagetory == rhs.InputCagetory))
      return false;
    if (!(TriggerButtons == rhs.TriggerButtons))
      return false;
    if (!(TriggerValue == rhs.TriggerValue))
      return false;
    return true;
  }
  bool operator != (const ActionTrigger &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const ActionTrigger & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(ActionTrigger &a, ActionTrigger &b);

std::ostream& operator<<(std::ostream& out, const ActionTrigger& obj);

typedef struct _notification__isset {
  _notification__isset() : title(false), detail(false), option(false) {}
  bool title :1;
  bool detail :1;
  bool option :1;
} _notification__isset;

class notification : public virtual ::apache::thrift::TBase {
 public:

  notification(const notification&);
  notification& operator=(const notification&);
  notification() : title(), detail() {
  }

  virtual ~notification() throw();
  std::string title;
  std::string detail;
  std::vector<std::string>  option;

  _notification__isset __isset;

  void __set_title(const std::string& val);

  void __set_detail(const std::string& val);

  void __set_option(const std::vector<std::string> & val);

  bool operator == (const notification & rhs) const
  {
    if (!(title == rhs.title))
      return false;
    if (!(detail == rhs.detail))
      return false;
    if (!(option == rhs.option))
      return false;
    return true;
  }
  bool operator != (const notification &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const notification & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(notification &a, notification &b);

std::ostream& operator<<(std::ostream& out, const notification& obj);

typedef struct _dataListItem__isset {
  _dataListItem__isset() : elementType(false), values(false), removeNotification(false) {}
  bool elementType :1;
  bool values :1;
  bool removeNotification :1;
} _dataListItem__isset;

class dataListItem : public virtual ::apache::thrift::TBase {
 public:

  dataListItem(const dataListItem&);
  dataListItem& operator=(const dataListItem&);
  dataListItem() : elementType() {
  }

  virtual ~dataListItem() throw();
  std::string elementType;
  std::vector<std::string>  values;
  notification removeNotification;

  _dataListItem__isset __isset;

  void __set_elementType(const std::string& val);

  void __set_values(const std::vector<std::string> & val);

  void __set_removeNotification(const notification& val);

  bool operator == (const dataListItem & rhs) const
  {
    if (!(elementType == rhs.elementType))
      return false;
    if (!(values == rhs.values))
      return false;
    if (!(removeNotification == rhs.removeNotification))
      return false;
    return true;
  }
  bool operator != (const dataListItem &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const dataListItem & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(dataListItem &a, dataListItem &b);

std::ostream& operator<<(std::ostream& out, const dataListItem& obj);

typedef struct _activeDependency__isset {
  _activeDependency__isset() : name(false), condition(false) {}
  bool name :1;
  bool condition :1;
} _activeDependency__isset;

class activeDependency : public virtual ::apache::thrift::TBase {
 public:

  activeDependency(const activeDependency&);
  activeDependency& operator=(const activeDependency&);
  activeDependency() : name(), condition() {
  }

  virtual ~activeDependency() throw();
  std::string name;
  std::string condition;

  _activeDependency__isset __isset;

  void __set_name(const std::string& val);

  void __set_condition(const std::string& val);

  bool operator == (const activeDependency & rhs) const
  {
    if (!(name == rhs.name))
      return false;
    if (!(condition == rhs.condition))
      return false;
    return true;
  }
  bool operator != (const activeDependency &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const activeDependency & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(activeDependency &a, activeDependency &b);

std::ostream& operator<<(std::ostream& out, const activeDependency& obj);

typedef struct _SettingValue__isset {
  _SettingValue__isset() : dataType(false), dataValue(false) {}
  bool dataType :1;
  bool dataValue :1;
} _SettingValue__isset;

class SettingValue : public virtual ::apache::thrift::TBase {
 public:

  SettingValue(const SettingValue&);
  SettingValue& operator=(const SettingValue&);
  SettingValue() : dataType(), dataValue() {
  }

  virtual ~SettingValue() throw();
  std::string dataType;
  std::string dataValue;

  _SettingValue__isset __isset;

  void __set_dataType(const std::string& val);

  void __set_dataValue(const std::string& val);

  bool operator == (const SettingValue & rhs) const
  {
    if (!(dataType == rhs.dataType))
      return false;
    if (!(dataValue == rhs.dataValue))
      return false;
    return true;
  }
  bool operator != (const SettingValue &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const SettingValue & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(SettingValue &a, SettingValue &b);

std::ostream& operator<<(std::ostream& out, const SettingValue& obj);

typedef struct _SettingItem__isset {
  _SettingItem__isset() : id(false), display(false), dataType(false), dataValue(false), dataList(false), platform(false), summary(false), description(false), UIType(false), devModeOnly(false), internalOnly(false), readOnly(false), isValid(false), isActive(false), hasNew(false), validation(false), activeDependencies(false), ActionName(false), ActionObject(false), ActionOnSetValue(false), ActionOnGetValue(false), Tags(false) {}
  bool id :1;
  bool display :1;
  bool dataType :1;
  bool dataValue :1;
  bool dataList :1;
  bool platform :1;
  bool summary :1;
  bool description :1;
  bool UIType :1;
  bool devModeOnly :1;
  bool internalOnly :1;
  bool readOnly :1;
  bool isValid :1;
  bool isActive :1;
  bool hasNew :1;
  bool validation :1;
  bool activeDependencies :1;
  bool ActionName :1;
  bool ActionObject :1;
  bool ActionOnSetValue :1;
  bool ActionOnGetValue :1;
  bool Tags :1;
} _SettingItem__isset;

class SettingItem : public virtual ::apache::thrift::TBase {
 public:

  SettingItem(const SettingItem&);
  SettingItem& operator=(const SettingItem&);
  SettingItem() : id(), display(), dataType(), dataValue(), platform((ePlatform::type)0), summary(), description(), UIType((eUIType::type)0), devModeOnly(0), internalOnly(0), readOnly(0), isValid(0), isActive(0), hasNew(0), validation(), ActionName(), ActionObject(), ActionOnSetValue(), ActionOnGetValue() {
  }

  virtual ~SettingItem() throw();
  std::string id;
  std::string display;
  std::string dataType;
  std::string dataValue;
  dataListItem dataList;
  ePlatform::type platform;
  std::string summary;
  std::string description;
  eUIType::type UIType;
  bool devModeOnly;
  bool internalOnly;
  bool readOnly;
  bool isValid;
  bool isActive;
  bool hasNew;
  std::string validation;
  std::vector<activeDependency>  activeDependencies;
  std::string ActionName;
  std::string ActionObject;
  std::string ActionOnSetValue;
  std::string ActionOnGetValue;
  std::vector<std::string>  Tags;

  _SettingItem__isset __isset;

  void __set_id(const std::string& val);

  void __set_display(const std::string& val);

  void __set_dataType(const std::string& val);

  void __set_dataValue(const std::string& val);

  void __set_dataList(const dataListItem& val);

  void __set_platform(const ePlatform::type val);

  void __set_summary(const std::string& val);

  void __set_description(const std::string& val);

  void __set_UIType(const eUIType::type val);

  void __set_devModeOnly(const bool val);

  void __set_internalOnly(const bool val);

  void __set_readOnly(const bool val);

  void __set_isValid(const bool val);

  void __set_isActive(const bool val);

  void __set_hasNew(const bool val);

  void __set_validation(const std::string& val);

  void __set_activeDependencies(const std::vector<activeDependency> & val);

  void __set_ActionName(const std::string& val);

  void __set_ActionObject(const std::string& val);

  void __set_ActionOnSetValue(const std::string& val);

  void __set_ActionOnGetValue(const std::string& val);

  void __set_Tags(const std::vector<std::string> & val);

  bool operator == (const SettingItem & rhs) const
  {
    if (!(id == rhs.id))
      return false;
    if (!(display == rhs.display))
      return false;
    if (!(dataType == rhs.dataType))
      return false;
    if (!(dataValue == rhs.dataValue))
      return false;
    if (__isset.dataList != rhs.__isset.dataList)
      return false;
    else if (__isset.dataList && !(dataList == rhs.dataList))
      return false;
    if (__isset.platform != rhs.__isset.platform)
      return false;
    else if (__isset.platform && !(platform == rhs.platform))
      return false;
    if (__isset.summary != rhs.__isset.summary)
      return false;
    else if (__isset.summary && !(summary == rhs.summary))
      return false;
    if (__isset.description != rhs.__isset.description)
      return false;
    else if (__isset.description && !(description == rhs.description))
      return false;
    if (__isset.UIType != rhs.__isset.UIType)
      return false;
    else if (__isset.UIType && !(UIType == rhs.UIType))
      return false;
    if (__isset.devModeOnly != rhs.__isset.devModeOnly)
      return false;
    else if (__isset.devModeOnly && !(devModeOnly == rhs.devModeOnly))
      return false;
    if (__isset.internalOnly != rhs.__isset.internalOnly)
      return false;
    else if (__isset.internalOnly && !(internalOnly == rhs.internalOnly))
      return false;
    if (__isset.readOnly != rhs.__isset.readOnly)
      return false;
    else if (__isset.readOnly && !(readOnly == rhs.readOnly))
      return false;
    if (!(isValid == rhs.isValid))
      return false;
    if (!(isActive == rhs.isActive))
      return false;
    if (!(hasNew == rhs.hasNew))
      return false;
    if (__isset.validation != rhs.__isset.validation)
      return false;
    else if (__isset.validation && !(validation == rhs.validation))
      return false;
    if (__isset.activeDependencies != rhs.__isset.activeDependencies)
      return false;
    else if (__isset.activeDependencies && !(activeDependencies == rhs.activeDependencies))
      return false;
    if (__isset.ActionName != rhs.__isset.ActionName)
      return false;
    else if (__isset.ActionName && !(ActionName == rhs.ActionName))
      return false;
    if (__isset.ActionObject != rhs.__isset.ActionObject)
      return false;
    else if (__isset.ActionObject && !(ActionObject == rhs.ActionObject))
      return false;
    if (__isset.ActionOnSetValue != rhs.__isset.ActionOnSetValue)
      return false;
    else if (__isset.ActionOnSetValue && !(ActionOnSetValue == rhs.ActionOnSetValue))
      return false;
    if (__isset.ActionOnGetValue != rhs.__isset.ActionOnGetValue)
      return false;
    else if (__isset.ActionOnGetValue && !(ActionOnGetValue == rhs.ActionOnGetValue))
      return false;
    if (__isset.Tags != rhs.__isset.Tags)
      return false;
    else if (__isset.Tags && !(Tags == rhs.Tags))
      return false;
    return true;
  }
  bool operator != (const SettingItem &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const SettingItem & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(SettingItem &a, SettingItem &b);

std::ostream& operator<<(std::ostream& out, const SettingItem& obj);

typedef struct _SettingCategory__isset {
  _SettingCategory__isset() : id(false), display(false), summary(false), description(false), icon(false), sortingPriority(false), isSystemCategory(false), items(false), enable(false), showInUI(false), script(false), Tags(false) {}
  bool id :1;
  bool display :1;
  bool summary :1;
  bool description :1;
  bool icon :1;
  bool sortingPriority :1;
  bool isSystemCategory :1;
  bool items :1;
  bool enable :1;
  bool showInUI :1;
  bool script :1;
  bool Tags :1;
} _SettingCategory__isset;

class SettingCategory : public virtual ::apache::thrift::TBase {
 public:

  SettingCategory(const SettingCategory&);
  SettingCategory& operator=(const SettingCategory&);
  SettingCategory() : id(), display(), summary(), description(), icon(), sortingPriority(0), isSystemCategory(0), enable(0), showInUI(0), script() {
  }

  virtual ~SettingCategory() throw();
  std::string id;
  std::string display;
  std::string summary;
  std::string description;
  std::string icon;
  int32_t sortingPriority;
  bool isSystemCategory;
  std::map<std::string, int32_t>  items;
  bool enable;
  bool showInUI;
  std::string script;
  std::vector<std::string>  Tags;

  _SettingCategory__isset __isset;

  void __set_id(const std::string& val);

  void __set_display(const std::string& val);

  void __set_summary(const std::string& val);

  void __set_description(const std::string& val);

  void __set_icon(const std::string& val);

  void __set_sortingPriority(const int32_t val);

  void __set_isSystemCategory(const bool val);

  void __set_items(const std::map<std::string, int32_t> & val);

  void __set_enable(const bool val);

  void __set_showInUI(const bool val);

  void __set_script(const std::string& val);

  void __set_Tags(const std::vector<std::string> & val);

  bool operator == (const SettingCategory & rhs) const
  {
    if (!(id == rhs.id))
      return false;
    if (!(display == rhs.display))
      return false;
    if (__isset.summary != rhs.__isset.summary)
      return false;
    else if (__isset.summary && !(summary == rhs.summary))
      return false;
    if (__isset.description != rhs.__isset.description)
      return false;
    else if (__isset.description && !(description == rhs.description))
      return false;
    if (!(icon == rhs.icon))
      return false;
    if (!(sortingPriority == rhs.sortingPriority))
      return false;
    if (!(isSystemCategory == rhs.isSystemCategory))
      return false;
    if (!(items == rhs.items))
      return false;
    if (!(enable == rhs.enable))
      return false;
    if (!(showInUI == rhs.showInUI))
      return false;
    if (!(script == rhs.script))
      return false;
    if (__isset.Tags != rhs.__isset.Tags)
      return false;
    else if (__isset.Tags && !(Tags == rhs.Tags))
      return false;
    return true;
  }
  bool operator != (const SettingCategory &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const SettingCategory & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(SettingCategory &a, SettingCategory &b);

std::ostream& operator<<(std::ostream& out, const SettingCategory& obj);

typedef struct _ModuleBaseInfo__isset {
  _ModuleBaseInfo__isset() : name(false), version(false), configHash(false) {}
  bool name :1;
  bool version :1;
  bool configHash :1;
} _ModuleBaseInfo__isset;

class ModuleBaseInfo : public virtual ::apache::thrift::TBase {
 public:

  ModuleBaseInfo(const ModuleBaseInfo&);
  ModuleBaseInfo& operator=(const ModuleBaseInfo&);
  ModuleBaseInfo() : name(), version(), configHash(0) {
  }

  virtual ~ModuleBaseInfo() throw();
  std::string name;
  std::string version;
  int32_t configHash;

  _ModuleBaseInfo__isset __isset;

  void __set_name(const std::string& val);

  void __set_version(const std::string& val);

  void __set_configHash(const int32_t val);

  bool operator == (const ModuleBaseInfo & rhs) const
  {
    if (!(name == rhs.name))
      return false;
    if (!(version == rhs.version))
      return false;
    if (!(configHash == rhs.configHash))
      return false;
    return true;
  }
  bool operator != (const ModuleBaseInfo &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const ModuleBaseInfo & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(ModuleBaseInfo &a, ModuleBaseInfo &b);

std::ostream& operator<<(std::ostream& out, const ModuleBaseInfo& obj);

typedef struct _ModuleSetting__isset {
  _ModuleSetting__isset() : baseInfo(false), settings(false), categories(false) {}
  bool baseInfo :1;
  bool settings :1;
  bool categories :1;
} _ModuleSetting__isset;

class ModuleSetting : public virtual ::apache::thrift::TBase {
 public:

  ModuleSetting(const ModuleSetting&);
  ModuleSetting& operator=(const ModuleSetting&);
  ModuleSetting() {
  }

  virtual ~ModuleSetting() throw();
  ModuleBaseInfo baseInfo;
  std::vector<SettingItem>  settings;
  std::vector<SettingCategory>  categories;

  _ModuleSetting__isset __isset;

  void __set_baseInfo(const ModuleBaseInfo& val);

  void __set_settings(const std::vector<SettingItem> & val);

  void __set_categories(const std::vector<SettingCategory> & val);

  bool operator == (const ModuleSetting & rhs) const
  {
    if (!(baseInfo == rhs.baseInfo))
      return false;
    if (!(settings == rhs.settings))
      return false;
    if (!(categories == rhs.categories))
      return false;
    return true;
  }
  bool operator != (const ModuleSetting &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const ModuleSetting & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(ModuleSetting &a, ModuleSetting &b);

std::ostream& operator<<(std::ostream& out, const ModuleSetting& obj);

typedef struct _AppDataRecord__isset {
  _AppDataRecord__isset() : id(false), content(false) {}
  bool id :1;
  bool content :1;
} _AppDataRecord__isset;

class AppDataRecord : public virtual ::apache::thrift::TBase {
 public:

  AppDataRecord(const AppDataRecord&);
  AppDataRecord& operator=(const AppDataRecord&);
  AppDataRecord() : id() {
  }

  virtual ~AppDataRecord() throw();
  std::string id;
  SettingValue content;

  _AppDataRecord__isset __isset;

  void __set_id(const std::string& val);

  void __set_content(const SettingValue& val);

  bool operator == (const AppDataRecord & rhs) const
  {
    if (!(id == rhs.id))
      return false;
    if (!(content == rhs.content))
      return false;
    return true;
  }
  bool operator != (const AppDataRecord &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const AppDataRecord & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(AppDataRecord &a, AppDataRecord &b);

std::ostream& operator<<(std::ostream& out, const AppDataRecord& obj);

typedef struct _AppDataCollection__isset {
  _AppDataCollection__isset() : category(false), records(false) {}
  bool category :1;
  bool records :1;
} _AppDataCollection__isset;

class AppDataCollection : public virtual ::apache::thrift::TBase {
 public:

  AppDataCollection(const AppDataCollection&);
  AppDataCollection& operator=(const AppDataCollection&);
  AppDataCollection() : category() {
  }

  virtual ~AppDataCollection() throw();
  std::string category;
  std::vector<AppDataRecord>  records;

  _AppDataCollection__isset __isset;

  void __set_category(const std::string& val);

  void __set_records(const std::vector<AppDataRecord> & val);

  bool operator == (const AppDataCollection & rhs) const
  {
    if (!(category == rhs.category))
      return false;
    if (!(records == rhs.records))
      return false;
    return true;
  }
  bool operator != (const AppDataCollection &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const AppDataCollection & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(AppDataCollection &a, AppDataCollection &b);

std::ostream& operator<<(std::ostream& out, const AppDataCollection& obj);

typedef struct _AppData__isset {
  _AppData__isset() : appId(false), data(false) {}
  bool appId :1;
  bool data :1;
} _AppData__isset;

class AppData : public virtual ::apache::thrift::TBase {
 public:

  AppData(const AppData&);
  AppData& operator=(const AppData&);
  AppData() : appId() {
  }

  virtual ~AppData() throw();
  std::string appId;
  std::vector<AppDataCollection>  data;

  _AppData__isset __isset;

  void __set_appId(const std::string& val);

  void __set_data(const std::vector<AppDataCollection> & val);

  bool operator == (const AppData & rhs) const
  {
    if (!(appId == rhs.appId))
      return false;
    if (!(data == rhs.data))
      return false;
    return true;
  }
  bool operator != (const AppData &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const AppData & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(AppData &a, AppData &b);

std::ostream& operator<<(std::ostream& out, const AppData& obj);

typedef struct _TitleMainIconNotification__isset {
  _TitleMainIconNotification__isset() : title(false), mainIcon(false), NotificationType(false) {}
  bool title :1;
  bool mainIcon :1;
  bool NotificationType :1;
} _TitleMainIconNotification__isset;

class TitleMainIconNotification : public virtual ::apache::thrift::TBase {
 public:

  TitleMainIconNotification(const TitleMainIconNotification&);
  TitleMainIconNotification& operator=(const TitleMainIconNotification&);
  TitleMainIconNotification() : title(), mainIcon(), NotificationType((TitleMainIconNotificationType::type)0) {
  }

  virtual ~TitleMainIconNotification() throw();
  std::string title;
  std::string mainIcon;
  TitleMainIconNotificationType::type NotificationType;

  _TitleMainIconNotification__isset __isset;

  void __set_title(const std::string& val);

  void __set_mainIcon(const std::string& val);

  void __set_NotificationType(const TitleMainIconNotificationType::type val);

  bool operator == (const TitleMainIconNotification & rhs) const
  {
    if (!(title == rhs.title))
      return false;
    if (!(mainIcon == rhs.mainIcon))
      return false;
    if (!(NotificationType == rhs.NotificationType))
      return false;
    return true;
  }
  bool operator != (const TitleMainIconNotification &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const TitleMainIconNotification & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(TitleMainIconNotification &a, TitleMainIconNotification &b);

std::ostream& operator<<(std::ostream& out, const TitleMainIconNotification& obj);

typedef struct _AppBaseInfo__isset {
  _AppBaseInfo__isset() : appId(false), name(false), icon_hd(false), icon_ld(false), description(false), properties(false), platform(false), size(false), languages(false) {}
  bool appId :1;
  bool name :1;
  bool icon_hd :1;
  bool icon_ld :1;
  bool description :1;
  bool properties :1;
  bool platform :1;
  bool size :1;
  bool languages :1;
} _AppBaseInfo__isset;

class AppBaseInfo : public virtual ::apache::thrift::TBase {
 public:

  AppBaseInfo(const AppBaseInfo&);
  AppBaseInfo& operator=(const AppBaseInfo&);
  AppBaseInfo() : appId(), name(), icon_hd(), icon_ld(), description(), size(0) {
  }

  virtual ~AppBaseInfo() throw();
  std::string appId;
  std::string name;
  std::string icon_hd;
  std::string icon_ld;
  std::string description;
  std::vector<std::string>  properties;
  std::vector<std::string>  platform;
  int32_t size;
  std::vector<std::string>  languages;

  _AppBaseInfo__isset __isset;

  void __set_appId(const std::string& val);

  void __set_name(const std::string& val);

  void __set_icon_hd(const std::string& val);

  void __set_icon_ld(const std::string& val);

  void __set_description(const std::string& val);

  void __set_properties(const std::vector<std::string> & val);

  void __set_platform(const std::vector<std::string> & val);

  void __set_size(const int32_t val);

  void __set_languages(const std::vector<std::string> & val);

  bool operator == (const AppBaseInfo & rhs) const
  {
    if (!(appId == rhs.appId))
      return false;
    if (!(name == rhs.name))
      return false;
    if (!(icon_hd == rhs.icon_hd))
      return false;
    if (!(icon_ld == rhs.icon_ld))
      return false;
    if (!(description == rhs.description))
      return false;
    if (!(properties == rhs.properties))
      return false;
    if (!(platform == rhs.platform))
      return false;
    if (!(size == rhs.size))
      return false;
    if (!(languages == rhs.languages))
      return false;
    return true;
  }
  bool operator != (const AppBaseInfo &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const AppBaseInfo & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(AppBaseInfo &a, AppBaseInfo &b);

std::ostream& operator<<(std::ostream& out, const AppBaseInfo& obj);

typedef struct _EventNotification__isset {
  _EventNotification__isset() : key(false), contents(true) {}
  bool key :1;
  bool contents :1;
} _EventNotification__isset;

class EventNotification : public virtual ::apache::thrift::TBase {
 public:

  EventNotification(const EventNotification&);
  EventNotification& operator=(const EventNotification&);
  EventNotification() : key(), contents("{}") {
  }

  virtual ~EventNotification() throw();
  std::string key;
  JSON contents;

  _EventNotification__isset __isset;

  void __set_key(const std::string& val);

  void __set_contents(const JSON& val);

  bool operator == (const EventNotification & rhs) const
  {
    if (!(key == rhs.key))
      return false;
    if (!(contents == rhs.contents))
      return false;
    return true;
  }
  bool operator != (const EventNotification &rhs) const {
    return !(*this == rhs);
  }

  bool operator < (const EventNotification & ) const;

  uint32_t read(::apache::thrift::protocol::TProtocol* iprot);
  uint32_t write(::apache::thrift::protocol::TProtocol* oprot) const;

  virtual void printTo(std::ostream& out) const;
};

void swap(EventNotification &a, EventNotification &b);

std::ostream& operator<<(std::ostream& out, const EventNotification& obj);

}}} // namespace

#endif
