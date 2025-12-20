using System;

namespace P6_OOP2
{
    internal abstract class A9_Emp : A9_Person
    {
        protected int empId;
        protected double basicSalary;

        public A9_Emp(string name, string phone, string email, int empId, double basicSalary)
            : base(name, phone, email)
        {
            this.empId = empId;
            this.basicSalary = basicSalary;
        }

        public abstract double CalSalary();
    }
}
