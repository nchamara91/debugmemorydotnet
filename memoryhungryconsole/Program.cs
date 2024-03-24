using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Starting memory hungry...");
        Timer timer = new Timer(IncreaseMemoryUsage, null, TimeSpan.Zero, TimeSpan.FromMinutes(5));

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        
    }

    static void IncreaseMemoryUsage(object state)
    {
        // Allocate 100MB of memory
        byte[] buffer = new byte[100 * 1024 * 1024];
        Console.WriteLine("Increased memory usage by 100MB");
    }
}