include "../../../commons/Config/SDKDesc/ServiceCommon/thrift/CommonType/CommonTypeSDKDataTypes.thrift"

namespace * Ruyi.SDK.SettingSystem.Api

typedef string JSON

enum NodeType {
    Category = 1,
    SettingItem = 2,
    All = 3,
}


struct CategoryNode {
    1: string id,
    2: string categoryId,
    3: i32 sortingPriority,
    4: list<CategoryNode> children,
}

struct SettingSearchResult {
    1: string Version,
    2: list<CommonTypeSDKDataTypes.SettingItem> SettingItems,
}

struct SettingTree {
    1: CategoryNode CateNode,
    2: map<string, CommonTypeSDKDataTypes.SettingCategory> SettingCategories,
    3: map<string, CommonTypeSDKDataTypes.SettingItem> SettingItems,
}

struct NodeList {
    1: list<CommonTypeSDKDataTypes.SettingCategory> SettingCategories,
    2: list<CommonTypeSDKDataTypes.SettingItem> SettingItems,
}

/** Notification of setting item from layer0 */
struct SettingItemNotification {
    /** The item's ID */
	1: string key,
    /** Optional. The arguments of the notification. In json string format */
	2: JSON contents = "{}",
}


