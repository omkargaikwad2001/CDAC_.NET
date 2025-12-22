using System;
using System.Collections.Generic;

namespace P10_Collections
{
    internal class A7_ListIntegers
    {
        static void Main1(string[] args)
        {
            List<int> list = new List<int>() { 10, 5, 8, 3, 12 };

            Console.WriteLine("List elements:");
            DisplayList(list);

            list.Sort();
            Console.WriteLine("\nList in Ascending Order:");
            DisplayList(list);

            list.Sort();
            list.Reverse();
            Console.WriteLine("\nList in Descending Order:");
            DisplayList(list);

            Console.Write("\nEnter element to add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            list.Add(num);

            Console.WriteLine("List after adding element:");
            DisplayList(list);

            int sum = 0;
            foreach (int i in list)
            {
                sum += i;
            }
            Console.WriteLine("\nSum of list elements: " + sum);

            Console.WriteLine("\nPrime numbers in the list:");
            foreach (int i in list)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void DisplayList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
