using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Conditional
{
    internal class A11_Pattern
    {
        static void Main1(string[] args)
        {

            //* * * * *
            //* * * * 
            //* * * 
            //* * 
            //* 

            for (int i = 5; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            //* * * * *
            // * * * *
            //  * * *
            //   * *
            //    * 

            for(int i = 1; i <= 5; i++)
            {
                //for space
                for(int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }

                //for *
                for(int k = 5; k >= i; k--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
