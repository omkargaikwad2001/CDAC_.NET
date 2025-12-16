using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Conditional
{
    internal class A5_Eligibility
    {
        static void Main1(string[] args)
        {

            Console.WriteLine("Enter marks for maths");
            int mathMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks for phy");
            int phyMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter marks for chem");
            int chemMarks = int.Parse(Console.ReadLine());

            int total = mathMarks + phyMarks + chemMarks;

            if (mathMarks>=65 && phyMarks>=55 && chemMarks >= 50 && total>=180)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
    }
}
