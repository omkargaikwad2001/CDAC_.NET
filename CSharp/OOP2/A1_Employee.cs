using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class A1_Employee:A1_Person
    {
        public int empId { get; set; }

        public A1_Employee(string name, int age, int empId):base(name,age) { 
            this.empId = empId;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"EmpId = {empId}");
            Console.WriteLine("Calling base class DisplayPerson() from child class display()");
            base.DisplayPerson();
        }
    }
}
