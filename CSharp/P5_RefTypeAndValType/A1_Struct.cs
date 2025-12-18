using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5_RefTypeAndValType
{
    internal class A1_Struct
    {
        struct Student
        {
            public int roll;
            public string name;
            public string email;
            public int[] marks;

            public void display()
            {
                Console.WriteLine("Roll = "+roll);
                Console.WriteLine("Name = " + name);
                Console.WriteLine("Email = " + email);
                
                foreach(var i in marks) Console.WriteLine("Marks = "+i);
            }
        }
        static void Main1(string[] args)
        {

            Student s;

            s.roll = 101;
            s.name = "Omkar";
            s.email = "omkar@gmail.com";
            s.marks = new int[] { 10, 20, 30 };

            s.display();
        }
    }
}
