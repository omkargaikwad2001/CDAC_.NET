using System;

namespace P12_DelegatesAndEvents
{
    internal class A5_Predicate
    {
        // 1. Check Positive
        public bool IsPositive(int no)
        {
            return no > 0;
        }

        // 2. Check Negative
        public bool IsNegative(int no)
        {
            return no < 0;
        }

        // 3. Check Prime
        public bool IsPrime(int no)
        {
            if (no <= 1)
                return false;

            for (int i = 2; i <= no / 2; i++)
            {
                if (no % i == 0)
                    return false;
            }
            return true;
        }

        // 4. Check Perfect Number
        public bool IsPerfect(int no)
        {
            if (no <= 0)
                return false;

            int sum = 0;
            for (int i = 1; i <= no / 2; i++)
            {
                if (no % i == 0)
                    sum += i;
            }
            return sum == no;
        }

        // 5. Check Palindrome
        public bool IsPallindrome(int no)
        {
            int temp = Math.Abs(no); // handle negative numbers
            int rev = 0, original = temp;

            while (temp > 0)
            {
                rev = (rev * 10) + (temp % 10);
                temp /= 10;
            }
            return rev == original;
        }

        static void Main1(string[] args)
        {
            A5_Predicate obj = new A5_Predicate();

            Predicate<int> p1 = obj.IsPositive;
            Console.WriteLine("Is Positive: " + p1(10));

            Predicate<int> p2 = obj.IsNegative;
            Console.WriteLine("Is Negative: " + p2(-5));

            Predicate<int> p3 = obj.IsPrime;
            Console.WriteLine("Is Prime: " + p3(7));

            Predicate<int> p4 = obj.IsPerfect;
            Console.WriteLine("Is Perfect: " + p4(28));

            Predicate<int> p5 = obj.IsPallindrome;
            Console.WriteLine("Is Palindrome: " + p5(121));

        }
    }
}
