---
Title: Release Notes
---

# 0.85 - October 14, 2006 {v0.85}

## NAnt

---

### **Bug fixes**

**Framework support**

* **.NET Compact Framework 2.0**

  * Embedded resource files cannot be compiled when targeting .NET Compact Framework 2.0 (bug [#1533924](https://sourceforge.net/tracker/index.php?func=detail&aid=1533924&group_id=31650&atid=4028680)).

**Functions**

* **file::is-assembly**

  * Function call fails when a file name that does not correspond with an assembly is specified as argument.

**Tasks**

* **&lt;aximp&gt;**

  * The value of the "rcw" attribute should be ignored when targeting .NET 1.0.

* **&lt;csc&gt;**

  * Output is always rebuilt when "keyfile" attribute is set (bug [#1550736](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1550736&group_id=31650)).

* **&lt;regen&gt;**

  * Assembly reference are not taken into account to determine if the maximum length of the command line is exceeded (bug [#1415272](https://sourceforge.net/tracker/index.php?func=detail&aid=1415272&group_id=31650&atid=402868)).

* **&lt;solution&gt;**

  * Runtime callable wrapper is not used when generating Windows Forms control for ActiveX component that has no Primary Interop Assembly.  
  * When importing a type library, [out, retval] parameters of methods on dispatch-only interfaces (dispinterfaces) are not transformed into return values (bug [#1527210](https://sourceforge.net/tracker/index.php?func=detail&aid=1527210&group_id=31650&atid=402868)).  
  * Dependencies are not handled properly for Enterprise Template projects in Visual Studio .NET 2003 solutions (bug [#1534864](https://sourceforge.net/tracker/index.php?func=detail&aid=1534864&group_id=31650&atid=402868)).

* **&lt;unzip&gt;**

  * Zip file containing zero-length files fails to extract (bug [#1503678](http://sourceforge.net/tracker/index.php?func=detail&aid=1503678&group_id=31650&atid=402868)).


### **Changes**

**Tasks**

* **&lt;tlbimp&gt;**

  * Added "transform" attribute which sets the name of transform to use for transforming the metadata. [.NET 1.1 or higher]

* **&lt;vbc&gt;**

  * Added "nostdlib" attribute which can be used to instruct the compiler not to reference standard libraries (system.dll and VBC.RSP). [.NET 2.0 or higher]


## NAntContrib

---

### **Changes**

**Tasks**

* **&lt;sql&gt;**

  * Introduced "encoding" attribute to allow the encoding of files containing SQL statements to be specified. The default is the the system's current ANSI code page.



# 0.85-rc4 - June 2, 2006 {v0.85-rc4}

## NAnt

---

### **Framework support**

  * Added support for .NET Framework 2.0 (except for *&lt;solution&gt;*{: class="text-primary"} task).

### **Breaking changes**

**Tasks**

* **&lt;delete&gt;**

  * Attempting to delete a file or directory that does not exist, no longer results in a build failure.

### **Bug fixes**

**Core**

* **XmlLogger**

  * XmlLogger produced invalid XML for elements that are not closed (bug [#1220439](https://sourceforge.net/tracker/index.php?func=detail&aid=1220439&group_id=31650&atid=402868)).

**Filters**
* **&lt;replacetokens&gt;**

  * Empty value is not supported for token (bug [#1192677](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1192677&group_id=31650)).

**Tasks**

* **&lt;cl&gt;**

  * Logic for determining whether compilation is necessary is not correct when PCH file is specified (bug [#1191185](http://sourceforge.net/tracker/index.php?func=detail&aid=1191185&group_id=31650&atid=402868)).
  * All sources are compiled if any of the specified sources is not up-to-date (bug [#1191285](http://sourceforge.net/tracker/index.php?func=detail&aid=1191285&group_id=31650&atid=402868)).
  * Macro definitions specified using the *&lt;defines&gt;*{: class="text-primary"} collection are passed to the compiler, regardless of the value of the "if" and "unless" attributes (bug [#1221945](http://sourceforge.net/tracker/index.php?func=detail&aid=1221945&group_id=31650&atid=402868)).

* **&lt;rc&gt;**

  * Modification of an external file does not trigger a rebuilt of the resource (bug [#1195320](https://sourceforge.net/tracker/index.php?func=detail&aid=1195320&group_id=31650&atid=402868)).
  * Macro definitions specified using the *&lt;defines&gt;*{: class="text-primary"} collection are passed to the compiler, regardless of the value of the "if" and "unless" attributes (bug [#1221945](http://sourceforge.net/tracker/index.php?func=detail&aid=1221945&group_id=31650&atid=402868)).

* **&lt;script&gt;**

  * Defining custom extensions (eg. tasks) using multiple *&lt;script&gt;*{: class="text-primary"} instances results in an INTERNAL ERROR (bug [#1187957](http://sourceforge.net/tracker/index.php?func=detail&aid=1187957&group_id=31650&atid=402868)).

* **&lt;solution&gt;**

  * Compilation of embedded resources is slow.
  * Assembly signing fails for web projects.
  * Build fails if XML Documentation File does not exist (bug [#1188394](http://sourceforge.net/tracker/index.php?func=detail&aid=1188394&group_id=31650&atid=402868)).
  * Satellite assemblies of reference projects are not copied to the output directory of referencing projects (bug [#1212909](http://sourceforge.net/tracker/index.php?func=detail&aid=1212909&group_id=31650&atid=402868)).
  * Changes in project file are not detected (bug [#1209741](http://sourceforge.net/tracker/index.php?func=detail&aid=1209741&group_id=31650&atid=402868)).
  * Error message that is output when a project does not exist, is misleading (bug [#1396124](https://sourceforge.net/tracker/index.php?func=detail&aid=1396124&group_id=31650&atid=402868)).
  * Large number of localized resources causes build failure (bug [#1425251](https://sourceforge.net/tracker/index.php?func=detail&aid=1425251&group_id=31650&atid=402868)).
  * Registering a project for COM interop fails for projects which reference other local assembly or projects (bug [#1477827](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1477827&group_id=31650)).
  * Unused assembly reference that cannot be resolved or does not exist results in build failure (bug [#1186176](http://sourceforge.net/tracker/index.php?func=detail&aid=1186176&group_id=31650&atid=402868)).
  * Visual C++
    * File-level option to enable Managed Extensions is ignored (bug [#1190966](https://sourceforge.net/tracker/index.php?func=detail&aid=1190966&group_id=31650&atid=402868)).
    * Linking fails if object file name is explictly set for a specific source file (bug [#1205728](http://sourceforge.net/tracker/index.php?func=detail&aid=1205728&group_id=31650&atid=402868)).
    * Delay loaded DLLs option is ignored.
    * Output files of dependent or referenced projects are not included when linking (bug [#1186838](http://sourceforge.net/tracker/index.php?func=detail&aid=1186838&group_id=31650&atid=402868) and [#1124296](http://sourceforge.net/tracker/index.php?func=detail&aid=1124296&group_id=31650&atid=402868)).
    * References to COM components are now supported (bug [#1437970](https://sourceforge.net/tracker/index.php?func=detail&aid=1437970&group_id=31650&atid=402868)).


### **Additions**

**Tasks**

* **&lt;regasm&gt;**

  * Registers an assembly, or set of assemblies for use from COM clients.

### **Changes**

**Core**

* **log4net**

  * Upgraded to log4net 1.2.9.

* **MailLogger**

  * Added "MailLogger.success.attachments" and "MailLogger.failure.attachments" properties to allow a set of files to be attached to the message that is sent.

* **Define types in task containers**

  * Global types can now be (re)defined in task containers (such a *&lt;if&gt;*{: class="text-primary"} , *&lt;foreach&gt;*{: class="text-primary"}).  

  For example:

    ```xml
    <project name="container-type" default="build">
        <if test="${platform::is-win32()}">
            <fileset id="sources">
                <include name="**/*.cs" />
                <!-- exclude Unix-specific classes -->
                <exclude name="**/Unix/*.cs" />
            </fileset>
        </if>
        <if test="${platform::is-unix()}">
            <fileset id="sources">
                <include name="**/*.cs" />
                <!-- exclude Win32-specific classes -->
                <exclude name="**/Win32/*.cs" />
            </fileset>
        </if>
        <target name="build">
            <csc output="IvsController.dll">
                <sources refid="sources" />
                <references>
                    <include name="System.dll" />
                    <include name="System.Data.dll" />
                    <include name="System.Xml.dll" />
                </references>
            </csc>
        </target>
    </project>
    ```                

    Up until now, only tasks could be executed in these containers.

**Tasks**

* **&lt;csc&gt;**

  * The */langversion*{: class="text-primary"} and */platform*{: class="text-primary"} commandline options of the C# compiler are now exposed as attributes.  
  * Added support for */keycontainer*{: class="text-primary"} and */keyfile*{: class="text-primary"} commandline options [Mono / .NET 2.0 or higher].

* **&lt;jsc&gt;**

  * The */platform*{: class="text-primary"} commandline option of the JScript.NET compiler is now exposed using the "platform" attribute.

* **&lt;link&gt;**

  * Introduced support for delay loaded DLLs.

* **&lt;nunit2&gt;**

  * Upgraded to NUnit 2.2.8.

* **&lt;unzip&gt;**

  * The character encoding that has been used for file names inside the zip file can now be set using the "encoding" parameter.

* **&lt;vbc&gt;**

  * The */platform*{: class="text-primary"} commandline option of the VB.NET compiler is now exposed using the "platform" attribute. [.NET 2.0 or higher]
  * Added support for */keycontainer*{: class="text-primary"} and */keyfile*{: class="text-primary"} commandline options. [.NET 2.0 or higher]

* **&lt;vjc&gt;**

  * Added support for */keycontainer*{: class="text-primary"} and */keyfile*{: class="text-primary"} commandline options.

* **&lt;zip&gt;**

  * Added "duplicate" parameter to allow build authors to control how duplicate file entries are to be processed.
  * Introduced "encoding" parameter for setting the encoding to be used for file names.

**Types**

* **&lt;arg&gt;**

  * Added "dir" attribute for directory-based command-line arguments. (feature request [#1193982](http://sourceforge.net/tracker/index.php?func=detail&aid=1193982&group_id=31650&atid=402871)).


## NAntContrib

---

### **Bug fixes**

**Tasks**

* **&lt;msi&gt; / &lt;msm&gt;**

  * Defining "failonerror" attribute results in validation error. (bug [#1227294](https://sourceforge.net/tracker/?func=detail&atid=474851&aid=1227294&group_id=54790)).

* **&lt;vb6&gt;**

  * Type library and component references are not parsed correctly (bug [#1184630](http://sourceforge.net/tracker/index.php?func=detail&aid=1184630&group_id=54790&atid=474851)).

* **&lt;vssdelete&gt;**

  * A file or project was destroyed if "destroy" was **false**, and deleted if "destroy" was **true**.

* **&lt;vssget&gt;**

  * Setting the "removedeleted" attribute for a "path" that refers to a file results in a COMException (This command only works on projects).

### **Changes**

**Tasks**

* **&lt;fxcop&gt;**

  * Added failOnAnalysisError attribute - Fail the task if analysis errors are generated by FxCop.

* **&lt;regasm&gt;**

  * Moved to NAnt project.

### **Additions**

**Tasks**

* **&lt;btsdeploy&gt;**

  * Deploys an assembly to a given BizTalk configuration database.

* **&lt;btsexport&gt;**

  * Exports bindings for a BizTalk assembly to an assembly binding information file.

* **&lt;btshost&gt;**

  * Allows BizTalk (in-process) host instances to be controlled.

* **&lt;btsimport&gt;**

  * Imports bindings from a given assembly binding information file into the specified BizTalk configuration database.

* **&lt;btsorchestration&gt;**

  * Performs a set of actions on a given orchestration.

* **&lt;btsreset&gt;**

  * Allows stopping, starting and resetting of BizTalk in-process host instances on the specified server.

* **&lt;btssendport&gt;**

  * Allows BizTalk send ports to be controlled.

* **&lt;btsunbind&gt;**

  * Removes all bindings for a given assembly from a BizTalk configuration database.

* **&lt;btsundeploy&gt;**

  * Removes a given assembly from a BizTalk configuration database.

* **&lt;cccatcs&gt;**

  * Displays a ClearCase config spec.

* **&lt;cccheckin&gt;**

  * Checks files into a ClearCase VOB.

* **&lt;cccheckout&gt;**

  * Checks files out of a ClearCase VOB.

* **&lt;cclock&gt;**

  * Locks ClearCase elements.

* **&lt;ccmkelem&gt;**

  * Creates elements in a ClearCase VOB.

* **&lt;ccmklabel&gt;**

  * Applies a ClearCase label.

* **&lt;ccmklbtype&gt;**

  * Creates a label object in a ClearCase VOB.

* **&lt;ccrmtype&gt;**

  * Removes elements from a ClearCase VOB.

* **&lt;ccuncheckout&gt;**

  * Uncheckout ClearCase elements.

* **&lt;ccunlock&gt;**

  * Unlocks ClearCase elements.

* **&lt;ccupdate&gt;**

  * Updates a ClearCase view.

* **&lt;cd&gt;**

  * Changes the current working directory.

* **&lt;choose&gt;**

  * Executes an alternate set of tasks depending on conditions that are individually set on each group of tasks.

* **&lt;iisapppool&gt;**

  * Allows an IIS application pool to be controlled.

* **&lt;msbuild&gt;**

  * Builds the specified targets in the project file using MSBuild.

* **&lt;vssdelete&gt;**

  * Used to delete or Destroy files or projects in Visual Source Safe. Submitted by Richard Adleta.

**Functions**

* **fileset functions**

  * Provides methods for interrogating filesets.

* **service functions**

  * Allow information on a Windows service to be retrieved.



# 0.85-rc3 - April 16, 2005 {v0.85-rc3}

## NAnt

---

### **Breaking changes**

**Tasks**

* **&lt;nant&gt;**

  * References are no longer copied to the new projects by default. This is now controlled using the "inheritrefs" attribute.

### **Bug fixes**

**Core**

* **XML Schema**

  * "if" and "unless" attributes of *&lt;target&gt;*{: class="text-primary"} element are not documented (bug [#1168170](https://sourceforge.net/tracker/index.php?func=detail&aid=1168170&group_id=31650&atid=402868)).

**Tasks**

* **&lt;copy&gt; / &lt;move&gt;**

  * If "flatten" is set to **true** and multiple source files are selected to be copied / moved to the same destination file, only the source file that was last written to should actually be copied / moved (bug [#1165252](http://sourceforge.net/tracker/index.php?func=detail&aid=1165252&group_id=31650&atid=402868)).

* **&lt;link&gt;**

  * Additional include directory containing spaces leads to build failures (bug [#1117794](http://sourceforge.net/tracker/index.php?func=detail&aid=1117794&group_id=31650&atid=402868)). This bug also affects the *&lt;solution&gt;*{: class="text-primary"} task.

* **&lt;nant&gt;**

  * Default value of "inheritall" attribute does not match documentation (bug [#1146121](https://sourceforge.net/tracker/index.php?func=detail&aid=1146121&group_id=31650&atid=402868)).
  * Documentation does not describe behavior of *&lt;nant&gt;*{: class="text-primary"} task for references (bug [#1146176](https://sourceforge.net/tracker/index.php?func=detail&aid=1146176&group_id=31650&atid=402868)).

* **&lt;ndoc&gt;**

  * When executing the *&lt;ndoc&gt;*{: class="text-primary"} task multiple times, the properties are not expanded again after the first execution (bug [#1124113](http://sourceforge.net/tracker/index.php?func=detail&aid=1124113&group_id=31650&atid=402868)).
  * Additional directories specified (using the *&lt;referencepaths&gt;*{: class="text-primary"} element) to search for assembly references were not correctly consumed.

* **&lt;resgen&gt;**

  * The "dynamicprefix" attribute is not honored when determining the name of the compiled resource file (bug [#1150186](http://sourceforge.net/tracker/index.php?func=detail&aid=1150186&group_id=31650&atid=402868)).

* **&lt;script&gt;**

  * Now supports any CodeDom provider, not just the built in languages (C#, VB, etc).
  * Allow lower case values ( c# and vb ) for the Language attribute.

* **&lt;servicecontroller&gt;**

  * Resources are leaked (bug [#1163461](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1163461&group_id=31650)).

* **&lt;call&gt;**

  * Added a "cascade" attribute to allow calling a single task without cascading all the dependencies. (bug [#1077323](http://sourceforge.net/tracker/index.php?func=detail&aid=1077323&group_id=31650&atid=402868)).

* **&lt;solution&gt;**

  * A relative path specified in the [AssemblyKeyFile](https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assemblykeyfileattribute) attribute must be resolved using either the solution directory or the intermediate output directory.
  * Configurations containing dashes are skipped (bug [#1184173](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1184173&group_id=31650)).
  * Check for existance of specified solution file is performed even if task is not to be executed (bug [#1178810](http://sourceforge.net/tracker/index.php?func=detail&aid=1178810&group_id=31650&atid=402868)).
  * Project configurations with names that do not match the solution configuration are skipped (bug [#947214](http://sourceforge.net/tracker/index.php?func=detail&aid=947214&group_id=31650&atid=402868)).
  * Projects are not always properly excluded (bug [#1143845](https://sourceforge.net/tracker/index.php?func=detail&aid=1143845&group_id=31650&atid=402868) and [#1182510](https://sourceforge.net/tracker/index.php?func=detail&aid=1182510&group_id=31650&atid=402868)).
  * Stack overflow in case of circular project references (bug [#1145670](http://sourceforge.net/tracker/index.php?func=detail&aid=1145670&group_id=31650&atid=402868)).
  * BaseAddress not correctly passed to compilers (bug [#1164709](http://sourceforge.net/tracker/index.php?func=detail&aid=1164709&group_id=31650&atid=402868)).
  * Project dependencies that are no longer included in the solution file result in a circular dependency error.
  * VB.NET
    * Referencing the same assembly multiple times results in an ambiguous reference (bug [#1178862](http://sourceforge.net/tracker/index.php?func=detail&aid=1178862&group_id=31650&atid=402868)).
  * Visual C++
    * Changes to source files or headers do not trigger a recompile (bug [#1155919](https://sourceforge.net/tracker/index.php?func=detail&aid=1155919&group_id=31650&atid=402868)).
    * Additional dependencies and library directory are ignored for static libraries (bug [#1173529](http://sourceforge.net/tracker/index.php?func=detail&aid=1173529&group_id=31650&atid=402868)).
    * IDL files without a type library are not supported (bug [#1160647](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1160647&group_id=31650)).
    * Target macros are not correctly expanded if output file is not set (bug [#1170100](http://sourceforge.net/tracker/index.php?func=detail&aid=1170100&group_id=31650&atid=402868)).
    * References to Static Library projects are ignored when linking, and passed to the compiler as Forced Using assemblies.
    * "Inherit project defaults" setting is ignored for Additional Dependencies of Linker (bug [#1178007](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1178007&group_id=31650)).
    * Additional project-level include directories are not merged with file-level include directories (bug [#1160043](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1160647&group_id=31650)).
    * Projects using precompiled header are always recompiled.

**Types**
* **&lt;fileset&gt;**

  * Patterns are read from file specified using *&lt;includesfile&gt;*{: class="text-primary"} element regardless of the value of conditional attributes ("if" and "unless").

### **Changes**

**Core**

* **MailLogger**

  * Added "MailLogger.body.encoding" property to allow the encoding of the body of the message to be set.

* **Response File**

  * NAnt now supports the use of a response file. Passing *@&lt;file&gt;*{: class="text-primary"} on the command line will cause the contents of *&lt;file&gt;*{: class="text-primary"} to be read as part of the command line. Multiple *@&lt;file&gt;*{: class="text-primary"} arguments may be used.

* **XmlLogger**

  * Project, target and task timing information is now output in a *&lt;duration&gt;*{: class="text-primary"} element in milliseconds (patch [#1122583](http://sourceforge.net/tracker/index.php?func=detail&aid=1122583&group_id=31650&atid=402870))

**Tasks**

* **&lt;csc&gt; / &lt;vbc&gt; / &lt;vjc&gt;**

  * Changed "debug" attribute from boolean to [DebugOutput](latest/reference/enums/NAnt.DotNet.Types.DebugOutput.html) enum to allow more control over the type of debugging information generated by the compiler.

* **&lt;lib&gt;**

  * Add "moduledefinition" attribute.

* **&lt;midl&gt;**

  * "tlb" attribute is no longer required.


### **Developer information**

**API**

* **FileSetAttribute**

  * The NAnt.Core.Attributes.FileSetAttribute is obsolete. Task developers should use the NAnt.Core.Attributes.BuildElementAttribute instead.  

  For example:
        
    ```csharp
    [~~FileSet~~BuildElement("fileset")]
    public FileSet CopyFileSet {
        get { return _fileset; }
        set { _fileset = value; }
    }
    ```

## NAntContrib

---

### **Bug fixes**

**Tasks**

* **&lt;msi&gt; / &lt;msm&gt;**

  * Directories containing spaces result in error 1639 during installation (bug [#1107112](https://sourceforge.net/tracker/?func=detail&atid=474851&aid=1107112&group_id=54790)).
  * Removed dependency of *&lt;properties&gt;*{: class="text-primary"} element (bug [#1149861](https://sourceforge.net/tracker/index.php?func=detail&aid=1149861&group_id=54790&atid=474851)).
  * Cabarc process would fail with spaces in filename (bug [#1153718](https://sourceforge.net/tracker/?func=detail&atid=474851&aid=1153718&group_id=54790)).
  * OCX's are not registered for self-registration (bug [#1165416](http://sourceforge.net/tracker/index.php?func=detail&aid=1165416&group_id=54790&atid=474851)).

### **Changes**

**Tasks**

* **&lt;codestats&gt;**

  * Added support for multiple line counters (patch [#1108543](http://sourceforge.net/tracker/index.php?func=detail&aid=1108543&group_id=54790&atid=474853)).

* **&lt;msi&gt; / &lt;msm&gt;**

  * Added support for fileset references.
  * Added *&lt;summaryinformation&gt;*{: class="text-primary"} element to specify information for the summary information stream (associated bug [#1149861](https://sourceforge.net/tracker/?func=detail&atid=474851&aid=1149861&group_id=54790)).
  * FeatureComponents table is not removed from merge modules (even when empty)
  * Added support for file, ini, and component searches. Depreciated the old syntax for registry searches. (associated bug [#1149948](https://sourceforge.net/tracker/?func=detail&atid=474851&aid=1149948&group_id=54790)).



# 0.85-rc2 - February 12, 2005 {v0.85-rc2}

## NAnt

---

### **General changes**

**Building NAnt**

  * The source distribution of NAnt no longer contains pre-built binaries to build a full version of NAnt. Instead, we now include GNU Make and NMake make files to build a bootstrap version of NAnt, which is then used to build the full version of NAnt.

**License**

  * The special exception that is part of the NAnt license has been modified to avoid confusion.

### **Bug fixes**

**Core**

* **XML Schema**

  * NAnt XML Schema definition for collection based elements was incorrect (bug [#1076620](http://sourceforge.net/tracker/index.php?func=detail&aid=1076620&group_id=31650&atid=402868)).

**Functions**

* **target::get-current-target()**

  * Current target is incorrect after execution of target using *&lt;call&gt;*{: class="text-primary"} task (bug [#1090260](http://sourceforge.net/tracker/index.php?func=detail&aid=1090260&group_id=31650&atid=402868)).

**Tasks**

* **&lt;cl&gt;**

  * *&lt;cl&gt;*{: class="text-primary"} does not recompile although headers have been updated (bug [#1079377](http://sourceforge.net/tracker/index.php?func=detail&aid=1079377&group_id=31650&atid=402868)).

* **&lt;mail&gt;**

  * Names containing comma's are not supported (bug [#961627](http://sourceforge.net/tracker/index.php?func=detail&aid=961627&group_id=31650&atid=402868)).

* **&lt;midl&gt;**

  * *&lt;midl&gt;*{: class="text-primary"} fails on second run if "header" or "iid" attributes are not specified (bug [#1078558](http://sourceforge.net/tracker/index.php?func=detail&aid=1078558&group_id=31650&atid=402868)).

* **&lt;solution&gt;**

  * Manifest resource names of resources in J# projects do not match those generated by Microsoft Visual Studio.NET.
  * For embedded resources that are dependent on a source file, namespace prefixing is wrong when a namespace declaration is not present in the source file (bug [#1077253](http://sourceforge.net/tracker/index.php?func=detail&aid=1077253&group_id=31650&atid=402868)).
  * Users should be warned about possible issues with resx files when building a project for a down-level target framework (bug [#1077254](http://sourceforge.net/tracker/index.php?func=detail&aid=1077254&group_id=31650&atid=402868)).
  * "App.config" should not be considered an output file for Class Library projects.
  * Win32 resources in Visual C++ projects are not compiled (bug [#1077712](http://sourceforge.net/tracker/index.php?func=detail&aid=1077712&group_id=31650&atid=402868)).
  * Improve error reporting when a referenced component cannot be resolved (bug [#1079777](http://sourceforge.net/tracker/index.php?func=detail&aid=1079777&group_id=31650&atid=402868)).
  * MFC and ATL shared linking is not supported for Visual C++ projects (bug [#1078636](http://sourceforge.net/tracker/index.php?func=detail&aid=1078636&group_id=31650&atid=402868)).
  * *&lt;solution&gt;*{: class="text-primary"} task doesn't support COM, OCX apps built in Visual C++ (bug [#1078641](http://sourceforge.net/tracker/index.php?func=detail&aid=1078641&group_id=31650&atid=402868)).
  * Support for some compile and link arguments is missing (bug [#1080237](http://sourceforge.net/tracker/index.php?func=detail&aid=1080237&group_id=31650&atid=402868)).
  * Project dependencies are not re-evaluated when assembly reference is converted to project reference (bug [#1076015](http://sourceforge.net/tracker/index.php?func=detail&aid=1076015&group_id=31650&atid=402868)).
  * Resolution of assembly references does not match Visual Studio .NET (bug [#1077869](http://sourceforge.net/tracker/index.php?func=detail&aid=1077869&group_id=31650&atid=402868)).

* **&lt;style&gt;**

  * Relative URI specified as argument for *document()*{: class="text-primary"} function is not considered to be relative to the base URI of stylesheet containing the function call (bug [#1078896](http://sourceforge.net/tracker/index.php?func=detail&aid=1078896&group_id=31650&atid=402868)).

* **&lt;sysinfo&gt;**

  * Document behavior when environment variable is defined with a name that is not a valid property name (bug [#1082225](http://sourceforge.net/tracker/index.php?func=detail&aid=1082225&group_id=31650&atid=402868)).

### **Additions**

**Tasks**

* **&lt;gunzip&gt;**

  * Expands a file packed using GZip compression.

* **&lt;setenv&gt;**

  * Sets environment variables.

**Types**

* **&lt;categories&gt;**

  * Controls the categories of tests to execute using the *&lt;nunit2&gt;*{: class="text-primary"} task.

### **Changes**

**Expressions**

* **Data Type support**

  * Added support for "long" data type for both relational and mathematical expressions.

**Tasks**

* **&lt;al&gt;**

  * Added numerous attributes. Eg. "version", "evidence", ... .

* **&lt;cl&gt;**

  * Added "pchthroughfile" and "pchmode" attributes to allow more control over precompiled header files.
    
  * Added "objectfile" and "pdbfile" attributes.

* **&lt;csc&gt;**

  * Added "baseaddress" and "filealign" attributes.

* **&lt;lc&gt;**

  * Deprecated "licensetarget" attribute in favor of "target" attribute.

* **&lt;exec&gt;**

  * Deprecated nested *&lt;option&gt;*{: class="text-primary"} element in favor of *&lt;variable&gt;*{: class="text-primary"} element for setting environment variables for the spawned process.

* **&lt;link&gt;**

  * Added "debug" and "pdbfile" attributes.
  * Added *&lt;modules&gt;*{: class="text-primary"} child element to link modules in the assembly.
  * Added *&lt;embeddedresources&gt;*{: class="text-primary"} child element to embed resources in the assembly.

* **&lt;mail&gt;**

  * "tolist" is no longer a required attribute.
  * The "tolist", "cclist" and "bcclist" attributes are now semicolon-separated lists. The comma is no longer considered a separator character.

* **&lt;ndoc&gt;**

  * Upgraded to NDoc 1.3.1 Release.

* **&lt;nunit2&gt;**

  * Added support including or excluding specific categories of test cases or fixtures.

* **&lt;resgen&gt;**

  * Added "usesourcepath" attribute to allow the source file's directory to be used as current directory for resolving relative file paths. [.NET 2.0 or higher]
  * Improved dependency scanning for resx files.

* **&lt;solution&gt;**

  * Improved support for precompiled header files.
  * Added support for project-level build events.

* **&lt;style&gt;**

  * Added support for extension objects.

**Types**

* **&lt;import&gt;**

  * The "name" attribute of the *&lt;import&gt;*{: class="text-primary"} element has been deprecated, and replaced by a "namespace" attribute. This change affects the following tasks: *&lt;asminfo&gt;*{: class="text-primary"}, *&lt;script&gt;*{: class="text-primary"} and *&lt;vbc&gt;*{: class="text-primary"}.


## NAntContrib

---

### **General changes**

* **License**

  * The special exception that is part of the NAntContrib license has been modified to avoid confusion.

* **Build Script(s)**

  * Removed single quotes around path variable in NAnt install (bug [#1153721](https://sourceforge.net/tracker/?func=detail&atid=474851&aid=1153721&group_id=54790)).

### **Bug fixes**

**Tasks**

* **&lt;vb6&gt;**

  * Fixed issue with scanning references to determine if a project needs compiling (bug [#1082302](https://sourceforge.net/tracker/?func=detail&atid=474851&aid=1082302&group_id=54790)).

* **&lt;msi&gt; / &lt;msm&gt;**

  * Fixed issue that caused error when invoking the same *&lt;msi&gt;*{: class="text-primary"} task multiple times (bug [#1040963](http://sourceforge.net/tracker/index.php?func=detail&aid=1040963&group_id=54790&atid=474851)).
  * Allow schema-generated tasks to work in build files with namespace (bug [#1077447](http://sourceforge.net/tracker/index.php?func=detail&aid=1077447&group_id=54790&atid=474851)).

* **&lt;p4sync&gt;**

  * Invalid command-line is generated when "force" is **true** (bug [#1081430](https://sourceforge.net/tracker/?func=detail&atid=474851&aid=1081430&group_id=54790)).

* **&lt;sql&gt;**

  * Avoid outputting separator line for empty rows.

* **&lt;svn-checkout&gt;**

  * Added '.' operator during checkout to fix issue with incorrect destination directory (bug [#1078255](http://sourceforge.net/tracker/index.php?func=detail&aid=1078255&group_id=54790&atid=474851)).

* **&lt;vsscheckout&gt;**

  * Checking out single file causes error.

* **&lt;vssget&gt;**

  * Getting single file causes error (bug [#1019972](http://sourceforge.net/tracker/index.php?func=detail&aid=1019972&group_id=54790&atid=474851)).

### **Additions**

**Tasks**

* **&lt;fxcop&gt;**

  * Analyzes managed code assemblies and reports information about the assemblies, such as possible design, localization, performance, and security improvements.

* **&lt;mkschanges&gt;**

  * Generates an XML file containing the differences between the sandbox and the project in the MKS database.

* **&lt;mkscheckpoint&gt;**

  * Checkpoints a project in an MKS Source Integrity database.

* **&lt;mksget&gt;**

  * Retrieves an item or project from MKS Source Integrity.

* **&lt;trycatch&gt;**

  * Executes a set of tasks, and optionally catches a build exception to allow recovery or rollback steps to be taken, or to define some steps to be taken regardless if the tasks succeed or fail, or both.

* **&lt;vsshistory&gt;**

  * Generates an XML file showing all changes made to a Visual SourceSafe project/file between specified labels or dates (by a given user).

### **Changes**

**Tasks**

* **&lt;deliisdir&gt;**

  * Added "website" attribute which allows for targeting a specific virtual site.

* **&lt;iisdirinfo&gt;**

  * Added "website" attribute which allows for targeting a specific virtual site.

* **&lt;mkiisdir&gt;**

  * Improved documentation.
  * Added "uncusername" and "uncpassword" attributes.
  * Added "website" attribute which allows for targeting a specific virtual site.

* **&lt;version&gt;**

  * Uses enums for the "buildtype" and "revisiontype" parameters.
  * The calculated version number and its indivual components are now also exposed to build authors as properties.

* **&lt;vssadd&gt;**

  * The "user" attribute is deprecated, and has been superceded by a "username" attribute.
  * The "user"/"username" attribute is no longer required. When no username is specified and "Use network name for automatic user log in" is enabled for the Visual SourceSafe database, then the current Windows username will be used to log in.

* **&lt;vsscheckin&gt;**

  * The "user" attribute is deprecated, and has been superceded by a "username" attribute.
  * The "user"/"username" attribute is no longer required. When no username is specified and "Use network name for automatic user log in" is enabled for the Visual SourceSafe database, then the current Windows username will be used to log in.
  * If "localpath" is not an absolute path, it will now be considered as a path relative to the project base directory.

* **&lt;vsscheckout&gt;**

  * The "user" attribute is deprecated, and has been superceded by a "username" attribute.
  * The "user"/"username" attribute is no longer required. When no username is specified and "Use network name for automatic user log in" is enabled for the Visual SourceSafe database, then the current Windows username will be used to log in.
  * Added "filetimestamp" attribute that allows the behavior for timestamps of local files to be set.
  * If "localpath" is not an absolute path, it will now be considered as a path relative to the project base directory.

* **&lt;vssdiff&gt;**

  * The "user" attribute is deprecated, and has been superceded by a "username" attribute.
  * The "user"/"username" attribute is no longer required. When no username is specified and "Use network name for automatic user log in" is enabled for the Visual SourceSafe database, then the current Windows username will be used to log in.

* **&lt;vssget&gt;**

  * The "user" attribute is deprecated, and has been superceded by a "username" attribute.
  * The "user"/"username" attribute is no longer required. When no username is specified and "Use network name for automatic user log in" is enabled for the Visual SourceSafe database, then the current Windows username will be used to log in.
  * Added "filetimestamp" attribute that allows the behavior for timestamps of local files to be set.
  * If "localpath" is not an absolute path, it will now be considered as a path relative to the project base directory.

* **&lt;vsslabel&gt;**

  * The "user" attribute is deprecated, and has been superceded by a "username" attribute.
  * The "user"/"username" attribute is no longer required. When no username is specified and "Use network name for automatic user log in" is enabled for the Visual SourceSafe database, then the current Windows username will be used to log in.

* **&lt;vssundocheckout&gt;**

  * The "user" attribute is deprecated, and has been superceded by a "username" attribute.
  * The "user"/"username" attribute is no longer required. When no username is specified and "Use network name for automatic user log in" is enabled for the Visual SourceSafe database, then the current Windows username will be used to log in.
  * If "localpath" is not an absolute path, it will now be considered as a path relative to the project base directory.



# 0.85-rc1 - November 28, 2004 {v0.85-rc1}

## NAnt

---

### **Framework support**

  * NAnt 0.85 adds support for the following frameworks (both as runtime and as target framework):
    * Mono (both 1.0 and 2.0 profile)
    * .NET 2.0 Beta 1
  * By default, NAnt will now target the framework on which its running. For example, if NAnt is running on .NET 2.0, the assemblies built using the *&lt;csc&gt;*{: class="text-primary"} task will target .NET 2.0. Previous versions of NAnt would target .NET 1.0 by default.
  * Information on how to override the target framework, can be found [here](/faq/#change-targetframework).

### **Breaking changes**

  * In previous version of NAnt, the *&lt;arg&gt;*{: class="text-primary"} element (used by, for example, the *&lt;exec&gt;*{: class="text-primary"} task) would automatically add quotes for both "file" and "value" attributes in the command line generated by the task. That automatic quoting has been removed for "value" attributes (but not for "file" attributes). This change may break build files that assume that both arguments specified using the "file" and "value" attributes will automatically be quoted.
  * Overwriting of read-only properties in tasks other than the *&lt;property&gt;*{: class="text-primary"} task will now result in a build failure. * Previous versions of NAnt would silently ignore an update of a read-only property.
  * The *&lt;nunit2&gt;*{: class="text-primary"} task been updated to support [NUnit 2.2](https://sourceforge.net/projects/nunit/files/NUnit%20Version%202/V2.2/). Assemblies built using previous versions of NUnit should either be rebuilt using [NUnit 2.2](https://sourceforge.net/projects/nunit/files/NUnit%20Version%202/V2.2/) or a [binding redirect](https://docs.microsoft.com/en-us/dotnet/framework/configure-apps/redirect-assembly-versions) should be configured in the application configuration file of the test assembly.

### **General changes**

  * Improved error reporting when invalid values are specified for attibutes representing files or directories.
  * This release of NAnt introduces support for expressions. More information is available [here](/docs/fundamentals/expressions).
  * [FilterChain](latest/reference/types/filterchain.html) support has been introduced to NAnt.
  * Enums that are used in tasks or types now have their own doc pages.
  * The default logger will now also output the number non-fatal errors and warnings.
  * Output of the [XmlLogger](/docs/fundamentals/loggers-and-listeners#xml-logger) is now buffered until build has finished, and [XmlLogger](/docs/fundamentals/loggers-and-listeners#xml-logger) can now also be used as a listener.
  * Added support for [wild targets](/docs/fundamentals/targets#wild-targets).
  * Lots of built-in properties have been deprecated, and replaced by functions. More information is available [here](/docs/fundamentals/properties).
  * NAnt will now report unknown attributes and child elements when initializing build elements.

### **Commandline changes**

  * Added "-e\[macs\]" option, which can be used to produce logging information without adornments.
  * Added "-ext\[ension\]" option to allow loading of external assemblies. As a result, third party loggers or listeners no longer have to reside in the NAnt bin directory or the GAC in order to be used by NAnt.
  * Deprecated -\[defaultframewor\]k option in favor of -t\[argetframework\].

### **New Tasks**

**&lt;aximp&gt;**

  * Generates a Windows Forms Control that wraps ActiveX Controls defined in an OCX.

**&lt;cvs-pass&gt;**

  * Creates or updates an entry in the specified .cvspass file. This should be used instead of the password attribute.

**&lt;cvs-changelog&gt;**

  * Produces an XML report that represents the cvs changes from the given start day, to a given end date.

**&lt;cvs-export&gt;**

  * Exports a cvs module in preperation for a release.

**&lt;cvs-tag&gt;**

  * Tags all local sources with the specified tag.

**&lt;ilasm&gt;**

  * Compiles ILASM programs.

**&lt;ildasm&gt;**

  * Disassembles any portable executable (PE) file that contains intermediate language (IL) code.

**&lt;loadfile&gt;**

  * Loads a text file into a property.

**&lt;tar&gt;**

  * Creates a tar file from the specified filesets.

### Task changes

* **&lt;asminfo&gt;**

  * Use hash implementation to check whether AssemblyInfo needs to be rebuilt.

* **&lt;attrib&gt;**

  * Support setting attributes on directories.

* **&lt;available&gt;**

  * Deprecated in favor of expression support.

* **&lt;cl&gt;**

  * Added support for passing character set to compiler.

* **&lt;csc&gt;**

  * Added "rebuild" attribute, which instructs NAnt to recompile the output file regardless of the file timestamps.
    "nowarn" attribute has been deprecated in favor of the *&lt;nowarn&gt;*{: class="text-primary"} child element.
  * Added support for suppressing/reporting specific warnings as errors using the *&lt;warnaserror&gt;*{: class="text-primary"} child element. [.NET 2.0 or higher]
  * Added support for package references. [Mono]
  * &lt;lib&gt; element is obsolete, in favor of *&lt;lib&gt;*{: class="text-primary"} child element on *&lt;references&gt;*{: class="text-primary"} and *&lt;modules&gt;*{: class="text-primary"} element.
  * Added support for /baseaddress compiler option.

* **&lt;copy&gt;**

  * Added support for [filterchains](/latest/reference/types/filterchain).

* **&lt;cvs&gt;**

  * Several bugs have been fixed in the *&lt;cvs&gt;*{: class="text-primary"} tasks.
  * Documentation updates.
  * Added "passfile" attribute.

* **&lt;exec&gt;**

  * Fixed internal error when "program" attribute was assigned invalid file name.
  * Added "resultproperty" attribute, which can be set to a name of a property in which the exit code of the program can be stored.
  * The *&lt;arg&gt;*{: class="text-primary"} element now supports line and PATH-like command-line arguments.

* **&lt;get&gt;**

  * Added support for client certificates (for HTTP requests) by means of the *&lt;certificates&gt;*{: class="text-primary"} elements.

* **&lt;jsc&gt;**

  * Added support for package references. [Mono]
  * Added "rebuild" attribute, which instructs NAnt to recompile the output file regardless of the file timestamps.

* **&lt;license&gt;**
  
  * Uses the lc.exe commandline tool to compile license files whenever available.

* **&lt;link&gt;**

  * Allow *&lt;fileset&gt;*{: class="text-primary"} reference to be set for the *&lt;sources&gt;*{: class="text-primary"} element.

* **&lt;move&gt;**

  * Added support for [filterchains](/latest/reference/types/filterchain).

* **&lt;nant&gt;**

  * Added *&lt;fileset&gt;*{: class="text-primary"} support for specifiying build files to execute.

* **&lt;ndoc&gt;**

  * Upgraded to NDoc 1.3 Release Candidate 1.
  * Added support for reference paths.

* **&lt;nunit&gt;**

  * The *&lt;nunit&gt;*{: class="text-primary"} task has been deprecated, and will be moved to NAntContrib in a future release. NUnit 1.0 test assemblies will remain supported through NAntContrib, but we strongly advise you to upgrade to NUnit 2.x.

* **&lt;nunit2&gt;**

  * Upgraded to support [NUnit 2.2](https://sourceforge.net/projects/nunit/files/NUnit%20Version%202/V2.2/).
  * If no explicit application configuration file is specified, a configuration file matching the name of the test assembly with extension ".config" will be used for the test domain.
  * Minor bug fixes.

* **&lt;regex&gt;**

  * Added "options" attribute that takes a comma-separated list of options to pass to the regex engine.

* **&lt;resgen&gt;**

  * Added support for assembly references, in order to be abel to compile .resx file that reference assemblies that are not located in the GAC.

* **&lt;script&gt;**

  * Simplified definition of custom functions with the *&lt;script&gt;*{: class="text-primary"} task.
  * Added support for Visual J# (where available), and third party CodeDOM providers.
  * *&lt;script&gt;*{: class="text-primary"} task is now supported on [Mono](http://www.mono-project.com/).
  * Assemblies emitted by the *&lt;script&gt;*{: class="text-primary"} task will now also be scanned for functions and filters.

* **&lt;solution&gt;**

  * Added support for Visual J# projects.
  * WebMaps are now case-insensitive (and added attribute to enable case-sensitivity).
  * Added "enablewebdav" attribute to allow WebDAV access for web projects.
  * Added a few unit tests to reduce the likelyhood of regressions.
  * Fixed some minor issues with regards to Visual C++ support.
  * General performance has been improved, except for project with loads of resources.
  * Added support for exclusion of source files for Visual C++ projects.
  * No longer stop loading projects, when the first excluded project is encountered (bug #982685).
  * No longer automatically use Primary Interop Assemblies for references to type libraries, but output warning instead.
  * Added support for satellite assemblies.
  * Respect project build order set in VS.NET.
  * VB.NET specific settings are now processed.
  * Improved support for precompiled headers, better grouping of files that should be compiled in one go.
  * Added support for empty projects.
  * No longer attempt to build ignored projects.
  * Match behaviour of VS.NET when resolving assembly references.
  * Fixed lookup of type libraries in the registry.
  * Expansion of macros is now case-insensitive.
  * Zero-byte resx files are now skipped to match VS.NET.
  * Introduced support for nmake projects.
  * Added support for web projects nested in Enterprise * Template Projects.
  * Compiled resource file are now stored in the *obj\&lt;configuration&gt;*{: class="text-primary"} directory relative to project directory. The compiled resource files will not be removed when the task finishes, by doing this resource files will now only be recompiled if the compiled resource file in the object directory is no longer up-to-date. This matches the behaviour of VS.NET.
  * Added support for deploying App.config to output directory.

* **&lt;sysinfo&gt;**

  * If "failonerror" is **false**, the *&lt;sysinfo&gt;*{: class="text-primary"} task will output a warning message in the build log when a certain environment variable cannot be exposed as a property (because of, for example, more strict naming rules for properties) and continue processing other environment variables. In previous versions of NAnt, execution of the *&lt;sysinfo&gt;*{: class="text-primary"} task would halt on the first error.

* **&lt;vbc&gt;**

  * Added support for suppressing specific warnings using the *&lt;nowarn&gt;*{: class="text-primary"} child element. [.NET 2.0 or higher]
  * Added support for suppressing/reporting specific warnings as errors using the *&lt;warnaserror&gt;*{: class="text-primary"} child element. [.NET 2.0 or higher]
  * Added support for generating XML documentation files, using "doc" attribute. [.NET 2.0 or higher]
  * Added support for package references. [Mono]
  * Added "rebuild" attribute, which instructs NAnt to recompile the output file regardless of the file timestamps.
  * Added *&lt;imports&gt;*{: class="text-primary"} child element, and deprecated "imports" attribute.
  * *&lt;lib&gt;*{: class="text-primary"} element is obsolete, in favor of *&lt;lib&gt;*{: class="text-primary"} child element on *&lt;references&gt;*{: class="text-primary"} and *&lt;modules&gt;*{: class="text-primary"} element.

* **&lt;vjc&gt;**

  * Added support for suppressing specific warnings using the *&lt;nowarn&gt;*{: class="text-primary"} child element. [.NET 2.0 or higher]
  * *&lt;lib&gt;*{: class="text-primary"} element is obsolete, in favor of *&lt;lib&gt;*{: class="text-primary"} child element on *&lt;references&gt;*{: class="text-primary"} and *&lt;modules&gt;*{: class="text-primary"} element.
  * Added "rebuild" attribute, which instructs NAnt to recompile the output file regardless of the file timestamps.
  * Added support for /baseaddress compiler option.

* **&lt;xmlpeek&gt; / &lt;xmlpoke&gt;**

  * Added support for XPath expressions with namespace prefixes.

* **&lt;zip&gt; / &lt;unzip&gt;**

  * Added support for multiple filesets.
  * A top level directory prefix can be set on individual filesets.
  * Upgraded [#ziplib](https://github.com/icsharpcode/SharpZipLib) to v0.83.

### **New types**

* **&lt;assemblyfileset&gt;**

  * Specialized *&lt;fileset&gt;*{: class="text-primary"} for managing assembly files.

* **&lt;warnaserror&gt;**

  * Controls the behaviour of a compiler with regards to the reporting of warnings.

### **Type changes**

* **&lt;fileset&gt;**

  * Deprecated *&lt;includes&gt;*{: class="text-primary"} and *&lt;excludes&gt;*{: class="text-primary"} elements in favor of *&lt;include&gt;*{: class="text-primary"} and *&lt;exclude&gt;*{: class="text-primary"} elements.
  * Deprecated *&lt;includesList&gt;*{: class="text-primary"} element in favor of *&lt;includesfile&gt;*{: class="text-primary"}.
  * Added *&lt;excludesfile&gt;*{: class="text-primary"} element.

### **Developer information**

  * The *Task.LogPrefix*{: class="text-primary"} property has been deprecated. Messages that are written to build log by a given task, will now automatically get prefixed with the task name. This behaviour can be disabled by the new -e\[macs\] commandline option.


## NAntContrib

---

### **New tasks**

* **&lt;depends&gt;**

  * Guarantees that listed dependencies are resolved before continuing.

* **&lt;grep&gt;**

  * Searches files for a regular-expression and produces an XML report of the matches.

* **&lt;PVCS&gt;**

  * Support for [PVCS](https://www.microfocus.com/en-us/products/pvcs/overview) has been added.

* **&lt;Surround SCM&gt;**

  * Support for [Surround SCM](https://www.perforce.com/products/surround-scm) has been added.

* **&lt;Subversion&gt;**

  * Support for [Subversion](https://subversion.apache.org/) has been introduced.

* **&lt;Perforce&gt;

  * Support for [Perforce SCM](https://www.perforce.com/) has been added.

### **Task changes**

* **&lt;aximp&gt;**

  * Moved to NAnt project.

* **&lt;comregister&gt;**

  * Minor fix to prevent file locking.
  * Added support for unregistering type libraries.
  * Prevented failure message boxes from being displayed when (un)registering a DLL server.
  * Improved reporting of error conditions.

* **&lt;gac&gt;**

  * Documentation has been improved.
  * Several issues have been fixed.

* **&lt;mkiisdir&gt;**

  * The hostname specified in the "iisserver" attribute is now taken into account when determining which site to target.
  * Only those IIS-properties explicitly specified will be set.
  * Added "appcreate" attribute to contol the creation of applications.
  * The root directory of a site is now configurable.

* **&lt;msi&gt; / &lt;msm&gt;**

  * Added automatic parsing of subdirectories of components.
  * Added support for registry components.
  * Documentation has been improved.
  * Added support for configurable merge modules.
  * Several issues have been fixed.
  * Added support for installing assemblies to the GAC.

* **&lt;sql&gt;**

  * Added "append" attribute that indicates whether to overwrite output file.
  * Added "showheaders" attribute that specifies whether or not to display schema information.
  * Column separator is changed from " " (two spaces) to ", ".
  * Added "quotechar" attribute which specified the character(s) to place arround column values to prevent collisions with for instance the comma character.

* **&lt;vb6&gt;**

  * Several issues have been fixed.

* **&lt;vssadd&gt;**

  * Added support for recursive add.

* **&lt;xsd&gt;**

  * Documentation has been improved.
  * Several issues have been fixed.