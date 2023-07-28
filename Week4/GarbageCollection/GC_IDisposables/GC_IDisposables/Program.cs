using System.Diagnostics;

public class TreasureBox : IDisposable
{
    private static int _InitialID = 0;
    private int _TreasureBoxID;
    private int _money;
    private int _jewelery;
    private bool _disposedValue;

    public TreasureBox(int _money, int _jewelery)
    {
        _InitialID ++;
        this. _money = _money;
        this._jewelery = _jewelery;
        _TreasureBoxID = _InitialID;

        Console.WriteLine($"Treasure created worth of {_money + _jewelery}");
    }


    protected virtual void Dispose(bool disposing)
    {
        //! todos written below used to prevent other from accessing destructed instance fields

        if (!_disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                Console.WriteLine($"Treasure {_TreasureBoxID} has been looted by the Disposer");
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            _disposedValue = true;
        }
    }

    ~TreasureBox()
    {
        Dispose(false); // * Supaya tidak bisa dispose
        Console.WriteLine($"Treasure {_TreasureBoxID} has been looted by the finalizer");
    }
    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~TreasureBox()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this); // * Supaya Tidak Invoke Finalizer
    }
}

public class Program
{
    public static void Main()
    {
        // Stopwatch stopwatch= Stopwatch.StartNew();
        GenerateTreasureBoxes();
        GC.Collect();
         // * GC dengan Finalizer (Tidak safe)
    
        TreasureBox programTreasure1 = new TreasureBox(78, 96);
        programTreasure1.Dispose(); //* GC dengan Dispose pattern

        // stopwatch.Stop();
        // Console.WriteLine($"yaaa kira-kira: {stopwatch.Elapsed}");
        
        Console.Read();
    }

    static void GenerateTreasureBoxes()
    {
        TreasureBox myTreasureBox1 = new TreasureBox(69,100);
        TreasureBox myTreasureBox2 = new TreasureBox(69,100);
        TreasureBox myTreasureBox3 = new TreasureBox(69,100);
        TreasureBox myTreasureBox4 = new TreasureBox(69,100);
        
    }

}