using System;

namespace P12_DelegatesAndEvents
{
    internal class A6_Anonymous
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("===== Predicate using Anonymous Method =====");

            // 1. Is Positive
            Predicate<int> p1 = delegate (int no)
            {
                return no > 0;
            };
            Console.WriteLine("Is Positive: " + p1(10));

            // 2. Is Negative
            Predicate<int> p2 = delegate (int no)
            {
                return no < 0;
            };
            Console.WriteLine("Is Negative: " + p2(-5));

            // 3. Is Prime
            Predicate<int> p3 = delegate (int no)
            {
                if (no <= 1) return false;

                for (int i = 2; i <= no / 2; i++)
                {
                    if (no % i == 0)
                        return false;
                }
                return true;
            };
            Console.WriteLine("Is Prime: " + p3(7));

            // 4. Is Perfect
            Predicate<int> p4 = delegate (int no)
            {
                if (no <= 0) return false;

                int sum = 0;
                for (int i = 1; i <= no / 2; i++)
                {
                    if (no % i == 0)
                        sum += i;
                }
                return sum == no;
            };
            Console.WriteLine("Is Perfect: " + p4(28));

            // 5. Is Palindrome
            Predicate<int> p5 = delegate (int no)
            {
                int temp = Math.Abs(no);
                int rev = 0, original = temp;

                while (temp > 0)
                {
                    rev = (rev * 10) + (temp % 10);
                    temp /= 10;
                }
                return rev == original;
            };
            Console.WriteLine("Is Palindrome: " + p5(121));

            Console.WriteLine("\n===== Predicate using Lambda Expression =====");

            Predicate<int> lp1 = no => no > 0;
            Console.WriteLine("Is Positive: " + lp1(5));

            Predicate<int> lp2 = no => no < 0;
            Console.WriteLine("Is Negative: " + lp2(-10));

            Predicate<int> lp3 = no =>
            {
                if (no <= 1) return false;
                for (int i = 2; i <= no / 2; i++)
                {
                    if (no % i == 0)
                        return false;
                }
                return true;
            };
            Console.WriteLine("Is Prime: " + lp3(11));

            Predicate<int> lp4 = no =>
            {
                if (no <= 0) return false;
                int sum = 0;
                for (int i = 1; i <= no / 2; i++)
                {
                    if (no % i == 0)
                        sum += i;
                }
                return sum == no;
            };
            Console.WriteLine("Is Perfect: " + lp4(6));

            Predicate<int> lp5 = no =>
            {
                int temp = Math.Abs(no);
                int rev = 0, original = temp;

                while (temp > 0)
                {
                    rev = (rev * 10) + (temp % 10);
                    temp /= 10;
                }
                return rev == original;
            };
            Console.WriteLine("Is Palindrome: " + lp5(12321));

        }
    }
}
