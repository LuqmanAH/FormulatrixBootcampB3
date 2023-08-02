# Concurrency and Asynchrony

  **Concurrenncy** => Run multiple task in the same time

  **Asynchrony** => Running at the same time

  **Synchrony** => Running procedurally (_default condition in main thread_)

  ---

- Achieved by Thread (_low level_) or task (_high level_)
- By the presence of the GC, C# runtime run 2 different threads by default. one main, the other for the GC purposes
- Implemented in C# using `Thread` class, started using its built-in method `start()`

```csharp
Thread t1 = new Thread(MyMethod);
Thread t2 = new Thread(MyOtherMethod);
```

- notable methods: `Start()`, `Join()`, `Sleep()`

```csharp
void Main()
{
 Thread T1 = new Thread(GR);
 Thread T2 = new Thread(P1);
 Thread T3 = new Thread(P2);
 
 T1.Start();
 T2.Start();
 T3.Start();
 
 T1.Join();
 T2.Join();
 T3.Join();
 
 Thread.Sleep(2000);
 Console.WriteLine("uWu");
}

void GR()
{
 Console.WriteLine("GR");
}

void P1()
{
 Console.WriteLine("P1");
}

void P2()
{
 Console.WriteLine("P2");
}
```

- **Start** => starts the method associated with the thread
- **Join** => wait the completion of associated thread
- **Sleep** => suspends the thread by the amount (_in miliseconds_)
  
---

- Threads has their own defined stack size, and can be explicitly defined by user
- Threads are foreground threads by default

## Task

- A higher order class that provides thread capability without the need to instantiate instances.
- Lighter resource requirements
- Invokes thread from a thread pool, no need new instances
- Thread pool configured by CPU based on the demand of the application

```csharp
using System.Threading.Tasks;

static void Main()
{
    Task task1 = Task.Run(Method1);
    task1.Wait();

    Console.WriteLine("Operation Complete");
}

static void Method1()
{
    Console.WriteLine("Uhuy");
}
```

Task can be invoked without the need of instance, but can't apply other methods such as wait, or access its properties.

```cs
Task.Run(() => Console.WriteLine("Foo"));
```

### Generic Task `Task <T>`

- when the function associated to the task returns value
- `<T>` define the task return type
- Task.Return is the property of the result value

### Main Thread Blocking

Methods such as:

- Task.Wait();
- Task.Delay();
- Thread.Join();
- Thread.Sleep();

Would completely stop main thread from running and should be avoided at all cost.

## Async - Await Modifier

- Labels used in C# to prevent main thread blocking but allows effective complex multithread allocation
- Prevent program freeze when program handles background tasks
  
---

- **Async** => make method asynchronous
- **await** => allow suspend of the current thread not blocking

```cs
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task backgroundTask = BackgroundProcess();

        while (!backgroundTask.IsCompleted)
        {
            Console.WriteLine("Mas monggo: ");
            string? usrInput = Console.ReadLine();

            Console.WriteLine($"you entered: {usrInput}");
            await Task.Delay(500);
        }

    }

    static async Task BackgroundProcess()
    {
        Console.WriteLine("Starting background computation..");

        await Task.Delay(10000);

        Console.WriteLine("Done!");
    }
}
```

- async modifier => notify the compiler to mark that method as asynchronous
- await => suspend process waiting a passed Task to be completed (_Task.IsCompleted_)

## Cancellation Token

- To prevent undefined instance in memory as a result of the `Thread.Abort()` method.
- A way to end a Task class instance safely, without drawbacks provided by `Abort()`

### **Cancellation Token**

- The _status_ of the Cancellation

### **Cancellation Token Source**

- Way to invoke Cancellation Token
- Way to alter the _status_ of the Token
- When the _status_ is set `true` the corresponding thread will terminate and change to the thread that calls / invoke the token

## DeadLock Scenario

- Condition where two different threads has dependency on each other
- The dependant field or variable is not provided by any of the thread

## Racing Condition

- Condition where two different active threads modify / handle one similar variable
- These threads require to apply different operation to the variable such that the value of the variable can not be determined
- Important when the real-time changes of a variable handled by thread is monitored
- Can be solved in C# by using the `lock` or `monitor` to encapsulate variable
- or use thread signaling methods