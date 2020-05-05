Title: Properties
Order: 60
---

[//]: # (TOC Begin)

* [Introduction](#introduction)
* [Naming rules](#naming-rules)
* [Built-in properties](#built-in-properties)
    * [Framework-related properties](#framework-related-properties)
    * [Platform-related properties](#platform-related-properties)
* [Read-only properties](#read-only-properties)
* [Global properties](#global-properties)
* [Examples](#examples)

[//]: # (TOC End)

# Introduction

A project can have a set of properties.  These might be set in the buildfile by the [&lt;property&gt;](http://nant.sourceforge.net/release/latest/help/tasks/property.html) task, or might be set outside NAnt.  A property has a name and a value. Properties may be used in the value of task attributes. This is done by placing the property name between "*${*{: class="text-primary"}" and "*}*{: class="text-primary"}" in the attribute value. Properties may also be used in [&lt;expressions&gt;](http://nant.sourceforge.net/release/latest/help/fundamentals/expressions.html).

# Naming rules

A property name is a string of the following characters:
* letters (*A-Z*{: class="text-primary"}, *a-z*{: class="text-primary"}),
* digits (*0-9*{: class="text-primary"}),
* underscore characters (*_*{: class="text-primary"}),
* dash characters (*-*{: class="text-primary"}),
* dot characters (*.*{: class="text-primary"}),

In addition, a valid property name must start with a letter or an underscore and must end with a letter, digit or an uderscore.

Examples of valid property names include:
* *propertyname*{: class="text-primary"}
* *property.name.with.dots*{: class="text-primary"}
* *property-name-with-dashes*{: class="text-primary"}
* *property.name-with.both-dots.and-dashes*{: class="text-primary"}
* *\_\_prop---3-erty\_\_*{: class="text-primary"}
* *\_\_prop.1...erty\_\_*{: class="text-primary"}
* *property1*{: class="text-primary"}
* *property1.0*{: class="text-primary"}
* *property2.0.0*{: class="text-primary"}
* *_property-2-1__*{: class="text-primary"}
* *property-1-name_*{: class="text-primary"}
* *property-1.0-name*{: class="text-primary"}

The following property names are not valid in NAnt:
* *!@#!@$!@*{: class="text-primary"} (contains illegal characters)
* *.aaaaa*{: class="text-primary"} (starts with a dot)
* *-aaaaa*{: class="text-primary"} (starts with a dash)
* *1aaaaa*{: class="text-primary"} (starts with a digit)
* *aaaaa.aaa.a.a.a.a-*{: class="text-primary"} (ends with a dash)
* *aaaaa.aaa.a.a.a.a.*{: class="text-primary"} (ends with a dot)

# Built-in Properties

NAnt has these built-in properties:

| Property               |                              Description                       |
|------------------------|----------------------------------------------------------------|
| nant.version           | _Deprecated_. The version of NAnt.                             |
| nant.filename          | _Deprecated_. The full path to the NAnt assembly.              |
| nant.location          | _Deprecated_. The base directory of the NAnt assembly.         |
| nant.project.basedir   | _Deprecated_. The absolute path of the project's basedir.      |
| nant.project.buildfile | _Deprecated_. The absolute path of the buildfile.              |
| nant.project.name      | _Deprecated_. The name of the project.                         |
| nant.project.default   | _Deprecated_. The name of the project's default target.        |
| nant.onsuccess         | The name of a target to be executed when the build succeeds.   |
| nant.onfailure         | The name of a target to be executed when the build fails.      |


## Framework related Properties

| Property                                                  |                              Description                                             |
|-----------------------------------------------------------|--------------------------------------------------------------------------------------|
| nant.settings.currentframework                            | The current target framework, eg. 'net-1.0'.                                         |
| nant.settings.currentframework.description                | _Deprecated_. Description of the current target framework.                             |
| nant.settings.currentframework.frameworkdirectory         | _Deprecated_. The framework directory of the current target framework.                 |
| nant.settings.currentframework.sdkdirectory               | _Deprecated_. The framework SDK directory of the current target framework.             |
| nant.settings.currentframework.frameworkassemblydirectory | _Deprecated_. The framework assembly directory of the current target framework.        |
| nant.settings.currentframework.runtimeengine              | _Deprecated_. The runtime engine of the current target framework if used eg. mono.exe. |


## Platform related Properties

| Property            |                              Description                                                        |
|---------------------|-------------------------------------------------------------------------------------------------|
| nant.platform.name  | _Deprecated_. The name of the platform on which NAnt is currently running - either win32 or unix. |
| nant.platform.win32 | _Deprecated_. Holds the value true if NAnt is running on the win32 platform; otherwise, false.    |
| nant.platform.unix  | _Deprecated_. Holds the value true if NAnt is running on the unix platform; otherwise, false.     |


## Read-only Properties

A property can be explicitly marked read-only by setting the "readonly" attribute on the [&lt;property&gt;](http://nant.sourceforge.net/release/latest/help/tasks/property.html) task to *true*.

The value of a read-only property cannot be modified after it has been set.

When attempting to override a read-only property using the [&lt;property&gt;](http://nant.sourceforge.net/release/latest/help/tasks/property.html) task, the new value will be ignored and a warning message will be output in the build log. Attempting to override read-only properties using any other means (eg. other tasks) will result in a build failure.

Note: properties set on the command-line are always read-only.

# Global Properties

Properties that should be accessible to all build files on a system can be defined in the *&lt;properties&gt;*{: class="text-primary"} node of the NAnt configuration file (*NAnt.exe.config*{: class="text-primary"}).

By changing the value of the property in the NAnt configuration file, the updated value will be accessible to all build files on the system:
```xml
    <?xml version="1.0"?>
    <configuration>
        ...
        <nant>
            ...
            <properties>
                <!-- properties defined here are accessible to all build files -->
                <property name="company.name" value="Foo Ltd." readonly="true" />
            </properties>
        </nant>
    </configuration>
```  

Individual build files can then use this property:
```xml
    <?xml version="1.0"?>
    <project name="test">
        <echo message="Company: ${company.name}" />
    </project>
```        

The output of this build is:

``` [echo] Company: Foo Ltd. ```
        

# Examples

The following build file demonstrates the use of property expansion:
```xml
    <?xml version="1.0"?>
    <project name="Property Test" default="test" basedir=".">
        <property name="project.name" value="PropertyTest"/>
        <property name="project.version" value="1.0.0"/>
        <target name="test">
            <echo message="Building ${project.name}-${project.version}"/>
        </target>
    </project>
```  

The output of this build is:

``` [echo] Building PropertyTest-1.0.0 ```  


  
The following build file demonstrates the use of properties in [&lt;expressions&gt;](http://nant.sourceforge.net/release/latest/help/fundamentals/expressions.html). It evaluates the length of the property *project.name*{: class="text-primary"} and displays it.
```xml
    <?xml version="1.0"?>
    <project name="Expression Test" default="test" basedir=".">
        <property name="project.name" value="Expression Test"/>
        <target name="test">
            <echo message="Project name consists of ${string::get-length(project.name)} characters."/>
        </target>
    </project>
```      

The output of this build is:

``` [echo] Project name consists of 15 characters. ```
        

**See Also**

* [&lt;property&gt;](http://nant.sourceforge.net/release/latest/help/tasks/property.html)
* [&lt;sysinfo&gt;](http://nant.sourceforge.net/release/latest/help/tasks/sysinfo.html)
* [&lt;tstamp&gt;](http://nant.sourceforge.net/release/latest/help/tasks/tstamp.html)
