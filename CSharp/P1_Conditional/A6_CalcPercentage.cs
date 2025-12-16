using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Conditional
{
    internal class A6_CalcPercentage
    {
        static void Main1(string[] args)
        {

            Console.WriteLine("Enter roll number");
            int roll = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name of student");
            string name = Console.ReadLine();

            Console.WriteLine("Enter maths marks");
            float mathMarks = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter phy marks");
            float phyMarks = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter chem marks");
            float chemMarks = float.Parse(Console.ReadLine());

            float total = mathMarks + phyMarks + chemMarks;

            float percentage = total / 3.0f; 

            Console.WriteLine("Roll No: "+roll);
            Console.WriteLine("Name of student: "+name);

            Console.WriteLine("Maths marks: "+ mathMarks);
            Console.WriteLine("Physics marks: " + phyMarks);
            Console.WriteLine("Chemistry marks: " + chemMarks);

            Console.WriteLine("Total = " + total);
            Console.WriteLine("Percentage = "+percentage);

            if (percentage >= 60)
            {
                Console.WriteLine("Class = First class");
            }else if (percentage>=50 && percentage<60)
            {
                Console.WriteLine("Class = Second class");
            }
            else
            {
                Console.WriteLine("Class = Third class");
            }

        }
    }
}
