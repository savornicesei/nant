---
Title: Frequently Asked Questions
Order: 60
---

[//]: # (TOC Begin)

* [Running NAnt](#running-nant)
    * [Security exception](#security-exception)
* [Building NAnt](#building-nant)
    * [NullReferenceException when building NAnt on Mono](#nullreferenceexception-when-building-nant-on-mono)
* [Debugging NAnt](#debugging-nant)
    * [Debug NAnt in Visual Studio](#debug-nant-in-visual-studio)
* [General](#general)
    * [Default framework targeted by NAnt](#default-framework-targeted-by-nant)
    * [Changing the target framework](#change-targetframework)
    * [Configure Visual Studio to recognize .build files as XML files](#configure-visual-studio-to-recognize-build-files-as-xml-files)
    * [Enable intellisense for .build files](#enable-intellisense-for-build-files)

[//]: # (TOC End)

## Running NAnt {#running-nant}

### Security exception {#security-exception}

Q: I am getting the following security exception when I try to run NAnt:  

![error msg](https://cloud.githubusercontent.com/assets/7837837/3226348/10083990-f06b-11e3-8955-263c885a5ffa.jpg)

A: This issue is well documented on [Surfjungle's Build & Release Management Blog](http://surfjungle.blogspot.com/2011/11/tip-running-nant-091-on-windows-7.html) and other places online. The summary of this issue is that zip files downloaded from the internet are saved as blocked files on Windows machines starting with Vista/7. When you unzip a blocked zip file and try to run any binary program that was extracted, this kind of error can appear.  To prevent this error from happening, perform the following steps:

1. Right-click on the zip file
2. Select "Properties"
3. Click the "Unblock" button in the zip file properties window and hit ok
4. Unzip the zip file and run NAnt as normal

NAnt should now run as normal without the above exception.

This is done via the packages.config file at the root of the tools folder.  See this [tutorial](https://cakebuild.net/docs/tutorials/pinning-cake-version) for more information.

## Building NAnt {#building-nant}

### NullReferenceException when building NAnt on Mono {#nullreferenceexception-when-building-nant-on-mono}

There are currently some regressions in Mono CVS ([bug #55996](http://bugzilla.ximian.com/show_bug.cgi?id=55996)) with regards to AppDomain unloading which cause a NullReferenceException when building NAnt.

Zoltan Varga implemented a workaround for this issue: set the environment variable `MONO_NO_UNLOAD` to any value before running NAnt:

```
$ export MONO_NO_UNLOAD=1
$ make clean
$ make
$ mono bin/NAnt.exe clean build
```

## Debugging NAnt {#debugging-nant}

### Debug NAnt in Visual Studio {#debug-nant-in-visual-studio}

NAnt cannot be built using VS.NET, as VS.NET (prior to VS.NET 2005) is unable to handle dependencies between projects very well.

However, you can compile NAnt using the NAnt build scripts, and then debug NAnt using VS.NET. To do this, open the NAnt solution file in VS.NET and change the following debugging properties of the _NAnt.Console_ project (using Project -> Properties -> Configuration Properties -> Debugging):

* Debug Mode: Program
* Start Application: {select NAnt.exe that you just compiled}

Finally, just run NAnt in VS.NET (using Debug -> Start or just F5), and when VS.NET informs you that there were build errors, and asks whether you still want to continue : select _Yes_.

## General {#general}

### Default framework targeted by NAnt {#default-framework-targeted-by-nant}

As from NAnt 0.85, NAnt by default targets the framework on which its running.

### Changing the target framework {#change-targetframework}

NAnt supports three ways for changing the target framework:

From the command line, using the -t\[argetframework\] argument:

```    NAnt.exe -t:net-1.0 ```

By changing the default target framework in the NAnt configuration file:

```xml
    <frameworks>
        <platform name="win32" default="net-1.0">
            ...
        </platform>
    </frameworks>
```

By changing the value of the system property `nant.settings.currentframework`: 

```xml 
<property name="nant.settings.currentframework" value="net-1.0" /> 
```

### Configure Visual Studio to recognize .build files as XML files {#configure-visual-studio-to-recognize-build-files-as-xml-files}

1. In "Solution Explorer", right-click a .build file and choose "Open With".
2. In the "Open With" dialog, select "HTML/XML Editor" and click the "Set as Default" button.

### Enable intellisense for .build files {#enable-intellisense-for-build-files}

Copy the schema for your version of NAnt from the schema folder in the NAnt distribution to:

* Visual Studio .NET 2003
    * The "Common7\Packages\schemas\xml" subdirectory of your Visual Studio.NET installation.
* Visual Studio 2005
    * The "Xml\Schemas" subdirectory of your Visual Studio 2005 installation.