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