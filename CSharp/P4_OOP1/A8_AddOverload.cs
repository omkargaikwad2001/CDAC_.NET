using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP1
{
    internal class A8_AddOverload
    {
        //addition of two integers
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        
        //addition of three integers
        public int Add(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        //addition of two floats
        public float Add(float n1, float n2)
        {
            return n1 + n2;
        }
        static void Main1(string[] args)
        {
            A8_AddOverload a = new A8_AddOverload();

            Console.WriteLine(a.Add(1, 2));
            Console.WriteLine(a.Add(3, 4, 5));
            Console.WriteLine(a.Add(1.2f, 3.4f));

            Console.WriteLine("using named  = "+a.Add(n1:10,n2:20));

        }
    }
}
