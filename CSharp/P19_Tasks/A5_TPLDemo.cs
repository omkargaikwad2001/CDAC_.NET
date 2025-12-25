using System;
using System.Threading;
using System.Threading.Tasks;

namespace P19_Tasks
{
    internal class A5_TPLDemo
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Parallel execution started\n");

            Parallel.For(1, 11, i =>
            {
                Console.WriteLine(
                    $"Number: {i}, Thread ID: {Thread.CurrentThread.ManagedThreadId}"
                );

                Thread.Sleep(500); // simulate work
            });

            Console.WriteLine("\nParallel execution finished");
            Console.ReadLine();
        }
    }
}
