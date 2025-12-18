using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP1
{
    internal class A12_InOutRef
    {
        //in
        public int Add(in int n1,in int n2)
        {
            //n1 = 100; readonly
            return n1 + n2;
        }

        //out
        public int Add(in int n1, in int n2, out int res)
        {
            res = n1 + n2;
            return res;
        }

        //ref
        public static void Swap(ref int a, ref int b)
        {
            int temp = a; a = b; b = temp;
        }
        static void Main1(string[] args)
        {
            A12_InOutRef p = new A12_InOutRef();
            Console.WriteLine("Using in param = "+p.Add(1, 2));

            int ans;
            Console.WriteLine("Using out param = "+p.Add(1, 2, out ans));

            int a = 10;
            int b = 20;

            Console.WriteLine("Before swap a = "+a+" b = "+b);

            Swap(ref a, ref b);

            Console.WriteLine("After swap a = " + a + " b = " + b);
        }
    }
}
