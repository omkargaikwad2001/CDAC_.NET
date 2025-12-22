using System;

namespace P8_Interfaces
{
    internal class A4_MyNumber : A4_IintOps
    {
        public int Number { get; set; }

        public A4_MyNumber(int num)
        {
            Number = num;
        }

        public bool IsOdd(int num)
        {
            return num % 2 != 0;
        }

        public bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public bool IsPrime(int num)
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

        public double CalFactorial(int num)
        {
            double fact = 1;
            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
