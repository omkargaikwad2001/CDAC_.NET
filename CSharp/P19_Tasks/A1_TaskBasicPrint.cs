using System;
using System.Threading;
using System.Threading.Tasks;

namespace P19_Tasks
{
    internal class A1_TaskBasicPrint
    {
        static void Main1(string[] args)
        {
            Task t = new Task(Display);
            t.Start();

            for (int i = 20; i < 30; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }

            t.Wait();   // Main waits for task
            Console.WriteLine("Done with Main ");
            Console.ReadLine();
        }

        public static void Display()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
}
