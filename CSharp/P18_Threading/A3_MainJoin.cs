using System;
using System.Threading;

namespace P18_Threading
{
    internal class A3_MainJoin
    {
        static void Main1(string[] args)
        {
            Thread t1 = new Thread(() => Display(10, "t1"));
            Thread t2 = new Thread(() => Display(20, "t2"));
            Thread t3 = new Thread(() => Display(30, "t3"));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("All threads completed. Main thread exiting...");
           
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
