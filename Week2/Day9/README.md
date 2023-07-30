# Day 9 Key Takeaways

The Confusion duo of C#: Delegate and Events

## Lessons Learned

### Terms to tackle before moving on

- ***Event*** = Events can be thought as a notification or message that goes out from an object or end user in C#
  
- ***Event Raiser*** = Objects or code block that sends out message or notification
  
- ***Event Args*** = Information related to the event that integrated within the notification that goes out from event raiser
  
- ***Event Handler*** = Listener to the messages that being sent from event raiser, has its own logic to treat the event args
  
- ***Delegate*** = Pipeline to connect between event raisers and event handlers

The relation between those terms can be summed up beautifully in this illustration (ref: dotnettutorials).

![delegate process](/Week2/Day9/images/wholeprocess.webp)

- Here the button acts as the Event raiser, well it's actually just a connector to the actual end user event raiser with the program.
- A click to the button will be considered as an event, 
- thus each time the button is clicked, a set of event args is passed to a defined delegate pipeline
- delegate will send the event args to its respective listeners or event handlers (*yes, there could be more than one listener. In fact its ability to implement multiple listeners was the main reason this thing is used in the first place*)

The part that makes all of this concept harder to get around the head is that in C#, **everything** is an object instance. Even its built-in stuffs. 

This means when instantiating a delegate, we would create an instance of a delegate class that comes with a handy name of `System.MulticastDelegate`.

### Embracing the confusing delegates

Assume a program class that has one method to add 2 integers

```csharp
partial class Program
{
    static int Addition(int x, int y)
    {
        return x + y;
    }
}
```

We then define a delegate that could handle methods with similar format as `program.Addition` (*receives excatly 2 integers as arguments and returns integer type*).

```csharp
public delegate int Operation(int x, int y);
```

Note that delegates has similar hierarchy as classes in C# thus we define the delegate outside of the `partial class program` but in similar namespace (*this is optional but this is my assumption when implementing this example tho*)

The defined delegate is now ready to be implemented inside our main program

```csharp
partial class Program
{
    static void Main()
    {
        Operation obj = new Operation(Program.Addition);
        Console.WriteLine("Addition of 3 and 4 is: {0}", obj(3,4);)
    }
}
```

By *inserting* our static method to the delegate, invoking the instance of the delegate followed with arguments similar to what we pass to the method itself would return the value of the method.

### Different Ways to Assign Method to Delegate

The key consideration when assigning a method to delegate is that the method should have the same signature as the delegate.

The 'signature' can be comprehended by examining the example below

```csharp
public delegate int OperationDelegate (int x, int y);

public class Operation
{
    public int AdditionOperation(int a, int b)
    {
        return a + b;
    }
}
```

The delegate `OperationDelegate` has similar signature with `AdditionOperation` of the `Operation` class. This is because both has the same access modifier, return value type and parameters type, and also the number of parameters required by the method.

Assignment of `AdditionOperation` to the delegate can be done by explicitly inserting the method when creating the instance of the delegate

```csharp
public delegate int OperationDelegate (int x, int y);

public class Operation
{
    public static int AdditionOperation(int a, int b)
    {
        int res = a + b;
        return res;
    }
    public static int MultiplicationOperation(int c, int d)
    {
        int res = c * d;
        return res;
    }
}

public class Program
{
    static void Main (string[] args)
    {
        OperationDelegate opDelegate = new(Operation.AdditionOperation);
    
        Console.WriteLine(opDelegate(3,4));
        Console.WriteLine(opDelegate.Invoke(4,5));

        opDelegate -= Operation.AdditionOperation;
        opDelegate += Operation.MultiplicationOperation;
        Console.WriteLine(opDelegate(3,4));
        Console.WriteLine(opDelegate.Invoke(4,5));

        opDelegate = null;

    }
}
```

Method assigned to the delegate is known as **Handler Method**.This handler method is invoked whenever the variable of the delegate is called with the required arugments or by using its built in method `Invoke()`.

Methods encapsulated by the instance of delegate can further be modified by using `-=` and `+=` to remove or add methods respectively.

Multiple methods assignment to an instance of delegate is possible and introduce a unique behavior but will be discussed in depth in the following materials.

Observe how we can nullify the content of delegates by explicitly assign a null value to the variable.

### Callback Delegate

what happens when you pass a delegate object as an argument of one method?

basically you are giving the said method flexibility in which the method now has the ability to call other methods that the delegate provided point to. we can invoke this other methods at any point inside the first method definition.

we commonly describe this as **Callback Delegate**.

```csharp
public delegate void Caller(string message);

public class Example
{
    public static void ProcessManager(string message, Caller callback)
    {
        //* the way you would invoke the caller fully depends on how you want the behavior of the caller delegate
        
        Console.WriteLine($"Sedang diProses: {message}");
        callback("uhuy"); 
        Console.WriteLine($"Sedang diProses: {message} kedua");
        callback("ihiy");
        callback("ahoy");
    }

    public static void CallbackDisplayer(string callbackArgs)
    {
        Console.WriteLine($"Callback Received: {callbackArgs}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Caller callbackDelegate = new Caller(Example.CallbackDisplayer);

        Example.ProcessManager("The Anget", callbackDelegate);
    }
}
```

I know the above example is dumpster fire. but the key takeaway is that the `ProcessManager` method has full control over the Caller delegate object and how it would behave inside the definition of the `ProcessManager` method.

`ProcessManager` is abstracted by what methods the `Caller` object is currently points to. it actually doesn't give a damn.
### Array of Delegates

This operation emphasizes the ability of delegate to be instantiated as an array just like other types in C#

```csharp
public class Operation
{
    public static void Add(int a, int b)
    {
        Console.WriteLine("Addition={0}",a + b);
    }

    public static void Multiple(int a, int b)
    {
        Console.WriteLine("Multiply={0}", a * b);
    }
}

class Program
{
    delegate void DelOp(int x, int y);

    static void Main(string[] args)
    {
        // Delegate instantiation
        DelOp[] obj =
        {
            new DelOp(Operation.Add),
            new DelOp(Operation.Multiple)
        };

        for (int i = 0; i < obj.Length; i++)
        {
            obj[i](2, 5);
            obj[i](8, 5);
            obj[i](4, 6);
        }
        Console.ReadLine();
    }
}
```

Here the instance creation of delegates are assigned to the array of delegates. The addition operation is executed based on the order of the array assignment.

Observe how in this example we have to create multiple delegate instances rather than implementing multiple methods to a single delegate. The latter could be a better option when memory resource is limited and multiple methods are required to be associated with this delegate.

In contrast, the former could be used when you require to perform two methods that have a different signature in succession

### Multicast Delegate

A single delegate instance can be used to store multiple methods to invoke by the first in first out configuration.
