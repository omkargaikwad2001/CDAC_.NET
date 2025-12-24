using System;
using System.IO;
using System.Text;

namespace P14_FileIO
{
    // Student class
    class Student
    {
        public int RollNo;
        public string Name;
        public int Age;
        public double Marks;
        public char Grade;

        public override string ToString()
        {
            return $"RollNo: {RollNo}\nName: {Name}\nAge: {Age}\nMarks: {Marks}\nGrade: {Grade}";
        }
    }

    internal class A2_FileStream
    {
        static void Main1(string[] args)
        {
            string filePath = "StudentData.txt";

            // Accept student data
            Student s = new Student();

            Console.Write("Enter Roll No: ");
            s.RollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            s.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks: ");
            s.Marks = double.Parse(Console.ReadLine());

            Console.Write("Enter Grade: ");
            s.Grade = char.Parse(Console.ReadLine());

            // Convert student object to string
            string data =
                s.RollNo + "," +
                s.Name + "," +
                s.Age + "," +
                s.Marks + "," +
                s.Grade;

            // WRITE student object to file using FileStream
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                fs.Write(bytes, 0, bytes.Length);
            }

            Console.WriteLine("\nStudent data written to file successfully.");

            // READ student object from file using FileStream
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] bytes = new byte[fs.Length];
                fs.Read(bytes, 0, bytes.Length);

                string fileData = Encoding.UTF8.GetString(bytes);
                string[] arr = fileData.Split(',');

                Student s2 = new Student
                {
                    RollNo = int.Parse(arr[0]),
                    Name = arr[1],
                    Age = int.Parse(arr[2]),
                    Marks = double.Parse(arr[3]),
                    Grade = char.Parse(arr[4])
                };

                Console.WriteLine("\n--- Student Data Read From File ---");
                Console.WriteLine(s2);
            }

            Console.ReadLine();
        }
    }
}
