---
Title: Releases
---

# 0.92 - June 9, 2012 {v0.92}

## NAnt

---

**No Updates since 0.92-rc1**

## NAntContrib

---

### **Bug Fixes**

**Tasks**

* **NUnit2Report** 

  * Fixed graphs so they appear correctly on modern browsers. ([Pull Request #21](https://github.com/nant/nantcontrib/pull/21))  
    Removed # prefix from anchor names. ([Pull Request #20](https://github.com/nant/nantcontrib/pull/20))
  
  
  
# 0.92-rc1 - May 23, 2012 {v0.92-rc1}

## NAnt

---

### **Breaking changes**

**Tasks**

* **XmlPoke**

  * Updated XmlPoke task to honor the *failonerror*{: class="text-primary"} attribute. ([Issue #44](https://github.com/nant/nant/issues/44))

### **Changes**

**Core**

* **NAnt AppDomains**

  * Updated NAnt to use the Unrestricted permission state when creating AppDomains by default instead of just on .NET/Mono 4.0. ([Issue #48](https://github.com/nant/nant/issues/48))

**Tasks**

* **TryCatch**

  * Moved *&lt;trycatch&gt;*{: class="text-primary"} task from NAntContrib to NAnt. ([Issue #26](https://github.com/nant/nant/issues/26))

* **Choose**

  * Moved *&lt;choose&gt;*{: class="text-primary"} task from NAntContrib to NAnt. ([Issue #26](https://github.com/nant/nant/issues/26))
  
  
## NAntContrib

---

### **Changes**

**Tasks**

* **TryCatch**
    
  * Moved *&lt;trycatch&gt;*{: class="text-primary"} task from NAntContrib to NAnt. ([Issue #26](https://github.com/nant/nant/issues/26))

* **Choose**

  * Moved *&lt;choose&gt;*{: class="text-primary"} task from NAntContrib to NAnt. ([Issue #26](https://github.com/nant/nant/issues/26))
  
  
  
# 0.92-beta1 - May 6, 2012 {v0.92-beta1}

**No updates since 0.92-alpha1.**
  
  
  
# 0.92-alpha1 - April 22, 2012 {v0.92-alpha1}

## NAnt

---

### **Changes**

**Framework support**

  * Removed runtime support for .NET/Mono 1.* Frameworks (target support for .NET/Mono 1.* Frameworks still remains)

**Core**

* **NAnt Project Files**

  * Updated NAnt project files to VS2010 format.

* **NUnit**

  * Upgraded to NUnit 2.6.

* **App.Config**

  * Added initial support for Silverlight 5

* **Command Line**

  * Added pause option to pause nant before exit.

* **Type Factory**

  * Added detailed error messages when type loading exception occurs.

**Tasks**

* **Mail**

  * Updated *&lt;mail&gt;*{: class="text-primary"} task to reference System.Net.Mail namespace instead of System.Web.Mail.
  * Added additional attritbutes for greater control of the *&lt;mail&gt;*{: class="text-primary"} task. Such as:

    * mailport
    * ssl
    * user
    * password
    * replyto

* **Zip**

  * Added flatten attribute to *&lt;zip&gt;*{: class="text-primary"} task.

* **Tar**

  * Added flatten attribute to *&lt;tar&gt;*{: class="text-primary"} task.

### **Bug fixes**

**Tasks**

* **Copy/Move tasks**

  * Fixed issues with *&lt;copy&gt;*{: class="text-primary"} and *&lt;move&gt;*{: class="text-primary"} tasks when trying to relocate directories. ([Issue #11](https://github.com/nant/nant/issues/11))

* **Asminfo**

  * Fixed issue with *&lt;asminfo&gt;*{: class="text-primary"} task when trying to add assembly attributes with default constructors. ([Issue #41](https://github.com/nant/nant/issues/41))

* **Style**

  * Updated *&lt;style&gt;*{: class="text-primary"} task to preserve singleton tags whenever possible. ([Issue #17](https://github.com/nant/nant/issues/17))


## NAntContrib

---

### **Changes**

**Core**

* **NAntContrib Project Files**

  * Updated NAntContrib project files to VS2010 format.

**Functions**

* **Array functions**

  * Added Array functions to sort and reverse a string array.

### **Bug fixes**

**Tasks**

* **&lt;iisapppool&gt;**

  * Fixed issue with *&lt;iisapppool&gt;*{: class="text-primary"} encountering access denied error when executing on remote machine. [Issue #6](https://github.com/nant/nantcontrib/issues/6)



# 0.91 - October 22, 2011 {v0.91}

## NAnt

---

### **Bug fixes**

**Core**

* **XmlPeek**

  * Fixed issue with XmlPeek not outputting results in xml format. ([bugs #3366107](https://sourceforge.net/tracker/?func=detail&aid=3366107&group_id=31650&atid=402868) and [#3390653](https://sourceforge.net/tracker/?func=detail&aid=3390653&group_id=31650&atid=402868))

* **App.config**

  * Added necessary .NET 4.0 WPF and misc missing .NET 3.5 reference assemblies. ([bug 3314793](https://sourceforge.net/tracker/index.php?func=detail&aid=3314793&group_id=31650&atid=402868))


## NAntContrib

---

**No Updates since 0.91-rc1**

  Released to maintain consistency with NAnt.



# 0.91-rc1 - October 8, 2011 {v0.91-rc1}

## NAnt

---

### **Bug fixes**

**Core**

* **App.config**

  * Fixed issue with NDoc when building NAnt from source. (bug [#3416986](https://sourceforge.net/tracker/index.php?func=detail&aid=3416986&group_id=31650&atid=402868)).

* **Makefile**

  * Fixed issue when building NAnt with older versions of GNU Make.


## NAntContrib

---

**No Updates since 0.91-beta1**

  Released to maintain consistency with NAnt.



# 0.91-beta1 - September 25, 2011 {v0.91-beta1}

## NAnt

---

### **Changes**

**Core**

* **App.Config**

  * Added mono-4.0 target  
  * Added initial support for Silverlight 3 and 4

* **log4net**

  * Upgraded to log4net 1.2.10.

* **MSBuild**

  * Added initial support for 2008/2010 MSBuild/VS.NET project files.

### **Bug fixes**

**Core**

* **App.config**

  * Added WindowsBase.dll and PresentationFramework.dll to 4.0 target.

* **NAnt.xsd**

  * Changed the NAnt.Core.Tasks.DescriptionTask task to mixed. (bug [#3058913](https://sourceforge.net/tracker/?func=detail&aid=3058913&group_id=31650&atid=402868)).

* **BuildException**

  * Display correct registry hives in BuildException when Registry Path not found.

**Tasks**

* **ndoc**

  * Fixed ndoc task to find hhc.exe for chm generation on 64 bit machines through reflection.


## NAntContrib

---

### **Bug fixes**

**Tasks**

* **&lt;vb6&gt;**

  * Type library references with path ending of backslash+number (eg. vbscript.dll\3) are now parsed correctly. (bug [#1745360](https://sourceforge.net/tracker/?func=detail&aid=1745360&group_id=54790&atid=474851)).
  * Take "ResFile32" and "Desiger" files into account when checking for recompilation. (bug [#1205594](https://sourceforge.net/tracker/index.php?func=detail&aid=1205594&group_id=54790&atid=474851) and [#1648001](https://sourceforge.net/tracker/index.php?func=detail&aid=1648001&group_id=54790&atid=474853)).
  * Reduced vb6 task problems with "Auto Increment" revision. (bug [#1081472](https://sourceforge.net/tracker/index.php?func=detail&aid=1081472&group_id=54790&atid=474851)).

* **&lt;msbuild&gt;**

  * Multiple targets can now be defined. (bug [#3214616](https://sourceforge.net/tracker/?func=detail&aid=3214616&group_id=54790&atid=474851)).

**Functions**

* **choose**

  * Global types can now be defined in either the *&lt;when&gt;*{: class="text-primary"} or *&lt;otherwise&gt;*{: class="text-primary"} elements.
    ```xml
    <choose>
        <when test="${build.config == 'Debug'}">
            <patternset id="sources">
                <include name="**/*.cs" />
            </patternset>
        </when>
        <when test="${build.config == 'Release'}">
            <patternset id="sources">
                <include name="**/*.cs" />
                <exclude name="**/Instrumentation/*.cs" />
            </patternset>
        </when>
        <otherwise>
            <fail>Build configuration '${build.config}' is not supported!</fail>
        </otherwise>
    </choose>
    ```          

### **Additions**

**Functions**

* **Windows Installer functions**

  * Allows information on Windows Installer databases and products to be retrieved.

**Tasks**

* **&lt;btsreceivelocation&gt;**

  * Allows BizTalk receive locations to be controlled.

* **&lt;kill&gt;**

  * Immediately stops a given process.  
  * When used in combination with the *&lt;exec&gt;*{: class="text-primary"} task, it allows processed to be spawned for a certain duration or task, and then stopped.

* **&lt;loadproperties&gt;**

  * Loads a file's contents as NAnt properties.

* **&lt;waitforexit>&gt;**

  * Waits for a given process on the local computer to exit.  
  * When used in combination with the *&lt;exec&gt;*{: class="text-primary"} task, it allows processed to be spawned for a certain duration or task, and then wait until the process is finished before continuing.

### **Changes**

**Framework support**

* **Mono**

  * Fixes in both Mono and NAntContrib now allow NAntContrib to be used in Mono (both Windows and Linux).

* **.NET Framework 3.5**

  * Updated build file to allow NAntContrib to be built against .NET Framework 3.5 and Mono 3.5 Profile.

**Installation**

* **Templates**

  * The templates used by the *&lt;msi&gt;*{: class="text-primary"} and *&lt;msm&gt;*{: class="text-primary"} takes are now embedded in the NAntContrib assembly, and no longer need to be installed separately.

**Tasks**

* **&lt;deliisdir&gt;**

  * Attempting to delete a virtual directory that does not exist, no longer results in a build failure.



# 0.91-alpha2 - August 17, 2010 {v0.91-alpha2}

## NAnt

---

### **Bug fixes**

**Core**

* **App.config**

  * Fixed typo that prevented System.Management.dll from being included.

**Tasks**

* **&lt;include&gt;**

  * Fixed error with the *&lt;include&gt;*{: class="text-primary"} task when different build files include the same file. (bug [#3016497](https://sourceforge.net/tracker/?func=detail&aid=3016497&group_id=31650&atid=402868)).

**Functions**

* **NAnt::get-assembly()**

  * Using the *NAnt::get-assembly()*{: class="text-primary"} function causes an "Object must implement IConvertible" error. (bug [#3013492](https://sourceforge.net/tracker/?func=detail&aid=3013492&group_id=31650&atid=402868)).



# 0.91-alpha1 - May 29, 2010 {v0.91-alpha1}

## NAnt

---

### **Framework support**

  * Added support for .NET Framework 4.0 (except for *&lt;solution&gt;*{: class="text-primary"} task).

### **Bug fixes**

**Expressions**

* **Coercion**

  * Coercion of arguments is not supported (bug [#3013492](http://sourceforge.net/tracker/?func=detail&aid=3013492&group_id=31650&atid=402868)).

### **Changes**

**Tasks**

* **&lt;xmlpeek&gt;**

  * Enhanced the *&lt;xmlpeek&gt;*{: class="text-primary"} task to support more advanced XPath functions and syntax. It is now possible to use functions such as count() and to index the node using XPath directly. (feature request [#1560566](http://sourceforge.net/tracker/index.php?func=detail&aid=1560566&group_id=31650&atid=402871)).



# 0.90 - May 8, 2010 {v0.90}

## NAnt

---

### **Bug fixes**

**Tasks**

* **&lt;tar&gt;**

  * When the "destfile" attribute specifies a non-existent path, the base directory(ies) will be created. (bug [#2997300](http://sourceforge.net/tracker/index.php?func=detail&aid=2997300&group_id=31650&atid=402868)).



# 0.90-rc1 - May 2, 2010 {v0.90-rc1}

## NAnt

---

### **Bug fixes**

**Core**

* **&lt;PathScanner&gt;**

  * Catch UnauthorizedAccessException in PathScanner to prevent NAnt from crashing when using the Scan() function to search for file(s) in directory with special permissions.



# 0.90-beta1 - April 17, 2010 {v0.90-beta1}
## NAnt

---

### **Bug fixes**

**Tasks**

* **&lt;csc&gt; / &lt;jsc&gt; / &lt;vbc&gt; / &lt;vjc&gt;**

  * When the "output" attribute specifies a non-existent path, the base directory(ies) will be created. (bug [#2985057](http://sourceforge.net/tracker/index.php?func=detail&aid=2985057&group_id=31650&atid=402868)).

* **ExternalProgramBase**

  * For certain tasks (NDoc, Exec, MSBuild, etc) the console output is unorganized and difficult to read. (bug [#2981604](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=2981604&group_id=31650)).

* **&lt;script&gt;**

  * Cleanup the output to show assembly information and functions only when "verbose" attribute is set to "true". (bug [#2981386](http://sourceforge.net/tracker/?func=detail&aid=2981386&group_id=31650&atid=402868)).

* **&lt;zip&gt;**

  * When the "zipfile" attribute specifies a non-existent path, the base directory(ies) will be created. (bug [#2981389](http://sourceforge.net/tracker/index.php?func=detail&aid=2981389&group_id=31650&atid=402868)).



# 0.90-alpha1 - April 1, 2010 {v0.90-alpha1}

## NAnt

---

### **Breaking changes**

**Core**

* **Extensibility**

  * Deprecated NAnt.Core.Element.InitializeElement(XmlNode) and NAnt.Core.Task.InitializeTask(XmlNode) in favor of NAnt.Core.Element.Initialize(). This was done to discourage direct access to the XML node that was used to initialize the construct.

**Tasks**

* **&lt;script&gt;**

  * As of this release, only the following namespaces are imported by default:

    * System
    * System.Collections
    * ~~System.Collections.Specialized~~
    * System.IO
    * System.Text
    * ~~System.Text.RegularExpressions~~
    * NAnt.Core
    * NAnt.Core.Attributes

  * Starting from this release, only *NAnt.Core*{: class="text-primary"} and *mscorlib*{: class="text-primary"} will be referenced by default.  
  In previous releases, all loaded assemblies would implicitly be referenced.

### **Bug fixes**

**Extensibility**

* **DataTypeBaseBuilder / FilterBuilder / TaskBuilder**

  * Changes to constructors break backward compatibility (bug [#2782705](http://sourceforge.net/tracker/?func=detail&aid=2782705&group_id=31650&atid=402868)).

**Expressions**

* **Identifiers**

  * Identifiers containing a dot or backslash are falsely rejected.

**Framework support**

* **.NET Framework (All)**

  * The target framework cannot be initialized if the .NET Framework SDK is not installed (bug [#1859708](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=1859708&group_id=31650)).

* **.NET Framework 1.1**

  * Added the following assemblies to the list of reference assemblies:

    * Microsoft.VisualBasic.Compatibility.dll
    * Microsoft.VisualBasic.Compatibility.Data.dll
    * System.Data.OracleClient.dll

  Fixes bug [#1848648](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=1848648&group_id=31650).

* **.NET Framework 3.5**

  * Modified version (as returned by *framework::get-version()*{: class="text-primary"}) to "3.5".  
  * Added support for Windows SDK 6.1 (bug [#1986551](https://sourceforge.net/tracker/index.php?func=detail&aid=1986551&group_id=31650&atid=402868)).  
  * Added support for Windows SDK 7.0.  

**Tasks**

* **&lt;echo&gt;**

  * A newline is implicitly added when writing a message to a file (bug [#2807728](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=2807728&group_id=31650)).

* **&lt;echo&gt;**

  * When "output" parameter is specified, standard output is redirected properly. (bug [#1010223](https://sourceforge.net/tracker/?func=detail&aid=1010223&group_id=31650&atid=402868)).

* **ExternalProgramBase**

  * The value of *UseRuntimeEngine*{: class="text-primary"} is not respected when overriden by derived classes (bug [#1850383](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=1850383&group_id=31650)).

* **&lt;move&gt;**

  * When source file is newer than destination file, then an error is reported if "overwrite" is not set to **true**.

* **&lt;solution&gt;**

  * Solution Folders result in build failure (bug [#1732361](http://sourceforge.net/tracker/index.php?func=detail&aid=1732361&group_id=31650&atid=402868)).

* **&lt;xmlpeek&gt;**

  * "verbose" feature is now worked as documented (bug [#1911292](http://sourceforge.net/tracker/index.php?func=detail&aid=1911292&group_id=31650&atid=402868)).

* **&lt;zip&gt;**

  * Improved backward compatibility with older unzip implementations.

**Types**

* **&lt;fileset&gt;**

  * Files matching the ***/vssver2.scc*{: class="text-primary"} pattern are not excluded by default (bug [#2515816](https://sourceforge.net/tracker/index.php?func=detail&aid=2515816&group_id=31650&atid=402868)).

### **Additions**

**Functions**

* **environment::newline()**

  * Gets the newline string defined for this environment.

* **framework::get-description()**

  * Gets the description of the current target framework.

* **framework::get-clr-version()**

  * Gets the CLR version of the current target framework.

* **framework::get-frameworks(NAnt.Core.FrameworkTypes)**

  * Gets a comma-separated list of frameworks filtered by the specified [FrameworkTypes](/release/latest/reference/enums/NAnt.Core.FrameworkTypes.html).

    For example:

        ```xml
        <target name="build-all">
            <foreach item="String" in="${framework::get-frameworks('installed compact')}" delim="," property="framework">
                <property name="nant.settings.currentframework" value="${framework}" />
                <call target="${framework}" />
            </foreach>
        </target>
    
        <target name="build">
            ...
        </target>
        ```   

* **framework::get-version()**

  * Gets the version of the current target framework.

* **platform::is-windows()**

  * Return a value indicating whether NAnt is running on Windows.

**Tasks**

* **&lt;untar&gt;**

  * Extracts files from a tar archive.

### **Changes**

**Packaging**

* **pkg-config**

  * When installing NAnt from source on Unix (using make install), a nant.pc is now installed in $prefix/lib/pkgconfig.

* **DESTDIR**

  * To allow for staged installs, our makefile now also supports the [DESTDIR](http://www.gnu.org/prep/standards/html_node/DESTDIR.html) variable:

    ```bash
    $ make DESTDIR=/tmp/local install
    ```
                

**Functions**

* **platform::is-win32()**

  * This function is deprecated, use *platform::is-windows()*{: class="text-primary"} instead.

**Tasks**

* **&lt;csc&gt; / &lt;jsc&gt; / &lt;vbc&gt; / &lt;vjc&gt;**

  * Added "winres" attribute to specify a Win32 resource file.

* **&lt;echo&gt;**

  * The "encoding" attribute can be used to specify the encoding when writing messages to a file.

    ```xml
    <echo file="build.cmd" encoding="ascii">
    ...
    </echo>
    ```
                
* **&lt;link&gt;**

  * Added "moduledefinition" parameter to allow the name of the module definition file to be set.

* **&lt;nunit2&gt;**

  * Allow referenced assemblies to be specified using *&lt;references&gt;*{: class="text-primary"} element on *&lt;test&gt;*{: class="text-primary"}:

    ```xml
    <nunit2>
        <test>
            <assemblies basedir="build/tests">
                <include name="Cegeka.HealthCare.DocGen.Tests.dll" />
                <include name="Cegeka.HealthCare.Util.Tests.dll" />
            </assemblies>
            <references basedir="build/lib">
                <include name="Cegeka.HealthCare.Common.dll" />
                <include name="Cegeka.HealthCare.DocGen.dll" />
                <include name="Cegeka.HealthCare.Util.dll" />
            </assemblies>
        </test>
    </nunit2>
    ```
                
  Previously, all referenced assemblies needed to be either in the GAC, or in the directory containing the test assembly.

* **&lt;solution&gt;**

  * Introduced support for targeting a specific platform, as defined in the solution or project.

* **&lt;xmlpoke&gt;**

  * Added "preserveWhitespace" parameter to retain the original format of the XML files.

* **&lt;unzip&gt;**

  * Added "overwrite" parameter to control whether to overwrite files even if they are newer than corresponding entries in the archive.

**Third-Party**

* **#ziplib**

  * Upgraded to [v0.85.5.452](https://github.com/icsharpcode/SharpZipLib/releases/tag/0.85.5.452).

**Types**

* **&lt;fileset&gt; / &lt;patternset&gt;**

  * For patterns specified using *&lt;includesfile&gt;*{: class="text-primary"} or *&lt;excludesfile&gt;*{: class="text-primary"}, lines that have a number sign (#) as the first non-blank character in a line are now ignored.



# 0.86-beta1 - December 8, 2007 {v0.86-beta1}

## NAnt

---

### **Breaking changes**

**Core**

* **nant.tasks properties**

  * Prior to NAnt 0.85, build authors would use a "nant.tasks.*" property to check whether a given task was available.  
  
  * With the introduction of expression support in NAnt 0.85, we provided a more powerful alternative through the *task::exists*{: class="text-primary"} function.  
    As of this release, the "nant.tasks.*" properties are therefore no longer set by NAnt.

* **nant.failure**

  * Removed support for the "nant.failure" property to set the target that should be executed when the build fails.  
    This property was deprecated in NAnt 0.83 in favor of the "nant.onfailure" attribute.  
    As of this release, setting the "nant.failure" attribute will no longer have any effect.

**Expressions**

* **= operator**

  * In NAnt 0.85, support for the '=' operator to check for equality was deprecated in favor of the '==' operator.  
    As from this release, the '=' operator is no longer recognized.

**Tasks**

* **&lt;style&gt;**

  * Removed support for *&lt;param&gt;*{: class="text-primary"} child element, which was deprecated in NAnt 0.84 in favor of a *&lt;parameters&gt;*{: class="text-primary"} element.

### **Bug fixes**

**Core**

* **MailLogger**

  * If "MailLogger.smtp.username", "MailLogger.smtp.port" or "MailLogger.smtp.enablessl" are set, messages must be delivered using the SMTP protocol over the network. [.NET 1.1 or higher]

* **Response File**

  * Quoted arguments are not parsed correctly from response files (bug [#1736526](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1736526&group_id=31650)).

* **Document Type Definition**

  * Executing a project with a DTD can lead to an internal error. (bug [#1809994](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1809994&group_id=31650)).

**Framework support**

* **Mono/Cygwin**

  * In [Cygwin](http://www.cygwin.com/), the directory containing the Mono configuration files was not correctly constructed from pkg-config info, leading to errors when running applications that use System.Configuration.

**Tasks**

* **&lt;call&gt;**

  * Target is not re-executed if "cascade" is false (bug [#1474159](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=1474159&group_id=31650)).

* **&lt;csc&gt;**

  * Satellite assemblies are not signed when signing key is specified using "keyfile" attribute (bug [#1587739](http://sourceforge.net/tracker/index.php?func=detail&aid=1587739&group_id=31650&atid=402868)).

* **&lt;exec&gt;**

  * Empty lines written to standard output or standard error by external program are ignored.

* **&lt;resgen&gt;**

  * If the embedded resource compiler for the target framework does not support assembly references, then copy both the compiler and related files (based on pattern matching) to the intermediary compile directory (bug [#1591991](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=1591991&group_id=31650)).

* **&lt;solution&gt;**

  * Visual C++
    * Custom build steps are not supported (bug [#1082374](http://sourceforge.net/tracker/index.php?func=detail&aid=1082374&group_id=31650&atid=402868)).
    * Unexpected error when name of project configuration differs from solution configuration (bug [#1607209](https://sourceforge.net/tracker/index.php?func=detail&aid=1607209&group_id=31650&atid=402868)).

**Third-Party**

* **#ziplib**

  * Files with a compressed size of over 4GB cannot be added to zip archive (bug [#1698336](https://sourceforge.net/tracker/index.php?func=detail&aid=1698336&group_id=31650&atid=402868)).


**Types**

* **&lt;fileset&gt;**

  * Case differences are not always ignored on a case-insensitive filesystem (bug [#1776101](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1776101&group_id=31650)).  
  * Pattern mathing for files in the root directory of a volume is always case-sensitive (bug [#1761377](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1761377&group_id=31650)).


### **Additions**

**Expressions**

* **Version operators**

  * Introduced support for [relational operators](/docs/fundamentals/expressions) between version values.

**Framework support**

* **Tool paths**

  * Since NAnt 0.84, task authors have been able to specify the location of the command-line tool by applying a *ProgramLocationAttribute*{: class="text-primary"} to classes deriving from ExternalProgramBase.  
    The *ProgramLocationAttribute*{: class="text-primary"} allows task authors to specify whether the tool is located in the framework directory (eg. C:\WINDOWS\Microsoft.NET\Framework\v1.1.4432) or the SDK directory (eg. C:\Program Files\Microsoft Visual Studio .NET 2003\SDK\v1.1) without actually having to deal with the complexity of knowing the actual path to these directories (for each supported framework).  

    In NAnt 0.86, we've taken this one step further. Each defined framework now has a (ordered) list of directories that can be scanned to locate a framework tool. The list of directories can be easily tuned for each framework by modifying the *&lt;tool-paths&gt;*{: class="text-primary"} nodes in the NAnt configuration file.  

    An example of such a node for the Mono 3.5 profile:

    ```xml
    <tool-paths>
        <directory name="${path::combine(prefix, 'lib/mono/3.5')}" />
        <directory name="${path::combine(prefix, 'lib/mono/2.0')}" />
        <directory name="${path::combine(prefix, 'lib/mono/1.0')}" />
    </tool-paths>
    ``` 

    The directories configured in the *&lt;tool-paths&gt;*{: class="text-primary"} node of the current target framework will be scanned in the order in which they are defined.   

    The tool paths are implicitly used when a given tool cannot be located on the location specified by the *ProgramLocationAttribute*{: class="text-primary"}. As such, this only applies to tasks deriving from ExternalProgramBase.    

    To expose this functionality to build authors, we've added a *framework::get-tool-path*{: class="text-primary"} function that can be used to search for a given tool.    

    For example:

    ```xml
    <exec program="${framework::get-tool-path('gacutil.exe')}" managed="strict">
        <arg value="/i" />
        <arg file="Cegeka.HealthFramework.dll" />
    </exec>
    ```    

* **Strict execution**

  * Introduced support for forcing a managed application to run on the currently targeted CLR.  

    This was previously only possible by modifying the *&lt;startup&gt;*{: class="text-primary"} section of the application configuration file or by using constructs specific to each CLR (eg. using **COMPLUS_VERSION** environment variable for the MS CLR), which made build scripts non-portable.  

    Developers extending NAnt, can now control this by setting the *Managed*{: class="text-primary"} property for tasks deriving from *ExternalProgramBase*{: class="text-primary"}.  

    For build authors, forcing a managed application to run on a specific version of a CLR can be done by setting the "managed" attribute of *&lt;exec&gt;*{: class="text-primary"} to **strict**.  

    For example:

    ```xml
    <exec program="nunit-console.exe" managed="strict">
        <arg value="/noshadow" />
        <arg file="Cegeka.HealthFramework.Tests.dll" />
    </exec>
    ```                

* **.NET Framework 3.5**

  * Support for targeting .NET Framework 3.5 and Mono 3.5 Profile is now available.

    **Note:** this does not apply to the *&lt;solution&gt;*{: class="text-primary"} task.

* **Silverlight 2.0**

  * Added experimental support for targeting Silverlight 2.0 and Moonlight 2.0.

    **Note:** this does not apply to the *&lt;solution&gt;*{: class="text-primary"} task.

**Types**

* **&lt;patternset&gt;**

  * Defines a set of patterns, mostly used to include or exclude certain files.
  * Patterns can be grouped to sets, and later be referenced by their id.  

    For example:

    ```xml
    <patternset id="binaries">
        <include name="bin/**/*" />
        <exclude name="bin/*.tmp" />
    </patternset>

    <patternset id="docs">
        <include name="requirements/**/*" />
        <exclude name="design/**/*.doc" />
    </patternset>

    <patternset id="client.sources">
        <include name="client/**/*.cs" />
        <exclude name="client/**/*.vb" />
    </patternset>

    <patternset id="server.sources">
        <include name="server/**/*.cs" />
        <exclude name="server/**/*.vb" />
    </patternset>

    <patternset id="sources">
        <patternset refid="client.sources" />
        <patternset refid="server.sources" />
    </patternset>

    <target name="deploy">
        <copy todir="${dist.path}">
            <fileset basedir="${build.path}">
                <patternset refid="binaries" />
                <patternset refid="docs" />
                <patternset refid="sources" />

                <exclude name="**/*.sdf" />
            </fileset>
        </copy>
    </target>
    ```


### **Changes**

**Core**

* **Performance**

  * Initial start-up time and project initialization have been reduced dramatically by lazy configuration of supported target frameworks.

**Framework support**

* **.NET Compact Framework 2.0**

  * Compiler options that were introduced in .NET Framework 2.0 are now also available when targeting .NET Compact Framework 2.0.

**Tasks**

* **&lt;al&gt;**

  * Modules to compile into an assembly can now be specified using the *&lt;modules&gt;*{: class="text-primary"} child element.

* **&lt;csc&gt;**

  * Added "delaysign" attribute which specified whether to delay sign the assembly using only the public portion of the strong name key.

* **&lt;exec&gt;**

  * The "useruntimeengine" attribute has been deprecated in favor of a "managed" attribute.

* **&lt;jsc&gt;**

  * Added "autoref" attribute to enable automatically referencing of assemblies if they have the same name as an imported namespace or as a type annotation when declaring a variable.  
  * Added "nostdlib" attribute which instructs the compiler not to import standard library.  
  * Added "versionsafe" attribute which causes the compiler to generate errors for implicit method overrides.
  * Now uses mjs when targeting Mono.  

* **&lt;vbc&gt;**

  * Added "delaysign" attribute which specified whether to delay sign the assembly using only the public portion of the strong name key.

* **&lt;vjc&gt;**

  * Added "delaysign" attribute which specified whether to delay sign the assembly using only the public portion of the strong name key.

**Third-Party**

* **#ziplib**

  * Upgraded to v0.85.1 which, amongst other things, adds support for ZIP64.

**Types**

* **&lt;assemblyfileset&gt;**

  * The reference assemblies of a given target framework are no longer limited to the assemblies in, what is known as, the framework assembly directory.  
  Instead, these are now defined using one or more *&lt;reference-assemblies&gt;*{: class="text-primary"} filesets in the *&lt;framework&gt;*{: class="text-primary"} node of the NAnt configuration file.

* **&lt;fileset&gt;**

  * Added a "casesensitive" attribute to control whether pattern matching must be case-sensitive.
  * The default is **true** on Unix and **false** on on other platforms.



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



# 0.84 - December 26, 2003 {v0.84}

## NAnt

---

### **Task changes**

**&lt;xmlpeek&gt;**

  * Fixed issues with logging statements.
  * Added unit tests.

**&lt;xmlpoke&gt;**

  * Added unit tests.
  
  
## NAntContrib

---

### **Task changes**

* **&lt;regasm&gt;**

  * Fixed issue when long filenames were specified for the *typelib*{: class="text-primary"} or *regfile*{: class="text-primary"} attribute.
  
  
  
# 0.84-rc2 - December 21, 2003 {v0.84-rc2}

## NAnt

---

### **General changes**

  * Specifying multiple targets on the command line will no longer cause all dependencies of these targets to be executed again.
  * The [XmlLogger](/docs/fundamentals/loggers-and-listeners#xml-logger) will now correctly handle null-characters in the build output.
    Fixed issue with resources specified using the *&lt;resources&gt;*{: class="text-primary"} element of the compiler tasks.

### **Task changes**

**&lt;solution&gt;**

  * Fixed issues with web-projects.
  * Added support for generating strongly signed ActiveX/COM wrapper assemblies.

**&lt;xmlpeek&gt;**

  * *Filename*{: class="text-primary"} attribute was renamed to *file*{: class="text-primary"} to improve consistency with other tasks.

**&lt;xmlpoke&gt;**

  * *Filename*{: class="text-primary"} attribute was renamed to *file*{: class="text-primary"} to improve consistency with other tasks.


## **NAntContrib**

No changes
  
  
  
# 0.84-rc1 - December 6, 2003 {v0.84-rc1}

## NAnt

---

### **Breaking changes**

Some existing build scripts may stop working now or in the next release due to the following changes:

  * The NAntContrib binaries are no longer included in the NAnt distribution package. The NAntContrib distribution package can now be obtained here.
  * The *&lt;call&gt;*{: class="text-primary"} task now executes the given target and all its dependencies. In previous versions of NAnt only the target itself would be executed.
  * The *todir*{: class="text-primary"} attribute of the *&lt;copy&gt;*{: class="text-primary"} and *&lt;move&gt;*{: class="text-primary"} tasks no longer defaults to the project base directory. It must now be set explicitly.
  * The *force*{: class="text-primary"} attribute of the *&lt;call&gt;*{: class="text-primary"} task has been deprecated and has no longer any effect. The *&lt;call&gt;*{: class="text-primary"} task will now always execute the specified target, regardless of the fact that this target has already been executed before.
  * The string-based *files*{: class="text-primary"} and *attachments*{: class="text-primary"} attributes of the *&lt;mail&gt;*{: class="text-primary"} task have been replaced by fileset support.
  * In previous versions of NAnt, the documentation stated that a target identified by the *nant.onfailure*{: class="text-primary"} property would be executed when the build fails. However, NAnt actually executed a target identified by the *nant.failure*{: class="text-primary"} property (if available). This has now been corrected and the old syntax (*nant.failure*{: class="text-primary"}) is now deprecated.
  * The *&lt;param&gt;*{: class="text-primary"} element of the *&lt;style&gt;*{: class="text-primary"} task has been deprecated in favor of a *&lt;parameters&gt;*{: class="text-primary"} collection with nested *&lt;parameter&gt;*{: class="text-primary"} elements. The *&lt;parameter&gt;*{: class="text-primary"} element now also supports a *namespaceuri*{: class="text-primary"}, *if*{: class="text-primary"} and *unless*{: class="text-primary"} attribute. See the documentation of the *&lt;style&gt;*{: class="text-primary"} task for more information.
  * In previous versions of NAnt, the *Plain*{: class="text-primary"} formatter was implicitly added in the *&lt;nunit2&gt;*{: class="text-primary"} task. In NAnt 0.8.4, the *Plain*{: class="text-primary"} formatter will only implicitly be added if no other formatters are specified. In this case, a warning message will be output to the build log encouraging build authors to explicitly add this formatter for forward compatibility. In future versions of NAnt, the *Plain*{: class="text-primary"} formatter will no longer implicitly be added.
  * The nested *&lt;param&gt;*{: class="text-primary"} child element of the *&lt;style&gt;*{: class="text-primary"} task has been deprecated in favor of a nested *&lt;parameters&gt;*{: class="text-primary"} collection.

### **General changes**

  * The user documentation has been overhauled. Nested elements are more clearly documented, documentation has been added for element types such as filesets and credentials, and the overall format is slightly cleaner and easier to use.
  * Improved bootstrapping NAnt on linux. Now supports Mono 0.28.
  * Localization support has been improved in the *&lt;csc&gt;*{: class="text-primary"}, *&lt;jsc&gt;*{: class="text-primary"}, *&lt;vbc&gt;*{: class="text-primary"} and *&lt;vjc&gt;*{: class="text-primary"} tasks: when dynamixprefix is set to "true" and prefix is set to the root namespace of the assembly for the nested *&lt;resources&gt;*{: class="text-primary"} element, the compiler tasks will now compile resources with IDs matching these generated by VS.NET. Support for the generation of satellite assemblies was also added to these tasks.
  * On systems with both the .NET Framework 1.0 and .NET Framework 1.1 installed, NAnt will now execute on the .NET Framework 1.1 by default. Note, the default target framework has remained unchanged, and is still .NET Framework 1.0.

### **New Tasks**
**&lt;asminfo&gt;**

  * Moved from NAntContrib to NAnt, and was rewritten to support multiple code languages and attribute types.

**&lt;servicecontroller&gt;**

  * Allows a Windows service to be controlled (started, stopped, ...).

**&lt;delay-sign&gt;**

  * Supports delay-signing of strongly named assemblies.

**&lt;mc&gt;, &lt;rc&gt; and &lt;midl&gt;**

  * Moved from NAntContrib to NAnt. These tasks control compilation of service messages, resources, and IDL code respectively.

**&lt;xmlpeek&gt;**

  * Extracts text from an XML file at the location specified by an XPath expression.

**&lt;xmlpoke&gt;**

  * Replaces text in an XML file at the location specified by an XPath expression.

### **Task changes**

**&lt;call&gt;**

  * The *&lt;call&gt;*{: class="text-primary"} task now executes the given target and all its dependencies. In previous versions of NAnt only the target itself would be executed.
  * The *force*{: class="text-primary"} attribute of the *&lt;call&gt;*{: class="text-primary"} task has been deprecated and has no longer any effect. The *&lt;call&gt;*{: class="text-primary"} task will now always execute the specified target, regardless of the fact that this target has already been executed before.

**&lt;cl&gt;**

  * Added support for Managed Extensions.

**&lt;copy&gt;**

  * The *todir*{: class="text-primary"} attribute no longer defaults to the project base directory. It must now be set explicitly.
  * Added *flatten*{: class="text-primary"} attribute to allow all matching files to be copied to a single directory.

**&lt;csc&gt;**

  * Improved localization support.
  * Added support for additional search directories to resolve assembly references through a nested *&lt;lib&gt;*{: class="text-primary"} element.

**&lt;cvs-checkout&gt;**

  * Added option to checkout a revision based on sticky tag, -r on the command line client.
  * Added option to checkout a module to an alternate directory, -d on the command line client.
  * Fixed bug in parsing cvsnt date format.

**&lt;cvs-update&gt;**

  * Fixed bug in parsing cvsnt date format.

**&lt;echo&gt;**

  * Added *level*{: class="text-primary"} attribute to allow messages to be output with a specific level.

**&lt;fail&gt;**

  * Allow reason of failure to be specified as inline content.

**&lt;get&gt;**

  * The *httpproxy*{: class="text-primary"} attribute of the *&lt;get&gt;*{: class="text-primary"} task is deprecated, use the new *&lt;proxy&gt;*{: class="text-primary"} child element instead.
  * Added *&lt;credentials&gt;*{: class="text-primary"} child element used for authenticating the request with the Internet resource.
  * Deprecated the *ignoreerrors*{: class="text-primary"} attribute in favor of the *failonerror*{: class="text-primary"} attribute.
  * Added *timeout*{: class="text-primary"} attribute to allow length of time to wait for a response or the request to timeout to be specified.

**&lt;if&gt;**

  * Added *&lt;uptodatefiles&gt;*{: class="text-primary"} child element for uptodate fileset support.
  * *&lt;if uptodatefile="..."&gt;*{: class="text-primary"} now behaves as documented, meaning that nested tasks will only be executed if the file specifies in the *uptodatefile*{: class="text-primary"} attribute actually exists and the file specified in the *uptodatefile*{: class="text-primary"} attribute is more recent or the same lastwritetime than the file(s) specifies in the comparefile attribute and *&lt;comparefiles&gt;*{: class="text-primary"} fileset.

**&lt;include&gt;**

  * A verbose message will now be output to the build log when a file is included multiple times. In previous versions of NAnt, this would cause a build failure.

**&lt;jsc&gt;**

  * Improved localization support.
  * Added support for additional search directories to resolve assembly references through a nested *&lt;lib&gt;*{: class="text-primary"} element.

**&lt;mail&gt;**

  * The string-based *files*{: class="text-primary"} and *attachments*{: class="text-primary"} attributes have been replaced by fileset support.

**&lt;move&gt;**

  * The *todir*{: class="text-primary"} attribute no longer defaults to the project base directory. It must now be set explicitly.
  * Added *flatten*{: class="text-primary"} attribute to allow all matching files to be moved to a single directory.

**&lt;nant&gt;**

  * Properties can now be added or overridden when calling a nested build using the new *&lt;properties&gt;*{: class="text-primary"} child element.
  * *buildfile*{: class="text-primary"} is now a required attribute, which makes it harder to accidently write an infinitely looping build.

**&lt;nantschema&gt;**

  * Currently the *&lt;nantschema&gt;*{: class="text-primary"} task does not generate the correct XML Schema definition for collections and arrays. This tasks needs to be updated. Please use with caution.

**&lt;ndoc&gt;**

  * Updated the *&lt;ndoc&gt;*{: class="text-primary"} task to using version 1.2 of NDoc.

**&lt;nunit2&gt;**

  * Updated the *&lt;nunit2&gt;*{: class="text-primary"} task to use version 2.1 of NUnit.
  * In previous versions of NAnt, the *Plain*{: class="text-primary"} formatter was implicitly added. In NAnt 0.8.4, the *Plain*{: class="text-primary"} formatter will only implicitly be added if no other formatters are specified. In this case, a warning message will be output to the build log encouraging build authors to explicitly add this formatter for forward compatibility. In future versions of NAnt, the *Plain*{: class="text-primary"} formatter will no longer implicitly be added.
  * Added *outputdir*{: class="text-primary"} attribute for *&lt;formatter&gt;*{: class="text-primary"} element to control the directory where the test result file will be stored (if the *usefile*{: class="text-primary"} attribute is "true").

**&lt;property&gt;**

  * Added *overwrite*{: class="text-primary"} attribute to the *&lt;property&gt;*{: class="text-primary"} task to control whether the value of the specified property should be overwritten when the property already exists.
  * Added support for dynamic properties, meaning properties of which references to other properties are not expanded when the value is set.

**&lt;resgen&gt;**

  * Added support for specifying a prefix to *&lt;resgen&gt;*{: class="text-primary"} task when using a fileset.

**&lt;solution&gt;**

  * Added nested *&lt;assemblyfolders&gt;*{: class="text-primary"} fileset element that allows a set of folders to be set, that should be searched to resolve assembly references.
  * By default, the Visual Studio.NET assembly folders will be searched to resolve assembly references. An includevsfolders attribute was added to control whether these folders should be searched for assembly references.
  * Added *&lt;excludeprojects&gt;*{: class="text-primary"} fileset that allows a set of projects to be excluded.
  * An *outputdir*{: class="text-primary"} attribute can now be specified, which overrides the directory where compiled targets will be placed.
  * A nested *&lt;webmap&gt;*{: class="text-primary"} element was added that maps URL's of web projects to local path, thereby removing the need to configure the web server to allow access to these project files.
  * Added support for Visual C++ projects.
  * A large number of defect fixes and performance improvements have been applied.

**&lt;style&gt;**

  * The nested *&lt;param&gt;*{: class="text-primary"} child element has been deprecated in favor of a nested *&lt;parameters&gt;*{: class="text-primary"} collection.

**&lt;touch&gt;**

  * If the file specified in the single-file case does not exist, it will now be created.

**&lt;vbc&gt;**

  * Improved localization support.
  * Added support for additional search directories to resolve assembly references through a nested *&lt;lib&gt;*{: class="text-primary"} element.

**&lt;vjc&gt;**

  * Improved localization support.
  * Added support for additional search directories to resolve assembly references through a nested *&lt;lib&gt;*{: class="text-primary"} element.

**&lt;zip&gt;**

  * Fixed issue when files were included that were not located beneath the basedir of the fileset.
  * Added *includeemptydirs*{: class="text-primary"} attribute to control whether empty directories should be included in the generated zip file.
  * Fixed failure when no *basedir*{: class="text-primary"} for fileset was specified.
  * Fixed failure when *basedir*{: class="text-primary"} of fileset is set to the root directory of a drive in Windows.

### **API changes**

  * Added *ProgramLocationAttribute*{: class="text-primary"} that can be assigned to a task to indicate that it wraps an executable that is part of either the .NET Framework or the .NET Framework SDK, and have NAnt figure out the full path to the executable using the framework settings in the NAnt configuration file.
  * *FileSetAttribute*{: class="text-primary"} has been deprecated. The *BuildElementAttribute*{: class="text-primary"} should be used instead.
  * Added *FrameworkConfigurableAttribute*{: class="text-primary"} that can be assigned to a task attribute to allow the default values of that attribute to be configured from the framework configuration section in the NAnt configuration file for the currently active framework.
  * Added *&lt;proxy&gt;*{: class="text-primary"} and *&lt;credentials&gt;*{: class="text-primary"} data types that are used to provide proxy settings and authentication information for tasks that connect to external resources (eg. the *&lt;get&gt;*{: class="text-primary"} task).
  * Added support for framework-specific third party libraries.
  * Updated [log4net](http://logging.apache.org/log4net/) to version 1.2.0 beta 8.
  
  
## NAntContrib

---

### **New tasks**

* **&lt;vssdif&gt;**

  * Shows all changes to a Visual SourceSafe project after a specified label.

### Task changes

* **&lt;msi&gt; and &lt;msm&gt;**

  * For entries in the File table, the language will now be supplied.
  * Nullable columns for a custom table are now properly supported.
  * Added checkinterop attributes to the component and fileoverride elements.
  * Support pure registry components.
  * Improved error reporting.

* **&lt;slingshot&gt;**

  * Fixed bug with regards to parameters.
  * Added support for Visual Studio.NET 2003 solutions.

* **&lt;sql&gt;**

  * Made task less chatty.

* **&lt;validatexml&gt;**

  * Renamed schemas child element name from *&lt;schemaref&gt;*{: class="text-primary"} to *&lt;schema&gt;*{: class="text-primary"}.

* **&lt;version&gt;**

  * Improved error reporting and documentation.

* **&lt;vssget&gt;**

  * Added *removedeleted*{: class="text-primary"} attribute to support removal of local files that were deleted files from the Visual SourceSafe repository.
  * Added *usemodtime*{: class="text-primary"} attribute to support setting the timestamp of local files to the modification time of these files in the Visual SourceSafe repository.
  * Added unit tests.

### **Removed Tasks**

* **&lt;tlbimp&gt;**

  * Moved to NAnt.

* **&lt;tlbexp&gt;**

  * Moved to NAnt.

* **&ltrc&gt;**

  * Moved to NAnt.

* **&lt;midl&gt;**

  * Moved to NAnt.

* **&lt;mailex&gt;**

  * All functionality has been merged into the NAnt *&lt;mail&gt;*{: class="text-primary"} task.

* **&lt;asminfo&gt;**

  * Moved to NAnt.

* **&lt;taskdef&gt;**

  * Moved to NAnt.
  
  
  
# 0.8.3 - September 28, 2003 {v0.8.3}

## NAnt

---

### **User-visible changes**

  * Included NAntContrib binaries are from a release build. In rc3 they were debug versions.
  
  
  
# 0.8.3-rc3 - August 29, 2003 {v0.8.3-rc3}

## NAnt

---

### **User-visible changes**

  * Added test directory to distribution fixing the build failure in 0.8.3.
  
  
  
# 0.8.3-rc2 - July 28, 2003 {v0.8.3-rc2}

## NAnt

---

### **User-visible changes**

  * Built with .NET 1.0.
  * This release candidate is built with version 1.0 of the .NET Framework. The binaries for RC1 had been built with version 1.1, which had backwards compatibility issues.
  * Fixed defect: temp directory leak in *&lt;solution&gt;*{: class="text-primary"} task.
  * Matthew Mastracci fixed a major temp directory leak. It was leaking approx. one temp directory per project! You should clear your Local Settings\Temp directory for the user you use to build your solutions.
  * *&lt;solution&gt;*{: class="text-primary"} VB.NET support.
  * The *&lt;solution&gt;*{: class="text-primary"} task now supports VB.NET projects. This was meant to be part of the RC1 release.
  * Matthew Mastracci has also checked in support for reading resources of VB projects and generating the appropriate dependent resource name.
  * Documentation for NAntContrib.
  * This release candidate includes the binaries and documentation for the NAntContrib extensions. Note that the source is still distributed seperately during this release cycle.
  
  
  
# 0.8.3-rc1 - July 10, 2003 {v0.8.3-rc1}

## NAnt

---

### **User-visible changes**

  * NAntContrib is now distributed with NAnt.  
        To better support the frequently-used NAntContrib extensions, the library is now distributed as part of the NAnt release.
  * Preliminary Linux support.  
        This is the first release with Linux support, so please report any issues you encounter. The next release will be fully tested and documented on both Linux and Windows.
  * New Tasks    
    * *&lt;cvs-checkout&gt;*{: class="text-primary"} task : Checkout source from CVS.
    * *&lt;cvs-update:&gt;*{: class="text-primary"} task : Update source from CVS.
    * *&lt;solution&gt;*{: class="text-primary"} task : compile .sln directly. In most cases, this means you no longer have to preprocess a solution with the slingshot tool. Supports both Visual Studio .NET and Visual Studio 2003.
  * Changed tasks.  
    See the section below for details.
  * FileSet references.  
    You can now define a named FileSet and refer to it anywhere a FileSet is used.

### **API changes**

  * Namespace changes
    * "SourceForge" is no longer part of the NAnt namespaces.
    * Split classes up into Tasks and Types.
    * Task assemblies now have their own namespaces.
    * Removed Msft prefix from base classes.
  * Logging framework changed
    * Refactored NAnt (build) logging system : moved to an event driven logging system, and allow thresholds to be set. The build outcome is now completely handled by the loggers.
    * Replaced the LogListener with an IBuildLogger interface for loggers and an IBuildListener interface for build listeners.
    * The ConsoleLogger is replaced by a DefaultLogger, which always logs to the console, and which can also be configured to log to a file (using the -logfile option).
    * The static Log class is removed and replaced by instance methods on the Project and Task classes. These instance methods actually fire events that get handled by the build logger and buid listeners.
    * Added a Level enum that is used to assign a priority (level) to a message. This allows messages to be filtered on their priority.
    * Added a strongly typed collection for the build listeners.
    * Updated all existing logging statements to use the new logging system instead of the static Log class. Assigned levels to the existing logging statements.
    * Added MailLogger that can be used to send the build results as an email, see xml docs for how its to be configured.
  * Many, many style/structure/documentation fixes. More that are worth listing here.
  * Fixed NUnit2 support for FileSets.
  * Prevent warnings for using obsolete methods to allow NDoc Documenter.Nant to build on .NET 1.1 runtime.
  * Nightly.xml no longer depends on NAntContrib tasks.
  * Moved *&lt;mail&gt;*{: class="text-primary"} task and test back into core as its working fine on Linux now.
  * New attribute-driven command-line parser.

### **Command-line client changes**

  * Changed target back to the default argument.
  * Moved company information (http://nant.sourceforge.net) from help text to logo banner.
  * Added support for running default.build if there are multiple build files in a directory.
  * Added support for collection-based command-line options, with the following restrictions :
    * property type should implement ICollection
    * collection should have an Add method with one parameter
    * parameter of the Add method should be strongly-typed
    * collection should have a default public constructor
    * the property should have a setter if the collection is not initialized (null reference)
  * Fixed "bug" where ApplicationException would no longer be throw when no matching buildfile is found after searching the directory tree upwards.
  * Updated short form of buildfile to -f.
  * Added -q shortname for -quiet command-line option.
  * Changed description of -indent command-line option.
  * Added command-line option for adding build listeners.
  * Updated xml documentation.
  * Added command-line options for filtering build output (-debug and -quiet).
  * Jarek's patch to allow setting of the default framework from the command line, fixes bug 729778.
  * Always use identifier mono-1.0 for Mono framework, no use in always creating new framework configurations for every Mono release.

### **Task changes**

**&lt;exec&gt;**

  * Added support for an environment optionset to the *&lt;exec&gt;*{: class="text-primary"} task.
  * Fixed optionset so that it correctly returns optionvalues.
  * Remove Timeout from ExecTask, make Timeout in ExternalProgramBase a task attribute and make it writable.
  * Throw BuildException if process has not exited after timeout.

**&lt;vjc&gt;**

  * Added attribute for setting the warninglevel (0-4).
  * Added attribute for specifiying list of warnings that should be suppressed by the compiler.

**&lt;jsc&gt;**

  * Added support for codepage compiler flag.
  * Added attribute for setting the warninglevel (0-4).

**&lt;csc&gt;**

  * Added support for codepage compiler flag.
  * Renamed optionoptimize attribute to optimize.
  * Added attribute for setting the warninglevel (0-4).
  * Added attribute for specifiying list of warnings that should be suppressed by the compiler.
  * Patch from Justin Santa Barbara to add optimize flag to csc.
  * Fixed csc example.

**&lt;nantschema&gt;**

  * Added makefile for building on Linux. Also a new bin directory for Linux specific binaries.

**&lt;mcs&gt;**

 * Removed *&lt;mcs&gt;*{: class="text-primary"} task. the *&lt;csc&gt;*{: class="text-primary"} task in combination with the framework support should be used instead.

**&lt;nant&gt;**

  * Fixed problem with basedir in nested *&lt;nant&gt;*{: class="text-primary"} build being incorrect if basedir="." is used.
  * Have new project inherit the default framework from the current project.

**&lt;copy&gt;**

  * Fix for *&lt;copy&gt;*{: class="text-primary"} task breakage on Linux.
  * Reenabled File.SetAttributes on Mono build as bug #41999 has been fixed.

**&lt;if&gt;**

  * Fixed logging bug with parenthesis instead of brace. Caused *&lt;if uptodate...&gt;*{: class="text-primary"} to fail erroneously.

**&lt;cl&gt; and &lt;link&gt;**

  * On demand compile support for *&lt;link&gt;*{: class="text-primary"} and *&lt;cl&gt;*{: class="text-primary"} tasks.
  * Added unit tests for the *&lt;cl&gt;*{: class="text-primary"} and *&lt;link&gt;*{: class="text-primary"} tasks.
  * Moved Visual C++ related tasks into Win32Assemblies so it doesn't get built in a Mono/Linux build.

**&lt;fileset&gt;**

  * Added support for FileSet references. Framework for making all types referencable but only implemented for FileSets right now.

**&lt;mail&gt;**

  * Reenabled usage of StringWriter constructor with CultureInfo as this bug in Mono is fixed.
  * No longer have empty strings as default.
  * Bcc and cc are no longer set to an empty string when not specified in buildfile, thereby preventing problems with Mono bug #45746.
  
  
  
# 0.8.2 - April 24, 2003 {v0.8.2}

## NAnt

---

  * Misc bugfixes.
  
  
  
# 0.8.2-rc3 - April 17, 2003 {v0.8.2-rc3}

## NAnt

---

  * *&lt;if&gt;*{: class="text-primary"} task changes to support the uptodate test.
    Changes for task item element initialization.
  * Read output of *&lt;exec&gt;*{: class="text-primary"}'d (and other external program) processes and insert into logfile.
  * Fixed logging for *&lt;regex&gt;*{: class="text-primary"} task.
  * Made NAnt errors less chatty.
  * NAnt now works without Framework SDK installed.
  * Fixed bugs in *&lt;Copy&gt;*{: class="text-primary"} and *&lt;Move&gt;*{: class="text-primary"} tasks which caused exceptions when using todir and a FileSet, in certain cases.
  * New *&lt;unzip&gt;*{: class="text-primary"} task.
  * New *&lt;loadtasks&gt;*{: class="text-primary"} task which replaces the functionality of taskdef (from NAntContrib).
  * *&lt;foreach&gt;*{: class="text-primary"} supports *{: class="text-primary"}&lt;in&gt*{: class="text-primary"};*&lt;items&gt;*{: class="text-primary"} FileSet to work on files.
  
  
  
# 0.8.2-rc2 - April 12, 2003 {v0.8.2-rc2}

## NAnt

---

  * Fix for *&lt;nunit2&gt;*{: class="text-primary"} task using FileSet.
  * Fix for FileSet's *&lt;includeList&gt;*{: class="text-primary"} element.
  
  
  
# 0.8.2-rc1 - April 12, 2003 {v0.8.2-rc1}

## NAnt

---

  * Logging cleanups: use log4net for internal logging.
  * FxCop cleanups for correctness.
  * Support for multiple versions of .NET framework.
  * Changes to make NAnt more Mono-friendly.
  * Updated SharpZipLib library.
  * Makes error reporting more accurate - give line numbers for property expansion errors.
  * Multiple test assembly support for *&lt;nunit2&gt;*{: class="text-primary"} task.
  * General speed-up for directory/file scanning.
  * *&lt;resgen&gt;*{: class="text-primary"} task file generation correctness fixes.
  * Added support multiple delimiters and string trimming to LoopTask's file line mode.
  * More support for csc/vbc command-line options.
  
  
  
# 0.8.1 - February 21, 2003 {v0.8.1}

## NAnt

---

  * Added more command-line options (-f: to specify a buildfile).
  * Added case sensitivity checks.
  * Added *&lt;vjc&gt;*{: class="text-primary"} task.
  * Fixed NUnit2 support.
  * Misc bugfixes and cleanups from contributors.
  
  
  
# 0.7.9 - June 11, 2002 {v0.7.9}

## NAnt

---

  * If more than one build file matches the criteria, e.g. two files ending in .build than NAnt will report an error.
  * Added -find option, causes NAnt to search up the directory tree looking for the buildfile. Use in conjunction with -buildfile:foo.* to find the first foo.* file up the directory tree.
  * Added -projecthelp option, callable targets should now include a description attribute to describe briefly what they do.
  * CompilerBase tasks now check for changed resources and recompiles if out of date.
  * Compiler tasks reportq what caused the rebuild when verbose is on, try 'NAnt -verbose'.
  * Improved Log class.
  * Added PlainText NUnit formatter, see NAnt's build file for an example.
  * nant.onsuccess and nant.onfailure properties can now name a target to get executed at the end of a build.
  * FileSets now have an absolute element. Items inside an absolute element will always be included in the file set. This is useful for references that are in the system path. See the HelloWindowsForms build file for an example.
  * -set option changed to -D to be more like Ant.
  * Unknown command line arguments cause program help to be displayed.
  * FileSets now support absolute paths and parent directories.
  * *Tasks.dll assemblies that are in the same folder as NAnt are automatically loaded and scanned for tasks.
  * User manual available.
  * Help for tasks is auto-generated.
  * *&lt;attrib&gt;*{: class="text-primary"} task added.
  * *&lt;gac&gt;*{: class="text-primary"} task added and moved to NAntContrib project.
  * *&lt;sysinfo&gt;*{: class="text-primary"} task added.
  * Added failonerror, verbose, if and unless attributes to all tasks.
  * DESIGN DECISION: all elements and attributes will be lowercase
  * Major reworking of FileSet class (removed absolutes element, added asis attribute).
  * Tasks/Targets/FileSet includes/excludes now have if/unless attributes.
  * New Unit Tests added.
    * CallTest.cs
    * DeleteTest.cs
    * EchoTest.cs
    * FailTest.cs
    * MkdirTest.cs
    * MoveTest.cs
    * PropertyTest.cs
  * New Properties added during project initilization.
    * nant.location points to nant.exe directory
    * nant.tasks.[TaskName].location points to [TaskName] host assembly
  * *&lt;nant&gt;*{: class="text-primary"} task now inherits properties to new project.
  * Tasks moved to NAntContrib Project
    * GacTask.cs
    * RcTask.cs
    * ResGenTask.cs
    * TlbExpTask.cs
    * TlbImpTask.cs
    * TypedCollectionTask.cs
    * Vb6Task.cs
  * NUnit XML format updated.
  * Many, many, many bugs fixed.
  
  
  
# 0.7.749 - January 19, 2002 {v0.7.749}

## NAnt

---

  * *&lt;docnet&gt;*{: class="text-primary"} task added, try 'NAnt doc' to build NAnt's documentation.
  * NUnitCore.dll added to project.
  * Fixed FileSet basedir attributes, they now expand macros.
  * *&lt;script&gt;*{: class="text-primary"} task and example added - thanks to Sergey Chaban.
  * Build file now extracts version number from AssemblyInfo.cs - thanks to Sergey Chaban.
  * CompilerBase now adds quotations to all referenced files - thanks to Mike Krueger.
  * BuildException is now serializable.
  * ExternalProgramBase reports differentiates between Process exceptions and program return codes now.
  * Unit tests are now run as part of the buid process.
  * *&lt;touch&gt;*{: class="text-primary"} task added - thanks to Jay Turpin.
  * NUnit overhaul.
    * camelCase'ed attributes, haltOnFailure, haltOnError
    * renamed printsummary to verbose
    * replaced SummaryResultFormatter with improved SummaryFormatter
    * added VerboseFormatter
  * *&lt;get&gt;*{: class="text-primary"} task added - thanks to Jay Turpin
  * *&lt;docnet&gt;*{: class="text-primary"} task renamed to *&lt;ndoc&gt;*{: class="text-primary"}.
  * NDoc.Core.dll and NDoc.Documenter.Msdn.dll added to project.
  * NAnt.exe split into NAnt.exe and NAnt.Core.dll.
  * *&lt;al&gt;*{: class="text-primary"} task added - thanks to Joe Jones.
  * *&lt;resgen&gt;*{: class="text-primary"} task added - thanks to Joe Jones.
  * *&lt;zip&gt;*{: class="text-primary"} task added - thanks to Mike Krueger.
  * *&lt;cl&gt;*{: class="text-primary"} task added - thanks to Shawn Van Ness.
  * Added support for .NET v1.0.3705 (RTM).
  
  
  
# 0.6.0 - September 18, 2001 {v0.6.0}

## NAnt

---

  * Report build file xml errors in a useful way.
  * Report error location when tasks are missing required attributes.
  * *&lt;copy&gt;*{: class="text-primary"} task updated - thanks to Ian MacLean.
    **/*.cs type pattern matching now available in FileSets via DirectoryScanner class.
  * Added all the environment variables to properites,ie, *&lt;echomessage="path=${nant.env.PATH}"/&gt;*{: class="text-primary"}.
  * *&lt;move&gt;*{: class="text-primary"} task updated - thanks to Ian MacLean.
  * *&lt;sleep&gt;*{: class="text-primary"} task added - thanks to Ian MacLean.
  * DirectoryScanner and FileSet's scan for files AND directories now
  * FileSet's cache scan results, use Scan() to rescan.
  * FileSet's auto initialize to their containing task, this helps clean up the code.
  * *&lt;copy&gt;*{: class="text-primary"} task can now copy full directory trees.
  * Added verbose attribute to *&lt;copy&gt;*{: class="text-primary"} task, default off, message gives number of files processed.
  * Fixed bug with any ExternalBase tasks hanging - thanks to Sergey Chaban for reporting.
  * *&lt;include&gt;*{: class="text-primary"} task added.
  * *&lt;call&gt;*{: class="text-primary"} task added.
  * -verbose command line option added.
  * Build file can now build complete distribution, try 'NAnt dist'.



# 0.5.0 - August 22, 2001 {v0.5.0}

## NAnt

---

  * Complete overhaul of the web site and doc folder (all html files).
  * Made src a parent folder to be able to hold multiple assemblies in anticipation of the NAnt.Tests.dll assembly.
  * License changed to GNU General Public License.
  * Source code placed under CVS.
  * Tasks can now have attributes in base classes, see CompilerBase as an example - thanks to Mike Krueger.
  * Coding conventions posted on SourceForge in the document manager.
  * Task manager in SourceForge is now being used to track currently active tasks.
  * Namespace changed to SourceForge.NAnt.
  * Added basic command line parsing.
  * Added version resource.
  * Support for multiple build targets (try 'NAnt clean test').
  * BuildException added to report text position in the build file where errors occur - thanks to Ian MacLean.
  * *&lt;style&gt;*{: class="text-primary"} task (xslt processing) added - thanks to Serge.
  * Executable is now signed with the NAnt.key.
  * Converted all public/protected fields to properties.
  * Added support for user defined properties.
  * Added -set option (try 'NAnt -set:debug=true clean build').
  * Changed verions number to 0.5 to reflect the number of changes in the code base.
  
  
  
# 0.1.5 - July 22, 2001 {v0.1.5}

## NAnt

---

  * Only compiles program if source file last write time &gt; output last write time.
  * Refactored compiler code into common CompilerBase class.
  * Refactored compiler and exec task into common ExternalProgramBase class.
  * Added *&lt;arg value="/win32res:filename"/&gt;*{: class="text-primary"} element to all external program tasks.
  * Added Int32ValidatorAttribute and BooleanValidatorAttribute classes to perform error checking on task attributes after macro expansion but before task execution. Search for BooleanValidator or Int32Validator in tasks for examples.
  * Changed Task attribute names to TaskAttributeAttribute and FileSetAttribute.
  * Removed default value for task attributes (set with initial value).
  * Changes to Project class on how to initialize a project and run it.
  * Right aligned task prefixes to clean up output.
  * Added or enhanced these tasks
    * vbc, jsc, csc
    * move
    * nant
    * tstamp
    * exec (failonerror attribute)
  
  
  
# 0.1.4 - July 19, 2001 {v0.1.4}

## NAnt

---

  * Added or enhanced these tasks
    * echo
    * fail
    * property
    * copy (respects basedir)
    * delete (respects basedir)
    * mkdir (respects basedir)
    * exec
  
  
  
# 0.1.3 - July 18, 2001 {v0.1.3}

## NAnt

---

  * Dependencies working via depends attribute on targets.
  * Changed name from NBuild to NAnt.
  * Using the name "Parameter" to refer to the xml attributes in tasks because it was conflicting badly with .NET Attributes.
  * Added FileSetParameterAttribute so that FileSet parameters would autoinit.
  * Renamed TaskAttributeAttribute to StringParameterAttribute.
  * Broke into seperate source files (one per class).
  * Changed default build file from Project.xml to the first file with a .build extension.
  
  
  
# 0.1.2 - July 16, 2001 {v0.1.2}

## NAnt

---

  * Basic functionality to have NAnt build itself (*&lt;csc&gt;*{: class="text-primary"} task).
  
  
  
# 0.1.1 - July 5, 2001 {v0.1.1}

## NAnt

---

  * Initial test version.
