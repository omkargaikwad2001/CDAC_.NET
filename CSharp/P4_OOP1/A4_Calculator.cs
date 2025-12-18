using System;

namespace P4_OOP1
{
    internal class A4_Calculator
    {
        public double No1 { get; set; }
        public double No2 { get; set; }

        public A4_Calculator(double n1, double n2)
        {
            No1 = n1;
            No2 = n2;
        }

        public double Add()
        {
            return No1 + No2;
        }

        public double Subtract()
        {
            return No1 - No2;
        }

        public double Multiply()
        {
            return No1 * No2;
        }

        public double Divide()
        {
            if (No2 == 0)
            {
                Console.WriteLine("Division by zero is not allowed");
                return 0;
            }
            return No1 / No2;
        }
    }

    internal class CalculatorDemo
    {
        static void Main1(string[] args)
        {
            A4_Calculator calc = new A4_Calculator(10, 5);

            Console.WriteLine("Addition = " + calc.Add());
            Console.WriteLine("Subtraction = " + calc.Subtract());
            Console.WriteLine("Multiplication = " + calc.Multiply());
            Console.WriteLine("Division = " + calc.Divide());
        }
    }
}
