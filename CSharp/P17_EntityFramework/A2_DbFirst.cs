using System;
using System.Linq;
using P17_EntityFramework.Models;

namespace P17_EntityFramework
{
    internal class A2_DbFirst
    {
        static void Main1(string[] args)
        {
            using (DotnetContext db = new DotnetContext())
            {
                // ---------------- CREATE ----------------
                //Book b1 = new Book()
                //{
                //    Name = "ASP.NET Core",
                //    Price = 550
                //};

                //db.Books.Add(b1);
                //db.SaveChanges();
                //Console.WriteLine("Book Inserted Successfully");

                //    // ---------------- READ ----------------
                //Console.WriteLine("\nAll Books:");
                //var books = db.Books.ToList();

                //foreach (var b in books)
                //{
                //    Console.WriteLine($"ID: {b.Bookid}, Name: {b.Name}, Price: {b.Price}");
                //}

                //    // ---------------- UPDATE ----------------
                //Console.WriteLine("Enter bid to update...");
                //int bid = int.Parse(Console.ReadLine());
                //var bookToUpdate = db.Books.FirstOrDefault(b => b.Bookid == bid);
                //if (bookToUpdate != null)
                //{
                //    bookToUpdate.Price = 650;
                //    db.SaveChanges();
                //    Console.WriteLine("\nBook Updated Successfully");
                //}

                //    // ---------------- DELETE ----------------
                Console.WriteLine("Enter bid to delete...");
                int bid = int.Parse(Console.ReadLine());
                var bookToDelete = db.Books.FirstOrDefault(b => b.Bookid == bid);
                if (bookToDelete != null)
                {
                    db.Books.Remove(bookToDelete);
                    db.SaveChanges();
                    Console.WriteLine("\nBook Deleted Successfully");
                }
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
