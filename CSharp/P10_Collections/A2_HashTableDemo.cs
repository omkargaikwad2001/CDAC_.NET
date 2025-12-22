using System;
using System.Collections;

namespace P10_Collections
{
    internal class A2_HashTableDemo
    {
        static void Main1(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("Omkar", 123);
            ht.Add("Amit", 456);
            ht.Add("Shubham", 789);
            ht.Add("Kiran", 987);
            ht.Add("Ajay", 654);

            // Display Hashtable
            Console.WriteLine("Hashtable elements:");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine(entry.Key + " ----- " + entry.Value);
            }

            Console.WriteLine("\n----------------------------------");

            // 1. Accept name and find present or not
            Console.WriteLine("Enter name to search:");
            string name = Console.ReadLine();

            if (ht.ContainsKey(name))
            {
                Console.WriteLine("Phone number: " + ht[name]);
            }
            else
            {
                Console.WriteLine("Name not found");
            }

            Console.WriteLine("\n----------------------------------");

            // 2. Accept phone number and find present or not
            Console.WriteLine("Enter phone number to search:");
            int phone = int.Parse(Console.ReadLine());

            bool phoneFound = false;
            foreach (DictionaryEntry entry in ht)
            {
                if (entry.Value.Equals(phone))
                {
                    Console.WriteLine("Name: " + entry.Key);
                    phoneFound = true;
                    break;
                }
            }

            if (!phoneFound)
            {
                Console.WriteLine("Phone number not found");
            }

            Console.WriteLine("\n----------------------------------");

            // 3. Accept name and remove from collection
            Console.WriteLine("Enter name to remove:");
            string removeName = Console.ReadLine();

            if (ht.ContainsKey(removeName))
            {
                ht.Remove(removeName);
                Console.WriteLine("Removed successfully");
            }
            else
            {
                Console.WriteLine("Name not found");
            }

            Console.WriteLine("\nHashtable after removal:");
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine(entry.Key + " ----- " + entry.Value);
            }
        }
    }
}
