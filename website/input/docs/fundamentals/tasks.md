Title: Tasks
Order: 50
---

[//]: # (TOC Begin)

* [Introduction](#introduction)
* [Loading custom extensions](#loading-custom-extensions)
    * [Automatic discovery](#automatic-discovery)
        * [Operating system](#operating-system)
        * [Runtime framework](#runtime-framework)
        * [Project](#project)
    * [Forced scan](#forced-scan)

[//]: # (TOC End)

# Introduction

A task is a piece of code that can be executed.

A task can have multiple attributes (or arguments, if you prefer). The value of an attribute may contain references to a [property](properties).  These references will be resolved before the task is executed.

Tasks have a common structure:
```xml
    <name attribute1="value1" attribute2="value2" ... />
```
where name is the name of the task, attribute# is the attribute name, and value# is the value for this attribute.

**Note:** For more information see the [Task Reference](http://nant.sourceforge.net/release/latest/help/tasks/index.html).

# Loading custom extensions

Extensions can be devided in the following categories:
* Tasks
* Filters
* Functions
* Global Types

NAnt currently provides two mechanisms to make third-party extensions available for use in build scripts:
* Automatic discovery
* Forced scan

Both mechanisms use .NET reflection to scan one or more assemblies for the presence of extensions. When found, these extensions are registered in the NAnt type system, and from then on these are available for all build scripts (in the current NAnt instance).

## Automatic discovery

To facilitate registration of extensions that are used in multiple (or even all) build scripts, NAnt supports automatic discovery of extensions.

In this context, automatic discovery means scanning a predefined set of directories and files for extensions.

The actual set of directories and files that is scanned is determined by:
* Operating system
* Runtime framework
* Project

## Operating system

When starting NAnt, all assemblies matching the following patterns will be scanned for extensions:

**Windows**

| Pattern                            | Action  | Description                              |
|:-----------------------------------|:-------:|:-----------------------------------------|
| *Tasks.dll                         | include | NAnt Core assemblies                     |
| *Tests.dll                         | include | NAnt test assemblies                     |
| extensions/common/neutral/**/*.dll | include | Framework and version-neutral assemblies |
| NAnt.MSNetTasks.dll                | exclude | Microsoft.NET specific assembly          |
| NAnt.MSNet.Tests.dll               | exclude | Microsoft.NET specific test assembly     |

**Unix**

| Pattern                            | Action  | Description                              |
|:-----------------------------------|:-------:|:-----------------------------------------|
| *Tasks.dll                         | include | NAnt Core assemblies                     |
| *Tests.dll                         | include | NAnt test assemblies                     |
| extensions/common/neutral/**/*.dll | include | Framework and version-neutral assemblies |
| NAnt.MSNetTasks.dll                | exclude | Microsoft.NET specific assembly          |
| NAnt.MSNet.Tests.dll               | exclude | Microsoft.NET specific test assembly     |
| NAnt.Win32Tasks.dll                | exclude | Win32 specific assembly                  |
| NAnt.Win32.Tests.dll               | exclude | Win32 specific test assembly             |

**NOTE:** all patterns are matched relative to the NAnt base directory, which is the directory in which NAnt.exe is located.{: class="bg-info"}



### Runtime framework

Depending on the runtime framework on which NAnt is running, some additional directories are scanned.

In general, the following include patterns are applied:
* extensions/common/&lt;CLR version&gt;/**/*.dll
* extensions/&lt;framework family&gt;/neutral/**/*.dll
* extensions/&lt;framework family&gt;/&lt;framework version&gt;/**/*.dll

**Example:**

When running NAnt on Microsoft .NET Framework 1.0, assemblies matching the following pattern would be scanned:
* extensions/common/1.0/**/*.dll
* extensions/net/neutral/**/*.dll
* extensions/net/1.0/**/*.dll

**NOTE:** the exact set of patterns that are used for a given runtime framework is defined in the NAnt configuration file (NAnt.exe.config).{: class="bg-info"}

### Project

Whenever a build project is started, NAnt will scan the following directories for assemblies that match the *.dll pattern:

    <Project Base Directory>/extensions/common/neutral/
    <Project Base Directory>/extensions/common/<CLR version>/
    <Project Base Directory>/extensions/<framework family>/neutral/
    <Project Base Directory>/tasks/<framework family>/<framework version>/

**Example:**

For a project file located in "c:\projects\log4net" with NAnt running on the Microsoft .NET 2.0 runtime, NAnt would end-up scanning the following project-level directories:

    c:\projects\log4net\extensions\common\neutral\
    c:\projects\log4net\extensions\common\2.0\
    c:\projects\log4net\extensions\net\neutral\
    c:\projects\log4net\extensions\net\2.0\

## Forced scan

To explicitly instruct NAnt to scan a certain assembly (or set of assemblies) for extensions, build authors can use the [&lt;loadtasks&gt;](http://nant.sourceforge.net/release/latest/help/tasks/loadtasks.html) tasks. 