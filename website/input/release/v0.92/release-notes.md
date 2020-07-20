---
Title: v0.92 release notes
---
[//]: # (TOC Begin)
* [v0.92](#v0.92)
* [v0.91-rc1](#v0.91-rc1)
* [v0.92-beta1](#v0.92-beta1)
* [v0.92-alpha1](#v0.92-alpha1)
* [v0.91](#v0.91)
* [v0.91-rc1](#v0.91-rc1)
* [v0.91-beta1](#v0.91-beta1)
* [v0.91-alpha2](#v0.91-alpha2)
* [v0.91-alpha1](#v0.91-alpha1)
* [v0.90](#v0.90)
* [v0.90-rc1](#v0.90-rc1)
* [v0.90-beta1](#v0.90-beta1)
* [v0.90-alpha1](#v0.90-alpha1)
* [v0.86-beta1](#v0.86-beta1)
* [v0.85](#v0.85)
* [v0.85-rc4](#v0.85-rc4)
* [v0.85-rc3](#v0.85-rc3)
* [v0.85-rc2](#v0.85-rc2)
* [v0.85-rc1](#v0.85-rc1)
* [v0.84](#v0.84)
* [v0.84-rc2](#v0.84-rc2)
* [v0.84-rc1](#v0.84-rc1)
* [v0.8.3](#v0.8.3)
* [v0.8.3-rc3](#v0.8.3-rc3)
* [v0.8.3-rc2](#v0.8.3-rc2)
* [v0.8.3-rc1](#v0.8.3-rc1)
* [v0.8.2](#v0.8.2)
* [v0.8.2-rc3](#v0.8.2-rc3)
* [v0.8.2-rc2](#v0.8.2-rc2)
* [v0.8.2-rc1](#v0.8.2-rc1)
* [v0.8.1](#v0.8.1)
* [v0.7.9](#v0.7.9)
* [v0.7.749](#v0.7.749)
* [v0.6.0](#v0.6.0)
* [v0.5.0](#v0.5.0)
* [v0.1.5](#v0.1.5)
* [v0.1.4](#v0.1.4)
* [v0.1.3](#v0.1.3)
* [v0.1.2](#v0.1.2)
* [v0.1.1](#v0.1.1)

[//]: # (TOC End)

# 0.92 (June 9, 2012) {v0.92}

## NAnt

No Updates since 0.92-rc1

## NAntContrib

### Bug Fixes

**Tasks**

* **NUnit2Report** 

    Fixed graphs so they appear correctly on modern browsers. ([Pull Request #21](https://github.com/nant/nantcontrib/pull/21))  
    Removed # prefix from anchor names. ([Pull Request #20](https://github.com/nant/nantcontrib/pull/20))


# 0.92-rc1 (May 23, 2012) {v0.91-rc1}

## NAnt

### Breaking changes

**Tasks**

* **XmlPoke**

    Updated XmlPoke task to honor the failonerror{: class="text-primary"} attribute. ([Issue #44](https://github.com/nant/nant/issues/44))

### Changes

**Core**

* **NAnt AppDomains**

    Updated NAnt to use the Unrestricted permission state when creating AppDomains by default instead of just on .NET/Mono 4.0. ([Issue #48](https://github.com/nant/nant/issues/48))

**Tasks**

* **TryCatch**

    Moved &lt;trycatch&gt; task from NAntContrib to NAnt. ([Issue #26](https://github.com/nant/nant/issues/26))

* **Choose**

    Moved &lt;choose&gt; task from NAntContrib to NAnt. ([Issue #26](https://github.com/nant/nant/issues/26))

## NAntContrib

### Changes

**Tasks**

* **TryCatch**
    
    Moved &lt;trycatch&gt; task from NAntContrib to NAnt. ([Issue #26](https://github.com/nant/nant/issues/26))

* **Choose**

    Moved &lt;choose&gt; task from NAntContrib to NAnt. ([Issue #26](https://github.com/nant/nant/issues/26))


# 0.92-beta1 (May 6, 2012) {v0.92-beta1}
No Updates since 0.92-alpha1


# 0.92-alpha1 (April 22, 2012) {v0.92-alpha1}

## NAnt

### Changes

**Framework support**

  * Removed runtime support for .NET/Mono 1.* Frameworks (target support for .NET/Mono 1.* Frameworks still remains)

**Core**

* **NAnt Project Files**

    Updated NAnt project files to VS2010 format.

* **NUnit**

    Upgraded to NUnit 2.6.

* **App.Config**

    Added initial support for Silverlight 5

* **Command Line**

    Added pause option to pause nant before exit.

* **Type Factory**

    Added detailed error messages when type loading exception occurs.

**Tasks**

* **Mail**

    Updated &lt;mail&gt; task to reference System.Net.Mail namespace instead of System.Web.Mail.

    Added additional attritbutes for greater control of the &lt;mail&gt; task. Such as:

        * mailport
        * ssl
        * user
        * password
        * replyto

* **Zip**

    Added flatten attribute to &lt;zip&gt; task.

* **Tar**

    Added flatten attribute to &lt;tar&gt; task.

### Bug fixes

**Tasks**

* **Copy/Move tasks**

    Fixed issues with &lt;copy&gt; and &lt;move&gt; tasks when trying to relocate directories. ([Issue #11](https://github.com/nant/nant/issues/11))

* **Asminfo**

    Fixed issue with &lt;asminfo&gt; task when trying to add assembly attributes with default constructors. ([Issue #41](https://github.com/nant/nant/issues/41))

* **Style**

    Updated &lt;style&gt; task to preserve singleton tags whenever possible. ([Issue #17](https://github.com/nant/nant/issues/17))

## NAntContrib

### Changes

**Core**

* **NAntContrib Project Files**

    Updated NAntContrib project files to VS2010 format. 

**Functions**

* **Array functions**
    
    Added Array functions to sort and reverse a string array.

## 0.91 (October 22, 2011) {v0.91}

### Bug fixes

**Core**

* **XmlPeek**

    Fixed issue with XmlPeek not outputting results in xml format. ([bugs #3366107](https://sourceforge.net/tracker/?func=detail&aid=3366107&group_id=31650&atid=402868) and [#3390653](https://sourceforge.net/tracker/?func=detail&aid=3390653&group_id=31650&atid=402868))

* **App.config**

    Added necessary .NET 4.0 WPF and misc missing .NET 3.5 reference assemblies. (bug 3314793)

## 0.91-rc1 (October 8, 2011) {v0.91-rc1}

### Bug fixes

**Core**

* **App.config**

    Fixed issue with NDoc when building NAnt from source. (bug [#3416986](https://sourceforge.net/tracker/index.php?func=detail&aid=3416986&group_id=31650&atid=402868)).

* **Makefile**

    Fixed issue when building NAnt with older versions of GNU Make.

## 0.91-beta1 (September 25, 2011) {v0.91-beta1}

### Changes

**Core**

* **App.Config**

    Added mono-4.0 target  
    Added initial support for Silverlight 3 and 4

* **log4net**

    Upgraded to log4net 1.2.10.

* **MSBuild**

    Added initial support for 2008/2010 MSBuild/VS.NET project files.

### Bug fixes

**Core**

* **App.config**

    Added WindowsBase.dll and PresentationFramework.dll to 4.0 target.

* **NAnt.xsd**

    Changed the NAnt.Core.Tasks.DescriptionTask task to mixed. (bug [#3058913](https://sourceforge.net/tracker/?func=detail&aid=3058913&group_id=31650&atid=402868)).

* **BuildException**

    Display correct registry hives in BuildException when Registry Path not found.

**Tasks**

* **ndoc**

    Fixed ndoc task to find hhc.exe for chm generation on 64 bit machines through reflection.

## 0.91-alpha2 (August 17, 2010) {v0.91-alpha2}

### Bug fixes

**Core**

* **App.config**

    Fixed typo that prevented System.Management.dll from being included.

**Tasks**

* **&lt;include&gt;**

    Fixed error with the &lt;include&gt; task when different build files include the same file. (bug [#3016497](https://sourceforge.net/tracker/?func=detail&aid=3016497&group_id=31650&atid=402868)).

**Functions**

* **NAnt::get-assembly()**

    Using the NAnt::get-assembly() function causes an "Object must implement IConvertible" error. (bug [#3013492](https://sourceforge.net/tracker/?func=detail&aid=3013492&group_id=31650&atid=402868)).


## 0.91-alpha1 (May 29, 2010) {v0.91-alpha1}

### Framework support

    Added support for .NET Framework 4.0 (except for &lt;solution&gt; task).

### Bug fixes

**Expressions**

* **Coercion**

    Coercion of arguments is not supported (bug [#3013492](http://sourceforge.net/tracker/?func=detail&aid=3013492&group_id=31650&atid=402868)).

### Changes

**Tasks**

* **&lt;xmlpeek&gt;**

    Enhanced the &lt;xmlpeek&gt; task to support more advanced XPath functions and syntax. It is now possible to use functions such as count() and to index the node using XPath directly. (feature request [#1560566](http://sourceforge.net/tracker/index.php?func=detail&aid=1560566&group_id=31650&atid=402871)).


## 0.90 (May 8, 2010) {v0.90}

### Bug fixes

**Tasks**

* **&lt;tar&gt;**

    When the "destfile" attribute specifies a non-existent path, the base directory(ies) will be created. (bug [#2997300](http://sourceforge.net/tracker/index.php?func=detail&aid=2997300&group_id=31650&atid=402868)).


## 0.90-rc1 (May 2, 2010) {v0.90-rc1}

### Bug fixes

**Core**

* **&lt;PathScanner&gt;**

    Catch UnauthorizedAccessException in PathScanner to prevent NAnt from crashing when using the Scan() function to search for file(s) in directory with special permissions.


## 0.90-beta1 (April 17, 2010) {v0.90-beta1}

### Bug fixes

**Tasks**

* **&lt;csc&gt; / &lt;jsc&gt; / &lt;vbc&gt; / &lt;vjc&gt;**

    When the "output" attribute specifies a non-existent path, the base directory(ies) will be created. (bug [#2985057](http://sourceforge.net/tracker/index.php?func=detail&aid=2985057&group_id=31650&atid=402868)).

* **ExternalProgramBase**

    For certain tasks (NDoc, Exec, MSBuild, etc) the console output is unorganized and difficult to read. (bug [#2981604](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=2981604&group_id=31650)).

* **&lt;script&gt;**

    Cleanup the output to show assembly information and functions only when "verbose" attribute is set to "true". (bug [#2981386](http://sourceforge.net/tracker/?func=detail&aid=2981386&group_id=31650&atid=402868)).

* **&lt;zip&gt;**

    When the "zipfile" attribute specifies a non-existent path, the base directory(ies) will be created. (bug [#2981389](http://sourceforge.net/tracker/index.php?func=detail&aid=2981389&group_id=31650&atid=402868)).


## 0.90-alpha1 (April 1, 2010) {v0.90-alpha1}

### Breaking changes

**Core**

* **Extensibility**

    Deprecated NAnt.Core.Element.InitializeElement(XmlNode) and NAnt.Core.Task.InitializeTask(XmlNode) in favor of NAnt.Core.Element.Initialize(). This was done to discourage direct access to the XML node that was used to initialize the construct.

**Tasks**

* **&lt;script&gt;**

    As of this release, only the following namespaces are imported by default:

        * System
        * System.Collections
        * System.Collections.Specialized
        * System.IO
        * System.Text
        * System.Text.RegularExpressions
        * NAnt.Core
        * NAnt.Core.Attributes

    Starting from this release, only NAnt.Core and mscorlib will be referenced by default.  

    In previous releases, all loaded assemblies would implicitly be referenced.

### Bug fixes

**Extensibility**

* **DataTypeBaseBuilder / FilterBuilder / TaskBuilder**

    Changes to constructors break backward compatibility (bug [#2782705](http://sourceforge.net/tracker/?func=detail&aid=2782705&group_id=31650&atid=402868)).

**Expressions**

* **Identifiers**

    Identifiers containing a dot or backslash are falsely rejected.

**Framework support**

* **.NET Framework (All)**

    The target framework cannot be initialized if the .NET Framework SDK is not installed (bug [#1859708](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=1859708&group_id=31650)).

* **.NET Framework 1.1**

    Added the following assemblies to the list of reference assemblies:

        * Microsoft.VisualBasic.Compatibility.dll
        * Microsoft.VisualBasic.Compatibility.Data.dll
        * System.Data.OracleClient.dll

    Fixes bug [#1848648](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=1848648&group_id=31650).

* **.NET Framework 3.5**

    Modified version (as returned by framework::get-version()) to "3.5".  
    Added support for Windows SDK 6.1 (bug [#1986551](https://sourceforge.net/tracker/index.php?func=detail&aid=1986551&group_id=31650&atid=402868)).  
    Added support for Windows SDK 7.0.  

**Tasks**

* **&lt;echo&gt;**

    A newline is implicitly added when writing a message to a file (bug [#2807728](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=2807728&group_id=31650)).

* **&lt;echo&gt;**

    When "output" parameter is specified, standard output is redirected properly. (bug [#1010223](https://sourceforge.net/tracker/?func=detail&aid=1010223&group_id=31650&atid=402868)).

* **ExternalProgramBase**

    The value of UseRuntimeEngine is not respected when overriden by derived classes (bug [#1850383](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=1850383&group_id=31650)).

* **&lt;move&gt;**

    When source file is newer than destination file, then an error is reported if "overwrite" is not set to true.

* **&lt;solution&gt;**

    Solution Folders result in build failure (bug [#1732361](http://sourceforge.net/tracker/index.php?func=detail&aid=1732361&group_id=31650&atid=402868)).

* **&lt;xmlpeek&gt;**

    "verbose" feature is now worked as documented (bug [#1911292](http://sourceforge.net/tracker/index.php?func=detail&aid=1911292&group_id=31650&atid=402868)).

* **&lt;zip&gt;**

    Improved backward compatibility with older unzip implementations.

**Types**

* **&lt;fileset&gt;**

    Files matching the **/vssver2.scc pattern are not excluded by default (bug [#2515816](https://sourceforge.net/tracker/index.php?func=detail&aid=2515816&group_id=31650&atid=402868)).

### Additions

**Functions**

* **environment::newline()**

    Gets the newline string defined for this environment.

* **framework::get-description()**

    Gets the description of the current target framework.

* **framework::get-clr-version()**

    Gets the CLR version of the current target framework.

* **framework::get-frameworks(NAnt.Core.FrameworkTypes)**

    Gets a comma-separated list of frameworks filtered by the specified FrameworkTypes.

    For example:

        ```
        &lt;target name="build-all"&gt;
            &lt;foreach item="String" in="${framework::get-frameworks('installed compact')}" delim="," property="framework"&gt;
                &lt;property name="nant.settings.currentframework" value="${framework}" /&gt;
                &lt;call target="${framework}" /&gt;
            &lt;/foreach&gt;
        &lt;/target&gt;

        &lt;target name="build"&gt;
            ...
        &lt;/target&gt;
        ```      

* **framework::get-version()**

    Gets the version of the current target framework.

* **platform::is-windows()**

    Return a value indicating whether NAnt is running on Windows.

**Tasks**

* **&lt;untar&gt;**

    Extracts files from a tar archive.

### Changes

**Packaging**

* **pkg-config**

    When installing NAnt from source on Unix (using make install), a nant.pc is now installed in $prefix/lib/pkgconfig.

* **DESTDIR**

    To allow for staged installs, our makefile now also supports the DESTDIR variable:

        ```$ make DESTDIR=/tmp/local install
                

**Functions**

* **platform::is-win32()**

    This function is deprecated, use platform::is-windows() instead.

**Tasks**

* **&lt;csc&gt; / &lt;jsc&gt; / &lt;vbc&gt; / &lt;vjc&gt;**

    Added "winres" attribute to specify a Win32 resource file.

* **&lt;echo&gt;**

    The "encoding" attribute can be used to specify the encoding when writing messages to a file.

        ``` &lt;echo file="build.cmd" encoding="ascii"&gt;...&lt;/echo&gt;
                
* **&lt;link&gt;**

    Added "moduledefinition" parameter to allow the name of the module definition file to be set.

* **&lt;nunit2&gt;**

    Allow referenced assemblies to be specified using &lt;references&gt; element on &lt;test&gt;:

        ```
        &lt;nunit2&gt;
            &lt;test&gt;
                &lt;assemblies basedir="build/tests"&gt;
                    &lt;include name="Cegeka.HealthCare.DocGen.Tests.dll" /&gt;
                    &lt;include name="Cegeka.HealthCare.Util.Tests.dll" /&gt;
                &lt;/assemblies&gt;
                &lt;references basedir="build/lib"&gt;
                    &lt;include name="Cegeka.HealthCare.Common.dll" /&gt;
                    &lt;include name="Cegeka.HealthCare.DocGen.dll" /&gt;
                    &lt;include name="Cegeka.HealthCare.Util.dll" /&gt;
                &lt;/assemblies&gt;
            &lt;/test&gt;
        &lt;/nunit2&gt;
        ```
                
    Previously, all referenced assemblies needed to be either in the GAC, or in the directory containing the test assembly.

* **&lt;solution&gt;**

    Introduced support for targeting a specific platform, as defined in the solution or project.

* **&lt;xmlpoke&gt;**

    Added "preserveWhitespace" parameter to retain the original format of the XML files.

* **&lt;unzip&gt;**

    Added "overwrite" parameter to control whether to overwrite files even if they are newer than corresponding entries in the archive.

**Third-Party**

* **#ziplib**

    Upgraded to v0.85.5.452.

**Types**

* **&lt;fileset&gt; / &lt;patternset&gt;**

    For patterns specified using &lt;includesfile&gt; or &lt;excludesfile&gt;, lines that have a number sign (#) as the first non-blank character in a line are now ignored.


## 0.86-beta1 (December 8, 2007) {v0.86-beta1}

### Breaking changes

**Core**

* **nant.tasks properties**

    Prior to NAnt 0.85, build authors would use a "nant.tasks.*" property to check whether a given task was available.  

    With the introduction of expression support in NAnt 0.85, we provided a more powerful alternative through the task::exists function.  

    As of this release, the "nant.tasks.*" properties are therefore no longer set by NAnt.

* **nant.failure**

    Removed support for the "nant.failure" property to set the target that should be executed when the build fails.  

    This property was deprecated in NAnt 0.83 in favor of the "nant.onfailure" attribute.  

    As of this release, setting the "nant.failure" attribute will no longer have any effect.

**Expressions**

* **= operator**

    In NAnt 0.85, support for the '=' operator to check for equality was deprecated in favor of the '==' operator.  

    As from this release, the '=' operator is no longer recognized.

**Tasks**

* **&lt;style&gt;**

    Removed support for &lt;param&gt; child element, which was deprecated in NAnt 0.84 in favor of a &lt;parameters&gt; element.

### Bug fixes

**Core**

* **MailLogger**

    If "MailLogger.smtp.username", "MailLogger.smtp.port" or "MailLogger.smtp.enablessl" are set, messages must be delivered using the SMTP protocol over the network. [.NET 1.1 or higher]

* **Response File**

    Quoted arguments are not parsed correctly from response files (bug [#1736526](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1736526&group_id=31650)).

* **Document Type Definition**

    Executing a project with a DTD can lead to an internal error. (bug [#1809994](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1809994&group_id=31650)).

**Framework support**

* **Mono/Cygwin**

    In Cygwin, the directory containing the Mono configuration files was not correctly constructed from pkg-config info, leading to errors when running applications that use System.Configuration.

**Tasks**

* **&lt;call&gt;**

    Target is not re-executed if "cascade" is false (bug [#1474159](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=1474159&group_id=31650)).

* **&lt;csc&gt;**

    Satellite assemblies are not signed when signing key is specified using "keyfile" attribute (bug [#1587739](http://sourceforge.net/tracker/index.php?func=detail&aid=1587739&group_id=31650&atid=402868)).

* **&lt;exec&gt;**

    Empty lines written to standard output or standard error by external program are ignored.

* **&lt;resgen&gt;**

    If the embedded resource compiler for the target framework does not support assembly references, then copy both the compiler and related files (based on pattern matching) to the intermediary compile directory (bug [#1591991](http://sourceforge.net/tracker/?func=detail&atid=402868&aid=1591991&group_id=31650)).

* **&lt;solution&gt;**

    * Visual C++
        * Custom build steps are not supported (bug [#1082374](http://sourceforge.net/tracker/index.php?func=detail&aid=1082374&group_id=31650&atid=402868)).
        * Unexpected error when name of project configuration differs from solution configuration (bug [#1607209](https://sourceforge.net/tracker/index.php?func=detail&aid=1607209&group_id=31650&atid=402868)).

**Third-Party**

* **#ziplib**

    Files with a compressed size of over 4GB cannot be added to zip archive (bug [#1698336](https://sourceforge.net/tracker/index.php?func=detail&aid=1698336&group_id=31650&atid=402868)).


**Types**

* **&lt;fileset&gt;**

    Case differences are not always ignored on a case-insensitive filesystem (bug [#1776101](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1776101&group_id=31650)).  
    Pattern mathing for files in the root directory of a volume is always case-sensitive (bug [#1761377](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1761377&group_id=31650)).


### Additions

**Expressions**

* **Version operators**

    Introduced support for relational operators between version values.

**Framework support**

* **Tool paths**

    Since NAnt 0.84, task authors have been able to specify the location of the command-line tool by applying a ProgramLocationAttribute to classes deriving from ExternalProgramBase.  

    The ProgramLocationAttribute allows task authors to specify whether the tool is located in the framework directory (eg. C:\WINDOWS\Microsoft.NET\Framework\v1.1.4432) or the SDK directory (eg. C:\Program Files\Microsoft Visual Studio .NET 2003\SDK\v1.1) without actually having to deal with the complexity of knowing the actual path to these directories (for each supported framework).  

    In NAnt 0.86, we've taken this one step further. Each defined framework now has a (ordered) list of directories that can be scanned to locate a framework tool. The list of directories can be easily tuned for each framework by modifying the &lt;tool-paths&gt; nodes in the NAnt configuration file.  

    An example of such a node for the Mono 3.5 profile:

        ```
        &lt;tool-paths&gt;
            &lt;directory name="${path::combine(prefix, 'lib/mono/3.5')}" /&gt;
            &lt;directory name="${path::combine(prefix, 'lib/mono/2.0')}" /&gt;
            &lt;directory name="${path::combine(prefix, 'lib/mono/1.0')}" /&gt;
        &lt;/tool-paths&gt;
        ``` 

    The directories configured in the &lt;tool-paths&gt; node of the current target framework will be scanned in the order in which they are defined.  

    The tool paths are implicitly used when a given tool cannot be located on the location specified by the ProgramLocationAttribute. As such, this only applies to tasks deriving from ExternalProgramBase.  

    To expose this functionality to build authors, we've added a framework::get-tool-path function that can be used to search for a given tool.  

    For example:

        ```
        &lt;exec program="${framework::get-tool-path('gacutil.exe')}" managed="strict"&gt;
            &lt;arg value="/i" /&gt;
            &lt;arg file="Cegeka.HealthFramework.dll" /&gt;
        &lt;/exec&gt;
        ```    

* **Strict execution**

    Introduced support for forcing a managed application to run on the currently targeted CLR.

    This was previously only possible by modifying the &lt;startup&gt; section of the application configuration file or by using constructs specific to each CLR (eg. using COMPLUS_VERSION environment variable for the MS CLR), which made build scripts non-portable.

    Developers extending NAnt, can now control this by setting the Managed property for tasks deriving from ExternalProgramBase.

    For build authors, forcing a managed application to run on a specific version of a CLR can be done by setting the "managed" attribute of &lt;exec&gt; to strict.

    For example:

        ```
        &lt;exec program="nunit-console.exe" managed="strict"&gt;
            &lt;arg value="/noshadow" /&gt;
            &lt;arg file="Cegeka.HealthFramework.Tests.dll" /&gt;
        &lt;/exec&gt;
        ```                

* **.NET Framework 3.5**

    Support for targeting .NET Framework 3.5 and Mono 3.5 Profile is now available.

    Note: this does not apply to the &lt;solution&gt; task.

* **Silverlight 2.0**

    Added experimental support for targeting Silverlight 2.0 and Moonlight 2.0.

    Note: this does not apply to the &lt;solution&gt; task.

**Types**

* **&lt;patternset&gt;**

    Defines a set of patterns, mostly used to include or exclude certain files.

    Patterns can be grouped to sets, and later be referenced by their id.

    For example:

        ```
        &lt;patternset id="binaries"&gt;
            &lt;include name="bin/**/*" /&gt;
            &lt;exclude name="bin/*.tmp" /&gt;
        &lt;/patternset&gt;

        &lt;patternset id="docs"&gt;
            &lt;include name="requirements/**/*" /&gt;
            &lt;exclude name="design/**/*.doc" /&gt;
        &lt;/patternset&gt;

        &lt;patternset id="client.sources"&gt;
            &lt;include name="client/**/*.cs" /&gt;
            &lt;exclude name="client/**/*.vb" /&gt;
        &lt;/patternset&gt;

        &lt;patternset id="server.sources"&gt;
            &lt;include name="server/**/*.cs" /&gt;
            &lt;exclude name="server/**/*.vb" /&gt;
        &lt;/patternset&gt;

        &lt;patternset id="sources"&gt;
            &lt;patternset refid="client.sources" /&gt;
            &lt;patternset refid="server.sources" /&gt;
        &lt;/patternset&gt;

        &lt;target name="deploy"&gt;
            &lt;copy todir="${dist.path}"&gt;
                &lt;fileset basedir="${build.path}"&gt;
                    &lt;patternset refid="binaries" /&gt;
                    &lt;patternset refid="docs" /&gt;
                    &lt;patternset refid="sources" /&gt;

                    &lt;exclude name="**/*.sdf" /&gt;
                &lt;/fileset&gt;
            &lt;/copy&gt;
        &lt;/target&gt;
        ```


### Changes

**Core**

* **Performance**

    Initial start-up time and project initialization have been reduced dramatically by lazy configuration of supported target frameworks.

**Framework support**

* **.NET Compact Framework 2.0**

    Compiler options that were introduced in .NET Framework 2.0 are now also available when targeting .NET Compact Framework 2.0.

**Tasks**

* **&lt;al&gt;**

    Modules to compile into an assembly can now be specified using the &lt;modules&gt; child element.

* **&lt;csc&gt;**

    Added "delaysign" attribute which specified whether to delay sign the assembly using only the public portion of the strong name key.

* **&lt;exec&gt;**

    The "useruntimeengine" attribute has been deprecated in favor of a "managed" attribute.

* **&lt;jsc&gt;**

    Added "autoref" attribute to enable automatically referencing of assemblies if they have the same name as an imported namespace or as a type annotation when declaring a variable.  
    Added "nostdlib" attribute which instructs the compiler not to import standard library.  
    Added "versionsafe" attribute which causes the compiler to generate errors for implicit method overrides.
    Now uses mjs when targeting Mono.  

* **&lt;vbc&gt;**

    Added "delaysign" attribute which specified whether to delay sign the assembly using only the public portion of the strong name key.

* **&lt;vjc&gt;**

    Added "delaysign" attribute which specified whether to delay sign the assembly using only the public portion of the strong name key.

**Third-Party**

* **#ziplib**

    Upgraded to v0.85.1 which, amongst other things, adds support for ZIP64.

**Types**

* **&lt;assemblyfileset&gt;**

    The reference assemblies of a given target framework are no longer limited to the assemblies in, what is known as, the framework assembly directory.

    Instead, these are now defined using one or more &lt;reference-assemblies&gt; filesets in the &lt;framework&gt; node of the NAnt configuration file.

* **&lt;fileset&gt;**

    Added a "casesensitive" attribute to control whether pattern matching must be case-sensitive.

    The default is true on Unix and false on on other platforms.


## 0.85 (October 14, 2006) {v0.85}

### Bug fixes

**Framework support**

* **.NET Compact Framework 2.0**

    Embedded resource files cannot be compiled when targeting .NET Compact Framework 2.0 (bug [#1533924](https://sourceforge.net/tracker/index.php?func=detail&aid=1533924&group_id=31650&atid=4028680)).

**Functions**

* **file::is-assembly**

    Function call fails when a file name that does not correspond with an assembly is specified as argument.

**Tasks**

* **&lt;aximp&gt;**

    The value of the "rcw" attribute should be ignored when targeting .NET 1.0.

* **&lt;csc&gt;**

    Output is always rebuilt when "keyfile" attribute is set (bug [#1550736](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1550736&group_id=31650)).

* **&lt;regen&gt;**

    Assembly reference are not taken into account to determine if the maximum length of the command line is exceeded (bug [#1415272](https://sourceforge.net/tracker/index.php?func=detail&aid=1415272&group_id=31650&atid=402868)).

* **&lt;solution&gt;**

    Runtime callable wrapper is not used when generating Windows Forms control for ActiveX component that has no Primary Interop Assembly.  

    When importing a type library, [out, retval] parameters of methods on dispatch-only interfaces (dispinterfaces) are not transformed into return values (bug [#1527210](https://sourceforge.net/tracker/index.php?func=detail&aid=1527210&group_id=31650&atid=402868)).  

    Dependencies are not handled properly for Enterprise Template projects in Visual Studio .NET 2003 solutions (bug [#1534864](https://sourceforge.net/tracker/index.php?func=detail&aid=1534864&group_id=31650&atid=402868)).

* **&lt;unzip&gt;**

    Zip file containing zero-length files fails to extract (bug [#1503678](http://sourceforge.net/tracker/index.php?func=detail&aid=1503678&group_id=31650&atid=402868)).


### Changes

**Tasks**

* **&lt;tlbimp&gt;**

    Added "transform" attribute which sets the name of transform to use for transforming the metadata. [.NET 1.1 or higher]

* **&lt;vbc&gt;**

    Added "nostdlib" attribute which can be used to instruct the compiler not to reference standard libraries (system.dll and VBC.RSP). [.NET 2.0 or higher]


## 0.85-rc4 (June 2, 2006) {v0.85-rc4}

### Framework support

    Added support for .NET Framework 2.0 (except for &lt;solution&gt; task).

### Breaking changes

**Tasks**

* **&lt;delete&gt;**

    Attempting to delete a file or directory that does not exist, no longer results in a build failure.

### Bug fixes

**Core**

* **XmlLogger**

    XmlLogger produced invalid XML for elements that are not closed (bug [#1220439](https://sourceforge.net/tracker/index.php?func=detail&aid=1220439&group_id=31650&atid=402868)).

**Filters**
* **&lt;replacetokens&gt;**

    Empty value is not supported for token (bug [#1192677](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1192677&group_id=31650)).

**Tasks**

* **&lt;cl&gt;**

    * Logic for determining whether compilation is necessary is not correct when PCH file is specified (bug [#1191185](http://sourceforge.net/tracker/index.php?func=detail&aid=1191185&group_id=31650&atid=402868)).

    * All sources are compiled if any of the specified sources is not up-to-date (bug [#1191285](http://sourceforge.net/tracker/index.php?func=detail&aid=1191285&group_id=31650&atid=402868)).
    
    * Macro definitions specified using the &lt;defines&gt; collection are passed to the compiler, regardless of the value of the "if" and "unless" attributes (bug [#1221945](http://sourceforge.net/tracker/index.php?func=detail&aid=1221945&group_id=31650&atid=402868)).

* **&lt;rc&gt;**

    * Modification of an external file does not trigger a rebuilt of the resource (bug [#1195320](https://sourceforge.net/tracker/index.php?func=detail&aid=1195320&group_id=31650&atid=402868)).

    * Macro definitions specified using the &lt;defines&gt; collection are passed to the compiler, regardless of the value of the "if" and "unless" attributes (bug [#1221945](http://sourceforge.net/tracker/index.php?func=detail&aid=1221945&group_id=31650&atid=402868)).

* **&lt;script&gt;**

    * Defining custom extensions (eg. tasks) using multiple &lt;script&gt; instances results in an INTERNAL ERROR (bug [#1187957](http://sourceforge.net/tracker/index.php?func=detail&aid=1187957&group_id=31650&atid=402868)).

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


### Additions

**Tasks**

* **&lt;regasm&gt;**

    * Registers an assembly, or set of assemblies for use from COM clients.

### Changes

**Core**

* **log4net**

    * Upgraded to log4net 1.2.9.

* **MailLogger**

    * Added "MailLogger.success.attachments" and "MailLogger.failure.attachments" properties to allow a set of files to be attached to the message that is sent.

* **Define types in task containers**

    Global types can now be (re)defined in task containers (such a &lt;if&gt; , &lt;foreach&gt;).

    For example:

        ```
        &lt;project name="container-type" default="build"&gt;
            &lt;if test="${platform::is-win32()}"&gt;
                &lt;fileset id="sources"&gt;
                    &lt;include name="**/*.cs" /&gt;
                    &lt;!-- exclude Unix-specific classes --&gt;
                    &lt;exclude name="**/Unix/*.cs" /&gt;
                &lt;/fileset&gt;
            &lt;/if&gt;
            &lt;if test="${platform::is-unix()}"&gt;
                &lt;fileset id="sources"&gt;
                    &lt;include name="**/*.cs" /&gt;
                    &lt;!-- exclude Win32-specific classes --&gt;
                    &lt;exclude name="**/Win32/*.cs" /&gt;
                &lt;/fileset&gt;
            &lt;/if&gt;
            &lt;target name="build"&gt;
                &lt;csc output="IvsController.dll"&gt;
                    &lt;sources refid="sources" /&gt;
                    &lt;references&gt;
                        &lt;include name="System.dll" /&gt;
                        &lt;include name="System.Data.dll" /&gt;
                        &lt;include name="System.Xml.dll" /&gt;
                    &lt;/references&gt;
                &lt;/csc&gt;
            &lt;/target&gt;
        &lt;/project&gt;
        ```                

    Up until now, only tasks could be executed in these containers.

**Tasks**

* **&lt;csc&gt;**

    * The /langversion and /platform commandline options of the C# compiler are now exposed as attributes.
    
    * Added support for /keycontainer and /keyfile commandline options [Mono / .NET 2.0 or higher].

* **&lt;jsc&gt;**

    * The /platform commandline option of the JScript.NET compiler is now exposed using the "platform" attribute.

* **&lt;link&gt;**

    * Introduced support for delay loaded DLLs.

* **&lt;nunit2&gt;**

    * Upgraded to NUnit 2.2.8.

* **&lt;unzip&gt;**

    * The character encoding that has been used for file names inside the zip file can now be set using the "encoding" parameter.

* **&lt;vbc&gt;**

    * The /platform commandline option of the VB.NET compiler is now exposed using the "platform" attribute. [.NET 2.0 or higher]
    * Added support for /keycontainer and /keyfile commandline options. [.NET 2.0 or higher]

* **&lt;vjc&gt;**

    * Added support for /keycontainer and /keyfile commandline options.

* **&lt;zip&gt;**

    * Added "duplicate" parameter to allow build authors to control how duplicate file entries are to be processed.
    * Introduced "encoding" parameter for setting the encoding to be used for file names.

**Types**

* **&lt;arg&gt;**

    * Added "dir" attribute for directory-based command-line arguments. (feature request [#1193982](http://sourceforge.net/tracker/index.php?func=detail&aid=1193982&group_id=31650&atid=402871)).


## 0.85-rc3 (April 16, 2005) {v0.85-rc3}

### Breaking changes

**Tasks**

* **&lt;nant&gt;**

    * References are no longer copied to the new projects by default. This is now controlled using the "inheritrefs" attribute.

### Bug fixes

**Core**

* **XML Schema**

    * "if" and "unless" attributes of &lt;target&gt; element are not documented (bug [#1168170](https://sourceforge.net/tracker/index.php?func=detail&aid=1168170&group_id=31650&atid=402868)).

**Tasks**

* **&lt;copy&gt; / &lt;move&gt;**

    * If "flatten" is set to true and multiple source files are selected to be copied / moved to the same destination file, only the source file that was last written to should actually be copied / moved (bug [#1165252](http://sourceforge.net/tracker/index.php?func=detail&aid=1165252&group_id=31650&atid=402868)).

* **&lt;link&gt;**

    * Additional include directory containing spaces leads to build failures (bug [#1117794](http://sourceforge.net/tracker/index.php?func=detail&aid=1117794&group_id=31650&atid=402868)). This bug also affects the &lt;solution&gt; task.

* **&lt;nant&gt;**

    * Default value of "inheritall" attribute does not match documentation (bug [#1146121](https://sourceforge.net/tracker/index.php?func=detail&aid=1146121&group_id=31650&atid=402868)).
    * Documentation does not describe behavior of &lt;nant&gt; task for references (bug [#1146176](https://sourceforge.net/tracker/index.php?func=detail&aid=1146176&group_id=31650&atid=402868)).

* **&lt;ndoc&gt;**

    * When executing the &lt;ndoc&gt; task multiple times, the properties are not expanded again after the first execution (bug [#1124113](http://sourceforge.net/tracker/index.php?func=detail&aid=1124113&group_id=31650&atid=402868)).
    * Additional directories specified (using the &lt;referencepaths&gt; element) to search for assembly references were not correctly consumed.

* **&lt;resgen&gt;**

    * The "dynamicprefix" attribute is not honored when determining the name of the compiled resource file (bug [#1150186](http://sourceforge.net/tracker/index.php?func=detail&aid=1150186&group_id=31650&atid=402868)).

* **&lt;script&gt;**

    * Now supports any CodeDom provider, not just the built in languages (C#, VB, etc).
    * Allow lower case values ( c# and vb ) for the Language attribute.

* **&lt;servicecontroller&gt;**

    *Resources are leaked (bug [#1163461](https://sourceforge.net/tracker/?func=detail&atid=402868&aid=1163461&group_id=31650)).

* **&lt;call&gt;**

    * Added a "cascade" attribute to allow calling a single task without cascading all the dependencies. (bug [#1077323](http://sourceforge.net/tracker/index.php?func=detail&aid=1077323&group_id=31650&atid=402868)).

* **&lt;solution&gt;**

    * A relative path specified in the AssemblyKeyFile attribute must be resolved using either the solution directory or the intermediate output directory.
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

    * Patterns are read from file specified using &lt;includesfile&gt; element regardless of the value of conditional attributes ("if" and "unless").

### Changes

**Core**

* **MailLogger**

    * Added "MailLogger.body.encoding" property to allow the encoding of the body of the message to be set.

* **Response File**

    * NAnt now supports the use of a response file. Passing @&lt;file&gt; on the command line will cause the contents of &lt;file&gt; to be read as part of the command line. Multiple @&lt;file&gt; arguments may be used.

* **XmlLogger**

    * Project, target and task timing information is now output in a &lt;duration&gt; element in milliseconds (patch [#1122583](http://sourceforge.net/tracker/index.php?func=detail&aid=1122583&group_id=31650&atid=402870))

**Tasks**

* **&lt;csc&gt; / &lt;vbc&gt; / &lt;vjc&gt;**

    * Changed "debug" attribute from boolean to DebugOutput enum to allow more control over the type of debugging information generated by the compiler.

* **&lt;lib&gt;**

    * Add "moduledefinition" attribute.

* **&lt;midl&gt;**

    * "tlb" attribute is no longer required.


### Developer information

**API**

* **FileSetAttribute**

    The NAnt.Core.Attributes.FileSetAttribute is obsolete. Task developers should use the NAnt.Core.Attributes.BuildElementAttribute instead.

    For example:
        
        ```
        [FileSetBuildElement("fileset")]
        public FileSet CopyFileSet {
            get { return _fileset; }
            set { _fileset = value; }
        }
        ```
                

## 0.85-rc2 (February 12, 2005) {v0.85-rc2}

### General changes

**Building NAnt**

    * The source distribution of NAnt no longer contains pre-built binaries to build a full version of NAnt. Instead, we now include GNU Make and NMake make files to build a bootstrap version of NAnt, which is then used to build the full version of NAnt.

**License**

    * The special exception that is part of the NAnt license has been modified to avoid confusion.

## Bug fixes

**Core**

* **XML Schema**

    * NAnt XML Schema definition for collection based elements was incorrect (bug [#1076620](http://sourceforge.net/tracker/index.php?func=detail&aid=1076620&group_id=31650&atid=402868)).

**Functions**

* **target::get-current-target()**

    * Current target is incorrect after execution of target using &lt;call&gt; task (bug [#1090260](http://sourceforge.net/tracker/index.php?func=detail&aid=1090260&group_id=31650&atid=402868)).

**Tasks**

* **&lt;cl&gt;**

    * &lt;cl&gt; does not recompile although headers have been updated (bug [#1079377](http://sourceforge.net/tracker/index.php?func=detail&aid=1079377&group_id=31650&atid=402868)).

* **&lt;mail&gt;**

    * Names containing comma's are not supported (bug [#961627](http://sourceforge.net/tracker/index.php?func=detail&aid=961627&group_id=31650&atid=402868)).

* **&lt;midl&gt;**

    * &lt;midl&gt; fails on second run if "header" or "iid" attributes are not specified (bug [#1078558](http://sourceforge.net/tracker/index.php?func=detail&aid=1078558&group_id=31650&atid=402868)).

* **&lt;solution&gt;**

    * Manifest resource names of resources in J# projects do not match those generated by Microsoft Visual Studio.NET.
    * For embedded resources that are dependent on a source file, namespace prefixing is wrong when a namespace declaration is not present in the source file (bug [#1077253](http://sourceforge.net/tracker/index.php?func=detail&aid=1077253&group_id=31650&atid=402868)).
    * Users should be warned about possible issues with resx files when building a project for a down-level target framework (bug [#1077254](http://sourceforge.net/tracker/index.php?func=detail&aid=1077254&group_id=31650&atid=402868)).
    * "App.config" should not be considered an output file for Class Library projects.
    * Win32 resources in Visual C++ projects are not compiled (bug [#1077712](http://sourceforge.net/tracker/index.php?func=detail&aid=1077712&group_id=31650&atid=402868)).
    * Improve error reporting when a referenced component cannot be resolved (bug [#1079777](http://sourceforge.net/tracker/index.php?func=detail&aid=1079777&group_id=31650&atid=402868)).
    * MFC and ATL shared linking is not supported for Visual C++ projects (bug [#1078636](http://sourceforge.net/tracker/index.php?func=detail&aid=1078636&group_id=31650&atid=402868)).
    * &lt;solution&gt; task doesn't support COM, OCX apps built in Visual C++ (bug [#1078641](http://sourceforge.net/tracker/index.php?func=detail&aid=1078641&group_id=31650&atid=402868)).
    * Support for some compile and link arguments is missing (bug [#1080237](http://sourceforge.net/tracker/index.php?func=detail&aid=1080237&group_id=31650&atid=402868)).
    * Project dependencies are not re-evaluated when assembly reference is converted to project reference (bug [#1076015](http://sourceforge.net/tracker/index.php?func=detail&aid=1076015&group_id=31650&atid=402868)).
    * Resolution of assembly references does not match Visual Studio .NET (bug [#1077869](http://sourceforge.net/tracker/index.php?func=detail&aid=1077869&group_id=31650&atid=402868)).

* **&lt;style&gt;**

    * Relative URI specified as argument for document() function is not considered to be relative to the base URI of stylesheet containing the function call (bug [#1078896](http://sourceforge.net/tracker/index.php?func=detail&aid=1078896&group_id=31650&atid=402868)).

* **&lt;sysinfo&gt;**

    * Document behavior when environment variable is defined with a name that is not a valid property name (bug [#1082225](http://sourceforge.net/tracker/index.php?func=detail&aid=1082225&group_id=31650&atid=402868)).

### Additions

**Tasks**

* **&lt;gunzip&gt;**

    * Expands a file packed using GZip compression.

* **&lt;setenv&gt;**

    * Sets environment variables.

**Types**

* **&lt;categories&gt;**

    * Controls the categories of tests to execute using the &lt;nunit2&gt; task.

### Changes

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

    * Deprecated nested &lt;option&gt; element in favor of &lt;variable&gt; element for setting environment variables for the spawned process.

* **&lt;link&gt;**

    * Added "debug" and "pdbfile" attributes.
    * Added &lt;modules&gt; child element to link modules in the assembly.
    * Added &lt;embeddedresources&gt; child element to embed resources in the assembly.

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

    * The "name" attribute of the &lt;import&gt; element has been deprecated, and replaced by a "namespace" attribute. This change affects the following tasks: &lt;asminfo&gt;, &lt;script&gt; and &lt;vbc&gt;.


## 0.85-rc1 (November 28, 2004) {v0.85-rc1}

### Framework support

    * NAnt 0.85 adds support for the following frameworks (both as runtime and as target framework):
        * Mono (both 1.0 and 2.0 profile)
        * .NET 2.0 Beta 1
    * By default, NAnt will now target the framework on which its running. For example, if NAnt is running on .NET 2.0, the assemblies built using the &lt;csc&gt; task will target .NET 2.0. Previous versions of NAnt would target .NET 1.0 by default.
    * Information on how to override the target framework, can be found here.

### Breaking changes

    * In previous version of NAnt, the &lt;arg&gt; element (used by, for example, the &lt;exec&gt; task) would automatically add quotes for both "file" and "value" attributes in the command line generated by the task. That automatic quoting has been removed for "value" attributes (but not for "file" attributes). This change may break build files that assume that both arguments specified using the "file" and "value" attributes will automatically be quoted.
    * Overwriting of read-only properties in tasks other than the &lt;property&gt; task will now result in a build failure. * Previous versions of NAnt would silently ignore an update of a read-only property.
    * The &lt;nunit2&gt; task been updated to support NUnit 2.2. Assemblies built using previous versions of NUnit should either be rebuilt using NUnit 2.2 or a binding redirect should be configured in the application configuration file of the test assembly.

### General changes

    * Improved error reporting when invalid values are specified for attibutes representing files or directories.
    * This release of NAnt introduces support for expressions. More information is available here.
    * FilterChain support has been introduced to NAnt.
    * Enums that are used in tasks or types now have their own doc pages.
    * The default logger will now also output the number non-fatal errors and warnings.
    * Output of the XmlLogger is now buffered until build has finished, and XmlLogger can now also be used as a listener.
    * Added support for wild targets.
    * Lots of built-in properties have been deprecated, and replaced by functions. More information is available here.
    * NAnt will now report unknown attributes and child elements when initializing build elements.

### Commandline changes

    * Added "-e[macs]" option, which can be used to produce logging information without adornments.
    * Added "-ext[ension]" option to allow loading of external assemblies. As a result, third party loggers or listeners no longer have to reside in the NAnt bin directory or the GAC in order to be used by NAnt.
    * Deprecated -[defaultframewor]k option in favor of -t[argetframework].

### New Tasks

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
    "nowarn" attribute has been deprecated in favor of the &lt;nowarn&gt; child element.
    * Added support for suppressing/reporting specific warnings as errors using the &lt;warnaserror&gt; child element. [.NET 2.0 or higher]
    * Added support for package references. [Mono]
    * &lt;lib&gt; element is obsolete, in favor of &lt;lib&gt; child element on &lt;references&gt; and &lt;modules&gt; element.
    * Added support for /baseaddress compiler option.

* **&lt;copy&gt;**

    * Added support for filterchains.

* **&lt;cvs&gt;**

    * Several bugs have been fixed in the &lt;cvs&gt; tasks.
    * Documentation updates.
    * Added "passfile" attribute.

* **&lt;exec&gt;**

    * Fixed internal error when "program" attribute was assigned invalid file name.
    
    * Added "resultproperty" attribute, which can be set to a name of a property in which the exit code of the program can be stored.
    * The &lt;arg&gt; element now supports line and PATH-like command-line arguments.

* **&lt;get&gt;**

    * Added support for client certificates (for HTTP requests) by means of the &lt;certificates&gt; elements.

* **&lt;jsc&gt;**

    * Added support for package references. [Mono]
    * Added "rebuild" attribute, which instructs NAnt to recompile the output file regardless of the file timestamps.

* **&lt;license&gt;**
    * Uses the lc.exe commandline tool to compile license files whenever available.

* **&lt;link&gt;**

    * Allow &lt;fileset&gt; reference to be set for the &lt;sources&gt; element.

* **&lt;move&gt;**

    * Added support for filterchains.

* **&lt;nant&gt;**

    * Added &lt;fileset&gt; support for specifiying build files to execute.

* **&lt;ndoc&gt;**

    * Upgraded to NDoc 1.3 Release Candidate 1.
    Added support for reference paths.

* **&lt;nunit&gt;**

    * The &lt;nunit&gt; task has been deprecated, and will be moved to NAntContrib in a future release. NUnit 1.0 test assemblies will remain supported through NAntContrib, but we strongly advise you to upgrade to NUnit 2.x.

* **&lt;nunit2&gt;**

    * Upgraded to support NUnit 2.2.
    * If no explicit application configuration file is specified, a configuration file matching the name of the test assembly with extension ".config" will be used for the test domain.
    * Minor bug fixes.

* **&lt;regex&gt;**

    * Added "options" attribute that takes a comma-separated list of options to pass to the regex engine.

* **&lt;resgen&gt;**

    * Added support for assembly references, in order to be abel to compile .resx file that reference assemblies that are not located in the GAC.

* **&lt;script&gt;**

    * Simplified definition of custom functions with the &lt;script&gt; task.
    * Added support for Visual J# (where available), and third party CodeDOM providers.
    * &lt;script&gt; task is now supported on Mono.
    * Assemblies emitted by the &lt;script&gt; task will now also be scanned for functions and filters.

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
    * Compiled resource file are now stored in the obj\&lt;configuration&gt; directory relative to project directory. The compiled resource files will not be removed when the task finishes, by doing this resource files will now only be recompiled if the compiled resource file in the object directory is no longer up-to-date. This matches the behaviour of VS.NET.
    * Added support for deploying App.config to output directory.

* **&lt;sysinfo&gt;**

    * If "failonerror" is false, the &lt;sysinfo&gt; task will output a warning message in the build log when a certain environment variable cannot be exposed as a property (because of, for example, more strict naming rules for properties) and continue processing other environment variables. In previous versions of NAnt, execution of the &lt;sysinfo&gt; task would halt on the first error.

* **&lt;vbc&gt;**

    * Added support for suppressing specific warnings using the &lt;nowarn&gt; child element. [.NET 2.0 or higher]
    * Added support for suppressing/reporting specific warnings as errors using the &lt;warnaserror&gt; child element. [.NET 2.0 or higher]
    * Added support for generating XML documentation files, using "doc" attribute. [.NET 2.0 or higher]
    * Added support for package references. [Mono]
    * Added "rebuild" attribute, which instructs NAnt to recompile the output file regardless of the file timestamps.
    * Added &lt;imports&gt; child element, and deprecated "imports" attribute.
    * &lt;lib&gt; element is obsolete, in favor of &lt;lib&gt; child element on &lt;references&gt; and &lt;modules&gt; element.

* **&lt;vjc&gt;**

    * Added support for suppressing specific warnings using the &lt;nowarn&gt; child element. [.NET 2.0 or higher]
    &lt;lib&gt; element is obsolete, in favor of &lt;lib&gt; child element on &lt;references&gt; and &lt;modules&gt; element.
    * Added "rebuild" attribute, which instructs NAnt to recompile the output file regardless of the file timestamps.
    * Added support for /baseaddress compiler option.

* **&lt;xmlpeek&gt; / &lt;xmlpoke&gt;**

    * Added support for XPath expressions with namespace prefixes.

* **&lt;zip&gt; / &lt;unzip&gt;**

    * Added support for multiple filesets.
    * A top level directory prefix can be set on individual filesets.
    * Upgraded #ziplib to v0.83.

### New types

* **&lt;assemblyfileset&gt;**

    * Specialized &lt;fileset&gt; for managing assembly files.

* **&lt;warnaserror&gt;**

    * Controls the behaviour of a compiler with regards to the reporting of warnings.

### Type changes
* **&lt;fileset&gt;**

    * Deprecated &lt;includes&gt; and &lt;excludes&gt; elements in favor of &lt;include&gt; and &lt;exclude&gt; elements.
    * Deprecated &lt;includesList&gt; element in favor of &lt;includesfile&gt;.
    * Added &lt;excludesfile&gt; element.

### Developer information

    * The Task.LogPrefix property has been deprecated. Messages that are written to build log by a given task, will now automatically get prefixed with the task name. This behaviour can be disabled by the new -e[macs] commandline option.


## 0.84 (December 26, 2003) {v0.84}

### Task changes

**&lt;xmlpeek&gt;**

    * Fixed issues with logging statements.
    * Added unit tests.

**&lt;xmlpoke&gt;**

    * Added unit tests.


## 0.84-rc2 (December 21, 2003) {v0.84-rc2}

### General changes

  * Specifying multiple targets on the command line will no longer cause all dependencies of these targets to be executed again.
  * The XmlLogger will now correctly handle null-characters in the build output.
    Fixed issue with resources specified using the &lt;resources&gt; element of the compiler tasks.

### Task changes

**&lt;solution&gt;**

  * Fixed issues with web-projects.
  * Added support for generating strongly signed ActiveX/COM wrapper assemblies.

**&lt;xmlpeek&gt;**

  * Filename attribute was renamed to file to improve consistency with other tasks.

**&lt;xmlpoke&gt;**

  * Filename attribute was renamed to file to improve consistency with other tasks.


## 0.84-rc1 (December 6, 2003) {v0.84-rc1}

### Breaking changes

Some existing build scripts may stop working now or in the next release due to the following changes:

  * The NAntContrib binaries are no longer included in the NAnt distribution package. The NAntContrib distribution package can now be obtained here.
  * The &lt;call&gt; task now executes the given target and all its dependencies. In previous versions of NAnt only the target itself would be executed.
  * The todir attribute of the &lt;copy&gt; and &lt;move&gt; tasks no longer defaults to the project base directory. It must now be set explicitly.
  * The force attribute of the &lt;call&gt; task has been deprecated and has no longer any effect. The &lt;call&gt; task will now always execute the specified target, regardless of the fact that this target has already been executed before.
  * The string-based files and attachments attributes of the &lt;mail&gt; task have been replaced by fileset support.
  * In previous versions of NAnt, the documentation stated that a target identified by the nant.onfailure property would be executed when the build fails. However, NAnt actually executed a target identified by the nant.failure property (if available). This has now been corrected and the old syntax (nant.failure) is now deprecated.
  * The &lt;param&gt; element of the &lt;style&gt; task has been deprecated in favor of a &lt;parameters&gt; collection with nested &lt;parameter&gt; elements. The &lt;parameter&gt; element now also supports a namespaceuri, if and unless attribute. See the documentation of the &lt;style&gt; task for more information.
  * In previous versions of NAnt, the Plain formatter was implicitly added in the &lt;nunit2&gt; task. In NAnt 0.8.4, the Plain formatter will only implicitly be added if no other formatters are specified. In this case, a warning message will be output to the build log encouraging build authors to explicitly add this formatter for forward compatibility. In future versions of NAnt, the Plain formatter will no longer implicitly be added.
  * The nested &lt;param&gt; child element of the &lt;style&gt; task has been deprecated in favor of a nested &lt;parameters&gt; collection.

### General changes

    The user documentation has been overhauled. Nested elements are more clearly documented, documentation has been added for element types such as filesets and credentials, and the overall format is slightly cleaner and easier to use.
    Improved bootstrapping NAnt on linux. Now supports Mono 0.28.
    Localization support has been improved in the &lt;csc&gt;, &lt;jsc&gt;, &lt;vbc&gt; and &lt;vjc&gt; tasks: when dynamixprefix is set to "true" and prefix is set to the root namespace of the assembly for the nested &lt;resources&gt; element, the compiler tasks will now compile resources with IDs matching these generated by VS.NET. Support for the generation of satellite assemblies was also added to these tasks.
    On systems with both the .NET Framework 1.0 and .NET Framework 1.1 installed, NAnt will now execute on the .NET Framework 1.1 by default. Note, the default target framework has remained unchanged, and is still .NET Framework 1.0.

### New Tasks
**&lt;asminfo&gt;**

  * Moved from NAntContrib to NAnt, and was rewritten to support multiple code languages and attribute types.

**&lt;servicecontroller&gt;**

  * Allows a Windows service to be controlled (started, stopped, ...).

**&lt;delay-sign&gt;**

  * Supports delay-signing of strongly named assemblies.

**&lt;mc&gt;,&lt;rc&gt; and &lt;midl&gt;**

  * Moved from NAntContrib to NAnt. These tasks control compilation of service messages, resources, and IDL code respectively.

**&lt;xmlpeek&gt;**

  * Extracts text from an XML file at the location specified by an XPath expression.

**&lt;xmlpoke&gt;**

  * Replaces text in an XML file at the location specified by an XPath expression.

### Task changes

**&lt;call&gt;**

  * The &lt;call&gt; task now executes the given target and all its dependencies. In previous versions of NAnt only the target itself would be executed.
  * The force attribute of the &lt;call&gt; task has been deprecated and has no longer any effect. The &lt;call&gt; task will now always execute the specified target, regardless of the fact that this target has already been executed before.

**&lt;cl&gt;**

  * Added support for Managed Extensions.

**&lt;copy&gt;**

  * The todir attribute no longer defaults to the project base directory. It must now be set explicitly.
  * Added flatten attribute to allow all matching files to be copied to a single directory.

**&lt;csc&gt;**

  * Improved localization support.
  * Added support for additional search directories to resolve assembly references through a nested &lt;lib&gt; element.

**&lt;cvs-checkout&gt;**

  * Added option to checkout a revision based on sticky tag, -r on the command line client.
  * Added option to checkout a module to an alternate directory, -d on the command line client.
  * Fixed bug in parsing cvsnt date format.

**&lt;cvs-update&gt;**

  * Fixed bug in parsing cvsnt date format.

**&lt;echo&gt;**

  * Added level attribute to allow messages to be output with a specific level.

**&lt;fail&gt;**

  * Allow reason of failure to be specified as inline content.

**&lt;get&gt;**

  * The httpproxy attribute of the &lt;get&gt; task is deprecated, use the new &lt;proxy&gt; child element instead.
  * Added &lt;credentials&gt; child element used for authenticating the request with the Internet resource.
  * Deprecated the ignoreerrors attribute in favor of the failonerror attribute.
  * Added timeout attribute to allow length of time to wait for a response or the request to timeout to be specified.

**&lt;if&gt;**

  * Added &lt;uptodatefiles child element for uptodate fileset support.
  * &lt;if uptodatefile="..."&gt; now behaves as documented, meaning that nested tasks will only be executed if the file specifies in the uptodatefile attribute actually exists and the file specified in the uptodatefile attribute is more recent or the same lastwritetime than the file(s) specifies in the comparefile attribute and &lt;comparefiles&gt; fileset.

**&lt;include&gt;**

  * A verbose message will now be output to the build log when a file is included multiple times. In previous versions of NAnt, this would cause a build failure.

**&lt;jsc&gt;**

  * Improved localization support.
  * Added support for additional search directories to resolve assembly references through a nested &lt;lib&gt; element.

**&lt;mail&gt;**

  * The string-based files and attachments attributes have been replaced by fileset support.

**&lt;move&gt;**

  * The todir attribute no longer defaults to the project base directory. It must now be set explicitly.
  * Added flatten attribute to allow all matching files to be moved to a single directory.

**&lt;nant&gt;**

  * Properties can now be added or overridden when calling a nested build using the new &lt;properties&gt; child element.
  * buildfile is now a required attribute, which makes it harder to accidently write an infinitely looping build.

**&lt;nantschema&gt;**

  * Currently the &lt;nantschema&gt; task does not generate the correct XML Schema definition for collections and arrays. This tasks needs to be updated. Please use with caution.

**&lt;ndoc&gt;**

  * Updated the &lt;ndoc&gt; task to using version 1.2 of NDoc.

**&lt;nunit2&gt;**

  * Updated the &lt;nunit2&gt; task to use version 2.1 of NUnit.
  * In previous versions of NAnt, the Plain formatter was implicitly added. In NAnt 0.8.4, the Plain formatter will only implicitly be added if no other formatters are specified. In this case, a warning message will be output to the build log encouraging build authors to explicitly add this formatter for forward compatibility. In future versions of NAnt, the Plain formatter will no longer implicitly be added.
  * Added outputdir attribute for &lt;formatter&gt; element to control the directory where the test result file will be stored (if the usefile attribute is "true").

**&lt;property&gt;**

  * Added overwrite attribute to the &lt;property&gt; task to control whether the value of the specified property should be overwritten when the property already exists.
  * Added support for dynamic properties, meaning properties of which references to other properties are not expanded when the value is set.

**&lt;resgen&gt;**

  * Added support for specifying a prefix to &lt;resgen&gt; task when using a fileset.

**&lt;solution&gt;**

  * Added nested &lt;assemblyfolders&gt; fileset element that allows a set of folders to be set, that should be searched to resolve assembly references.
  * By default, the Visual Studio.NET assembly folders will be searched to resolve assembly references. An includevsfolders attribute was added to control whether these folders should be searched for assembly references.
  * Added &lt;excludeprojects&gt; fileset that allows a set of projects to be excluded.
  * An outputdir attribute can now be specified, which overrides the directory where compiled targets will be placed.
  * A nested &lt;webmap&gt; element was added that maps URL's of web projects to local path, thereby removing the need to configure the web server to allow access to these project files.
  * Added support for Visual C++ projects.
  * A large number of defect fixes and performance improvements have been applied.

**&lt;style&gt;**

  * The nested &lt;param&gt; child element has been deprecated in favor of a nested &lt;parameters&gt; collection.

**&lt;touch&gt;**

  * If the file specified in the single-file case does not exist, it will now be created.

**&lt;vbc&gt;**

  * Improved localization support.
  * Added support for additional search directories to resolve assembly references through a nested &lt;lib&gt; element.

**&lt;vjc&gt;**

  * Improved localization support.
  * Added support for additional search directories to resolve assembly references through a nested &lt;lib&gt; element.

**&lt;zip&gt;**

  * Fixed issue when files were included that were not located beneath the basedir of the fileset.
  * Added includeemptydirs attribute to control whether empty directories should be included in the generated zip file.
  * Fixed failure when no basedir for fileset was specified.
  * Fixed failure when basedir of fileset is set to the root directory of a drive in Windows.

### API changes

  * Added ProgramLocationAttribute that can be assigned to a task to indicate that it wraps an executable that is part of either the .NET Framework or the .NET Framework SDK, and have NAnt figure out the full path to the executable using the framework settings in the NAnt configuration file.
  * FileSetAttribute has been deprecated. The BuildElementAttribute should be used instead.
  * Added FrameworkConfigurableAttribute that can be assigned to a task attribute to allow the default values of that attribute to be configured from the framework configuration section in the NAnt configuration file for the currently active framework.
  * Added &lt;proxy&gt; and &lt;credentials&gt; data types that are used to provide proxy settings and authentication information for tasks that connect to external resources (eg. the &lt;get&gt; task).
  * Added support for framework-specific third party libraries.
  * Updated log4net to version 1.2.0 beta 8.


## 0.8.3 (September 28, 2003) {v0.8.3}

### User-visible changes

  * Included NAntContrib binaries are from a release build. In rc3 they were debug versions.


## 0.8.3-rc3 (August 29, 2003) {v0.8.3-rc3}

### User-visible changes

  * Added test directory to distribution fixing the build failure in 0.8.3.


## 0.8.3-rc2 (July 28, 2003) {v0.8.3-rc2}

### User-visible changes

  * Built with .NET 1.0.
  * This release candidate is built with version 1.0 of the .NET Framework. The binaries for RC1 had been built with version 1.1, which had backwards compatibility issues.
  * Fixed defect: temp directory leak in &lt;solution&gt; task.
  * Matthew Mastracci fixed a major temp directory leak. It was leaking approx. one temp directory per project! You should clear your Local Settings\Temp directory for the user you use to build your solutions.
  * &lt;solution&gt; VB.NET support.
  * The &lt;solution&gt; task now supports VB.NET projects. This was meant to be part of the RC1 release.
  * Matthew Mastracci has also checked in support for reading resources of VB projects and generating the appropriate dependent resource name.
  * Documentation for NAntContrib.
  * This release candidate includes the binaries and documentation for the NAntContrib extensions. Note that the source is still distributed seperately during this release cycle.


## 0.8.3-rc1 (July 10, 2003) {v0.8.3-rc1}

### User-visible changes

  * NAntContrib is now distributed with NAnt.  
        To better support the frequently-used NAntContrib extensions, the library is now distributed as part of the NAnt release.
  * Preliminary Linux support.  
        This is the first release with Linux support, so please report any issues you encounter. The next release will be fully tested and documented on both Linux and Windows.
  * New Tasks    
    * &lt;cvs-checkout&gt; task : Checkout source from CVS.
    * &lt;cvs-update:&gt; task : Update source from CVS.
    * &lt;solution&gt; task : compile .sln directly. In most cases, this means you no longer have to preprocess a solution with the slingshot tool. Supports both Visual Studio .NET and Visual Studio 2003.
  * Changed tasks.  
    See the section below for details.
  * FileSet references.  
    You can now define a named FileSet and refer to it anywhere a FileSet is used.

### API changes

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
  * Moved &lt;mail&gt; task and test back into core as its working fine on Linux now.
  * New attribute-driven command-line parser.

### Command-line client changes

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

### Task changes

**&lt;exec&gt;**

  * Added support for an environment optionset to the &lt;exec&gt; task.
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

 * Removed &lt;mcs&gt; task. the &lt;csc&gt; task in combination with the framework support should be used instead.

**&lt;nant&gt;**

  * Fixed problem with basedir in nested &lt;nant&gt; build being incorrect if basedir="." is used.
  * Have new project inherit the default framework from the current project.

**&lt;copy&gt;**

  * Fix for &lt;copy&gt; task breakage on Linux.
  * Reenabled File.SetAttributes on Mono build as bug #41999 has been fixed.

**&lt;if&gt;**

 * Fixed logging bug with parenthesis instead of brace. Caused &lt;if uptodate...&gt; to fail erroneously.

**&lt;cl&gt; and &lt;link&gt;**

  * On demand compile support for &lt;link&gt; and &lt;cl&gt; tasks.
  * Added unit tests for the &lt;cl&gt; and &lt;link&gt; tasks.
  * Moved Visual C++ related tasks into Win32Assemblies so it doesn't get built in a Mono/Linux build.

**&lt;fileset&gt;**

  * Added support for FileSet references. Framework for making all types referencable but only implemented for FileSets right now.

**&lt;mail&gt;**

  * Reenabled usage of StringWriter constructor with CultureInfo as this bug in Mono is fixed.
  * No longer have empty strings as default.
  * Bcc and cc are no longer set to an empty string when not specified in buildfile, thereby preventing problems with Mono bug #45746.


## 0.8.2 (April 24, 2003) {v0.8.2}

  * Misc bugfixes.


## 0.8.2-rc3 (April 17, 2003) {v0.8.2-rc3}

  * &lt;if&gt; task changes to support the uptodate test.
    Changes for task item element initialization.
  * Read output of &lt;exec&gt;'d (and other external program) processes and insert into logfile.
  * Fixed logging for &lt;regex&gt; task.
  * Made NAnt errors less chatty.
  * NAnt now works without Framework SDK installed.
  * Fixed bugs in &lt;Copy&gt; and &lt;Move&gt; tasks which caused exceptions when using todir and a FileSet, in certain cases.
  * New &lt;unzip&gt; task.
  * New &lt;loadtasks&gt; task which replaces the functionality of taskdef (from NAntContrib).
  * &lt;foreach&gt; supports &lt;in&gt;&lt;items&gt; FileSet to work on files.


## 0.8.2-rc2 (April 12, 2003) {v0.8.2-rc2}

  * Fix for &lt;nunit2&gt; task using FileSet.
  * Fix for FileSet's &lt;includeList&gt; element.


## 0.8.2-rc1 (April 12, 2003) {v0.8.2-rc1}

  * Logging cleanups: use log4net for internal logging.
  * FxCop cleanups for correctness.
  * Support for multiple versions of .NET framework.
  * Changes to make NAnt more Mono-friendly.
  * Updated SharpZipLib library.
  * Makes error reporting more accurate - give line numbers for property expansion errors.
  * Multiple test assembly support for &lt;nunit2&gt; task.
  * General speed-up for directory/file scanning.
  * &lt;resgen&gt; task file generation correctness fixes.
  * Added support multiple delimiters and string trimming to LoopTask's file line mode.
  * More support for csc/vbc command-line options.


## 0.8.1 (February 21, 2003) {v0.8.1}

  * Added more command-line options (-f: to specify a buildfile).
  * Added case sensitivity checks.
  * Added &lt;vjc&gt; task.
  * Fixed NUnit2 support.
  * Misc bugfixes and cleanups from contributors.


## 0.7.9 (June 11, 2002) {v0.7.9}

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
  * &lt;attrib&gt; task added.
  * &lt;gac&gt; task added and moved to NAntContrib project.
  * &lt;sysinfo&gt; task added.
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
  * &lt;nant&gt; task now inherits properties to new project.
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


## 0.7.749 (January 19, 2002) {v0.7.749}

  * &lt;docnet&gt; task added, try 'NAnt doc' to build NAnt's documentation.
  * NUnitCore.dll added to project.
  * Fixed FileSet basedir attributes, they now expand macros.
  * &lt;script&gt; task and example added - thanks to Sergey Chaban.
  * Build file now extracts version number from AssemblyInfo.cs - thanks to Sergey Chaban.
  * CompilerBase now adds quotations to all referenced files - thanks to Mike Krueger.
  * BuildException is now serializable.
  * ExternalProgramBase reports differentiates between Process exceptions and program return codes now.
  * Unit tests are now run as part of the buid process.
  * &lt;touch&gt; task added - thanks to Jay Turpin.
  * NUnit overhaul.
    * camelCase'ed attributes, haltOnFailure, haltOnError
    * renamed printsummary to verbose
    * replaced SummaryResultFormatter with improved SummaryFormatter
    * added VerboseFormatter
  * &lt;get&gt; task added - thanks to Jay Turpin
  * &lt;docnet&gt; task renamed to &lt;ndoc&gt;.
  * NDoc.Core.dll and NDoc.Documenter.Msdn.dll added to project.
  * NAnt.exe split into NAnt.exe and NAnt.Core.dll.
  * &lt;al&gt; task added - thanks to Joe Jones.
  * &lt;resgen&gt; task added - thanks to Joe Jones.
  * &lt;zip&gt; task added - thanks to Mike Krueger.
  * &lt;cl&gt; task added - thanks to Shawn Van Ness.
  *Added support for .NET v1.0.3705 (RTM).


## 0.6.0 (September 18, 2001) {v0.6.0}

  * Report build file xml errors in a useful way.
  * Report error location when tasks are missing required attributes.
  * &lt;copy&gt; task updated - thanks to Ian MacLean.
    **/*.cs type pattern matching now available in FileSets via DirectoryScanner class.
  * Added all the environment variables to properites,ie,&lt;echomessage="path=${nant.env.PATH}"/&gt;.
  * &lt;move&gt; task updated - thanks to Ian MacLean.
  * &lt;sleep&gt; task added - thanks to Ian MacLean.
  * DirectoryScanner and FileSet's scan for files AND directories now
  * FileSet's cache scan results, use Scan() to rescan.
  * FileSet's auto initialize to their containing task, this helps clean up the code.
  * &lt;copy&gt; task can now copy full directory trees.
  * Added verbose attribute to &lt;copy&gt; task, default off, message gives number of files processed.
  * Fixed bug with any ExternalBase tasks hanging - thanks to Sergey Chaban for reporting.
  * &lt;include&gt; task added.
  * &lt;call&gt; task added.
  * -verbose command line option added.
  * Build file can now build complete distribution, try 'NAnt dist'.


## 0.5.0 (August 22, 2001) {v0.5.0}

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
    BuildException added to report text position in the build file where errors occur - thanks to Ian MacLean.
  * &lt;style&gt; task (xslt processing) added - thanks to Serge.
  * Executable is now signed with the NAnt.key.
  * Converted all public/protected fields to properties.
  * Added support for user defined properties.
  * Added -set option (try 'NAnt -set:debug=true clean build').
  * Changed verions number to 0.5 to reflect the number of changes in the code base.


## 0.1.5 (July 22, 2001) {v0.1.5}

  * Only compiles program if source file last write time &gt; output last write time.
  * Refactored compiler code into common CompilerBase class.
  * Refactored compiler and exec task into common ExternalProgramBase class.
  * Added &lt;arg value="/win32res:filename"/&gt; element to all external program tasks.
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


## 0.1.4 (July 19, 2001) {v0.1.4}

  * Added or enhanced these tasks
    * echo
    * fail
    * property
    * copy (respects basedir)
    * delete (respects basedir)
    * mkdir (respects basedir)
    * exec


## 0.1.3 (July 18, 2001) {v0.1.3}

  * Dependencies working via depends attribute on targets.
  * Changed name from NBuild to NAnt.
  * Using the name "Parameter" to refer to the xml attributes in tasks because it was conflicting badly with .NET Attributes.
  * Added FileSetParameterAttribute so that FileSet parameters would autoinit.
  * Renamed TaskAttributeAttribute to StringParameterAttribute.
  * Broke into seperate source files (one per class).
  * Changed default build file from Project.xml to the first file with a .build extension.


## 0.1.2 (July 16, 2001) {v0.1.2}

  * Basic functionality to have NAnt build itself (&lt;csc&gt; task).


## 0.1.1 (July 5, 2001) {v0.1.1}

  * Initial test version.

