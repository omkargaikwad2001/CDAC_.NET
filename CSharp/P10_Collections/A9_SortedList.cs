using System;
using System.Collections.Generic;

namespace P10_Collections
{
    internal class A9_SortedList
    {
        static void Main1(string[] args)
        {
            SortedList<string, string> languages = new SortedList<string, string>();

            languages.Add("C", "C Programming");
            languages.Add("C++", "C Plus Plus");
            languages.Add("Java", "Java Language");
            languages.Add("C#", "C Sharp");
            languages.Add("Python", "Python Language");

            Console.WriteLine("SortedList Elements (Sorted by Key):");
            foreach (KeyValuePair<string, string> item in languages)
            {
                Console.WriteLine(item.Key + " ----- " + item.Value);
            }
        }
    }
}
