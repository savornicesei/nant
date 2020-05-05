Title: Functions
Order: 90
---

NAnt provides a rich set of bulitin functions, that allow you to:
* manipulate strings
* manipulate date/time values
* manipulate path names
* read the properties of files/directories
* access current build information and more
* and more

For a full list of supported functions, click [here](http://nant.sourceforge.net/release/latest/help/functions/index.html).

## Function call syntax

 To call functions, use *prefix::function-name(argument1, ..., argumentN)*{: class="text-primary"} syntax within expressions. NAnt will (implicitly) try to convert the arguments you pass to functions to correct types and will report an error in case of failure.

For example, assuming you would like to call *string::contains('0123456789', 1)*{: class="text-primary"} which expects two string parameters, but you want to pass the second parameter which is an integer. NAnt would attempt to convert the second parameter from *int*{: class="text-primary"} to *string*{: class="text-primary"}, which succeeds and function is called as if it was written as *string::contains('0123456789', '1')*{: class="text-primary"}.

The following table shows the possible type conversions:

|       From Type       |  To Type | Allowed |                          Remarks                                                                                                                                                                      |
|:---------------------:|:--------:|:-------:|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|          int          |  string  |   Yes   | The conversion is always possible.                                                                                                                                                                    |
|          int          |  double  |   Yes   | The conversion is always possible.                                                                                                                                                                    |
|          int          |  boolean |    No   | Can be done with the *if()*{: class="text-primary"} conditional operator or simply as (*value <> 0*{: class="text-primary"})                                                                                                                  |
|          int          | datetime |    No   | You cannot convert from *int*{: class="text-primary"} to *datetime*{: class="text-primary"}.                                                                                                                                                  |
|          int          | timespan |    No   | You can use the *timespan::from-xxx*{: class="text-primary"} functions to construct a *timespan*{: class="text-primary"} from a given number of days, months, ....                                                                            |
|                       |          |         |                                                                                                                                                                                                       |
|         string        |    int   |   Yes   | If the string doesn't represent an integer value, an error is reported.                                                                                                                               |
|         string        |  double  |   Yes   | If the string doesn't represent a floating point value, an error is reported.                                                                                                                         |
|         string        |  boolean |   Yes   | If the string isn't either *true*{: class="text-primary"} or *false*{: class="text-primary"} (case insensitive), an error is reported.                                                                                                        |
|         string        | datetime |   Yes   | If the string doesn't represent a valid date/time, an error is reported. Date/time string format is *MM/DD/YYYY HH:MI:SS*{: class="text-primary"}                                                                         |
|         string        | timespan |    No   | You can use *timespan::parse*{: class="text-primary"} to construct a *timespan*{: class="text-primary"} from a time indicated by a given string. If the string doesn't represent a valid timespan, an error is reported.                      |
|                       |          |         |                                                                                                                                                                                                       |
|         double        |    int   |   Yes   | If the string doesn't represent an integer value, an error is reported.                                                                                                                               |
|         double        |  string  |   Yes   | The converted string uses dot as a fractional part separator so the result looks like *0.1234567*{: class="text-primary"}                                                                                                 |
|         double        |  boolean |    No   | You cannot convert from *double*{: class="text-primary"} to *boolean*{: class="text-primary"}.                                                                                                                                                |
|         double        | datetime |    No   | You cannot convert from *double*{: class="text-primary"} to *datetime*{: class="text-primary"}.                                                                                                                                               |
|         double        | timespan |    No   | You can use the *timespan::from-xxx*{: class="text-primary"} functions to construct a *timespan*{: class="text-primary"} from a given number of days, months, ....                                                                            |
|                       |          |         |                                                                                                                                                                                                       |
|        boolean        |    int   |    No   | You cannot convert from *boolean*{: class="text-primary"} to *int*{: class="text-primary"}. You may want to use *if(bool value, 1, 0)*{: class="text-primary"} instead.                                                                                           |
|        boolean        |  string  |   Yes   | The result is *'True'*{: class="text-primary"} or *'False'*{: class="text-primary"} string.                                                                                                                                                   |
|        boolean        |  double  |    No   | You cannot convert from *boolean*{: class="text-primary"} to *double*{: class="text-primary"}.                                                                                                                                                |
|        boolean        | datetime |    No   | You cannot convert from *boolean*{: class="text-primary"} to *datetime*{: class="text-primary"}.                                                                                                                                              |
|        boolean        | timespan |    No   | You cannot convert from *boolean*{: class="text-primary"} to *timespan*{: class="text-primary"}.                                                                                                                                              |
|                       |          |         |                                                                                                                                                                                                       |
|        datetime       |    int   |    No   | You cannot convert from *datetime*{: class="text-primary"} to *int*{: class="text-primary"}.                                                                                                                                                  |
|        datetime       |  string  |   Yes   | The result is a *datetime* string with the following format: *MM/DD/YYYY HH:MI:SS*{: class="text-primary"}                                                                                                            |
|        datetime       |  double  |    No   | You cannot convert from *datetime*{: class="text-primary"} to *double*{: class="text-primary"}.                                                                                                                                               |
|        datetime       |  boolean |    No   | You cannot convert from *datetime*{: class="text-primary"} to *boolean*{: class="text-primary"}.                                                                                                                                              |
|        datetime       | timespan |    No   | You can use the value of *datetime::get-ticks* to construct a *timespan*{: class="text-primary"} using *timespan::from-ticks*{: class="text-primary"}.                                                                                    |
|                       |          |         |                                                                                                                                                                                                       |
|        timespan       |    int   |    No   | You cannot convert from *timespan*{: class="text-primary"} to *int*{: class="text-primary"}.                                                                                                                                                  |
|        timespan       |  double  |    No   | You can use *timespan::get-ticks*{: class="text-primary"} to convert from *timespan*{: class="text-primary"} to *double*{: class="text-primary"}.                                                                                                                 |
|        timespan       |  boolean |    No   | You cannot convert from *timespan*{: class="text-primary"} to *boolean*{: class="text-primary"}.                                                                                                                                              |
|        timespan       |  string  |    No   | You can use *timespan::to-string*{: class="text-primary"} to obtain the *string*{: class="text-primary"} representation of a *timespan*{: class="text-primary"}.                                                                                                  |
|        timespan       | datetime |    No   | You cannot convert from *timespan*{: class="text-primary"} to *datetime*{: class="text-primary"}.                                                                                                                                             |


## Custom functions

Just as you can extend NAnt with your own tasks it is also possible to implement your own functions for use in build files.

Functions can be implemented in any .NET language and are loaded in the same manner as tasks. ie either by locating your custom function assembly in the NAnt bin directory or using the [&lt;loadtasks&gt;](http://nant.sourceforge.net/release/latest/help/tasks/loadtasks.html) task. Example C# code for a Hello World function :

Define a custom function using C#.

```csharp                    
[FunctionSet("hello", "Hello")]
public class HelloFunctions : FunctionSetBase {        
    public HelloFunctions(Project project, PropertyDictionary properties) : base(project, properties) {
    }
    [Function("hello-world")]
    public static string HelloWorldfunc() {
        return "Hello World!!";
    }
}
```

and call that function from a build file.
```xml       
<echo message="${hello::hello-world()}" />
```      

A quick and easy way to develop new functions is to use the [&lt;script&gt;](http://nant.sourceforge.net/release/latest/help/tasks/script.html) task. This allows you to create and test new functions without the overhead of building an external assembly. The [&lt;script&gt;](http://nant.sourceforge.net/release/latest/help/tasks/script.html) task documentation contains examples of custom function definitions.