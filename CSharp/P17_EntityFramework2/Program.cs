using System;
using System.Linq;
using P17_EntityFramework2.Models;

namespace P17_EntityFramework2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Database.EnsureCreated(); // create DB & table if not exists

                int choice;
                do
                {
                    Console.Clear();
                    Console.WriteLine("====== STUDENT CRUD (CODE FIRST) ======");
                    Console.WriteLine("1. Insert Student");
                    Console.WriteLine("2. Display All Students");
                    Console.WriteLine("3. Update Student");
                    Console.WriteLine("4. Delete Student");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter Choice: ");

                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            InsertStudent(db);
                            break;

                        case 2:
                            DisplayStudents(db);
                            break;

                        case 3:
                            UpdateStudent(db);
                            break;

                        case 4:
                            DeleteStudent(db);
                            break;

                        case 5:
                            Console.WriteLine("Exiting...");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                } while (choice != 5);
            }
        }

        // ---------------- INSERT ----------------
        static void InsertStudent(AppDbContext db)
        {
            Student s = new Student();

            Console.Write("Enter Name: ");
            s.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            s.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Fees: ");
            s.Fees = double.Parse(Console.ReadLine());

            db.Students.Add(s);
            db.SaveChanges();

            Console.WriteLine("Student Inserted Successfully");
        }

        // ---------------- DISPLAY ----------------
        static void DisplayStudents(AppDbContext db)
        {
            var students = db.Students.ToList();

            Console.WriteLine("\nID\tName\tAge\tFees");
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id}\t{s.Name}\t{s.Age}\t{s.Fees}");
            }
        }

        // ---------------- UPDATE ----------------
        static void UpdateStudent(AppDbContext db)
        {
            Console.Write("Enter Student ID to Update: ");
            int id = int.Parse(Console.ReadLine());

            var student = db.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                Console.Write("Enter New Name: ");
                student.Name = Console.ReadLine();

                Console.Write("Enter New Age: ");
                student.Age = int.Parse(Console.ReadLine());

                Console.Write("Enter New Fees: ");
                student.Fees = double.Parse(Console.ReadLine());

                db.SaveChanges();
                Console.WriteLine("Student Updated Successfully");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }

        // ---------------- DELETE ----------------
        static void DeleteStudent(AppDbContext db)
        {
            Console.Write("Enter Student ID to Delete: ");
            int id = int.Parse(Console.ReadLine());

            var student = db.Students.FirstOrDefault(s => s.Id == id);

            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
                Console.WriteLine("Student Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Student Not Found");
            }
        }
    }
}
