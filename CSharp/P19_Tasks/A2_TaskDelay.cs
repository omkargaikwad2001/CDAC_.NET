using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_Tasks
{
    internal class A2_TaskDelay
    {
        static int Main1(string[] args)
        {
            Task t = new Task(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                    Task.Delay(100).Wait();
                }
            });
            t.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main : " + i);
                Thread.Sleep(100);
            }
            t.Wait();
            return 0;
        }

    }
}
