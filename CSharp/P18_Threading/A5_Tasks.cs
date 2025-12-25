using System;
using System.Threading;
using System.Threading.Tasks;

namespace P18_Threading
{
    internal class A5_Tasks
    {
        static void Main1(string[] args)
        {
            // Creating tasks
            Task t1 = Task.Run(() => Display(10, "t1"));
            Task t2 = Task.Run(() => Display(20, "t2"));
            Task t3 = Task.Run(() => Display(30, "t3"));

            // Main thread waits for all tasks to complete
            Task.WaitAll(t1, t2, t3);

            Console.WriteLine("All tasks completed. Main thread exiting...");
            Console.ReadLine();
        }

        public static void Display(int n, string name)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(name + " - " + i);
                Thread.Sleep(100);
            }
        }
    }
}
