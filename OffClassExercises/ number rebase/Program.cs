using System;

namespace NumberRebase;

class Program
{
    static void Main(string[] args)
    {
        NumberRebase rebaser = new();
        double result = rebaser.AnyToBase10(5, 10);
        Console.WriteLine(result);
    }
}

class NumberRebase
{
    
    public double AnyToBase10(double initbase, int inputNum)
    {
        double y = 0d;
		List<int> digits = new List<int>();
		List<double> digitsReady = new List<double>();
		
		do
		{
			int digit = inputNum % 10;
			digits.Add(digit);
            inputNum /= 10;

		}while(inputNum > 0);

		foreach (int digit in digits)
		{
			int index = digits.IndexOf(digit);
			double newDigit = digit * Math.Pow(initbase, index);
			y += newDigit;
			digitsReady.Add(newDigit);
		}
        return y;
    }
}