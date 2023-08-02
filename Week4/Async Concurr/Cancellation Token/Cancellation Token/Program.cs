class Program
{
    public static async Task Main()
    {
        CancellationTokenSource source = new CancellationTokenSource();

        var countDownTask = Task.Run(() => CountDown(30, source.Token));
        var userInput = Task.Run(() => UserInput(source));

        await countDownTask;
        Console.WriteLine("End of the Program...");
    }

    static async Task CountDown(int countDown, CancellationToken cancelToken)
    {
        for (int i = countDown; i >= 0; i--)
        {
            Console.Clear();
            Console.WriteLine($"Time Left: {i}");
            try
            {
                await Task.Delay(1000, cancelToken);
            }
            catch(TaskCanceledException)
            {
                Console.Clear();
                Console.WriteLine("Hero chosen, Commencing battle..");
                return;
            }
        }

        Console.WriteLine("Time Out, commencing battle...");
    }

    static async Task UserInput(CancellationTokenSource sourceCancel)
    {
        char? exitChar = new();
        while (exitChar != ' ')
        {
            exitChar = Console.ReadKey().KeyChar;

            if (exitChar == ' ')
            {
                sourceCancel.Cancel();
                return;
            }
        }

    }
}