using System;

namespace P5_RefTypeAndValType
{
    internal class A4_Calculator
    {
        public void Calculate(int n)
        {
            int Square(int x)
            {
                return x * x;
            }

            int Cube(int x)
            {
                return x * x * x;
            }

            int SumOfDigits(int x)
            {
                int ans = 0;
                while (x > 0)
                {
                    ans += x % 10;
                    x /= 10;
                }
                return ans;
            }

            int CountOfNum(int x)
            {
                int cnt = 0;
                while (x > 0)
                {
                    cnt++;
                    x /= 10;
                }
                return cnt;
            }

            Console.WriteLine("Square = " + Square(n));
            Console.WriteLine("Cube = " + Cube(n));
            Console.WriteLine("Sum of Digits = " + SumOfDigits(n));
            Console.WriteLine("Count of Digits = " + CountOfNum(n));
        }

        static void Main1(string[] args)
        {
            A4_Calculator c = new A4_Calculator();
            c.Calculate(123);
        }
    }
}
