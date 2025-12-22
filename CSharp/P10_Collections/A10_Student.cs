using System;

namespace P10_Collections
{
    internal class A10_Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        public A10_Student(int rollNo, string name, string email, int age, int marks)
        {
            RollNo = rollNo;
            Name = name;
            Email = email;
            Age = age;
            Marks = marks;
        }

        public override string ToString()
        {
            return $"Roll:{RollNo}, Name:{Name}, Age:{Age}, Marks:{Marks}, Email:{Email}";
        }
    }
}
