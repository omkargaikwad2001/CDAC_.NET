using System;
using System.Threading;

namespace P18_Threading
{
    internal class A4_PrimeThread
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter starting number:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter ending number:");
            int end = int.Parse(Console.ReadLine());

            // Passing data from Main thread to child thread
            Thread t = new Thread(() => PrintPrime(start, end));

            t.Start();
            t.Join();   // Main waits for child

            Console.WriteLine("Main executed...");
           
        }

        public static void PrintPrime(int start, int end)
        {
            Console.WriteLine("\nPrime Numbers:");

            for (int i = start; i <= end; i++)
            {
                if (i < 2) continue;

                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
