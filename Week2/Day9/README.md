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
