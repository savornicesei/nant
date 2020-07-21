---
Title: Release Notes
---

# 0.91-alpha2 - August 17, 2010 {v0.91-alpha2}

## NAnt

---

### **Bug fixes**

**Core**

* **App.config**

  * Fixed typo that prevented System.Management.dll from being included.

**Tasks**

* **&lt;include&gt;**

  * Fixed error with the *&lt;include&gt;*{: class="text-primary"} task when different build files include the same file. (bug [#3016497](https://sourceforge.net/tracker/?func=detail&aid=3016497&group_id=31650&atid=402868)).

**Functions**

* **NAnt::get-assembly()**

  * Using the *NAnt::get-assembly()*{: class="text-primary"} function causes an "Object must implement IConvertible" error. (bug [#3013492](https://sourceforge.net/tracker/?func=detail&aid=3013492&group_id=31650&atid=402868)).



# 0.91-alpha1 - May 29, 2010 {v0.91-alpha1}

## NAnt

---

### **Framework support**

  * Added support for .NET Framework 4.0 (except for *&lt;solution&gt;*{: class="text-primary"} task).

### **Bug fixes**

**Expressions**

* **Coercion**

  * Coercion of arguments is not supported (bug [#3013492](http://sourceforge.net/tracker/?func=detail&aid=3013492&group_id=31650&atid=402868)).

### **Changes**

**Tasks**

* **&lt;xmlpeek&gt;**

  * Enhanced the *&lt;xmlpeek&gt;*{: class="text-primary"} task to support more advanced XPath functions and syntax. It is now possible to use functions such as count() and to index the node using XPath directly. (feature request [#1560566](http://sourceforge.net/tracker/index.php?func=detail&aid=1560566&group_id=31650&atid=402871)).
