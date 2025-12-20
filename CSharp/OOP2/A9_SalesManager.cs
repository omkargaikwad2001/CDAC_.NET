using System;

namespace P6_OOP2
{
    internal class A9_SalesManager : A9_Emp
    {
        private double incentive;

        public A9_SalesManager(string name, string phone, string email,
                                int empId, double salary, double incentive)
            : base(name, phone, email, empId, salary)
        {
            this.incentive = incentive;
        }

        public override double CalSalary()
        {
            return basicSalary + incentive;
        }
    }
}
