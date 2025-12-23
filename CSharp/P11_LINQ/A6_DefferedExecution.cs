using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_LINQ
{
    internal class A6_DefferedExecution
    {
        static void Main1(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Define the query (not executed yet)
            var query = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Before adding new numbers:");
            foreach (var n in query)
            {
                Console.WriteLine(n);
            }

            // Add more numbers to the list
            numbers.Add(6);
            numbers.Add(8);

            Console.WriteLine("\nAfter adding new numbers:");
            foreach (var n in query)
            {
                Console.WriteLine(n);
            }
        }
    }
}
