// See https://aka.ms/new-console-template for more information
namespace myDay1Program;
class Program
{
    static int MyInteger = 128;
    static float MyDecimal = 23.56F;
    static void Main(string[] args)
    {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("HOHOhO");
            Console.WriteLine(MyInteger);
            Console.WriteLine(MyDecimal);

            var x = message("HALO");
            Console.WriteLine(x);
    }

    static string message(string x)
    {
        return x;
    }
}