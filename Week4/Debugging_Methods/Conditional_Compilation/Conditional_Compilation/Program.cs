#define CONDITION1
namespace Conditional_Compilation;

class Program
{
    static void Main(string[] args)
    {
        #if CONDITION1
            Console.Write("CONDITION1 ");
        #elif CONDITION2
            Console.Write("CONDITION2 ");
        #elif CONDITION3
            Console.Write("CONDITION3 ");
        #elif CONDITION4
            Console.Write("CONDITION4 ");
        #else
            Console.Write("NO_CONDITION ");
        #endif
        Console.WriteLine("Lain-Lain");
    }
}