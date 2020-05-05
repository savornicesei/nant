Title: NAnt development guide
Order: 10020
---

## Introduction

So you are interested in contributing to the NAnt/NAntContrib projects.  Fantastic, this document will describe how to set up the development environment and start working with the code. 

>"Here's where the fun begins." - Han Solo


## System requirements

### Operating systems
NAnt is designed to run on any operating system that can run either the [Microsoft.Net](http://www.microsoft.com/net) or [Mono](http://www.mono-project.com) frameworks.  Because there are so many different platforms that qualify with the statement above, a list of platforms has been compiled below to help illustrate which ones we are actively testing on.  If you decide on using a platform that is not listed below (or one we have marked as inactive), we would like to hear which platform that is and the steps taken so NAnt/NAntContrib would work properly on said platform.

#### Active platforms
Platforms that we are actively testing/developing on.

* **Microsoft Windows**
    * Windows XP
    * Windows 7
* **Linux/BSD**
    * OpenSuSE
    * OpenBSD (Supports both i386 and amd64 as of April 30, 2012 snapshot)
* **Mac OS X**
    * Snow Leopard (10.6)

#### Inactive platforms ####
Platforms we have tested/developed on in the past but are not currently.

* **Microsoft Windows**
    * Windows Vista
* **Linux/BSD**
    * Ubuntu
    * Debian

### Development tools

#### IDEs

One of the more important tools used in NAnt/NAntContrib development is an IDE (Integrated Development Environment).  
Starting after the release of 0.91 final, the project files in both projects have been updated to VS2010 format.  This will enable not only the use of VS2010 for NAnt/NAntContrib development but other popular open source IDEs that can read/write this format as well.  
A list of known IDEs to support this format are listed below.

* [Visual Studio](http://www.microsoft.com/visualstudio/en-us)
    * Version 2010 or later
* [Sharpdevelop](http://www.icsharpcode.net/OpenSource/SD/)
    * Version 4.0 or later
* [Monodevelop](http://monodevelop.com/)
    * Version 2.8 or later

#### Frameworks
As stated previously, NAnt can run on any operating system platform that supports either the [Microsoft.Net](http://www.microsoft.com/net) or [Mono](http://www.mono-project.com) frameworks. So in order to develop for the NAnt/NAntContrib projects you need one or the other (or both) frameworks installed on the desired platform.

**Please Note:** There were some changes made in Mono 3.0 that currently prevent NAnt from working properly.  If you are planning on developing NAnt on Mono, please use version 2.10 until these issues can be addressed.

* **Microsoft Windows**
    * Microsoft .NET Framework and SDK
        * Version 2.0 or later
    * Mono
        * Version 2.10 (Preferred)
        * Version 2.8
        * Version 2.4 and 2.6 are known to work but with limited or no support for C# 4.0
* **Linux/BSD**
    * Mono (only framework available on non-Windows systems)
        * Version 2.10 (Preferred)
        * Version 2.8
        * Version 2.4 and 2.6 are known to work but with limited or no support for C# 4.0

#### Other tools
Besides installing the necessary frameworks on the target platform NAnt currently requires make programs in order for it to bootstrap itself.  Currently two make programs are used

* nmake
    * nmake is a simple make program from Microsoft.
    * Only available for 32-bit Microsoft Windows platforms.
    * The latest version of nmake (1.5) can be [found here](http://support.microsoft.com/kb/132084) in the more information section of the page.
* GNU make
    * Referred to as gmake on some platforms.
    * Works on most Linux/BSD and Microsoft Windows platforms.
    * Installed by default on some Linux/BSD platforms.
    * More details can be [found here](http://www.gnu.org/s/make/)

#### Linux/BSD Mono installation commands
Installing the necessary files/framework(s) on a Microsoft Windows system is relatively simple.  A user just goes to the appropriate website ([Microsoft.Net](http://www.microsoft.com/net) or [Mono](http://www.mono-project.com)), downloads and runs the installer(s) and is ready to go.  With *nix systems, it can be a bit more tricky depending on the porting system available for a given operating system.  Below are a list of commands separated by Linux/BSD platform that should install the necessary libs to get started on NAnt/NAntContrib development.

These commands assume that you are a member on the target system that can install programs and modify the system to suite the installation instructions below.

* OpenSuSE (11.4) (from [Mono's website](http://www.go-mono.com/mono-downloads/download.html))
    * `zypper addrepo http://download.mono-project.com/download-stable/openSUSE_11.4 mono-stable`
    * `zypper refresh --repo mono-stable`
    * `zypper dist-upgrade --repo mono-stable`
    * `zypper install mono-devel`
    * `zypper install mono-basic` (needed for regression testing)
* OpenSuSE (12.1) (from [Mono's website](http://www.go-mono.com/mono-downloads/download.html))
    * `zypper install mono-devel`
    * `zypper install mono-basic` (needed for regression testing)
* OpenBSD (5.1)
    * Current version of Mono in OpenBSD packages is 2.10.6
    * `pkg_add -i mono gmake`
    * `pkg_add -i mono-basic` (needed for regression testing)
* Ubuntu (Oneiric)
    * Current version of Mono in Ubuntu packages is 2.10.5
    * `aptitude install mono-complete`
    * `aptitude install mono-vbnc` (needed for regression testing)
* Debian (Squeeze)
    * Current version of Mono in Debian packages is 2.6.7
    * `apt-get install mono-complete`
    * `apt-get install mono-vbnc` (needed for regression testing)

## Working with the code

### Forking the project

Since moving the NAnt/NAntContrib repositories to github.com, the ideal method of contributing to the projects is by using GitHub's Fork feature into your own repo.  From there, a user can make whatever modifications he or she wishes in order to complete whatever goal that the user set out to accomplish.  More information can be [found here](http://help.github.com/fork-a-repo/).

### Compiling from source

Once you clone your forked repository, you can find instructions on how to compile it in the README.txt file in the root directory of the project.

### Finding inspiration to code

So at this point, you have a forked repo of the project you want to contribute to.  Time to start working.  If you are not sure of what you want to work on or you don't know where to begin, don't worry.  There are few areas that you can find inspiration.

* Look in the github.com issues list or the old sourceforge.net bug/feature request sections of the project you are working on.
    * NAnt
        * github.com
            * [Issues](https://github.com/nant/nant/issues)
        * Sourceforge.net
            * [Bugs](http://sourceforge.net/tracker/?group_id=31650&atid=402868)
            * [Feature Requests](http://sourceforge.net/tracker/?group_id=31650&atid=402871)
    * NAntContrib
        * github.com
            * [Issues](https://github.com/nant/nantcontrib/issues)
        * Sourceforge.net
            * [Bugs](http://sourceforge.net/tracker/?group_id=54790&atid=474851)
            * [Feature Requests](http://sourceforge.net/tracker/?group_id=54790&atid=474854)
* See if there are any useful features in the [Jakarta Ant Project](http://jakarta.apache.org/ant/manual/index.html) that NAnt/NAntContrib could benefit from.

If you want to make a change for a bug or feature that has not been reported yet, please create a new ticket in the appropriate area. 

Communicate your intentions to the team members by adding a comment in the ticket. If the ticket is already assigned to a developer, please also send a mail to the developer to coordinate the activity.

### Testing

To ensure NAnt source code maintains a high level of quality, all code committed must be unit tested.  This policy applies to all code contributions to the NAnt/NAntContrib projects.

* Unit tests should be written for all new code. Existing tests should also be executed to ensure no regression problems with the existing functionality.
    * All unit tests are written using [NUnit](http://www.nunit.org/)
    * As of March 1st, 2012, NAnt uses NUnit version 2.6 for all tests
* To ensure cross platform compatibility, code should be compiled against both Microsoft .NET and Mono platforms. For compile with the different tools, please refer to README.txt file. 

## Contributing code

### NAnt/NAntContrib coding convention

To ensure a consistent coding style for everyone who participates in the development, please follow the coding convention guidelines listed below. Not only does this improves readability, but also make diffing and merging much easier.  The objective of coding rules is to reduce confusion among the readers. The key to that is consistency: consistency throughout a project, between projects and between authors.

* Follow .NET naming conventions (see SDK docs, [here](http://10rem.net/articles/net-naming-conventions-and-programming-standards---best-practices), and [here](http://www.dofactory.com/reference/csharp-coding-standards.aspx))
    * Prefix private fields with an underscore character to look like: `int _value;`
    * Omit `private` scope declaration unless it makes the code clearer.
* Use 4 space indents instead of tabs.
* One class one file.
* Start namespace with NAnt or NAntContrib (depending on project)
* GPL header on every source file.
* Class files stored in directories to match namespace.
* Use [C# documentation tags](http://msdn.microsoft.com/en-us/library/5ast78ax%28v=vs.80%29.aspx) for any new classes, methods, and properties.
* Use "The Allman Style" as the indentation style (NEW!)
    * Open bracket character ({) on new line in all cases including classes and methods.
    * Close bracket character(}) goes on a new line.
    * Always use brackets for if statements even if statement is a single line.
    * More information regarding this indentation style can be [found here](http://en.wikipedia.org/wiki/Indent_style#Allman_style).
* Avoid ? : operations in all but the most trivial cases.
* Avoid assignment in conditionals.
* Avoid magic numbers, use a nested enum instead.
* Be consistent – look at the existing code and make yours fit it.
* Make the code so simple that its boring to read.

Examples of good and bad coding styles:
```csharp
// good
if (foobar) 
{
    DoSomething();
} 
else 
{
    DoSomethingElse();
}

// bad - ommits { } - error prone
if (foobar)
    DoSomething();

// bad - same reason as above but requires more work to edit
if (foobar) DoSomething();

// bad - does not represent logical structure of code
// read McConnell, Code Complete
if (foobar) {
    DoSomething();
}
else {
    DoSomethingElse();
}
```

### Submitting GitHub pull requests

After the user has finished with his or her batch of updates, check to make sure that what was coded coheres to the following guidelines.

* Ensure the code adheres to the coding convention (as described above).
* Ensure the code has the corresponding unit tests.
* Ensure the code is properly documented. 
* Ensure the code is tested on at least one platform.
    * Microsoft Windows
    * Linux/BSD
    * Mac OS X

Once this has been verified, go ahead and proceed with making a [pull request](http://help.github.com/send-pull-requests/).  In the discussion section of the pull request, please include all of the necessary information (such as what your work is trying to accomplish) and any bug/feature request IDs that your work may be addressing.  You may also include additional notes in the Files Changed section or the pull request if you feel they better illustrate what your work is trying to address.  Once that is complete, send the pull request and we will evaluate your request as soon as we can.

## Requesting help

If you encounter problems developing with the NAnt source code, please send your question to nant-developers mailing list. The email address is nant-developers@lists.sourceforge.net.