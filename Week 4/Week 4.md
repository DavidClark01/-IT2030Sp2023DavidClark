Compiler Error CS1002
; expected

The compiler detected a missing semicolon. A semicolon is required at the end of every statement in C#. A statement may span more than one line.

Fixed by adding a semicolon

Compiler Error CS0103
The name 'identifier' does not exist in the current context

An attempt was made to use a name that does not exist in the class, namespace, or scope. Check the spelling of the name and check your using directives and assembly references to make sure that the name that you are trying to use is available.

This error frequently occurs if you declare a variable in a loop or a try or if block and then attempt to access it from an enclosing code block or a separate code block

Fixed by capitalizing the b in ViewBag

Compiler Error CS0161
'method': not all code paths return a value

A method that returns a value must have a return statement in all code paths.

Fixed by deleted the unnecessary Index line of code that was causing the error