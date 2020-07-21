Title: Loggers and listeners
Order: 70
---

# Overview

NAnt has two related features to allow the build process to be monitored: listeners and loggers.

## Listeners

A listener is alerted of the following events:
* build started
* build finished
* target started
* target finished
* task started
* task finished
* message logged

## Loggers

Loggers extend the capabilities of listeners and add the following features:
* Receives a handle to the standard output and error print streams and therefore can log information to the console or the *-logfile*{: class="text-primary"} specified file.
* Logging level (*-quiet*{: class="text-primary"}, *-verbose*{: class="text-primary"}, *-debug*{: class="text-primary"}) aware.
* Emacs-mode aware. This still needs to be implemented.

# Built-in Listeners/Loggers

| Class                   |                              Description                                                                                                                                                                     |                              Type |
|-------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------|
| [NAnt.Core.DefaultLogger](#defaultlogger) |                              The logger used implicitly unless overridden with the -logger command-line                              switch.                                                                 | IBuildLogger                      |
| [NAnt.Core.MailLogger](#maillogger)    |                              Extends [DefaultLogger](#defaultlogger) such that output is still                              generated the same, and when the build is finished an e-mail can be sent.                          | IBuildLogger                      |
| [NAnt.Core.XmlLogger](#xmllogger)     |                              Generates output in XML format.                                                                                                                                                 | IBuildLogger                      |


## DefaultLogger {#default-logger}

Simply run NAnt normally, or:
```
    NAnt.exe -logger:NAnt.Core.DefaultLogger
```


## MailLogger {#mail-logger}

The MailLogger captures all output logged through DefaultLogger (standard NAnt output) and will send success and failure messages to unique e-mail lists, with control for turning off success or failure messages individually.

Properties controlling the operation of MailLogger are:

| Property                       |                              Description                                                |                              Required   |
|--------------------------------|-----------------------------------------------------------------------------------------|-----------------------------------------|
| MailLogger.mailhost            | The SMTP server to use.                                                                 | No, default is "localhost"              |
| MailLogger.from                | The address of the e-mail sender.                                                       | Yes, if mail needs to be sent.          |
| MailLogger.failure.notify      | Send build failure e-mails ?                                                            | No, default is "true".                  |
| MailLogger.success.notify      | Send build success e-mails ?                                                            | No, default is "true".                  |
| MailLogger.failure.to          | The address to send build failure messages to.                                          | Yes, if failure mail is to be sent.     |
| MailLogger.success.to          | The address to send build success messages to.                                          | Yes, if success mail is to be sent.     |
| MailLogger.failure.subject     | The subject of build failure messages.                                                  | No, default is "Build Failure".         |
| MailLogger.success.subject     | The subject of build success messages.                                                  | No, default is "Build Success".         |
| MailLogger.failure.attachments | The ID of a fileset representing a set of files to attach when the build fails.         | No.                                     |
| MailLogger.success.attachments | The ID of a fileset representing a set of files to attach when the build is successful. | No.                                     |
| MailLogger.body.encoding       | The encoding type of the body of the e-mail message.                                    | No, default is system's ANSI code page. |
| MailLogger.smtp.username<sup>1</sup>      | The name of the user to login to the SMTP server.                                       | No.                                     |
| MailLogger.smtp.password<sup>1</sup>      | The password of the specified user.                                                     | No.                                     |
| MailLogger.smtp.enablessl<sup>1</sup>     | Specifies whether to use SSL to encrypt the connection.                                 | No, default is "false".                 |
| MailLogger.smtp.port<sup>1</sup>          | The SMTP server port to connect to.                                                     | No, default is "25".                    |

<sup>1</sup> Only available when NAnt is built targeting .NET Framework 1.1 (or equivalent) or higher.{: class="text-warning"}
    

**Usage:**
```
    NAnt.exe -logger:NAnt.Core.MailLogger
```

**Example:**
```xml
    <project name="MailLogger Test" default="build">
        <property name="MailLogger.mailhost" value="smtp.wherever.be" />
        <property name="MailLogger.from" value="me@telenet.be" />
        <property name="MailLogger.failure.notify" value="true" />
        <property name="MailLogger.success.notify" value="true" />
        <property name="MailLogger.failure.to" value="support@home.be" />
        <property name="MailLogger.success.to" value="support@home.be" />
        <property name="MailLogger.failure.subject" value="Nightly build failure !" />
        <property name="MailLogger.success.subject" value="Nightly build successful" />
        <property name="MailLogger.failure.attachments" value="MailLogger.failure.files" />
        <property name="MailLogger.success.attachments" value="MailLogger.success.files" />

        <!-- set of files to attach when build fails -->
        <fileset id="MailLogger.failure.files">
            <include name="dump.log" />
            <include name="trace.txt" />
        </fileset>

        <!-- set of files to attach when build is successful -->
        <fileset id="MailLogger.success.files">
            <include name="trace.txt" />
        </fileset>
    
        <target name="build">
            <echo message="Starting build" />
            ....
            <echo message="Finished build" />
        </target>
    </project>
```       

## XmlLogger {#xml-logger}

Writes all build information out to an XML file named *log.xml*{: class="text-primary"}, or the value of the *XmlLogger.file*{: class="text-primary"} property if present, when used as a listener. When used as a logger, it writes all output to either the console or to the value of *-logfile*{: class="text-primary"}.

Whether used as a listener or logger, the output is not generated until the build is complete.

**Usage:**
```
    NAnt.exe -listener:NAnt.Core.XmlLogger
    NAnt.exe -logger:NAnt.Core.XmlLogger -logfile:buildlog.xml
```

**Example:**
```xml
    <buildresults project="test">
        <message level="Info"><![CDATA[Buildfile: file:///D:/nant-test/xmlpeek/default.build]]></message>
        <message level="Info"><![CDATA[Target framework: Microsoft .NET Framework 1.1]]></message>
        <message level="Info"><![CDATA[Target(s) specified: build]]></message>
        <target name="build">
            <task name="xmlpeek">
                <message level="Info"><![CDATA[Peeking at 'D:\nant-test\xmlpeek\input.xml' with XPath expression 'x:parameters/x:param'.]]></message>
                <message level="Info"><![CDATA[Found '1' nodes with the XPath expression 'x:parameters/x:param'.]]></message>
                <duration>15.625</duration>
            </task>
            <duration>15.625</duration>
        </target>
        <duration>31.25</duration>
    </buildresults>
```    

