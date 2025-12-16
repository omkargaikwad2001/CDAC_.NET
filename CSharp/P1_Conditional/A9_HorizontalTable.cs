using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Conditional
{
    internal class A9_HorizontalTable
    {
        static void Main1(string[] args)
        {

            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i*j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
