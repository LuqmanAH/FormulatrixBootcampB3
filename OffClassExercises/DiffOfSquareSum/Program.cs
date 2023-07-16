public class Program
{
    public static void Main(string[] args)
    {
        DifferenceOfSquares differ = new();
        Console.WriteLine(differ.CalculateSquareOfSum(3));
        Console.WriteLine(differ.CalculateSumOfSquares(3));
        Console.WriteLine(differ.CalculateDiffOfSquare(3));
    }
}

public class DifferenceOfSquares
{
    public int CalculateSquareOfSum(int max)
    {
        int temp = 0;
        for (int i = 1; i <= max; i++)
        {
            temp += i;
        }
        return temp * temp;
    }
    public int CalculateSumOfSquares(int max)
    {
        int tempSquared = 0;
        for (int i = 1; i <= max; i++)
        {
            tempSquared += i * i;
        }
        return tempSquared;
    }
    public int CalculateDiffOfSquare(int max)
    {
        int diff = CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
        return diff;
    }
}