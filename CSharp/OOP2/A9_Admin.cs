using System;

namespace P6_OOP2
{
    internal class A9_Admin : A9_Emp
    {
        private double bonus;

        public A9_Admin(string name, string phone, string email,
                         int empId, double salary, double bonus)
            : base(name, phone, email, empId, salary)
        {
            this.bonus = bonus;
        }

        public override double CalSalary()
        {
            return basicSalary + bonus;
        }
    }
}
