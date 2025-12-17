using System;

namespace P2_Arrays
{
    internal class A15_RangeOperator
    {
        static void Main1(string[] args)
        {
            string[] cities =
            {
                "Mumbai",
                "Pune",
                "Delhi",
                "Bangalore",
                "Chennai",
                "Kolkata"
            };

            Console.WriteLine("All Cities:");
            foreach (string city in cities)
            {
                Console.Write(city + " ");
            }

            // First 3 cities
            string[] firstThree = cities[..3];
            Console.WriteLine("\n\nFirst 3 Cities:");
            foreach (string city in firstThree)
            {
                Console.Write(city + " ");
            }

            // Middle cities
            string[] middleCities = cities[2..^2];
            Console.WriteLine("\n\nMiddle Cities:");
            foreach (string city in middleCities)
            {
                Console.Write(city + " ");
            }

            // Last 2 cities
            string[] lastTwo = cities[^2..];
            Console.WriteLine("\n\nLast 2 Cities:");
            foreach (string city in lastTwo)
            {
                Console.Write(city + " ");
            }
        }
    }
}
