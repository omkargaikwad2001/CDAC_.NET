using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_LINQ
{
    internal class A4_AnonymousObject
    {
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

            // -------------------------------------------------
            // 1. Anonymous object (name, city) – Query Syntax
            // -------------------------------------------------
            var res1 = from c in list
                       select new { c.name, c.city };

            Console.WriteLine("Query Syntax : Name & City");
            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================================");

            // Method Syntax
            var res1m = list.Select(c => new { c.name, c.city });

            Console.WriteLine("Method Syntax : Name & City");
            foreach (var item in res1m)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================================");

            // -------------------------------------------------
            // 2. Anonymous object (name, city, age) where age > 24
            // -------------------------------------------------
            var res2 = from c in list
                       where c.age > 24
                       select new { c.name, c.city, c.age };

            Console.WriteLine("Query Syntax : Age > 24");
            foreach (var item in res2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================================");

            // Method Syntax
            var res2m = list
                        .Where(c => c.age > 24)
                        .Select(c => new { c.name, c.city, c.age });

            Console.WriteLine("Method Syntax : Age > 24");
            foreach (var item in res2m)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================================");

            // -------------------------------------------------
            // 3. Anonymous object with renamed properties
            // -------------------------------------------------
            var res3 = from c in list
                       select new
                       {
                           sname = c.name,
                           sage = c.age
                       };

            Console.WriteLine("Query Syntax : Renamed Properties");
            foreach (var item in res3)
            {
                Console.WriteLine($"Student Name = {item.sname}, Student Age = {item.sage}");
            }

            Console.WriteLine("========================================");

            // Method Syntax
            var res3m = list.Select(c => new
            {
                sname = c.name,
                sage = c.age
            });

            Console.WriteLine("Method Syntax : Renamed Properties");
            foreach (var item in res3m)
            {
                Console.WriteLine($"Student Name = {item.sname}, Student Age = {item.sage}");
            }
        }
    }
}
