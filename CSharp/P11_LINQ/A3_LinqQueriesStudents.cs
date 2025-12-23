using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_LINQ
{
    class Student
    {
        public int no { get; set; }
        public string name { get; set; }
        public string language { get; set; }
        public int age { get; set; }
        public string city { get; set; }

        public override string ToString()
        {
            return $"no = {no} name = {name} language = {language} age = {age} city = {city}";
        }
    }

    internal class A3_LinqQueriesStudents
    {
        public static void Display(List<Student> ls)
        {
            foreach (var s in ls)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("===========================================");
            Console.WriteLine();
        }

        static void Main1(string[] args)
        {
            List<Student> list = new List<Student>
            {
                new Student { no = 1, name = "Omkar", language = "C++", age = 25, city = "Pune" },
                new Student { no = 2, name = "Amit", language = "Java", age = 23, city = "Mumbai" },
                new Student { no = 3, name = "Shubham", language = "C#", age = 24, city = "Pune" },
                new Student { no = 4, name = "Kiran", language = "Python", age = 22, city = "Nashik" },
                new Student { no = 5, name = "Rohit", language = "Java", age = 26, city = "Delhi" },
                new Student { no = 6, name = "Neha", language = "C#", age = 21, city = "Pune" },
                new Student { no = 7, name = "Priya", language = "Python", age = 23, city = "Bangalore" },
                new Student { no = 8, name = "Sanket", language = "C++", age = 24, city = "Mumbai" },
                new Student { no = 9, name = "Anjali", language = "JavaScript", age = 22, city = "Pune" },
                new Student { no = 10, name = "Rahul", language = "Java", age = 27, city = "Chennai" }
            };

            Display(list);

            // 1. Students from Pune (Query Syntax)
            var res1 = from c in list
                       where c.city == "Pune"
                       select c;

            Console.WriteLine("Students with city = Pune (Query Syntax)");
            Display(res1.ToList());

            // Object Syntax
            Console.WriteLine("Students with city = Pune (Object Syntax)");
            var res1o = list.Where(c => c.city == "Pune");
            Display(res1o.ToList());

            // 2. Average age
            var res2 = list.Average(c => c.age);
            Console.WriteLine("Average Age = " + res2);
            Console.WriteLine();

            // 3. Student name contains 'y'
            var res3 = list.Where(c => c.name.Contains("y", StringComparison.OrdinalIgnoreCase));
            Display(res3.ToList());

            // 4. First record
            var res4 = list.First();
            Console.WriteLine("First Record:");
            Console.WriteLine(res4);
            Console.WriteLine();

            // 5. Last record
            var res5 = list.Last();
            Console.WriteLine("Last Record:");
            Console.WriteLine(res5);
            Console.WriteLine();

            // 6. Order by name ascending
            var res6 = list.OrderBy(c => c.name);
            Display(res6.ToList());

            // 7. Order by age descending
            var res7 = list.OrderByDescending(c => c.age);
            Display(res7.ToList());

            // 8. Max age
            var res8 = list.Max(c => c.age);
            Console.WriteLine("Max Age = " + res8);
            Console.WriteLine();

            // 9. Min age
            var res9 = list.Min(c => c.age);
            Console.WriteLine("Min Age = " + res9);
            Console.WriteLine();

            // 10. Group by city
            var res10 = list.GroupBy(c => c.city);

            foreach (var group in res10)
            {
                Console.WriteLine($"City : {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine();
            }

            // 11. Count total students
            var res11 = list.Count();
            Console.WriteLine("Total Students = " + res11);
            Console.WriteLine();

            // 12. Count students from Pune
            var res12 = list.Count(c => c.city == "Pune");
            Console.WriteLine("Total students from Pune = " + res12);
        }
    }
}
