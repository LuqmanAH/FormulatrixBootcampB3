class Program
{
    static SemaphoreSlim semaphore = new SemaphoreSlim(2);
    static async Task SharedResource(int taskID)
    {
        Console.WriteLine($"Task {taskID} wants to enter the ring to do some damage!");

        try
        {
            await semaphore.WaitAsync();
            Console.WriteLine($"Task {taskID} has entered semaphore to wreak havoc!");
            await Task.Delay(1000);
        }
        finally
        {
            semaphore.Release();
            Console.WriteLine($"Task {taskID} is leaving the semaphore!");
            await Task.Delay(1000);
        }
    }

    static async Task Main(string[] args)
    {
        Task[] tasks = new Task[5];

        for (int i = 0; i < 5; i++)
        {
            tasks[i] = SharedResource(i);
        }

        await Task.WhenAll(tasks);

        Console.WriteLine("\nCompleted Program");
    }
}