using System;

namespace P10_Collections
{
    internal class A11_Tuple
    {
        static void Main1(string[] args)
        {
            // 1 Value-type Tuple
            Console.WriteLine("---- Value-type Tuple ----");
            var student1 = (101, "Omkar", 85.5f);

            Console.WriteLine("Student ID: " + student1.Item1);
            Console.WriteLine("Student Name: " + student1.Item2);
            Console.WriteLine("Percentage: " + student1.Item3);

            // 2️ Named Elements
            var studentNamed = (ID: 102, Name: "Rahul", Percentage: 90.0f);
            Console.WriteLine("\n---- Named Tuple ----");
            Console.WriteLine("Student ID: " + studentNamed.ID);
            Console.WriteLine("Student Name: " + studentNamed.Name);
            Console.WriteLine("Percentage: " + studentNamed.Percentage);

            // 3️ Reference-type Tuple
            Console.WriteLine("\n---- Reference-type Tuple ----");
            Tuple<int, string, float> studentRef = new Tuple<int, string, float>(103, "Neha", 88.5f);

            Console.WriteLine("Student ID: " + studentRef.Item1);
            Console.WriteLine("Student Name: " + studentRef.Item2);
            Console.WriteLine("Percentage: " + studentRef.Item3);

            // 4️ Reference-type tuple with named elements
            var studentRefNamed = Tuple.Create(104, "Pooja", 92.0f);
            var (ID, Name, Percentage) = studentRefNamed;  // deconstruct
            Console.WriteLine("\n---- Reference-type Tuple with Named Elements ----");
            Console.WriteLine("Student ID: " + ID);
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("Percentage: " + Percentage);
        }
    }
}
