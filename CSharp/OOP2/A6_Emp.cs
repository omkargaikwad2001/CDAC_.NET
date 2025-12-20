using System;

namespace P6_OOP2
{
    internal class A6_Emp : A6_Person
    {
        private int empId;
        private double salary;

        public A6_Emp(string name, string phone, string email, int empId, double salary)
            : base(name, phone, email)
        {
            this.empId = empId;
            this.salary = salary;
        }

        public override void Display()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Emp Id : " + empId);
            Console.WriteLine("Name   : " + name);
            Console.WriteLine("Phone  : " + phone);
            Console.WriteLine("Email  : " + email);
            Console.WriteLine("Salary : " + salary);
        }
    }
}
