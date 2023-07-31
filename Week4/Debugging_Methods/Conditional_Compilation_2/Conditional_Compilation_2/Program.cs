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
            #else
                Console.WriteLine("No detected mode")
            #endif
            Console.ReadLine();
        }
    }
}