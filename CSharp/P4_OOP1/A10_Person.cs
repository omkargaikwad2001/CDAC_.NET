using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP1
{ 
    internal class A10_Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public void Display()
        {
            Console.WriteLine("First name = "+Fname);
            Console.WriteLine("Last name = "+Lname);
            Console.WriteLine("Age = "+Age);
        }

        //static void Main1(string[] args)
        //{
        //    A10_Person p = new A10_Person();

        //    p.Fname = "Omkar";
        //    p.Lname = "Gaikwad";
        //    p.Age = 24;

        //    p.Display();
        //}
    }
}
