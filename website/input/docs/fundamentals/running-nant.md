Title: Running NAnt
Order: 10
---

Running NAnt is simple once you have it [installed](docs/overview/installation), just type _NAnt_{: class="text-primary bold"}.  Type ``` NAnt -help ``` to get usage information.

## Specifying the Build File

When nothing is specified, _NAnt_ looks for a file ending with _.build_{: class="blue bold"}, e.g. _NAnt.build_{: class="text-primary bold"}, in the current directory.  If found, it uses that file as the build file.  If more than one file is found you need to specify the build file using the _-buildfile_{: class="text-primary bold"} option (see below).

If you use the _-find_ option, NAnt will search for a build file in the parent directory, and so on, until the root of the file system has been reached.  To make NAnt use another build file, use the command-line option _-buildfile:file_{: class="text-primary bold"}, where file is the build file you want to use.

## Specifying Targets

You can specify one or more targets that should be executed. When omitted, the target that is specified in the _default_{: class="text-primary bold"} attribute of the &lt;project&gt; tag is used.

The _-projecthelp_{: class="text-primary bold"} option prints out the description of the project, if it exists, followed by a list of the project's targets. First those with a description, then those without one.

## Setting Properties

To override properties specified in the build file use the ``` -D:property=value ``` option, where property is the name of the property, and value is the value for that property. 

## Examples

1. Run NAnt using the file ending in *.build.xml file in the current directory, on the default target:
``` NAnt ```

2. Run NAnt using the ProjectName.build file in the parent directory, on the default target:
``` NAnt -buildfile:..\ProjectName.build ```

3. Run NAnt using the default build file in the current directory, on a target called clean:
``` NAnt clean ```

4. Runs NAnt using the default build file in the current directory, first on the clean target and then on the dist target while setting the debug property to false.  This could, for example, make a release distribution from scratch:
``` NAnt -D:debug=false clean dist ```

