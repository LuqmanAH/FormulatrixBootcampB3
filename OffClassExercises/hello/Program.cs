// See https://aka.ms/new-console-template for more information
using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;

            Console.WriteLine("Write input x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine("Write input y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine("Multiplication result: ");
            result = Multiplication(x,y);
            // Console.Write("\n");

            Console.WriteLine(result);
            Console.ReadKey();
        }
        static double Multiplication(double x, double y)
        {
            double z = x * y;
            return z;
        }
    }
}