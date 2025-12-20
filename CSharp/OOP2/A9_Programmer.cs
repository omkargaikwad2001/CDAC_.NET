using System;

namespace P6_OOP2
{
    internal class A9_Programmer : A9_Emp
    {
        private int extraHours;
        private double chargePerHour;

        public A9_Programmer(string name, string phone, string email,
                              int empId, double salary,
                              int extraHours, double chargePerHour)
            : base(name, phone, email, empId, salary)
        {
            this.extraHours = extraHours;
            this.chargePerHour = chargePerHour;
        }

        public override double CalSalary()
        {
            return basicSalary + (extraHours * chargePerHour);
        }
    }
}
