# Uninitialized Property Access in C#

This example demonstrates a common error in C#: accessing a property before it's been assigned a value.  In C#, properties default to their default value (e.g., 0 for integers, null for reference types) if not explicitly initialized.  Accessing them before assignment might not immediately reveal an error, but it can lead to unexpected behavior or exceptions later in your program, especially if you are not expecting the default value.  This is particularly problematic in multithreaded environments.

**The Issue:**

The `MyProperty` is accessed in `MyMethod` before a value has been assigned to it.  This will result in the default value (0 for integers) being printed.  While this might not cause a crash in this simple example, in more complex situations this can lead to logic errors or exceptions. 

**The Solution:**

Always initialize your properties explicitly if they are not assigned during object instantiation to ensure that they are correctly initialized before being accessed. Alternatively, consider using null-conditional operators or other techniques to handle potential null values if appropriate.