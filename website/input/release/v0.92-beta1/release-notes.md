---
Title: Release Notes
---

# 0.92-beta1 - May 6, 2012 {v0.92-beta1}

**No updates since 0.92-alpha1.**
  
  
  
# 0.92-alpha1 - April 22, 2012 {v0.92-alpha1}

## NAnt

---

### **Changes**

**Framework support**

  * Removed runtime support for .NET/Mono 1.* Frameworks (target support for .NET/Mono 1.* Frameworks still remains)

**Core**

* **NAnt Project Files**

  * Updated NAnt project files to VS2010 format.

* **NUnit**

  * Upgraded to NUnit 2.6.

* **App.Config**

  * Added initial support for Silverlight 5

* **Command Line**

  * Added pause option to pause nant before exit.

* **Type Factory**

  * Added detailed error messages when type loading exception occurs.

**Tasks**

* **Mail**

  * Updated *&lt;mail&gt;*{: class="text-primary"} task to reference System.Net.Mail namespace instead of System.Web.Mail.
  * Added additional attritbutes for greater control of the *&lt;mail&gt;*{: class="text-primary"} task. Such as:

    * mailport
    * ssl
    * user
    * password
    * replyto

* **Zip**

  * Added flatten attribute to *&lt;zip&gt;*{: class="text-primary"} task.

* **Tar**

  * Added flatten attribute to *&lt;tar&gt;*{: class="text-primary"} task.

### **Bug fixes**

**Tasks**

* **Copy/Move tasks**

  * Fixed issues with *&lt;copy&gt;*{: class="text-primary"} and *&lt;move&gt;*{: class="text-primary"} tasks when trying to relocate directories. ([Issue #11](https://github.com/nant/nant/issues/11))

* **Asminfo**

  * Fixed issue with *&lt;asminfo&gt;*{: class="text-primary"} task when trying to add assembly attributes with default constructors. ([Issue #41](https://github.com/nant/nant/issues/41))

* **Style**

  * Updated *&lt;style&gt;*{: class="text-primary"} task to preserve singleton tags whenever possible. ([Issue #17](https://github.com/nant/nant/issues/17))


## NAntContrib

---

### **Changes**

**Core**

* **NAntContrib Project Files**

  * Updated NAntContrib project files to VS2010 format.

**Functions**

* **Array functions**

  * Added Array functions to sort and reverse a string array.

### **Bug fixes**

**Tasks**

* **&lt;iisapppool&gt;**

  * Fixed issue with *&lt;iisapppool&gt;*{: class="text-primary"} encountering access denied error when executing on remote machine. [Issue #6](https://github.com/nant/nantcontrib/issues/6)
