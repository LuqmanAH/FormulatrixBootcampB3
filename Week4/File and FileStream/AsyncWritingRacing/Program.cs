using System.IO;
using System.Security.AccessControl;
using System.Text;

class Program
{
    static SemaphoreSlim semaphore = new SemaphoreSlim(2);

    static async Task WriterOne(string filePath, int ID, string message)
    {
        try
        {
            await semaphore.WaitAsync();
            using (var fileWriter = new FileStream(filePath, FileMode.Create))
            {
                for (int i = 0; i < 10000; i++)
                {
                    byte[] data = Encoding.UTF8.GetBytes(message + "\n");
                    fileWriter.Write(data);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            semaphore.Release();
            Console.WriteLine($"Task {ID} is completed");
            await Task.Delay(1000);
        }
    }

    static void Reader(string filePath)
    {
        using (var streamReader = new StreamReader(filePath))
        {
            Console.WriteLine(streamReader.ReadToEnd());
        }
    }

    static async Task Main()
    {
        Task[] writeTasks = new Task[2];
        string filePath = "pesan.txt";

        writeTasks[0] = WriterOne(filePath, 1, "SALAM DARI BINJAI");
        writeTasks[1] = WriterOne(filePath, 2, "yamete senpai");

        await Task.WhenAll(writeTasks);
        Console.Clear();
        Reader(filePath);

    }
}