namespace SquareMatrix;

public class Program
{
    public static void Main(string[] args)
    {
        SquareIdenticalMatrix sim = new SquareIdenticalMatrix(5);// >
        SquareIdenticalMatrix sim2 = new SquareIdenticalMatrix(-98);// >
        Console.WriteLine(sim.ToString());
        sim2.Fill(6969);
        Console.WriteLine(sim2.ToString());
    }
}