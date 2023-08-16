namespace CompositeDesignPattern;

partial class Program
{
    static void Main(string[] args)
    {

    }

    static void Display<T>(T value)
    {
        ConsoleColor prevColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(value);
    }

}