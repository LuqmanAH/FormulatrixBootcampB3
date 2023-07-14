using System;

namespace Enumerator_Op_Overload;

public class Program
{
    public static void Main(string[] args)
    {
        Complex complex1 = new(4, 3);
        Complex complex2 = new(6, -7);

        complex1.Display();    
        complex2.Display();
        Console.WriteLine("-----------------");

        // overload operator
        Console.WriteLine(complex1 + complex2);
        Console.WriteLine(complex1 + complex2);
        Console.WriteLine("-----------------");

        //method
        Complex complex3 = Complex.AddComplex(complex1, complex2);

        // overloading
        Complex complex4 = complex1 + complex2;

        complex3.Display();    
        complex4.Display();
        Console.WriteLine("-----------------");

        //ambil komponen imaginary
        int complex3Real = Complex.AddPart(complex1, complex2, 2);

        //ambil komponen real
        int complex3Imag = Complex.AddPart(complex1, complex2);

        Console.WriteLine(complex3Imag);
        Console.WriteLine(complex3Real);
        Console.WriteLine("-----------------");

        Console.ReadLine();
    }
}