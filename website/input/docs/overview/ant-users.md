Title: Ant users
Order: 50
---

If you have used Ant before than NAnt should feel comfortable but NAnt is only compatible with Ant in spirit.  
Here is a partial list of differences:

* Tasks do not have to be in a target.  Tasks that appear directly in the project are executed inorder before any tasks in targets are executed.
* _nant.onsuccess_{: style="color: #337ab7; font-weight: bold;"} and _nant.onfailure_{: style="color: #337ab7; font-weight: bold;"} properties can be defined target names that will be executed at the end of the build.
* NAnt looks for the first file ending in _.build_{: style="color: #337ab7; font-weight: bold;"} instead of build.xml.
