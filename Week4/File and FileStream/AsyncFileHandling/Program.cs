using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string filePath = "puisi.txt";
        var sampleDelayTask = Task.Run(() => AsyncTask());

        string readContent = await ReadFileAsync(filePath);
        Console.WriteLine(readContent);

        await sampleDelayTask;
    }

    static async Task<String> ReadFileAsync(string filePath)
    {
        try
        {
            using(var streamReader = new StreamReader(filePath))
            {
                string contents = await streamReader.ReadToEndAsync();
                return contents;
            }
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine($"File {filePath} not found");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Could not open file {filePath} as error occured: {ex.Message}");
        }
        return string.Empty;
    }

    static async Task AsyncTask()
    {
        await Task.Delay(2000);
        Console.WriteLine("Task complete");
    }
}