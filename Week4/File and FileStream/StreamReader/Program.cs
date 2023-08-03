using System.IO;

class Program
{
    static async Task Main()
    {
        CancellationTokenSource source = new CancellationTokenSource();

        var ReadDelay = Task.Run(() => UserInput(source));
        var WriteDelay = Task.Run(() => UserInput(source));

        Console.WriteLine("==== Welcome! please read our beautiful poem ====");
        ReadAll("puisi.txt");
        Console.WriteLine("");
        Console.WriteLine("press spacebar key to continue");

        await ReadDelay;
        Console.Clear();
        Console.WriteLine("==== Let's Sing dangdut! ====");
        Writer("Dangdut.txt");
        ReadAll("Dangdut.txt");
        Console.WriteLine("");
        Console.WriteLine("press spacebar key to continue");
        
        await WriteDelay;
        Console.Clear();
        Console.WriteLine("==== Let's delete dangdut! ====");
        DeleteText("Dangdut.txt");
        Console.WriteLine("");
        Console.WriteLine("press spacebar key to close..");
        
        while (true)
        {
            if (Console.ReadKey().KeyChar == ' ')
            {
                break;
            }
        }

    }
    
    static void ReadAll(string filePath)
    {
        using(StreamReader streamReader = new StreamReader(filePath))
        {
            Console.WriteLine(streamReader.ReadToEnd());
        }
    }

    static void Writer(string filePath)
    {
        try
        {
            using (StreamWriter streamWriter = new StreamWriter(filePath))
            {
                streamWriter.WriteLine("Nganti ndangak ndangak mase");
                streamWriter.WriteLine("Aku kalah sak sembarangane");
                streamWriter.WriteLine("Trus piye Indonesia mase\n");
                streamWriter.WriteLine("Aku ninu ninu ninu");
                streamWriter.WriteLine("Yo ndak mampu aku");
                streamWriter.WriteLine("Nuruti karepmu");
            }
            Console.WriteLine($"Successfully written {filePath}");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Error when writing: " + ex.Message);
        }
    }

    static void DeleteText(string filePath)
    {
        try
        {
            FileInfo fileInfo = new FileInfo(filePath);
            fileInfo.Delete();
            Console.WriteLine($"Succesfully removed: {filePath}");
        }
        catch(IOException ex)
        {
            Console.WriteLine("Error occured while trying to delete file: " + ex.Message);
        }
    }

    static async Task UserInput(CancellationTokenSource source)
    {
        while (true)
        {
            if (Console.ReadKey().KeyChar == ' ')
            {
                source.Cancel();
                return;
            }
        }
    }
}