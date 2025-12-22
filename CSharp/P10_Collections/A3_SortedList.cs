using System;
using System.Collections;

namespace P10_Collections
{
    internal class A3_SortedList
    {
        static void Main1(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add("Omkar", 123);
            sl.Add("Amit", 456);
            sl.Add("Shubham", 789);
            sl.Add("Kiran", 987);
            sl.Add("Ajay", 654);

            Console.WriteLine("Displaying records:");
            foreach (DictionaryEntry entry in sl)
            {
                Console.WriteLine(entry.Key + " ----- " + entry.Value);
            }

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("Enter name to search:");
            string name = Console.ReadLine();

            if (sl.ContainsKey(name))
            {
                Console.WriteLine("Phone number: " + sl[name]);
            }
            else
            {
                Console.WriteLine("Name not found");
            }

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("Enter phone number to search:");
            int phone = int.Parse(Console.ReadLine());

            bool found = false;
            foreach (DictionaryEntry entry in sl)
            {
                if (entry.Value.Equals(phone))
                {
                    Console.WriteLine("Name: " + entry.Key);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Phone number not found");
            }

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("Enter name to remove:");
            string removeName = Console.ReadLine();

            if (sl.ContainsKey(removeName))
            {
                sl.Remove(removeName);
                Console.WriteLine("Removed successfully");
            }
            else
            {
                Console.WriteLine("Name not found");
            }

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("Key List:");
            foreach (var key in sl.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\n--------------------------------");

            Console.WriteLine("Value List:");
            foreach (var value in sl.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
