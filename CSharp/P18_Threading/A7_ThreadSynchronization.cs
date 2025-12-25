using System;
using System.Threading;

namespace P18_Threading
{
    internal class A7_ThreadSynchronization
    {
        static void Main1(string[] args)
        {
            Factors fc = new Factors();

            Thread t1 = new Thread(() => fc.PrintFactors(64));
            Thread t2 = new Thread(() => fc.PrintFactors(100));
            Thread t3 = new Thread(() => fc.PrintFactors(121));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine("All threads completed...");
            
        }
    }

    class Factors
    {
        public void PrintFactors(int no)
        {
            Monitor.Enter(this);   // start critical section
            try
            {
                Console.WriteLine("\nFactors of " + no + " :");

                for (int i = 1; i <= no; i++)
                {
                    if (no % i == 0)
                        Console.WriteLine(i);

                    Thread.Sleep(100);
                }
            }
            finally
            {
                Monitor.Exit(this); // end critical section
            }
        }
    }
}
