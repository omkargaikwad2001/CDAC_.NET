using System;

namespace P4_OOP1
{
    internal class A5_Student
    {
        public int Id { get; set; }
        public float Percent { get; set; }

        public A5_Student(int id, float percent)
        {
            Id = id;
            Percent = percent;
        }

        public void DisplayGrade()
        {
            Console.WriteLine("Student Id = " + Id);
            Console.WriteLine("Percentage = " + Percent);

            if (Percent >= 90)
                Console.WriteLine("Grade : Excellent");
            else if (Percent >= 80)
                Console.WriteLine("Grade : Very Good");
            else if (Percent >= 70)
                Console.WriteLine("Grade : Good");
            else if (Percent >= 60)
                Console.WriteLine("Grade : Average");
            else if (Percent >= 40)
                Console.WriteLine("Grade : Pass");
            else
                Console.WriteLine("Grade : Fail");
        }

        static void Main1(string[] args)
        {
            A5_Student s1 = new A5_Student(101, 85.5f);
            s1.DisplayGrade();

            Console.WriteLine("--------------------");

            A5_Student s2 = new A5_Student(102, 35.0f);
            s2.DisplayGrade();
        }
    }
}
