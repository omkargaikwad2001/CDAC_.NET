using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Conditional
{
    internal class A8_VerticaleTable
    {
        static void Main1(string[] args)
        {

            Console.WriteLine("Verticle Table");

            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 12; j++)
                {
                    Console.Write(i*j+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
