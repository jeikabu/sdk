# Gamesdb.xml Format

If a [simple entry](overlay.md#compatibility) isn't working for your application, you might need to create a more advanced entry.  It might be necessary in the following cases:

* Your exe is a commonly used or very generic name
* Your application is composed of multiple executables
* You need to enable/disable [runtime features](#runtime-element)

This section describes the full grammar of the gamesdb.xml file.  If you still can't get it working, [get help](support.md).

## Overview

Gamesdb.xml contains numerous entries similar to:
```xml
<game>
    <id>9999</id> 
    <name>YourGameName</name>
    <conditions>
        <cond name="is-YourGameName.exe-present" type="exe-present" exe="YourGameName.exe"/>
    </conditions>
    <detection>
        <variant order="1" name="default">
            <if cond="is-YourGameName.exe-present"/>
        </variant>
    </detection>
    <runtime>
        <features>
            <option enabled="true"/>
        </features>
    </runtime>
</game>
```

If the rules specified by a `<variant>` matches for a running executable, it will be identified as an instance of the application specified by `<game>`.  Then the overlay will attach to the application based on `<runtime>`.

| XML Element | Description | Required | Details
|-|-|-|-
| id | App Id of the application ([link](dev_onboarding.md)) | Yes | E.g. `<id>12345</id>`
| name | Title of your application | Yes | E.g. `<name>Ruyi Test App</name>`
| conditions | All the environment conditions used in `<detection>` to specify `<variant>` rules | Yes | See [Conditions Element](#conditions-element)
| detection | Specify `<variant>` rules used to identify applications | Yes | See [Detection Element](#detection-element)
| runtime | Enables/disables `<features>` at runtime | No | See [Runtime Element](#conditions-element)

## Conditions Element

`<conditions>` contains one or more `<cond>` elements.  These are simple environment checks that are combined in [`<detection>`](#detection-element).

Format is:
```xml
<cond name="CONDITION_NAME" type="TYPE" TYPE_ATTR="ADDITIONAL_ARG" />
```

Where `CONDITION_NAME` is the unique name of the condition.

And `TYPE`, `TYPE_ATTR`, and `ADDITIONAL_ARG` are defined as follows:

| TYPE | Description | TYPE_ATTR | ADDITIONAL_ARG
|-|-|-|-
| exe-present | Matches name of executable | `exe` | Name of running executable
| file-present | Checks for presence of a file | `file` | Path of file
| file-absent | Checks for absence of a file | `file` | Path of file
| arg-present | Checks for presense of command-line argument | `arg` | Command line argument
| arg-absent | Checks for absence of command-line argument | `arg` | Command line argument
| reg-value-op | Deprecated | 

If __TYPE__ is `file-present` or `file-absent`, the `file` attribute may use the following macros:

| Macro | Description
|-|-
| `{exedir}` | Directory containing running executable
| `{exe}` | Name of running executable

## Detection Element

`<detection>` contains one or more `<variant>` elements.  Each `<variant>` contains one or more rules.  If all the rules in a `<variant>` match, then an instance of an application is detected.

The following rules are supported:

| Rule | Description | Example
|-|-|-
| `if` | Check if `<cond>` specified in [`<conditions>`](#conditions-element) is true | `<if name="CONDITION_NAME" />`

Additional attributes:  

| Attribute | Description
|-|-
| name | Name
| id | Additional tag with no special meaning
| order | Deprecated

## Runtime Element

When the overlay attaches to an application, `<runtime>` configures some aspect of the hooking or rendering.

It may contain the following sections:
- `<features>`
- `<ruyifeatures>`

Each section contains one or more elements similar to:
```xml
<ELEMENT ATTR="VALUE" />
```

Within `<features></features>`:

| ELEMENT | ATTR | VALUE | Description | Default
|-|-|-|-|-
| overlay | enabled | true/false | | true
| forcebind | enabled | true/false | | false
| forcetopmost | enabled | true/false | | false
| opengl-vbo-rendering | enabled | true/false | | true
| opengl-state-hooking | enabled | true/false | | true
| game-window-subclassing | enabled | true/false | Hook Windows message pump | true
| forcerenderer | type | direct3d/opengl | Force overlay to use specified rendering API | `""`; Auto-detect
| forcecursor | type | software/hardware | Force overlay to use hardware/software cursor | `""`; Auto
| renderer-hooking | method | normal/intrusive/factory | Deprecated | normal
| party-network | | | Deprecated

Within `<ruyifeatures></ruyifeatures>`:

| ELEMENT | ATTR | VALUE | Description | Default
|-|-|-|-|-
| ruyi_xinput | enabled | true/false | Hook XInput API | false
| ruyi_dinput | enabled | true/false | Hook DirectInput API | false
| ruyi_sdkinput | enabled | true/false | | false