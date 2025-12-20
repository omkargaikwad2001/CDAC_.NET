using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_OOP2
{
    internal class A5_Student
    {
        public int RollNum { get; set; }
        public string Name { get; set; }
        public A5_Address Address { get; set; }

        public A5_Student(int RollNum, string Name, A5_Address Address)
        {
            this.RollNum = RollNum;
            this.Name = Name;
            this.Address = Address;
        }

        public void DisplayStudent()
        {
            Address.DisplayAddress();
            Console.WriteLine($"Roll num = {RollNum} Name = {Name}");
        }
    
    }
}
