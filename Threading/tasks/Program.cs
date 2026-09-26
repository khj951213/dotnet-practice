namespace tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Start");

        var thread1 = DoWorkAsync();
        var thread2 = CountAsync(50);

        await thread1;
        await thread2;

        Console.WriteLine("Finished");
    }

    static async Task DoWorkAsync()
    {
        Console.WriteLine("[Thread-Pool-1] Working...");

        // this doesn't block the thread for two seconds. Instead, the method pauses and gives control back to the caller.
        // When the deply finishes, execution continues.
        await Task.Delay(2000);

        Console.WriteLine("Work completed");
    }

    static async Task CountAsync(int num)
    {
        Console.WriteLine("[Thread-Pool-2] Counting starts");
        for (int i = 1; i < num+1; i++)
        {
            Console.WriteLine($"[Thread-Pool-2] Counting: {i}.");
            await Task.Delay(1000);
        }
        Console.WriteLine($"[Thread-Pool-2] Counting Finished");
    }
}
