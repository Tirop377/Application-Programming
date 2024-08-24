using System;


/*The Thread class represents a thread in .NET and is part of the System.
 * Threading namespace.It allows you to create and control a thread directly, 
 * giving you fine-grained control over thread behavior(e.g., setting priorities, 
 * pausing, resuming, or aborting threads).
 * 
 * Usage Scenario:
 * Use the Thread class when you need low-level control over threading operations, 
such as when you need to manage threads manually or when dealing with legacy code 
that relies heavily on threads.
*/

using System.Threading;

public class Program1
{
    public static void Main()
    {
        Thread thread = new Thread(new ThreadStart(DoWork));
        thread.Start();

        Console.WriteLine("Main thread continues to run...");
        thread.Join(); // Wait for the other thread to complete
        Console.WriteLine("Main thread ends.");
    }

    public static void DoWork()
    {
        Console.WriteLine("Worker thread is executing.");
        Thread.Sleep(2000); // Simulate work
        Console.WriteLine("Worker thread has finished.");
    }
}

/*

The Task class is part of the System.Threading.Tasks namespace and represents an asynchronous
operation. Tasks are higher-level abstractions over threads, designed to make concurrent programming
easier by handling complex thread management for you.
Use the Task class for asynchronous programming, where you want to run tasks concurrently and benefit 
from features like task cancellation, continuations, and easier integration with async/await patterns. 
It’s ideal for modern, scalable applications where you want to avoid manual thread management.
*/


public class Program2
{
    public static async Task Main()
    {
        Task workTask = Task.Run(() => DoWork());

        Console.WriteLine("Main thread continues to run...");
        await workTask; // Wait for the task to complete
        Console.WriteLine("Main thread ends.");
    }

    public static void DoWork()
    {
        Console.WriteLine("Task is executing.");
        Task.Delay(2000).Wait(); // Simulate work
        Console.WriteLine("Task has finished.");
    }
}

/*
 * Main Differences Between Thread and Task
Abstraction Level:
Thread: Provides low-level control over threading. You manage the lifecycle, including starting, stopping, and managing the thread’s state.
Task: Offers a higher-level abstraction over threads, focusing on the logical flow of asynchronous operations rather than the threads themselves.

Ease of Use:
Thread: Requires more manual coding and is more error-prone, particularly when managing multiple threads.
Task: Simplifies concurrency with built-in features like async/await, continuations, and automatic thread management.

Scalability:
Thread: Less scalable, as creating and managing many threads can be resource-intensive.
Task: More scalable, leveraging the ThreadPool for efficient resource management.
 */



//(a)

public class ThreadExample
{
    // Shared resource
    private static int sharedCounter = 0;

    // Object used for locking to ensure thread safety
    private static readonly object lockObject = new object();

    public static void Main()
    {
        // Create a new thread that runs the IncrementCounter method
        Thread workerThread = new Thread(new ThreadStart(IncrementCounter));

        // Start the worker thread
        workerThread.Start();

        // Main thread continues its execution
        for (int i = 0; i < 5; i++)
        {
            lock (lockObject)
            {
                sharedCounter++;
                Console.WriteLine($"Main Thread: Counter = {sharedCounter}");
            }
            Thread.Sleep(500); // Simulate work
        }

        // Synchronize with the worker thread to ensure it completes
        workerThread.Join(); // Wait for worker thread to finish

        Console.WriteLine("Main thread has completed.");
    }

    // Method to be run on the new thread
    public static void IncrementCounter()
    {
        for (int i = 0; i < 5; i++)
        {
            lock (lockObject)
            {
                sharedCounter++;
                Console.WriteLine($"Worker Thread: Counter = {sharedCounter}");
            }
            Thread.Sleep(500); // Simulate work
        }
    }
}
