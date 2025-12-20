using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class A3_Company
    {
        public static string CompanyName { get; set; }

        public A3_Company() {

            Console.WriteLine("Instance constructor of company called...");
        }

        static A3_Company() {

            Console.WriteLine("Static constructor of company called...");
        }
    }
}
