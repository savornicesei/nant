Title: Installation
Order: 30
---

NAnt is available in either a source or binary distribution. The binary distribution is all you need to use NAnt to build your projects, including creating your own custom tasks, types and functions.

If you are upgrading NAnt from a previous version, you must never install over the top of your previous installation. Delete or rename the existing installation directory before installing the new version of NAnt.

## Installing from binaries

1. Download the binary distribution archive. Either _nant-bin.zip_ or _nant-bin.tar.gz_ will work, the contents of each archive are the same.
2. Remove any previous versions of NAnt you may have installed.
3. Extract the contents of the archive to the location you wish to install NAnt (eg: C:\Program Files\NAnt in windows, or /usr/local/nant in Linux)
4. Depending on your environment, create a wrapper script to run NAnt:
    * **Run NAnt using Microsoft.NET**
        * Create a file called _nant.bat_ in a directory that is included in the _PATH_ system environment variable. (eg. C:\WINDOWS).
        * Add the following to _nant.bat_:
            ```
            @echo off
            "C:\Program Files\NAnt\bin\NAnt.exe" %*
            ```                                

    * **Run NAnt using Mono**
        * **Windows**
            * Create a file called _nant.bat_ in a directory that is included in the _PATH_ system environment variable. (eg. C:\WINDOWS).
            * Add the following to nant.bat:
                ```
                @echo off
                mono "C:\Program Files\NAnt\bin\NAnt.exe" %*
                ```                                         

        * **Linux / Cygwin**
            * Create a file called _nant_ in a suitable location in your filesystem (eg. /usr/local/bin).
            * Add the following to _nant_:
                ```
                #!/bin/sh
                exec mono /usr/local/nant/bin/NAnt.exe "$@"
                ```                                    

            * Ensure _nant_ has permission to execute, eg: ``` chmod a+x /usr/local/bin/nant ```
                                    

5. Open a new command prompt (shell) and type _nant -help_. If successful, you should see a usage message displaying available command line options.
6. (optional) Download and install NAnt-contrib or other third party extensions to NAnt.

## Installing from source

1. Download the source distribution archive. Either nant-src.zip or nant-src.tar.gz will work, the contents of each archive are the same.
2. Remove any previous versions of NAnt you may have installed.
3. Extract the contents of the archive to a temporary location. This should not be the location you wish to install NAnt to.
4. Open a command prompt and change into the folder you extracted the archive to.
5. Depending on your environment, build the NAnt distribution:
    * **Install NAnt using Microsoft .NET**
        * **GNU Make**
            ```
            make install MONO= MCS=csc prefix=installation-path
            #eg. make install MONO= MCS=csc prefix="C:\Program Files"
            ```
        * **NMake**
            ```
            nmake -f Makefile.nmake install prefix=installation-path
            #eg. nmake -f Makefile.nmake install prefix="C:\Program Files"
            ```
    * **Install NAnt using Mono**
        * **GNU Make**
            ```
            make install prefix=installation-path
            #eg. make install prefix="C:\Program Files"
            ```
        * **NMake**
            ```
            nmake -f Makefile.nmake install MONO=mono CSC=mcs prefix=installation-path
            #eg. nmake -f Makefile.nmake install MONO=mono CSC=mcs prefix=/usr/local/
            ```

    This will first build a bootstrap version of NAnt, and then use that to build and install the full version to installation-path/NAnt.
6. Follow the instructions as for a binary release from step 5.
