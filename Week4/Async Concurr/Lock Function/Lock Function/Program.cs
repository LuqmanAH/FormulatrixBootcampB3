class TaskSafeQueue<T>
{
    private readonly object lockObject = new object();
    private Queue<T> queue = new Queue<T>();

    public void Enqueue(T item)
    {
        lock (lockObject)
        {
            queue.Enqueue(item);
            Console.WriteLine($"Success Enqueued: {item}");
        }
    }

    public T? Dequeue()
    {
        lock(lockObject)
        {
            if (queue.Count > 0)
            {
                T item = queue.Dequeue();
                Console.WriteLine($"Dequeued: {item}");
                return item;
            }
            return default;
        }
    }
}

class Program
{
    static void ProduceIntQueue(TaskSafeQueue<int> queue)
    {
        for (int i = 0; i < 10; i ++)
        {
            queue.Enqueue(i);
        }
    }

    static void ConsumeIntQueue(TaskSafeQueue<int> queue)
    {
        for (int i = 0; i < 10; i ++)
        {
            int item = queue.Dequeue();
        }
    }
    
    static async Task Main(string[] args)
    {
        TaskSafeQueue<int> taskSafeQueue = new TaskSafeQueue<int>();

        Task enqueueTask = Task.Run(() => ProduceIntQueue(taskSafeQueue));
        await enqueueTask;
        Task dequeueTask = Task.Run(() => ConsumeIntQueue(taskSafeQueue));

        await Task.WhenAll(enqueueTask, dequeueTask);
        Console.WriteLine("Ingfo aman ges");
    }
}