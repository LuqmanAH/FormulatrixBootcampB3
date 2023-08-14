namespace EF_DB_First.Program;

public partial class Program
{
    static void SectionTitle(string title)
    {
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("*");
        Console.WriteLine($" {title}");
        Console.WriteLine("*");
        Console.ForegroundColor = prevColor;
    }

    static void Fail(string message)
    {
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor= ConsoleColor.DarkRed;
        Console.WriteLine($"Fail > {message}");
        Console.ForegroundColor = prevColor;
    }
    static void Info(string message)
    {
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor= ConsoleColor.Magenta;
        Console.WriteLine($"Info > {message}");
        Console.ForegroundColor = prevColor;
    }
    static void Printer(string message)
    {
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor= ConsoleColor.DarkGreen;
        Console.WriteLine($"{message}");
        Console.ForegroundColor = prevColor;
    }
    static string? GetInput()
    {
        return Console.ReadLine();
    }
}
