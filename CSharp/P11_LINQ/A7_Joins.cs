using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_LINQ
{
    internal class A7_Joins
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int DeptId { get; set; }
        }

        class Department
        {
            public int DeptId { get; set; }
            public string DeptName { get; set; }
        }

        static void Main1(string[] args)
        {
            // Student list
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Omkar", DeptId = 101 },
                new Student { Id = 2, Name = "Amit", DeptId = 102 },
                new Student { Id = 3, Name = "Neha", DeptId = 101 },
                new Student { Id = 4, Name = "Priya", DeptId = 103 },
            };

            // Department list
            List<Department> departments = new List<Department>
            {
                new Department { DeptId = 101, DeptName = "CSE" },
                new Department { DeptId = 102, DeptName = "IT" },
                new Department { DeptId = 103, DeptName = "ECE" },
            };

            // ==========================
            // Query Syntax (Inner Join)
            // ==========================
            var joinQuery = from s in students
                            join d in departments on s.DeptId equals d.DeptId
                            select new
                            {
                                StudentName = s.Name,
                                DepartmentName = d.DeptName
                            };

            Console.WriteLine("Query Syntax - Inner Join:");
            foreach (var item in joinQuery)
            {
                Console.WriteLine($"{item.StudentName} - {item.DepartmentName}");
            }

            Console.WriteLine("\n=========================\n");

            // ==========================
            // Method Syntax (Inner Join)
            // ==========================
            var joinMethod = students.Join(departments,
                                           s => s.DeptId,
                                           d => d.DeptId,
                                           (s, d) => new
                                           {
                                               StudentName = s.Name,
                                               DepartmentName = d.DeptName
                                           });

            Console.WriteLine("Method Syntax - Inner Join:");
            foreach (var item in joinMethod)
            {
                Console.WriteLine($"{item.StudentName} - {item.DepartmentName}");
            }

            Console.WriteLine();
            Console.WriteLine("=======================================================");

            var cseStudentsQuery = from s in students
                                   join d in departments on s.DeptId equals d.DeptId
                                   where d.DeptName == "CSE"
                                   select new
                                   {
                                       StudentName = s.Name,
                                       DepartmentName = d.DeptName
                                   };

            Console.WriteLine("Students in CSE Department (Query Syntax):");
            foreach (var item in cseStudentsQuery)
            {
                Console.WriteLine(item.StudentName);
            }

        }
    }
}
