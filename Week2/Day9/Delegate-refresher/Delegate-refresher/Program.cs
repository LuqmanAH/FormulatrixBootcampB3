public delegate int OperationDelegate (int x, int y);

public class Operation
{
    public static int AdditionOperation(int a, int b)
    {
        int res = a + b;
        return res;
    }
    public static int MultiplicationOperation(int c, int d)
    {
        int res = c * d;
        return res;
    }
}

public class Program
{
    static void Main (string[] args)
    {
        OperationDelegate opDelegate = new(Operation.AdditionOperation);
    
        Console.WriteLine(opDelegate(3,4));
        Console.WriteLine(opDelegate.Invoke(4,5));

        opDelegate -= Operation.AdditionOperation;
        opDelegate += Operation.MultiplicationOperation;
        Console.WriteLine(opDelegate(3,4));
        Console.WriteLine(opDelegate.Invoke(4,5));

        opDelegate = null;

    }
}