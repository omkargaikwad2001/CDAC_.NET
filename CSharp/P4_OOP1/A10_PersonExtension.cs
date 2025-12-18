using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP1
{
    static class A10_PersonExtension
    {
        public static string GetFullName(this A10_Person p)
        {
            return p.Fname+" "+p.Lname;
        }

        public static bool IsAdult(this A10_Person p)
        {
            if (p.Age >= 18)
            {
                return true;
            }

            return false;
        }
        static void Main1(string[] args)
        {
            
            A10_Person p = new A10_Person();
            p.Fname = "Omkar";
            p.Lname = "Gaikwad";
            p.Age = 24;

            Console.WriteLine(p.GetFullName());

            Console.WriteLine(p.IsAdult());
        }
    }
}
