using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP1
{
    internal class A7_Params
    {
        
        //optional parameters
        //positional parameter
        public float Multiply(float n1, float n2=2, float n3=2)
        {
            return n1 * n2 * n3;
        }

        //overload multiply method with using params
        public float Multiply(params float[] arr)
        {
            float ans = 1.0f;

            foreach(float f in arr) ans *= f;

            return ans;
        }
        static void Main1(string[] args)
        {
            A7_Params p = new A7_Params();

            Console.WriteLine(p.Multiply(2));
            Console.WriteLine(p.Multiply(3,3,3));

            //named parameter
            Console.WriteLine(p.Multiply(n1:5,n2:3,n3:4));

            //params
            Console.WriteLine(p.Multiply(1,2,3,4,5,6));
        }




    }
}
