class Program
{
    static readonly AutoResetEvent autoResetEvent = new AutoResetEvent(false);

    static async Task Main(string[] args)
    {
        Task[] tasks = new Task[5];

        for (int i = 0; i < 5; i++)
        {
            tasks[i] = DoWork(i);
        }

        await Task.Delay(1000);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Signalling..");
            autoResetEvent.Set();
            await Task.Delay(1000);
        }

        await Task.WhenAll(tasks);
        Console.WriteLine("Program Completed");
    }

    static async Task DoWork(int taskID)
    {
        Console.WriteLine($"Task {taskID} is waiting for auto reset event..");
        await Task.Run(() => autoResetEvent.WaitOne());

        Console.WriteLine($"Task {taskID} has received the signal");
        await Task.Delay(1000);

        Console.WriteLine($"Completed task {taskID}");
    }
}