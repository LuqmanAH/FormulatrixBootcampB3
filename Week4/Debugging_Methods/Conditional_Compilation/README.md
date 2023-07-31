# Conditional Compilation, Debug x Trace

Conditional compilation in C# allows you to include or exclude sections of code during the compilation process based on certain conditions. This feature is useful when you want to have different behavior or code for different build configurations.

## **1️⃣ #if, #else, #elif, #endif Directives**


```csharp
#define DEBUG 

using System;

namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            #if DEBUG
                Console.WriteLine("Debug mode");
            #else
                Console.WriteLine("Release mode");
            #endif
        }
    }
}
```


## **2️⃣ #warning and #error Directives**

You can also use the `#warning` directive to issue a warning message during compilation and the `#error` directive to generate a compilation error with a custom error message.


```csharp
#define TEST

using System;

namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            #if TEST
                #warning This is a test build
            #else
                #error Production build is not allowed
            #endif
        }
    }
}
```

In the example above, the `#warning` directive will generate a warning message when the `TEST` constant is defined, and the `#error` directive will cause a compilation error when the `TEST` constant is not defined.

## 3️⃣ Debug and Release

- Default C sharp setting would compile the main program code to its debug phase
- To release the code, we can explicitly declare in the terminal command `dotnet build -c "Release_Name"`.
- Access the release version of the code in comparison with the debug version can be done by visiting `.\bin\` associated with the project.
- defining a debug / release version of a code would result in a different behavior

```csharp
#define RELEASE 

using System;

namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            #if DEBUG
                Console.WriteLine("Debug mode");
            #elif RELEASE
                Console.WriteLine("Release mode");
            else
                Console.WriteLine("No detected mode")
            #endif
        }
    }
}
```

By default, the build shall create a debug version of the above code, meaning that even we explicitly define that we want to compile the code to run the release version of the code, we would get the debug version of the code to be run.

## 4️⃣ Debug and Trace C# Class

- Debug class used to help dev in performing debug to the code
- Trace class used to procedurally trace the execution of the code
- Debug statements **can not** be accessed by the release version of the code
- Both debug and trace statements would be printed in the **debug console**

```csharp
using System.Diagnostics;

namespace DebugTrace;

class Program
{
    static void Main()
    {
        int x = 8;
        int y = 10;
        int result = Add(8, 10);

        // Will be present in the debug console of the debug version
        Debug.WriteLine("Starting program...");
        Debug.WriteLine($"x = {x}");
        Debug.WriteLine($"y = {y}");

        // Will be the only stuff that present in the debug console of the release version
        Trace.WriteLine("Calculating x and y..");
        Trace.WriteLine($"result = {result}");
        Trace.WriteLine("");

        Debug.Assert(result == 18, "The sum should be 18");
        // Trace.Assert(result == 18, "The sum should be 18");
        Console.ReadLine();
    }

    static int Add(int a, int b)
    {
        return a * b;
    }
}
```

Handling message thru debug console wouldn't be a good option if this was a release version. Instead, we can introduce a new instance of a console trace listener to cast trace messages to the terminal.

```csharp
ConsoleTraceListener consoleTraceListener= new ConsoleTraceListener();
Trace.Listeners.Add(consoleTraceListener);
```

## 💡 Summary

Conditional compilation in C# allows you to control which sections of code are included or excluded during the compilation process based on specified conditions. Remember:

- Use `#if`, `#else`, `#elif`, and `#endif` to conditionally include or exclude blocks of code.
- Use `#warning` to issue a warning message and `#error` to generate a compilation error conditionally.
