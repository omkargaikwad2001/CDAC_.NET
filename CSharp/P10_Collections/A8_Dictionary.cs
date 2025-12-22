using System;
using System.Collections.Generic;

namespace P10_Collections
{
    internal class A8_Dictionary
    {
        static void Main1(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();

            students.Add(101, "Omkar");
            students.Add(102, "Amit");
            students.Add(103, "Rahul");
            students.Add(104, "Neha");
            students.Add(105, "Pooja");

            Console.WriteLine("Initial Dictionary:");
            Display(students);

            Console.WriteLine("\n-----------------------------");

            Console.Write("Enter roll no to find: ");
            int findRoll = Convert.ToInt32(Console.ReadLine());

            if (students.ContainsKey(findRoll))
            {
                Console.WriteLine("Student Name: " + students[findRoll]);
            }
            else
            {
                Console.WriteLine("Roll number not found");
            }

            Console.WriteLine("\n-----------------------------");

            Console.Write("Enter roll no to update name: ");
            int updateRoll = Convert.ToInt32(Console.ReadLine());

            if (students.ContainsKey(updateRoll))
            {
                Console.Write("Enter new name: ");
                string newName = Console.ReadLine();
                students[updateRoll] = newName;
                Console.WriteLine("Record updated successfully");
            }
            else
            {
                Console.WriteLine("Roll number not found");
            }

            Console.WriteLine("\n-----------------------------");

            Console.Write("Enter roll no to delete: ");
            int deleteRoll = Convert.ToInt32(Console.ReadLine());

            if (students.Remove(deleteRoll))
            {
                Console.WriteLine("Record deleted successfully");
            }
            else
            {
                Console.WriteLine("Roll number not found");
            }

            Console.WriteLine("\n-----------------------------");

            Console.WriteLine("Final Dictionary:");
            Display(students);
        }

        static void Display(Dictionary<int, string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " ----- " + item.Value);
            }
        }
    }
}
