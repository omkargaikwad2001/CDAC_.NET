using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_String
{
    internal class A17_WordCount
    {
        static void Main1(string[] args)
        {

            string str = "Hello this is omkar from cdac";

            int cnt = 0;

            //Console.WriteLine("using count function "+str.Count()); 

            string[] arr = str.Split(" ");
            Console.WriteLine("Word count = "+arr.Length);

        }
    }
}
