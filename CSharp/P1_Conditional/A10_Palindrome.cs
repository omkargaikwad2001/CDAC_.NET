using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Conditional
{
    internal class A10_Palindrome
    {
        static void Main1(string[] args)
        {

            Console.WriteLine("Enter number ");
            int num = int.Parse(Console.ReadLine());

            int original = num;
            
            int ans = 0;

            while (num > 0)
            {
                int lastD = num%10;

                ans = ans * 10 + lastD;

                num = num / 10;
            }

            if (ans == original)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }

        }
    }
}
