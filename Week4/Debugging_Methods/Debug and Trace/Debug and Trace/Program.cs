using System.Diagnostics;

namespace DebugTrace;

class Program
{
    static void Main()
    {
        ConsoleTraceListener consoleTraceListener= new ConsoleTraceListener();
        Trace.Listeners.Add(consoleTraceListener);
        int x = 8;
        int y = 10;
        int result = Add(8, 10);

        Debug.WriteLine("Starting program...");
        Debug.WriteLine($"x = {x}");
        Debug.WriteLine($"y = {y}");

        Trace.WriteLine("Calculating x and y..");
        Trace.WriteLine($"result = {result}");
        Trace.WriteLine("");

        Debug.Assert(result == 18, "The sum should be 18");
        Console.ReadLine();
    }

    static int Add(int a, int b)
    {
        return a * b;
    }
}