# Overlay

The overlay is based off technology licensed from [Evolve](www.evolvehq.com) and provides the following functionality:  

* [In-app "overlay" UI](#Overlay-ui) displayed on top of apps (including pop-up notifications for achievements, etc.)
* [Taking screenshots](#Screenshots)
* [Input](#input.md) from devices (as an alternative to implementing input portion of SDK)
* __Coming soon:__ Recording video (see [DVR](dvr.md))

![](/docs/img/warning.png) The following are not (yet) supported:  

* Vulkan (coming less soon)
* HDR10 (not coming soon; see [hardware](hardware.md))

It is implemented via [dll injection](https://en.wikipedia.org/wiki/DLL_injection) (also called dll hooking) so it works without requiring any modifications to applications (it currently supports over 5000 games).  However, this might cause problems if your game uses anti-cheat middleware.

## API

Compatible apps don't __have__ to do anything with the SDK.

However, there are some functions related to the overlay in the SDK.  For example, apps can trigger a screenshot.  See [SDK documentation](https://subor.github.io/) for details.

## Compatibility

Your game can be made compatible with any of the following methods:
- __Coming Soon__ Automatic compatibility via `RuyiManifest.json`
- Creating a [manifest entry](#manifest)
- Editing [Gamesdb.xml](#gamesdb.xml)

### Manifest

Apps can be made compatible with the overlay by placing an entry in the [RuyiManifest](app_metadata.md) (from [UE4 sample](https://github.com/subor/sample_ue4_platformer/blob/development/Pack/RuyiManifest.json)):

```json
{
    ...
    "GameDb":{
        "Id": 6003,
        "Name": "PlatformerGame",
        "Conditions":[
            {"Name": "is-PlatformerGame.exe-present", "Type": "ExePresent", "AdditionalArg": "PlatformerGame.exe"}
        ],
        "Detection": [
            {"Name": "PlatformerGame", "Order": 1, "Rules": [{"Cond": "is-PlatformerGame.exe-present"}]}
        ],
        "Runtime": {
            "Features":{},
            "RuyiFeatures":{}
        }
    }
}
```

The JSON structure is derived from the [gamesdb.xml format](#gamesdb.xml).

Use [devtool](devtool) to check the overlay works with your app:

1. __App Root Folder__ should be directory containing your `RuyiManifest.json`
1. Ensure both layer0 and overlay are running
1. Click __Update GamesDB__
1. When you launch your app the overlay should attach
    - If it doesn't, shut down your app, check the contents of `RuyiManifest.json`, and repeat the above steps
    - If it still doesn't, see [debugging](#debugging)

![](/docs/img/devtool_update_gamesdb.png)

### Gamesdb.xml

The recommended way to make your app compatible is via [`RuyiManifest.json`](#manifest).  Alternatively, compatible apps may be listed in `RuyiOverlay/Resources/DeployRes/gamesdb.xml`.

1. [Shutdown Layer0](layer0.md)
1. Open `OverlayClient/DeployRes/gamesdb.xml` in a text/XML editor
1. Inside `<games version="2">` add a new `<game>` block similar to:

    ```xml
    <game>
        <!-- Your app id -->
        <id>9999</id> 
        <name>Your Game Name</name>
        <conditions>
            <cond name="is-YourGameName.exe-present" type="exe-present" exe="YourGameName.exe"/>
        </conditions>
        <detection>
            <variant order="1" name="default">
                <if cond="is-YourGameName.exe-present"/>
            </variant>
        </detection>
    </game>
    ```

1. Save `gamesdb.xml`
1. Restart layer0

__In most cases__, a simple entry like above will suffice.  For more advanced uses, consult [gamesdb.xml format](gamesdb_format.md).

## Overlay UI

## Screenshots

In-app screenshots may be taken via any of the following mechanisms:

- __Coming Soon__ Ruyi controller's _share_ button
- Gamepad or keyboard shortcut ([details](input.md))
- Selecting menu option in [overlay UI](#Overlay-UI)
- Programmatically from app via Ruyi SDK

## Input

Instead of integrating the input portion of the SDK, you may be able to leverage dll hooking of input APIs.  This _might_ work if your app uses any of the following:

- Engines: UE4
- Middleware: [SDL](http://libsdl.org/)
- APIs: [XInput or DirectInput](https://docs.microsoft.com/en-us/windows/desktop/xinput/xinput-and-directinput)

This currently does __NOT__ work if your app uses:
- __Coming Soon__ [New Unity input system](https://github.com/Unity-Technologies/InputSystem)
- [HID API](https://docs.microsoft.com/en-us/windows-hardware/drivers/hid/introduction-to-hid-concepts) (support will be added in the future)
- [Unity Input](https://docs.unity3d.com/ScriptReference/Input.html) (which uses HID)


```json
"Runtime": {
    "RuyiFeatures":{

    }
}
```

## Debugging

Some registry values in `HKLM/Software/Subor/Ruyi` can be set (or created):

| Name | Type | Description
|-|-|-
| `EnableDisplayDriverLogging` | DWORD | If __1__, additional logging is done
| `DisplayDriverLogFilePath` | string/REG_SZ | Path of file for log output

