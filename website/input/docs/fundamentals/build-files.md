Title: Build files
Order: 20
---

NAnt's build files are written in XML. Each build file contains one [project](projects) and a number of [targets](targets).  Each target contains a number of [tasks](tasks).

Here is a simple build file that compiles a C# HelloWorld project. 
```xml
<?xml version="1.0"?>
<project name="Hello World" default="build" basedir=".">
    <description>The Hello World of build files.</description>
    <property name="debug" value="true" overwrite="false" />
    <target name="clean" description="remove all generated files">
        <delete file="HelloWorld.exe" failonerror="false" />
        <delete file="HelloWorld.pdb" failonerror="false" />
    </target>
    <target name="build" description="compiles the source code">
        <csc target="exe" output="HelloWorld.exe" debug="${debug}">
            <sources>
                <includes name="HelloWorld.cs" />
            </sources>
        </csc>
    </target>
</project>
```        

In this example there are two targets, "clean" and "build".  By default the "build" target will be called.

## Examples

You can find the files you need to try out these *examples*{: class="text-primary"} in the examples folder that comes with the NAnt distribution.

1. Run NAnt and builds the project in debug mode (the default)
``` nant ```

2. Run NAnt and removes the compiled files if they exist
``` nant clean ```

3. Run NAnt and builds the project in non-debug mode
Even though the build file sets the debug property to true, the value that is set on the command line will not be touched, as the "overwrite" attribute on the *&lt;property&gt;*{: class="text-primary"} task is set to "false"
``` nant -D:debug=false ```


**Important:** Some tasks like the compiler tasks will only execute if the date stamp of the generated file is older than the source files.  If you compile HelloWorld project in debug mode and then try to compile it again in non-debug mode without first cleaning nothing will happen because NAnt will think the project does not need rebuilding.{: class="bg-warning"}