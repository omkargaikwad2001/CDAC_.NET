using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_Threading
{
    internal class A2_Print1to5
    {
        static void Main1(string[] args)
        {

            Thread t = new Thread(Display);

            t.Start();

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("Main - "+i);
                Thread.Sleep(100);
            }

        }

        public static void Display()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Child - " + i);
                Thread.Sleep(100);
            }
        }
    }
}
