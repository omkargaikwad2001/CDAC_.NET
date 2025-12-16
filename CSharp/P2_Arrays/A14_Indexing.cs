using System;

namespace P2_Arrays
{
    internal class A14_Indexing
    {
        static void Main1(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80 };

            Console.WriteLine("Array Elements:");
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n\nAccessing elements using index from end:");

            Console.WriteLine("Last element (^1)        : " + arr[^1]);
            Console.WriteLine("Second last element (^2) : " + arr[^2]);
            Console.WriteLine("Third last element (^3)  : " + arr[^3]);
        }
    }
}
