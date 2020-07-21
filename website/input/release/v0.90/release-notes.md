---
Title: Release Notes
---

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
