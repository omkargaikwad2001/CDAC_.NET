using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_LINQ
{
    internal class A8_StudentMoreLINQ
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

            //1. Display all students from Pune
            var res1 = list.Where(c => c.city == "Pune");
            Display(res1.ToList());

            //2. Students with age > 24
            var res2 = list.Where(c => c.age > 24);
            Display(res2.ToList());

            //3. Display only student name and city (anonymous object)
            var res3 = list.Select(c => new { c.name, c.city }).ToList();
            Console.WriteLine("Name & City of Students:");
            foreach (var c in res3)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("=============================");

            //4. Sort students by age descending
            var res4 = list.OrderByDescending(c => c.age).ToList();
            Console.WriteLine("Students sorted by Age (Descending):");
            Display(res4);

            //5. Find student with highest age
            var maxAge = list.Max(c => c.age);
            var oldestStudent = list.First(c => c.age == maxAge);
            Console.WriteLine("Student with Highest Age:");
            Console.WriteLine(oldestStudent);
            Console.WriteLine("=============================");

            //6. Calculate average age
            var avgAge = list.Average(c => c.age);
            Console.WriteLine("Average Age of Students: " + avgAge);
            Console.WriteLine("=============================");

            //7. Group students by city
            var groupByCity = list.GroupBy(c => c.city);
            Console.WriteLine("Students Grouped by City:");
            foreach (var group in groupByCity)
            {
                Console.WriteLine($"City: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine();
            }

            //8. Count number of students in each city
            var countByCity = list.GroupBy(c => c.city)
                                  .Select(g => new { City = g.Key, Count = g.Count() });
            Console.WriteLine("Number of Students in Each City:");
            foreach (var item in countByCity)
            {
                Console.WriteLine($"{item.City} : {item.Count}");
            }
            Console.WriteLine("=============================");

            //9. Check if all students age < 25
            bool allUnder25 = list.All(c => c.age < 25);
            Console.WriteLine("Are all students under 25? " + allUnder25);

            //10. Display top 3 students according to age
            var top3ByAge = list.OrderByDescending(c => c.age).Take(3).ToList();
            Console.WriteLine("Top 3 Students by Age:");
            Display(top3ByAge);
        }
    }
}
