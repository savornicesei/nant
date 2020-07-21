---
Title: Release Notes
---

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