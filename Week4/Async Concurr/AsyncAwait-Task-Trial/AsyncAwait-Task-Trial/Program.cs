using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task userInput = UserInput();
        await Task.WhenAny(userInput, Task.Delay(5000));
        Console.WriteLine("Time out, begining battle");

    }

    // static async Task BackgroundProcess()
    // {
    //     Console.WriteLine("Starting background computation..");

    //     await Task.Delay(10000);

    //     Console.WriteLine("Done!");
    // }

    static async Task UserInput()
    {
        while (true)
        {
            Console.WriteLine("Mas monggo: ");
            string? usrInput = Console.ReadLine(); //! nyangkut bos

            Console.WriteLine($"you entered: {usrInput}");
            await Task.Delay(500);
        }
    }
}