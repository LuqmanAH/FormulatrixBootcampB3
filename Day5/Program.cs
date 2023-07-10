namespace MainProgram;

class Program
{
    public static void Main()
    {
        ParentClass pClassNum = new(50);
        ParentClass xClassNum = pClassNum;
        xClassNum.xClass = 867686;
        Console.WriteLine("");

        ParentClass pClassWord = new("50");
        ParentClass xClassWord = pClassWord;
        xClassWord.yClass = "867686";
        Console.WriteLine("");

        ParentStruct pStructNum = new(50);
        ParentStruct xStructNum = pStructNum;
        xStructNum.xStruct = 867686;
        Console.WriteLine("");

        ParentStruct pStructWord = new("50");
        ParentStruct xStructWord = pStructWord;
        xStructWord.yStruct = "867686";
        Console.WriteLine("--------");

        Console.WriteLine(pClassNum.xClass);
        Console.WriteLine(xClassNum.xClass);
        Console.WriteLine("--------");

        Console.WriteLine(pClassWord.yClass);
        Console.WriteLine(xClassWord.yClass);
        Console.WriteLine("--------");

        Console.WriteLine(pStructNum.xStruct);
        Console.WriteLine(xStructNum.xStruct);
        Console.WriteLine("--------");

        Console.WriteLine(pStructWord.yStruct);
        Console.WriteLine(xStructWord.yStruct);
        Console.WriteLine("--------");

        Pair<int, string> pair1 = new(23, "twentyThree");
        Pair<int, string> pair2 = new(234, "twentyThreeFour");
        Console.WriteLine(pair1.Equals(pair2));
        Console.WriteLine($"{pair1.First} is written {pair1.Second}");

    }
}

class ParentClass
{
    public int xClass;
    public string yClass;
    public ParentClass(int xClass)
    {
        this.xClass = xClass;
    }
    public ParentClass(string yClass)
    {
        this.yClass = yClass;
    }
}

struct ParentStruct
{
    public int xStruct;
    public string yStruct;
    public ParentStruct(int xStruct)
    {
        this.xStruct = xStruct;
    }
    public ParentStruct(string yStruct)
    {
        this.yStruct = yStruct;
    }
}
public class Pair<T1, T2>
{
    public T1? First;
    public T2? Second;

    public Pair(T1 first, T2 second)
    {
        this.First = first;
        this.Second = second;
    }

    public bool Equals(Pair<T1, T2> other)
    {
        //! opo lah iki lur (Lib ghoib)
        return EqualityComparer<T1>.Default.Equals(First, other.First);
    }
}