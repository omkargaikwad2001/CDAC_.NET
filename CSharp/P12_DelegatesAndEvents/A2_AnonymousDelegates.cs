using System;

namespace P12_DelegatesAndEvents
{
    // Custom delegate
    delegate void StringDelegate1(string s);

    internal class A2_AnonymousDelegates
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("===== Anonymous Method using Custom Delegate =====");

            // Anonymous Method - Single Cast
            StringDelegate1 d1 = delegate (string s)
            {
                Console.WriteLine("Upper Case: " + s.ToUpper());
            };
            d1("Hello World");

            // Anonymous Method - Multicast
            StringDelegate1 d2 = delegate (string s)
            {
                Console.WriteLine("Upper Case: " + s.ToUpper());
            };

            d2 += delegate (string s)
            {
                Console.WriteLine("Lower Case: " + s.ToLower());
            };

            d2 += delegate (string s)
            {
                Console.WriteLine("Original String: " + s);
            };

            d2("Dot Net Anonymous");

            Console.WriteLine("\n===== Lambda Expression using Custom Delegate =====");

            // Lambda - Single Cast
            StringDelegate1 d3 = (s) => Console.WriteLine("Upper Case: " + s.ToUpper());
            d3("Lambda Example");

            // Lambda - Multicast
            StringDelegate1 d4 = (s) => Console.WriteLine("Upper Case: " + s.ToUpper());
            d4 += (s) => Console.WriteLine("Lower Case: " + s.ToLower());
            d4 += (s) => Console.WriteLine("Original String: " + s);
            d4("Lambda Multicast");

            Console.WriteLine("\n===== Action Delegate with Anonymous Method =====");

            Action<string> act1 = delegate (string s)
            {
                Console.WriteLine("Upper Case: " + s.ToUpper());
            };

            act1 += delegate (string s)
            {
                Console.WriteLine("Lower Case: " + s.ToLower());
            };

            act1 += delegate (string s)
            {
                Console.WriteLine("Original String: " + s);
            };

            act1("Action Anonymous");

            Console.WriteLine("\n===== Action Delegate with Lambda Expression =====");

            Action<string> act2 = s => Console.WriteLine("Upper Case: " + s.ToUpper());
            act2 += s => Console.WriteLine("Lower Case: " + s.ToLower());
            act2 += s => Console.WriteLine("Original String: " + s);
            act2("Action Lambda");

            Console.ReadLine();
        }
    }
}
