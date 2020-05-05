Title: Expressions
Order: 80
---

[//]: # (TOC Begin)

* [Introduction](#introduction)
* [Expression syntax](#expression-syntax)
* [Data types](#data-types)
* [Operators](#operators)
    * [Operator precedence](#operator-precedence)
    * [Operators on numeric values](#operators-on-numeric-values)
        * [Add](#add)
        * [Subtract](#subtract)
        * [Multiply](#multiply)
        * [Divide](#divide)
        * [Mod](#mod)
        * [Equal](#equal)
        * [Inequal](#inequal)
        * [Greater than](#greater-than)
        * [Greater than or equal](#greater-than-or-equal)
        * [Less than](#less-than)
        * [Less than or equal](#less-than-or-equal)
        * [Unary plus](#unary-plus)
        * [Unary minus](#unary-minus)
    * [Operators on boolean values](#operators-on-boolean-values)
        * [Equal](#equal-1)
        * [Inequal](#inequal-1)
        * [Greater than](#greater-than-1)
        * [Greater than or equal](#greater-than-or-equal-1)
        * [Less than](#less-than-1)
        * [Less than or equal](#less-than-or-equal-1)
        * [Logical and](#logical-and)
        * [Logical or](#logical-or)
    * [Operators on string values](#operators-on-string-values)
        * [Concat](#concat)
        * [Equal](#equal-2)
        * [Inequal](#inequal-2)
        * [Greater than](#greater-than-2)
        * [Greater than or equal](#greater-than-or-equal-2)
        * [Less than](#less-than-2)
        * [Less than or equal](#less-than-or-equal-2)
    * [Operators on TimeSpan and DateTime values](#operators-on-timespan-and-datetime-values)
        * [Add](#add-1)
        * [Subtract](#subtract-1)
        * [Equal](#equal-3)
        * [Inequal](#inequal-3)
        * [Greater than](#greater-than-3)
        * [Greater than or equal](#greater-than-or-equal-3)
        * [Less than](#less-than-3)
        * [Less than or equal](#less-than-or-equal-3)
    * [Operators on Version values](#)
        * [Equal](#equal-4)
        * [Inequal](#inequal-4)
        * [Greater than](#greater-than-4)
        * [Greater than or equal](#greater-than-or-equal-4)
        * [Less than](#less-than-4)
        * [Less than or equal](#less-than-or-equal-4)

[//]: # (TOC End)

# Introduction

Expressions are simple, yet powerful mechanism that allows you to write advanced formulas to be used in task arguments and conditions that direct the build process. Expressions can access project [properties](http://nant.sourceforge.net/release/latest/help/fundamentals/properties.html) and call builtin or user-defined [functions](http://nant.sourceforge.net/release/latest/help/functions/index.html).

NAnt provides a rich set of bulitin functions, that allow you to:
* manipulate strings
* manipulate date/time values
* manipulate path names
* read the properties of files/directories
* access current build information and more
* and more

For a full list of supported functions, click [here](http://nant.sourceforge.net/release/latest/help/functions/index.html).

# Expression Syntax

Expressions can be used in all task arguments, by using *${...}*{: class="text-primary"} notation. You may use standard syntax for arithmetical (addition, subtraction, multiplication, division, modulus), logical (negation, conjunction, alternative) and relational operators (equality, inequality). To call functions, use *prefix::function-name(argument1, ..., argumentN)*{: class="text-primary"} syntax. To access properties, you simply use their names without any prefix or suffix. See the examples section below for more information.

**NOTE:** Expressions are often used in XML attributes. The grammar specified in this section applies to the attribute value after XML 1.0 normalization. So, for example, if the grammar uses the character *&lt;*{: class="text-primary"}, this must not appear in the XML source as *&lt;*{: class="text-primary"} but must be quoted according to XML 1.0 rules by, for example, entering it as *\&lt;*{: class="text-primary"}.{: class="bg-info"}

**Examples:**

1. Accessing a property:
    ```xml
        <property name="build.version" value="3" />
        <echo message="The current date is: ${build.version}" />
    ```
    This will output the current value of *build.version*{: class="text-primary"} property.

2. Calling a function
    ```xml
        <echo message="The current date is: ${datetime::now()}" />
    ```
    This will output the current date and time.
    
3. Storing the result of an expression

    To store the result of an expression in a property, use the *&lt;property&gt;*{: class="text-primary"} task:
    ```xml
        <property name="autoexec-present" value="${file::exists('c:\autoexec.bat')}" />
    ```
    This will set the property *autoexec-present*{: class="text-primary"} to either **true** or **false** depending on whether the specified file exists or not.
    
4. Real-life expression use
    ```xml
        <property name="myprj.basedir" value="c:\" />
        <property name="filename" value="${path::combine(myprj.basedir,'version.txt')}" />

        <if test="${not file::exists(filename) or file::get-length(filename) = 0}">
            <echo message="The version file ${filename} doesn't exist or is empty!" />
        </if>
    ```
    This will check for the existence of a file version.txt in a directory specified by myprj.basedir. Note that this makes use of the short-circuit evaluation supported by NAnt, so you can test for the existence of the file and check its length in the same expression. ( ie like C, NAnt will not evaluate the second part of an 'or' expression if the first evaluates to **true** )
    
5. Using expressions to conditionally execute tasks

    All tasks support *if*{: class="text-primary"} and *unless*{: class="text-primary"} attributes. Expressions can be used there to control which tasks get executed:
    ```xml
        <property name="myprj.basedir" value="c:\" unless="property::exists('myprj.basedir')" />
        <csc target="library" output="out.dll" ...
            if="${datetime::now() - file::get-last-write-time('out.dll')) > timespan::from-hours(1)}">
        ...
        </csc>
    ```
    This will rebuild the C# library only if it was last rebuilt more than an hour ago.


# Data types

Expressions can access, pass and return values of the following types:

| Type     |                          Allowed values                                                                    |
|----------|------------------------------------------------------------------------------------------------------------|
| int      | 32-bit signed integer value                                                                                |
| long     | 64-bit signed integer value                                                                                |
| double   | 64-bit signed double precision floating point value                                                        |
| boolean  | true or false                                                                                              |
| string   | strings of characters of any length.                                                                       |
| datetime | values represeting date & time (range is from 00:00:00, January 1, 1 AD to 23:59:59, December 31, 9999 AD) |
| timespan | represents a time interval.                                                                                |
| version  | represents a version number consisting of two to four components.                                          |

In addition, the expression evaluation engine allows you to return and pass values of any CLI type through the use of [custom functions](http://nant.sourceforge.net/release/latest/help/fundamentals/functions.html#custom). Note that there's no support for implicit type conversions.


# Operators

## Operator precedence

NAnt expressions support standard ( c style ) operator precedence, that we're accustomed to:

* *and*{: class="text-primary"} is evaluated before *or*{: class="text-primary"}, left to right. For example *false or true and true and false*{: class="text-primary"} evaluates as *false or ((true and true) and false)*{: class="text-primary"}
* multiplication,division and modulus are evaluated before addition and subtraction, left to right. For example *1 + 2 * 3 / 4*{: class="text-primary"} evaluates as *1 + ((2 * 3) / 4)*{: class="text-primary"}
* parentheses can be used to override the default operator precedence. For example *(1 + 2) * 3*{: class="text-primary"} evaluates as written, even though the multiplication has precedence over addition

**NOTE:** Because NAnt supports properties whose names can contain dashes, there's a possible ambiguity between the subtraction of two properties and accessing a single property with a name containing a dash:      
*aaa-bbb*{: class="text-primary"} - this is ambiguous. It could either be property "*aaa*{: class="text-primary"} MINUS property *bbb*{: class="text-primary"}" or property "*aaa-bbb*{: class="text-primary"}".{: class="bg-info"}

To avoid confusion, it's recommended to surround the subtraction operator (or even better, all binary operators) with spaces. The expression *aaa - bbb*{: class="text-primary"} always evaluates as a subtraction.

## Operators on Numeric Values

The following operators are supported on numeric values:
* \+ operator
* \- operator
* \* operator
* / operator
* % operator
* == operator
* \!= operator
* \> operator
* \>= operator
* < operator
* <= operator
* unary plus
* unary minus (negation)


### Add

**Summary**

Returns the arithmetic sum of its operands.

**Operands**

| Left Operand | Right Operand |                          Example                                                                |
|--------------|---------------|-------------------------------------------------------------------------------------------------|
| int          | int           |                          1 + 5 evaluates to 6                                                   |
| int          | long          |                          1 + 6666666667 evaluates to 6666666668                                 |
| int          | double        |                          1 + 5.0 evaluates to 6.0                                               |
| long         | long          |                          6666666667 + 11111111111 evaluates to 17777777778                      |
| long         | int           |                          6666666667 + 1 evaluates to 6666666668                                 |
| long         | double        |                          6666666667 + 1.5 evaluates to 6666666668.5                             |
| double       | double        |                          1.5 + 5.0 evaluates to 6.5                                             |
| double       | int           |                          1.0 + 5 evaluates to 6.0                                               |
| double       | long          |                          1.5 + 6666666667 evaluates to 6666666668.5                             |


### Subtract

**Summary**

Returns the arithmetic difference of its operands.

**Operands**

| Left Operand | Right Operand |                          Example                                                               |
|--------------|---------------|------------------------------------------------------------------------------------------------|
|      int     |      int      |                          5 - 1 evaluates to 4                                                  |
|      int     |      long     |                          5 - 6666666667 evaluates to -6666666662                               |
|      int     |     double    |                          5.0 - 1 evaluates to 4.0                                              |
|     long     |      long     |                          11111111111 - 6666666667 evaluates to 4444444444                      |
|     long     |      int      |                          6666666667 - 5 evaluates to 6666666662                                |
|     long     |     double    |                          6666666667 - 1.5 evaluates to 6666666665.5                            |
|    double    |     double    |                          5.0 - 1.0 evaluates to 4.0                                            |
|    double    |      int      |                          5.0 - 1 evaluates to 4.0                                              |
|    double    |      long     |                          1.5 - 6666666667 evaluates to -6666666665.5                           |


### Multiply

**Summary**

Returns the arithmetic product of its operands.

**Operands**

| Left Operand | Right Operand |                          Example                                                                     |
|--------------|---------------|------------------------------------------------------------------------------------------------------|
|      int     |      int      |                          5 * 2 evaluates to 10                                                       |
|      int     |      long     |                          2 * 6666666667 evaluates to 13333333334                                     |
|      int     |     double    |                          5 * 2.0 evaluates to 10.0                                                   |
|     long     |      long     |                          6666666667 * long::parse('2') evaluates to 13333333334                      |
|     long     |      int      |                          6666666667 * 2 evaluates to 13333333334                                     |
|     long     |     double    |                          6666666667 * 1.7 evaluates to 11333333333.9                                 |
|    double    |     double    |                          5.0 * 2.0 evaluates to 10.0                                                 |
|    double    |      int      |                          5.0 * 2 evaluates to 10.0                                                   |
|    double    |      long     |                          1.7 * 6666666667 evaluates to 11333333333.9                                 |

### Divide

**Summary**

Returns the arithmetic quotient of its operands.

**Operands**

| Left Operand | Right Operand |                          Example                                                          |
|--------------|---------------|-------------------------------------------------------------------------------------------|
|      int     |      int      |                          10 / 2 evaluates to 5                                            |
|      int     |      long     |                          10 / 10000000000 evaluates to 0.000000001                        |
|      int     |     double    |                          8 / 2.0 evaluates to 4.0                                         |
|     long     |      long     |                          13333333334 / 6666666667 evaluates to 2                          |
|     long     |      int      |                          13333333334 / 2 evaluates to 6666666667                          |
|     long     |     double    |                          13333333334 / 2.0 evaluates to 6666666667.0                      |
|    double    |     double    |                          9.0 / 2.0 evaluates to 4.5                                       |
|    double    |      int      |                          6.0 / 3 evaluates to 2.0                                         |
|    double    |      long     |                          20000000000.0 / 10000000000 evaluates to 2.0                     |

**Remarks**

If the divisor is zero, then an error is raised.


### Mod

**Summary**

Returns the remainder after dividing its first operand by its second.

**Operands**

| Left Operand | Right Operand |                          Example                                                      |
|--------------|---------------|---------------------------------------------------------------------------------------|
|      int     |      int      |                          5 % 3 evaluates to 2                                         |
|      int     |      long     |                          10 % 6666666667 evaluates to 10                              |
|      int     |     double    |                          5 % 3.5 evaluates to 1.5                                     |
|     long     |      long     |                          13333333334 % 6666666667 evaluates to 0                      |
|     long     |      int      |                          6666666667 % 10 evaluates to 7                               |
|     long     |     double    |                          6666666667 % 3.5 evaluates to 3.0                            |
|    double    |     double    |                          9.0 % 4.7 evaluates to 4.3                                   |
|    double    |      int      |                          8.5 % 2 evaluates to 0.5                                     |
|    double    |      long     |                          20000000000.0 % 6666666667 evaluates to 6666666666.0         |

**Remarks**

If the divisor is zero, then an error is raised.


### Equal

**Summary**

Returns true if and only if the value of the first operand is equal to the value of the second operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                           |
|--------------|---------------|--------------------------------------------------------------------------------------------|
|      int     |      int      |                          5 == 3 evaluates to false                                         |
|      int     |      long     |                          5 == 6666666667 evaluates to false                                |
|      int     |     double    |                          6 == 6.0 evaluates to true                                        |
|     long     |      long     |                          6666666667 == 6666666667 evaluates to true                        |
|     long     |      int      |                          6666666667 == 665 evaluates to false                              |
|     long     |     double    |                          6666666667 == 6666666667.0 evaluates to true                      |
|    double    |     double    |                          9.5 == 6.7 evaluates to false                                     |
|    double    |      int      |                          8.5 == 8 evaluates to false                                       |
|    double    |      long     |                          8.5 == 6666666667 evaluates to false                              |


### Inequal

**Summary**

Returns true if and only if the value of the first operand is not equal to the value of the second operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                            |
|--------------|---------------|---------------------------------------------------------------------------------------------|
|      int     |      int      |                          5 != 3 evaluates to true                                           |
|      int     |      long     |                          5 != 6666666667 evaluates to true                                  |
|      int     |     double    |                          6 != 6.0 evaluates to false                                        |
|     long     |      long     |                          6666666667 != 6666666667 evaluates to false                        |
|     long     |      int      |                          6666666667 != 665 evaluates to true                                |
|     long     |     double    |                          6666666667 != 6666666667.0 evaluates to false                      |
|    double    |     double    |                          9.5 != 6.7 evaluates to true                                       |
|    double    |      int      |                          8.5 != 8 evaluates to true                                         |
|    double    |      long     |                          8.5 != 6666666667 evaluates to true                                |


### Greater than

**Summary**

Returns true if and only if the first operand is greater than the second operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                           |
|--------------|---------------|--------------------------------------------------------------------------------------------|
|      int     |      int      |                          5 > 3 evaluates to false                                          |
|      int     |      long     |                          5 > 6666666667 evaluates to false                                 |
|      int     |     double    |                          6 > 4.0 evaluates to true                                         |
|     long     |      long     |                          6666666667 > 6666666667 evaluates to false                        |
|     long     |      int      |                          6666666667 > 665 evaluates to true                                |
|     long     |     double    |                          6666666667 > 6666666667.0 evaluates to false                      |
|    double    |     double    |                          9.5 > 9.5 evaluates to false                                      |
|    double    |      int      |                          8.3 > 9 evaluates to false                                        |
|    double    |      long     |                          8.5 > 6666666667 evaluates to false                               |


### Greater than or equal

**Summary**

Returns true if and only if the first operand is greater than or equal to second operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                           |
|--------------|---------------|--------------------------------------------------------------------------------------------|
|      int     |      int      |                          5 >= 3 evaluates to false                                         |
|      int     |      long     |                          5 >= 6666666667 evaluates to false                                |
|      int     |     double    |                          6 >= 4.0 evaluates to true                                        |
|     long     |      long     |                          6666666667 >= 6666666667 evaluates to true                        |
|     long     |      int      |                          6666666667 >= 665 evaluates to true                               |
|     long     |     double    |                          6666666667 >= 6666666667.0 evaluates to true                      |
|    double    |     double    |                          9.5 >= 9.5 evaluates to true                                      |
|    double    |      int      |                          8.3 >= 9 evaluates to false                                       |
|    double    |      long     |                          8.5 >= 6666666667 evaluates to false                              |


### Less than

**Summary**

Returns true if and only if the first operand is less than the second operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                           |
|--------------|---------------|--------------------------------------------------------------------------------------------|
|      int     |      int      |                          5 < 3 evaluates to false                                          |
|      int     |      long     |                          5 < 6666666667 evaluates to true                                  |
|      int     |     double    |                          6 < 7.0 evaluates to true                                         |
|     long     |      long     |                          6666666667 < 6666666667 evaluates to false                        |
|     long     |      int      |                          6666666667 < 665 evaluates to false                               |
|     long     |     double    |                          6666666667 < 6666666667.0 evaluates to false                      |
|    double    |     double    |                          9.5 < 9.5 evaluates to false                                      |
|    double    |      int      |                          8.3 < 9 evaluates to true                                         |
|    double    |      long     |                          8.5 < 6666666667 evaluates to true                                |


### Less than or equal

**Summary**

Returns true if and only if the first operand is less than or equal to second operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                           |
|--------------|---------------|--------------------------------------------------------------------------------------------|
|      int     |      int      |                          5 <= 3 evaluates to false                                         |
|      int     |      long     |                          5 <= 6666666667 evaluates to true                                 |
|      int     |     double    |                          6 <= 7.0 evaluates to true                                        |
|     long     |      long     |                          6666666667 <= 6666666667 evaluates to true                        |
|     long     |      int      |                          6666666667 <= 665 evaluates to false                              |
|     long     |     double    |                          6666666667 <= 6666666667.0 evaluates to true                      |
|    double    |     double    |                          9.5 <= 9.5 evaluates to true                                      |
|    double    |      int      |                          8.3 <= 9 evaluates to true                                        |
|    double    |      long     |                          8.5 <= 6666666667 evaluates to true                               |


### Unary plus

**Summary**

Returns its operand with the sign unchanged. Semantically, this operation performs no operation.

**Operands**

| Operand |                          Example                                                    |
|---------|-------------------------------------------------------------------------------------|
| int     |                          (+1) evaluates to 1                                        |
| long    |                          (+6666666667) evaluates to 6666666667                      |
| double  |                          (+1.5) evaluates to 1.5                                    |

### Unary minus

**Summary**

Returns its operand with the sign reversed.

If the operand is positive, its negative is returned; if it is negative, its positive is returned.

**Operands**

| Operand |                          Example                                                     |
|---------|--------------------------------------------------------------------------------------|
| int     |                          (-1) evaluates to -1                                        |
| long    |                          (-6666666667) evaluates to -6666666667                      |
| double  |                          (-9.6) evaluates to -9.6                                    |


## Operators on Boolean Values

The following operators are supported on boolean values:
* == operator
* != operator
* \> operator
* \>= operator
* < operator
* <= operator
* and operator
* or operator


### Equal

**Summary**

Returns true if both operands are true or if both operands are false.

**Examples**


### Inequal

**Summary**

Returns true if the first operand is true and the second operand is false, or the first operand is false and the second operand is true.

**Examples**


### Greater than

**Summary**

Returns true if the first operand is true and the second operand is false; otherwise, returns false.

**Examples**


### Greater than or equal

**Summary**

Returns true if the first operand is true and the second operand is false, or both operands are either true or false.

**Examples**


### Less than

**Summary**

Returns true if the first operand is false and the second operand is true; otherwise, returns false.

**Examples**


### Less than or equal

**Summary**

Returns true if the first operand is false and the second operand is true, or both operands are either true or false.

**Examples**


### Logical and

**Summary**

Returns true if both operands are true, otherwise returns false.

**Examples**
```xml
<if test="${A and B}">
```


### Logical or

**Summary**

Returns true if either operand is true, otherwise returns false.

**Examples**
```xml
<if test="${A or B}">
```


## Operators on String Values

The following operators are supported on string values:
* \+ operator
* == operator
* != operator
* \> operator
* \>= operator
* < operator
* <= operator


### Concat

**Summary**

Returns the concatenation of both string operands.

**Examples**


### Equal

**Summary**

Returns true if the value of the left operand is the same as the value of the right operand.

**Remarks**

The comparison is case-sensitive and culture-insensitive.


### Inequal

**Summary**

Returns true if the value of the first operand is not the same as the value of the second operand.

**Remarks**

The comparison is case-sensitive and culture-insensitive.


### Greater than

**Summary**

Returns true if the first operand is greater than the seconds operand.

**Remarks**

The comparison is case-sensitive and culture-insensitive.


### Greater than or equal

**Summary**

Returns true if the first operand is greater than or equal to the seconds operand.

**Remarks**

The comparison is case-sensitive and culture-insensitive.


### Less than

**Summary**

Returns true if the first operand is less than the seconds operand.

**Remarks**

The comparison is case-sensitive and culture-insensitive.


### Less than or equal

**Summary**

Returns true if the first operand is less than or equal to the seconds operand.

**Remarks**

The comparison is case-sensitive and culture-insensitive.


## Operators on TimeSpan and DateTime Values

The following operators are supported on timespan and datetime values:
* \+ operator
* \- operator
* == operator
* != operator
* \> operator
* \>= operator
* < operator
* <= operator


### Add

**Summary**

Returns the result of adding the value of the left operand to the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                                                                                                                     |
|--------------|---------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|   datetime   |    timespan   |                          datetime::now() + timespan::from-days(10)                  evaluates to a datetime 10 days in the future                                                    |
|   timespan   |    timespan   |                          timespan::from-seconds(30) + timespan::from-minutes(10)    evaluates to a timespan representing a duratio of 10 minutes and 30 seconds                      |


### Subtract

**Summary**

Returns the result of subtracting the value of the right operand from the value of the left operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                                                                                                              |
|--------------|---------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|   datetime   |    datetime   |                          (datetime::now() + timespan::from-days(10)) - datetime::now          evaluates to a timespan representing a duration of 10 days                      |
|   datetime   |    timespan   |                          datetime::now() - timespan::from-days(3) evaluates                   to a datetime 3 days in the past                                                |
|   timespan   |    timespan   |                          timespan::from-minutes(15) - timespan::from-minutes(10) evaluates    to a timespan representing 5 minutes                                            |


### Equal

**Summary**

Returns true if the value of the left operand is the same as the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                                                                |
|--------------|---------------|---------------------------------------------------------------------------------------------------------------------------------|
|   datetime   |    datetime   |                          datetime::now() == (datetime::now() + timespan::from-days(10)) evaluates to false                      |
|   timespan   |    timespan   |                          timespan::from-seconds(30) == timespan::from-seconds(30) evaluates to true                             |


### Inequal

**Summary**

Returns true if the value of the left operand is not the same as the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                                                               |
|--------------|---------------|--------------------------------------------------------------------------------------------------------------------------------|
|   datetime   |    datetime   |                          datetime::now() != (datetime::now() + timespan::from-days(10)) evaluates to true                      |
|   timespan   |    timespan   |                          timespan::from-seconds(30) != timespan::from-seconds(30) evaluates to false                           |


### Greater than

**Summary**

Returns true if the value of the left operand is greater than the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                                                               |
|--------------|---------------|--------------------------------------------------------------------------------------------------------------------------------|
|   datetime   |    datetime   |                          datetime::now() > (datetime::now() + timespan::from-days(10)) evaluates to false                      |
|   timespan   |    timespan   |                          timespan::from-seconds(30) > timespan::from-seconds(30) evaluates to false                            |


### Greater than or equal

**Summary**

Returns true if the value of the left operand is greater than or equal to the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                                                                |
|--------------|---------------|---------------------------------------------------------------------------------------------------------------------------------|
|   datetime   |    datetime   |                          datetime::now() >= (datetime::now() + timespan::from-days(10)) evaluates to false                      |
|   timespan   |    timespan   |                          timespan::from-seconds(30) >= timespan::from-seconds(30) evaluates to true                             |


### Less than

**Summary**

Returns true if the value of the left operand is less than the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                                                              |
|--------------|---------------|-------------------------------------------------------------------------------------------------------------------------------|
| datetime     | datetime      |                          datetime::now() < (datetime::now() + timespan::from-days(10)) evaluates to true                      |
| timespan     | timespan      |                          timespan::from-seconds(30) < timespan::from-seconds(30) evaluates to false                           |


### Less than or equal

**Summary**

Returns true if the value of the left operand is less than the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                                                               |
|--------------|---------------|--------------------------------------------------------------------------------------------------------------------------------|
| datetime     | datetime      |                          datetime::now() <= (datetime::now() + timespan::from-days(10)) evaluates to true                      |
| timespan     | timespan      |                          timespan::from-seconds(30) <= timespan::from-seconds(30) evaluates to true                            |


## Operators on Version Values

The following operators are supported on version values:
* == operator
* != operator
* \> operator
* \>= operator
* < operator
* <= operator


### Equal

**Summary**

Returns true if the value of the left operand is the same as the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                          |
|--------------|---------------|-------------------------------------------------------------------------------------------|
|    version   |    version    |                          version::parse('1.2') == version::parse('1.2') evaluates to true |


### Inequal

**Summary**

Returns true if the value of the left operand is not the same as the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                            |
|--------------|---------------|---------------------------------------------------------------------------------------------|
| version      | version       |                          version::parse('1.2') != version::parse('1.3.1') evaluates to true |


### Greater than

**Summary**

Returns true if the value of the left operand is greater than the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                            |
|--------------|---------------|---------------------------------------------------------------------------------------------|
| version      | version       |                          version::parse('1.2') > version::parse('1.3.1') evaluates to false |


### Greater than or equal

**Summary**

Returns true if the value of the left operand is greater than or equal to the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                          |
|--------------|---------------|-------------------------------------------------------------------------------------------|
| version      | version       |                          version::parse('1.2') >= version::parse('1.2') evaluates to true |


### Less than

**Summary**

Returns true if the value of the left operand is less than the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                           |
|--------------|---------------|--------------------------------------------------------------------------------------------|
| version      | version       |                          version::parse('1.2') < version::parse('1.3.1') evaluates to true |


### Less than or equal

**Summary**

Returns true if the value of the left operand is less than or equal to the value of the right operand.

**Operands**

| Left Operand | Right Operand |                          Example                                                          |
|--------------|---------------|-------------------------------------------------------------------------------------------|
| version      | version       |                          version::parse('1.2') <= version::parse('1.2') evaluates to true |
