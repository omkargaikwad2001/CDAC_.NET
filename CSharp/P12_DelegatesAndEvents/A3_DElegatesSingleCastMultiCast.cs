using System;

namespace P12_DelegatesAndEvents
{
    // Step 1: Declare delegate
    delegate int MathDelegate(int a, int b);

    internal class A3_DElegatesSingleCastMultiCast
    {
        // Method 1: Addition
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method 2: Subtraction
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method 3: Multiplication
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Main1(string[] args)
        {
            A3_DElegatesSingleCastMultiCast obj = new A3_DElegatesSingleCastMultiCast();

            Console.WriteLine("----- Single Cast Delegate -----");
            MathDelegate d1 = obj.Add;
            int result1 = d1(10, 5);
            Console.WriteLine("Addition Result: " + result1);

            Console.WriteLine("\n----- Multi Cast Delegate -----");
            MathDelegate d2 = obj.Add;
            d2 += obj.Subtract;
            d2 += obj.Multiply;

            // In multicast delegate, only LAST method return value is stored
            int result2 = d2(10, 5);
            Console.WriteLine("Multicast Delegate Final Result: " + result2);

            Console.WriteLine("\n----- Func Delegate -----");
            Func<int, int, int> func1 = obj.Add;
            Console.WriteLine("Func Add Result: " + func1(20, 10));

            Func<int, int, int> func2 = obj.Subtract;
            Console.WriteLine("Func Subtract Result: " + func2(20, 10));

            Func<int, int, int> func3 = obj.Multiply;
            Console.WriteLine("Func Multiply Result: " + func3(20, 10));

            Console.ReadLine();
        }
    }
}
