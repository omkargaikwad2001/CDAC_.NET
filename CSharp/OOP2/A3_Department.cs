using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class A3_Department:A3_Company
    {
        public string DepartmentName { get; set; }

        public A3_Department() {

            Console.WriteLine("Instance constructor of department called...");
        }

        static A3_Department()
        {

            Console.WriteLine("Static constructor of department called...");
        }
    }
}
