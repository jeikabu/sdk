// This autogenerated skeleton file illustrates how to build a server.
// You should copy it to another filename to avoid overwriting it.

#include "SettingSystemService.h"
#include <thrift/protocol/TBinaryProtocol.h>
#include <thrift/server/TSimpleServer.h>
#include <thrift/transport/TServerSocket.h>
#include <thrift/transport/TBufferTransports.h>

using namespace ::apache::thrift;
using namespace ::apache::thrift::protocol;
using namespace ::apache::thrift::transport;
using namespace ::apache::thrift::server;

using namespace  ::Ruyi::SDK::SettingSystem::Api;

class SettingSystemServiceHandler : virtual public SettingSystemServiceIf {
 public:
  SettingSystemServiceHandler() {
    // Your initialization goes here
  }

  /**
   * Get a setting data of the module.
   * 
   * @param id The setting's unique id in current module.
   */
  void GetSettingItem( ::Ruyi::SDK::CommonType::SettingItem& _return, const std::string& id) {
    // Your implementation goes here
    printf("GetSettingItem\n");
  }

  /**
   * Get a list of setting data of the module.
   * 
   * @param category Category to filter the settings. Null indicates getting all settings of the module
   * 
   * @param includeChildren Whecher to get the settings of children cagegories.
   */
  void GetSettingItems(std::vector< ::Ruyi::SDK::CommonType::SettingItem> & _return, const std::string& category, const bool includeChildren) {
    // Your implementation goes here
    printf("GetSettingItems\n");
  }

  /**
   * Search a set of settings using a json format string.
   * According to the format of json string your write, searching can be separated to 3 types: simple search, lambda search and complicated search. And each of they can be combined with the other.
   * 
   * @param filterJson Json string used to search.
   */
  void SearchSettingItems(std::map<std::string,  ::Ruyi::SDK::SettingSystem::Api::SettingSearchResult> & _return, const std::string& filterJson) {
    // Your implementation goes here
    printf("SearchSettingItems\n");
  }

  /**
   * Get settings and categories in a tree
   */
  void GetCategoryNode( ::Ruyi::SDK::SettingSystem::Api::SettingTree& _return) {
    // Your implementation goes here
    printf("GetCategoryNode\n");
  }

  /**
   * Get child nodes of specified setting item or setting category
   * 
   * @param parent The parent node
   * 
   * @param nodeType Specifies whether the child nodes containing setting item or setting category, or both
   * 
   * @param param The parameter passed to the function which will be called while getting the item value
   * 
   * @param tags Tags used to filter the setting items. Only items with specified tags will be added in the result
   */
  void GetChildNode( ::Ruyi::SDK::SettingSystem::Api::NodeList& _return, const std::string& parent, const  ::Ruyi::SDK::SettingSystem::Api::NodeType::type nodeType, const std::string& param, const std::vector<std::string> & tags) {
    // Your implementation goes here
    printf("GetChildNode\n");
  }

  /**
   * Set the specified setting's "dataValue" with the new value
   * 
   * @param key Identity of the setting
   * 
   * @param val Value to be set
   */
  bool SetSettingItem(const std::string& key, const std::string& val) {
    // Your implementation goes here
    printf("SetSettingItem\n");
  }

  /**
   * Set a set of settings' "dataValue"
   * 
   * @param keyValues The key-values to be set.
   */
  int32_t SetSettingItems(const std::map<std::string, std::string> & keyValues) {
    // Your implementation goes here
    printf("SetSettingItems\n");
  }

  /**
   * Restore a module setting to default
   * 
   * @param moduleName Module name specifies the module to be restored.
   * 
   * @param category The category of which to restored. Null indicates all settings.
   */
  bool RestoreDefault(const std::string& moduleName, const std::string& category) {
    // Your implementation goes here
    printf("RestoreDefault\n");
  }

  /**
   * @RestoreUserDefault_Summary
   * 
   * @param userId @RestoreUserDefault_userId_desc
   * 
   * @param moduleName @RestoreUserDefault_moduleName_desc
   * 
   * @param category @RestoreUserDefault_category_desc
   */
  bool RestoreUserDefault(const std::string& userId, const std::string& moduleName, const std::string& category) {
    // Your implementation goes here
    printf("RestoreUserDefault\n");
  }

  /**
   * Update the module settings from an older version to the latest one
   * 
   * @param moduleName Module of the setting
   */
  bool UpdateModuleVersion(const std::string& moduleName) {
    // Your implementation goes here
    printf("UpdateModuleVersion\n");
  }

  /**
   * @SetUserAppData_Summary
   * 
   * @param userId @SetUserAppData_userId_desc
   * 
   * @param category @SetUserAppData_category_desc
   * 
   * @param settingItems @SetUserAppData_settingItems_desc
   */
  int32_t SetUserAppData(const std::string& userId, const std::string& category, const std::map<std::string,  ::Ruyi::SDK::CommonType::SettingValue> & settingItems) {
    // Your implementation goes here
    printf("SetUserAppData\n");
  }

  /**
   * @GetUserAppData_Summary
   * 
   * @param userId @GetUserAppData_userId_desc
   * 
   * @param category @GetUserAppData_category_desc
   * 
   * @param settingKeys @GetUserAppData_settingKeys_desc
   */
  void GetUserAppData( ::Ruyi::SDK::CommonType::AppData& _return, const std::string& userId, const std::string& category, const std::vector<std::string> & settingKeys) {
    // Your implementation goes here
    printf("GetUserAppData\n");
  }

  /**
   * @RemoveUserAppData_Summary
   * 
   * @param userId @RemoveUserAppData_userId_desc
   * 
   * @param category @RemoveUserAppData_category_desc
   * 
   * @param settingKeys @RemoveUserAppData_settingKeys_desc
   */
  int32_t RemoveUserAppData(const std::string& userId, const std::string& category, const std::vector<std::string> & settingKeys) {
    // Your implementation goes here
    printf("RemoveUserAppData\n");
  }

  /**
   * Notify layer0 that a setting item has specific event
   * 
   * @param key The item's ID
   * 
   * @param contents Optional. The arguments of the notification. In json string format
   */
  bool SettingItemNotify(const std::string& key, const  ::Ruyi::SDK::SettingSystem::Api::JSON& contents) {
    // Your implementation goes here
    printf("SettingItemNotify\n");
  }

  void GetNetworkAdapterSettings( ::Ruyi::SDK::SettingSystem::Api::NetworkSettings& _return) {
    // Your implementation goes here
    printf("GetNetworkAdapterSettings\n");
  }

  void GetLanNetworkName(std::string& _return) {
    // Your implementation goes here
    printf("GetLanNetworkName\n");
  }

  bool SetNetworkSettings(const bool isWLan, const bool EnableDHCP, const std::string& IpAddress, const std::string& SubMask, const std::string& Gateway, const std::string& MainDNS, const std::string& SubDNS) {
    // Your implementation goes here
    printf("SetNetworkSettings\n");
  }

  bool SetNetworkProxy(const std::string& ProxyServer, const std::string& ProxyPort) {
    // Your implementation goes here
    printf("SetNetworkProxy\n");
  }

  bool ConnectToWifi(const std::string& profileName, const std::string& key) {
    // Your implementation goes here
    printf("ConnectToWifi\n");
  }

  bool ConnectToAppointedWifi(const std::string& profileName, const std::string& Auth, const std::string& Ciper, const std::string& KeyType, const std::string& key) {
    // Your implementation goes here
    printf("ConnectToAppointedWifi\n");
  }

  void GetNetworkSettings( ::Ruyi::SDK::SettingSystem::Api::RuyiNetworkSettings& _return) {
    // Your implementation goes here
    printf("GetNetworkSettings\n");
  }

  void GetNetworkStatus( ::Ruyi::SDK::SettingSystem::Api::RuyiNetworkStatus& _return) {
    // Your implementation goes here
    printf("GetNetworkStatus\n");
  }

  void RuyiTestNetwork( ::Ruyi::SDK::SettingSystem::Api::RuyiNetworkTestResult& _return) {
    // Your implementation goes here
    printf("RuyiTestNetwork\n");
  }

  bool RuyiStartNetworkSpeedTest(const int32_t userindex) {
    // Your implementation goes here
    printf("RuyiStartNetworkSpeedTest\n");
  }

  bool RuyiStopNetworkSpeedTest(const int32_t userindex) {
    // Your implementation goes here
    printf("RuyiStopNetworkSpeedTest\n");
  }

  void GetAvailableWifi(std::vector< ::Ruyi::SDK::SettingSystem::Api::WifiEntity> & _return) {
    // Your implementation goes here
    printf("GetAvailableWifi\n");
  }

  bool DisconnectWifi() {
    // Your implementation goes here
    printf("DisconnectWifi\n");
  }

  bool DiscoverBluetoothDevice() {
    // Your implementation goes here
    printf("DiscoverBluetoothDevice\n");
  }

  bool ConnectBluetoothDevice(const std::string& DeviceName, const std::string& DeviceAddress) {
    // Your implementation goes here
    printf("ConnectBluetoothDevice\n");
  }

  bool DisconnectBluetoothDevice(const std::string& DeviceName, const std::string& DeviceAddress) {
    // Your implementation goes here
    printf("DisconnectBluetoothDevice\n");
  }

  bool RemoveBluetoothDevice(const std::string& DeviceName, const std::string& DeviceAddress) {
    // Your implementation goes here
    printf("RemoveBluetoothDevice\n");
  }

};

int main(int argc, char **argv) {
  int port = 9090;
  ::apache::thrift::stdcxx::shared_ptr<SettingSystemServiceHandler> handler(new SettingSystemServiceHandler());
  ::apache::thrift::stdcxx::shared_ptr<TProcessor> processor(new SettingSystemServiceProcessor(handler));
  ::apache::thrift::stdcxx::shared_ptr<TServerTransport> serverTransport(new TServerSocket(port));
  ::apache::thrift::stdcxx::shared_ptr<TTransportFactory> transportFactory(new TBufferedTransportFactory());
  ::apache::thrift::stdcxx::shared_ptr<TProtocolFactory> protocolFactory(new TBinaryProtocolFactory());

  TSimpleServer server(processor, serverTransport, transportFactory, protocolFactory);
  server.serve();
  return 0;
}

