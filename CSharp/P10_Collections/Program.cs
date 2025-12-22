namespace P10_Collections
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Assignment 6
            //// int
            //A6_MyDataGeneric<int> d1 = new A6_MyDataGeneric<int>(100);
            //d1.DisplayData();

            //// float
            //A6_MyDataGeneric<float> d2 = new A6_MyDataGeneric<float>(12.5f);
            //d2.DisplayData();

            //// string
            //A6_MyDataGeneric<string> d3 = new A6_MyDataGeneric<string>("Omkar");
            //d3.DisplayData();

            //// boolean
            //A6_MyDataGeneric<bool> d4 = new A6_MyDataGeneric<bool>(true);
            //d4.DisplayData();

            //// Employee
            //Employee emp = new Employee(1, "Amit");
            //A6_MyDataGeneric<Employee> d5 = new A6_MyDataGeneric<Employee>(emp);
            //d5.DisplayData();

            //// Student
            //Student stu = new Student(101, "Rahul");
            //A6_MyDataGeneric<Student> d6 = new A6_MyDataGeneric<Student>(stu);
            //d6.DisplayData();

            //*****************************************************************

            //Assignment 10
            List<A10_Student> students = new List<A10_Student>()
            {
                new A10_Student(101, "Omkar", "omkar@gmail.com", 22, 85),
                new A10_Student(102, "Amit", "amit@gmail.com", 21, 78),
                new A10_Student(103, "Rahul", "rahul@gmail.com", 23, 90),
                new A10_Student(104, "Neha", "neha@gmail.com", 20, 88),
                new A10_Student(105, "Pooja", "pooja@gmail.com", 22, 80)
            };

            Console.WriteLine("---- Original List ----");
            Display(students);

            students.Sort(new A10_StudentName());
            Console.WriteLine("\n---- Sorted by Name ----");
            Display(students);

            students.Sort(new A10_StudentAge());
            Console.WriteLine("\n---- Sorted by Age ----");
            Display(students);

            students.Sort(new A10_StudentMarks());
            Console.WriteLine("\n---- Sorted by Marks ----");
            Display(students);
        }

        static void Display(List<A10_Student> students)
        {
            foreach (A10_Student s in students)
            {
                Console.WriteLine(s);
            }
        }
    
    }
}
