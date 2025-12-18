using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP1
{
    static class A11_StringExtension
    {
        public static string ToPascal(this string str)
        {
            return str[0].ToString().ToUpper() + str.Substring(1);
        }

        public static int CountChar(this string str)
        {
            int count = 0;

            string[] strArr = str.Split(" ");

            return strArr.Length;
        }
        static void Main1(string[] args)
        {
            string s = "omkar";

            string s2 = "omkar gaikwad at cdac";

            Console.WriteLine(s.ToPascal());

            Console.WriteLine(s2.CountChar());
        }
    }
}
