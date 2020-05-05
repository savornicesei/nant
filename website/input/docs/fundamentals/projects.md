Title: Projects
Order: 30
---

A project has these attributes:

| Attribute |                                                                         Description                                            | Required |
|:---------:|:------------------------------------------------------------------------------------------------------------------------------ |:--------:|
| name      | The name of the project.                                                                                                       |    No    |
| default   | The default target to execute when no target is supplied on the command-line.                                                  |    No    |
| basedir   | The base directory from which all path calculations are done.  If not set, the parent directory of the buildfile will be used. |    No    |

Optionally, a description for the project can be provided as a top-level *&lt;description&gt;*{: class="text-primary"} element.  The text contained in the description element is used when the *-projecthelp*{: class="text-primary"} command line option is used.  See the example build file for details.

Each project defines zero or more [targets](targets).  A target is a set of [tasks](tasks) to be executed.  When starting NAnt, you can select which target(s) you want to have executed.  When no target is given, the project's default target is used. When no target and no default target are specified, only the global tasks of the project are executed.