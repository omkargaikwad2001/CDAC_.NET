using System;

namespace P10_Collections
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }

        public Employee(int empId, string name)
        {
            EmpId = empId;
            Name = name;
        }

        public override string ToString()
        {
            return $"EmpId:{EmpId}, Name:{Name}";
        }
    }
}
