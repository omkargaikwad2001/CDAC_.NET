using System;
using System.Threading;

namespace P18_Threading
{
    internal class A2_ThreadProperties
    {
        static void Main1(string[] args)
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name);
            t.Name = "Main Thread";
            Console.WriteLine(t.Name);
            Console.WriteLine(t.ManagedThreadId); //Id of Thread
            Console.WriteLine(t.ThreadState);
            Console.WriteLine(t.Priority);
            Console.WriteLine(t.IsAlive);
            Console.WriteLine(t.IsBackground);
        }       
    }
}
