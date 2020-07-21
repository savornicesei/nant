---
Title: Release Notes
---

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
