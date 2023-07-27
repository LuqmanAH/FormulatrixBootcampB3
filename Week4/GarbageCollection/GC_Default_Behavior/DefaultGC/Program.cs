using System.Diagnostics;

public class TreasureBox
{
    private static int _InitialID = 0;
    private int _TreasureBoxID;
    private int _money;
    private int _jewelery;

    public TreasureBox(int _money, int _jewelery)
    {
        _InitialID ++;
        this. _money = _money;
        this._jewelery = _jewelery;
        _TreasureBoxID = _InitialID;

        Console.WriteLine($"Treasure created worth of {_money + _jewelery}");
    }
}

public class Program
{
    public static void Main()
    {
        Stopwatch stopwatch= Stopwatch.StartNew();
        GenerateTreasureBoxes();// * Keluar dari line ini, instances yang di define sudah tidak relevan
                                // * Automatic Garbage disposal by GC, no explicit declaration required
                                // ! Auto disposal: Wait gen 0 heap full
        Console.WriteLine($"yaaa kira-kira: {stopwatch.Elapsed}");
        Console.Read();
    }

    static void GenerateTreasureBoxes()
    {
        TreasureBox myTreasureBox1 = new TreasureBox(69,100);
        TreasureBox myTreasureBox2 = new TreasureBox(69,100);
        TreasureBox myTreasureBox3 = new TreasureBox(69,100);
        TreasureBox myTreasureBox4 = new TreasureBox(69,100);
        TreasureBox myTreasureBox5 = new TreasureBox(69,100);
        TreasureBox myTreasureBox6 = new TreasureBox(69,100);
        TreasureBox myTreasureBox7 = new TreasureBox(69,100);
        TreasureBox myTreasureBox8 = new TreasureBox(69,100);
        TreasureBox myTreasureBox9 = new TreasureBox(69,100);
        TreasureBox myTreasureBox = new TreasureBox(69,100);
    }

}