using System;

namespace P4_OOP1
{
    internal class A6_MyNumber
    {
        private int num;

        public A6_MyNumber()
        {
            this.num = 0;
        }

        public A6_MyNumber(int num)
        {
            this.num = num;
        }

        public bool IsNegative()
        {
            return num < 0;
        }

        public bool IsPositive()
        {
            return num > 0;
        }

        public bool IsZero()
        {
            return num == 0;
        }

        public bool IsOdd()
        {
            return num % 2 != 0;
        }

        public bool IsEven()
        {
            return num % 2 == 0;
        }

        static void Main1(string[] args)
        {
            A6_MyNumber n1 = new A6_MyNumber(-7);

            Console.WriteLine("Is Negative : " + n1.IsNegative());
            Console.WriteLine("Is Positive : " + n1.IsPositive());
            Console.WriteLine("Is Zero     : " + n1.IsZero());
            Console.WriteLine("Is Odd      : " + n1.IsOdd());
            Console.WriteLine("Is Even     : " + n1.IsEven());

            Console.WriteLine("--------------------");

            A6_MyNumber n2 = new A6_MyNumber();

            Console.WriteLine("Is Negative : " + n2.IsNegative());
            Console.WriteLine("Is Positive : " + n2.IsPositive());
            Console.WriteLine("Is Zero     : " + n2.IsZero());
            Console.WriteLine("Is Odd      : " + n2.IsOdd());
            Console.WriteLine("Is Even     : " + n2.IsEven());
        }
    }
}
