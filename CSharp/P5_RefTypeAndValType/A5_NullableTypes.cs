using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_RefTypeAndValType
{
    internal class A5_NullableTypes
    {
        static int Main1(string[] args)
        {
            int? a = null;

            Console.WriteLine(a.HasValue);
            a = 10;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a.Value);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(a.GetValueOrDefault(30));
            a = null;
            Console.WriteLine(a.GetValueOrDefault(30));
            Console.WriteLine("---------------------------------");
            int b = a ?? 20;
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Console.WriteLine("-----------------------");
            b = a ??= 20;
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Console.WriteLine("------------------------------");


            string? s = null;

            Console.WriteLine(s?.Length);
            s = "Hello";
            Console.WriteLine(s?.Length);
            Console.WriteLine(s!.Length);

            return 0;
        }

    }
}
