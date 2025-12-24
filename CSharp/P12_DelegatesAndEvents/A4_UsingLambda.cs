using System;

namespace P12_DelegatesAndEvents
{
    // Custom delegate
    delegate int MathDelegate1(int a, int b);

    internal class A4_UsingLambda
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("===== Anonymous Method using Custom Delegate =====");

            // Anonymous Method - Single Cast
            MathDelegate1 d1 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine("Add Result: " + d1(10, 5));

            // Anonymous Method - Multicast
            MathDelegate1 d2 = delegate (int a, int b)
            {
                Console.WriteLine("Add: " + (a + b));
                return a + b;
            };

            d2 += delegate (int a, int b)
            {
                Console.WriteLine("Subtract: " + (a - b));
                return a - b;
            };

            d2 += delegate (int a, int b)
            {
                Console.WriteLine("Multiply: " + (a * b));
                return a * b;
            };

            int result1 = d2(10, 5);
            Console.WriteLine("Final Multicast Result: " + result1);

            Console.WriteLine("\n===== Lambda Expression using Custom Delegate =====");

            // Lambda - Single Cast
            MathDelegate1 d3 = (a, b) => a + b;
            Console.WriteLine("Add Result: " + d3(20, 10));

            // Lambda - Multicast
            MathDelegate1 d4 = (a, b) =>
            {
                Console.WriteLine("Add: " + (a + b));
                return a + b;
            };

            d4 += (a, b) =>
            {
                Console.WriteLine("Subtract: " + (a - b));
                return a - b;
            };

            d4 += (a, b) =>
            {
                Console.WriteLine("Multiply: " + (a * b));
                return a * b;
            };

            int result2 = d4(20, 10);
            Console.WriteLine("Final Multicast Result: " + result2);

            Console.WriteLine("\n===== Func Delegate using Anonymous Method =====");

            Func<int, int, int> f1 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine("Func Add: " + f1(30, 10));

            Console.WriteLine("\n===== Func Delegate using Lambda Expression =====");

            Func<int, int, int> f2 = (a, b) => a - b;
            Console.WriteLine("Func Subtract: " + f2(30, 10));

            Func<int, int, int> f3 = (a, b) => a * b;
            Console.WriteLine("Func Multiply: " + f3(30, 10));

            Console.ReadLine();
        }
    }
}
