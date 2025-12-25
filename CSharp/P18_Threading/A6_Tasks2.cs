using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_Threading
{
    internal class A6_Tasks2
    {
        static void Main1(string[] args)
        {

            Task t = Task.Run(() => Display());
            t.Wait();
        }

        public static void Display()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
