---
Title: Release Notes
---

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
