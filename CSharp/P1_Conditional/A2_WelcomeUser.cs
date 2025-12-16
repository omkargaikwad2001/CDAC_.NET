using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Conditional
{
    internal class A2_WelcomeUser
    {
        public static void Main1(string[] args)
        {
            Console.WriteLine("Enter Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome "+name);
            Console.WriteLine($"Welcome {name}");
            Console.WriteLine("Welcome {0}",name);
        }
    }
}
