using System;
using System.Xml.XPath;

namespace NumberRebase;

class Program
{
    static void Main(string[] args)
    {
        NumberRebase rebaser = new();
        // double result = rebaser.AnyToBase10(3, 12);
        // Console.WriteLine(result);
		// double backAgain = rebaser.DecToAny(5, result);
		// Console.WriteLine(backAgain);
		double daBoi = rebaser.Rebase(3, 5, 12);
		Console.WriteLine(daBoi);
    }
}

class NumberRebase
{
    public double Rebase(double initBase, double toBase, int inputNum)
	{
		double decEquivalent = AnyToBase10(initBase, inputNum);
		double result = DecToAny(toBase, decEquivalent);
		return result;
	}
    private static double AnyToBase10(double initBase, int inputNum)
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
			double newDigit = digit * Math.Pow(initBase, index);
			y += newDigit;
			digitsReady.Add(newDigit);
		}
        return y;
    }

	private static double DecToAny(double toBase, double inputNum)
	{
		List<double> anyDigits = new List<double>();
		if (inputNum == 0)
		{
			return 0;
		}
		while (inputNum > 0)
		{
			anyDigits.Add(inputNum % toBase);
			inputNum = Math.Floor(inputNum / toBase);
		}
		anyDigits.Reverse();
		string temp = string.Join("", anyDigits);
		return double.Parse(temp);
	}
}