Title: Targets
Order: 40
---

A target has these attributes:

|  Attribute  |                              Description                                         | Required |
|:-----------:|----------------------------------------------------------------------------------|:--------:|
|     name    | The name of the target.                                                          |    Yes   |
|   depends   | A comma-separated list of names of targets on which this target depends.         |    No    |
|      if     | An expression that should evaluate to true in order for this target to execute.  |    No    |
|    unless   | An expression that, when evaluated to true, will cause the target to be skipped. |    No    |
| description | A short description of this target's function.                                   |    No    |

The optional *description*{: class="text-primary"} attribute can be used to provide a one-line description of this target, which is printed by the *-projecthelp*{: class="text-primary"} command-line option.

## Dependencies

 NAnt tries to execute the targets in the *depends*{: class="text-primary"} attribute in the order they appear from left to right. It is possible that a target can get executed earlier when an earlier target depends on it:
```xml
<target name="A"/>
<target name="B" depends="A" />
<target name="C" depends="B" />
<target name="D" depends="C,B,A" />
```    
 Suppose we want to execute target D.  From its *depends*{: class="text-primary"} attribute, you might think that first target C, then B and then A is executed.  Wrong!  C depends on B, and B depends on A, so first A is executed, then B, then C, and finally D.

A target gets executed only once, even when more than one target depends on it (see the previous example). However, when the [*&lt;call&gt;*{: class="text-primary bold"}](http://nant.sourceforge.net/release/latest/help/tasks/call.html) task is used to execute a target, both the target and all its dependent targets will be re-executed.

## Wild targets {#wild-targets}

A target can be marked as _wild_ by setting the *name*{: class="text-primary"} attribute to "*". A build file can contain up to one wild target, and it is executed if and only if the invoked target does not exist in the current build file.  Wild targets let you define how to handle invalid requests, or provide generic behavior for unknown targets. For example:
```xml
<target name="A" />
<target name="B" />
<target name="*" />
```         

The last target is executed if the invoked target is neither A nor B.

## Conditional Execution

A target also has the ability to perform its execution if or unless a property has been set.  This allows, for example, better control on the building process depending on the state of the system (OS, command-line property defines, etc.).  To make a target sense this property, you should add the *if*{: class="text-primary"} or *unless*{: class="text-primary"} attribute with an expression that the target should react to. For example:
```xml
<target name="build-module-A" if="${module-A-present}" />
<target name="build-own-fake-module-A" unless="${file::exists('fake-module-a.dll')}" />
```  

If no *if*{: class="text-primary"} and no *unless*{: class="text-primary"} attribute is present, the target will always be executed.

**Note:** the dependencies of a target are always executed before testing the target's condition.{: class="bg-warning"}
