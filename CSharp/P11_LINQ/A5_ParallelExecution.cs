using System;
using System.Threading.Tasks;

namespace P11_LINQ
{
    internal class A5_ParallelExecution
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("=== Parallel.For Example ===\n");

            // Parallel.For loop
            Parallel.For(1, 11, i =>
            {
                Console.WriteLine($"Parallel Task {i} is running");
            });

            Console.WriteLine("\n=== Task Example ===\n");

            // Using Task
            Task t1 = Task.Run(() => PrintTask("Task 1"));
            Task t2 = Task.Run(() => PrintTask("Task 2"));
            Task t3 = Task.Run(() => PrintTask("Task 3"));

            // Wait for all tasks to finish
            Task.WaitAll(t1, t2, t3);

            Console.WriteLine("\nAll tasks completed.");
        }

        // Method to simulate work for Task
        static void PrintTask(string name)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"{name} iteration {i}");
            }
        }
    }
}
