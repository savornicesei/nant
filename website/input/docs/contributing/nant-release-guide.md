Title: NAnt release guide
Order: 10020
---

## Introduction

This page describes the process of performing a release for both the NAnt and NAntContrib projects.  Please make sure that you check with the project admins and developers before generating an official release.

## Requirements

To build a new release, you need at least the following software on the build machine:
* Windows XP SP3 or later
* [nmake](http://support.microsoft.com/kb/132084)
* [Cygwin](http://www.cygwin.com/) with Net/openssh, Devel/git, and Utils/gnupg packages
* [Microsoft .NET Framework 2.0 Redistributable](http://www.microsoft.com/download/en/details.aspx?id=19)
* [Microsoft .NET Framework 2.0 SDK](http://www.microsoft.com/download/en/details.aspx?displaylang=en&id=19988)
* [Microsoft HTML Help Workshop](http://go.microsoft.com/fwlink/?LinkId=14188)

## Preparation

Before proceeding with building the release, please make sure that the following criteria is met:
* Make sure that the following paths are located in the Windows PATH environment variable.
    * Path to nmake.exe
    * Paths to cygwin programs.
        * If using cygwin shell, these programs are automatically appended to $PATH var.
    * Both the .NET 2.0 Framework (path to csc.exe) and SDK bin paths.
* Make sure that a clean version of both [NAnt](https://github.com/nant/nant) and [NAntContrib](https://github.com/nant/nantcontrib) is checked out from github.com prior to starting the build processes.
    * Read/Write access to [NAnt](https://github.com/nant/nant) and [NAntContrib](https://github.com/nant/nantcontrib) git repositories is required.
* Update the release notes (located in doc/releasenotes.html for each project) with all the changes relevant for the release.

## Building NAnt Release

1. Modify the following properties in **NAnt.build** to reflect the release that is being prepared:
    * `project.release.type` - Change this to either **alpha#**, **beta#**, **rc#** or **release**.
    * `project.version` - Change the value of this property to match the major and minor release number.
2. Bootstrap NAnt:

        C:\path\to\nant.git>nmake -f Makefile.nmake bootstrap

3. Execute the following command to make sure **src/CommonAssemblyInfo.cs** is updated for the release:

        C:\path\to\nant.git>bootstrap\NAnt -t:net-2.0 build

4. Modify the following property in **NAnt.build**:
    * `create.assemblyinfo` - Change the value of this property to **false** to prevent the **CommonAssemblyInfo.cs** file from being recreated in the distribution packages (and GIT).
5. Build NAnt:

        C:\path\to\nant.git>bootstrap\NAnt -t:net-2.0 -f:release.xml
    * This step will automatically create the following files and attempt to upload the [SourceForge File Release System](http://sourceforge.net/projects/nant/files/).
        * nant-{major version}-{minor version}[-{release type}]-src.zip
        * nant-{major version}-{minor version}[-{release type}]-src.tar.gz
        * nant-{major version}-{minor version}[-{release type}]-bin.zip
        * nant-{major version}-{minor version}[-{release type}]-bin.tar.gz
    * If the upload process fails, upload the release files to [Sourceforge.net](http://sourceforge.net/projects/nant/files/) manually.
6. Go the [SourceForge File Manager](http://sourceforge.net/projects/nant/files/) and make sure the appropriate file is selected as the default for downloading on each platform.
7. Modify **web/index.html** in the <u>build directory for the current release (eg. build/nant/web/index.html)</u> to add information about the new release.
8. Copy the modified web/index.html to the web directory in the local git working copy.
9. Commit the following files to [NAnt's git repo](https://github.com/nant/nant).
    * NAnt.build
    * doc/releasenotes.html
    * src/CommonAssemblyInfo.cs
    * web/index.html
10. Create a tag for the release:

        C:\path\to\nant.git\git tag -s {tag name} -m "{tag message}"
    * {tag name} is constructed using "rel-{major version}-{minor version}[-{release type}]".
        * `rel-0-85-rc4` - NAnt 0.85 Release Candidate 4
        * `rel-0-85` - NAnt 0.85 RTM
    * {tag message} should be brief.
        * `Tagging NAnt 0.85 Release Candidate 4`
        * `Tagging NAnt 0.85 RTM`
11. Push the recently created tag to git master

        C:\path\to\nant.git>git push --tags
12. Upload the new web site by executing the following command:

        C:\path\to\nant.git>bootstrap\NAnt.exe -f:release.xml deploy-web-sf
13. Verify the website has been updated, and all the links are working.
14. Modify the following properties in **NAnt.build** back to indicate the development status of git master branch:
    * `project.release.type` - Change the value of this property to **dev**.
    * `project.version` - Change this to match the version number of the next release.
    * `create.assemblyinfo` - Change the value of this property to **true** to re-enable automatic creation of the **CommonAssemblyInfo.cs** file.
15. Commit **NAnt.build** to git master branch.

## Building NAntContrib Release

Building the NAntContrib release requires the above instructions for building the NAnt release be completed before proceeding.  This ensures that the NAntContrib release is built upon the correct version of the NAnt libs.

1. Modify the following properties in **NAntContrib.build** to reflect the release that is being prepared:
    * `project.release.type` - Change this to either **alpha#**, **beta#**, **rc#** or **release**.
        * This should match exactly with what was set during the NAnt release.
    * `project.version` - Change the value of this property to match the major and minor release number.
2. Execute the following command to make sure **src/CommonAssemblyInfo.cs** is updated for the release:

        C:\path\to\nantcontrib.git>path\to\recent\nant\build\nant.exe -t:net-2.0 build

3. Modify the following property in **NAntContrib.build**:
    * `create.assemblyinfo` - Change the value of this property to **false** to prevent the **CommonAssemblyInfo.cs** file from being recreated in the distribution packages (and GIT).
4. Build NAntContrib:

        C:\path\to\nantcontrib.git>path\to\recent\nant\build\nant.exe -t:net-2.0 -f:release.xml
    * This step will automatically create the following files and attempt to upload the [SourceForge File Release System](http://sourceforge.net/projects/nantcontrib/files/).
        * nantcontrib-{major version}-{minor version}[-{release type}]-src.zip
        * nantcontrib-{major version}-{minor version}[-{release type}]-doc.tar.gz
        * nantcontrib-{major version}-{minor version}[-{release type}]-bin.zip
    * If the upload process fails, upload the release files to [Sourceforge.net](http://sourceforge.net/projects/nantcontrib/files/) manually.
6. Go the [SourceForge File Manager](http://sourceforge.net/projects/nantcontrib/files/) and make sure the appropriate file is selected as the default for downloading on each platform.
7. Modify **web/index.html** in the <u>build directory for the current release (eg. build/nantcontrib/web/index.html)</u> to add information about the new release.
8. Copy the modified web/index.html to the web directory in the local git working copy.
9. Commit the following files to [NAntContrib's git repo](https://github.com/nant/nantcontrib).
    * NAntContrib.build
    * doc/releasenotes.html
    * src/CommonAssemblyInfo.cs
    * web/index.html
10. Create a tag for the release:

        C:\path\to\nantcontrib.git\git tag -s {tag name} -m "{tag message}"
    * {tag name} is constructed using "rel-{major version}-{minor version}[-{release type}]".
        * `rel-0-85-rc4` - NAntContrib 0.85 Release Candidate 4
        * `rel-0-85` - NAntContrib 0.85 RTM
    * {tag message} should be brief.
        * `Tagging NAntContrib 0.85 Release Candidate 4`
        * `Tagging NAntContrib 0.85 RTM`
11. Push the recently created tag to git master

        C:\path\to\nantcontrib.git>git push --tags
12. Upload the new web site by executing the following command:

        C:\path\to\nantcontrib.git>path\to\recent\nant\build\nant.exe -f:release.xml deploy-web-sf
13. Verify the website has been updated, and all the links are working.
14. Modify the following properties in **NAntContrib.build** back to indicate the development status of git master branch:
    * `project.release.type` - Change the value of this property to **dev**.
    * `project.version` - Change this to match the version number of the next release.
    * `create.assemblyinfo` - Change the value of this property to **true** to re-enable automatic creation of the **CommonAssemblyInfo.cs** file.
15. Commit **NAntContrib.build** to git master branch.

## Announcements

1. Post a message announcing the new release to the following mailing lists:
    * nant-announce@lists.sourceforge.net
    * nant-users@lists.sourceforge.net
    * nant-developers@lists.sourceforge.net
    * nantcontrib-developer@lists.sourceforge.net
    * mono-list@lists.ximian.com
    * boolang@googlegroups.com
    * nunit-discuss@googlegroups.com
    * devel@lists.monobjc.net
    * users@lists.monobjc.net
    * Any other mailing list which are considered appropriate and you have permission to post NAnt related announcements.
2. Make sure that the subject lines of the distributed emails contain the prefix: `[ANN]`
3. Submit a news article to the following web sites:
    * http://freshmeat.net
    * Any other site deemed appropriate for NAnt related announcements.
4. Post an announcement on the http://sourceforge.net/news/?group_id=31650 SourceForge web site.
5. Post an announcement on the http://sourceforge.net/apps/wordpress/nant blog.

## Announcement Example

The following fragment can be used as a template for the release announcement:

Subject: [ANN] Announcing NAnt/NAntContrib 0.92 Alpha1

We are proud to announce the final release of NAnt/NAntContrib 0.92 Alpha1.

This release focuses on extending our already strong support for multiple target frameworks (including .NET 4.0, Mono 4.0, Silverlight, etc), bringing improved flexibility and performance.  A number of outstanding issues have been fixed as well.

A roadmap has been created to help illustrate the current release plan.  Please note that this roadmap is a work in progress and is subject to change depending on feature priorities, issues, and developer's comfort level with the release:
https://sourceforge.net/apps/mediawiki/nant/index.php?title=Roadmap

Binary and source distributions are available for immediate download from:

NAnt:
https://sourceforge.net/projects/nant/files/nant/0.92-alpha1/

NAntContrib:
https://sourceforge.net/projects/nantcontrib/files/nantcontrib/0.92-alpha1/

The GIT tag for NAnt/NAntContrib 0.92 Alpha1 is:
rel-0-92-alpha1

Discussion of NAnt occurs on the mailing list at nant-users@lists.sourceforge.net.  

Bugs can be reported using Github.com's issue tracker at:

NAnt:
https://github.com/nant/nant/issues

NAntContrib:
https://github.com/nant/nantcontrib/issues

For more detailed progress on the inner workings of NAnt and NAntContrib, check out the NAnt Blog at https://sourceforge.net/apps/wordpress/nant/

About NAnt: 

NAnt is a free .NET build tool, allowing applications to be built targeting both Microsoft .NET and Mono while supporting both Windows and Linux platforms.

About NAntContrib:

NAntContrib is the project for tasks and tools that haven't made it into the main NAnt distribution yet or for whatever reason don't belong there.

Check the NAnt homepage for additional info at http://nant.sourceforge.net.

Check the NAntContrib homepage for additional info at http://nantcontrib.sourceforge.net.
Bugs can be reported using the Bug Tracker at http://sourceforge.net/projects/nant. 

Check the NAnt homepage for additional info at http://nant.sourceforge.net.