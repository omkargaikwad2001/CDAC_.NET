using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_Tasks
{
    internal class A3_TaskReturn
    {
        static int Main1(string[] args)
        {
            //we can return values with task
            Task<int> t = new Task<int>(Display);
            t.Start();
            Console.WriteLine(t.Result);
            t.Wait();
            return 0;
        }

        private static int Display()
        {
            return 100;
        }
    }
}
