Title: Why NAnt
Order: 10
---

NAnt is different.  Instead of a model where it is extended with shell-based commands, NAnt is extended using task classes.  Instead of writing shell commands, the configuration files are XML-based, calling out a target tree where various tasks get executed.  Each task is run by an object that implements a particular Task interface.

Granted, this removes some of the expressive power that is inherent in being able to construct a shell command such as ``` find . -name foo -exec rm {} ```, but it gives you the ability to be cross-platform - to work anywhere and everywhere. And hey, if you really need to execute a shell command, NAnt has an <span class="blue bold">&lt;exec&gt;</span> task that allows different commands to be executed based on the OS it is executing on.

## Hystory

The idea for NAnt came from [Hazware's XBuild](http://www.hazware.com/xbHome.htm) project which in turn was inspired from [Apache Ant](http://jakarta.apache.org/ant/).  After emailing the author for a beta 2 release of the tool and getting no response Gerry Shaw ported the code to .NET beta 2.  Due to the number of changes from .NET beta 1 to beta 2 the result was a total rewrite.

NAnt was registered at Source Forge on July 18, 2001 with the first public release made that day.

The name NAnt comes from the fact that this tool is Not Ant.

For more information on why Ant and NAnt were developed read the [Ant Introduction](http://jakarta.apache.org/ant/manual/).