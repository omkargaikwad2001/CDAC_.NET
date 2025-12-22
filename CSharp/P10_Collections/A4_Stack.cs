using System;
using System.Collections;

namespace P10_Collections
{
    internal class A4_Stack
    {
        static void Main1(string[] args)
        {
            Stack stack = new Stack();

            Console.WriteLine("Enter 5 numbers to push into stack:");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter number " + i + ": ");
                int num = Convert.ToInt32(Console.ReadLine());
                stack.Push(num);
            }

            Console.WriteLine("\nStack elements:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPerforming Pop operation...");
            int popped = (int)stack.Pop();
            Console.WriteLine("Popped element: " + popped);

            Console.WriteLine("\nStack after pop:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
