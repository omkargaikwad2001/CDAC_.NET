using System;

namespace P10_Collections
{
    internal class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }

        public Student(int rollNo, string name)
        {
            RollNo = rollNo;
            Name = name;
        }

        public override string ToString()
        {
            return $"RollNo:{RollNo}, Name:{Name}";
        }
    }
}
