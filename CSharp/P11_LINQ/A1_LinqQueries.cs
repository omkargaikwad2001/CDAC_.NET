using System;
using System.Linq;

namespace P11_LINQ
{
    internal class A1_LinqQueries
    {
        static void Main1(string[] args)
        {
            int[] intNumbers = new int[] { 60, 80, 50, 90, 10, 30, 70, 40, 20, 100 };

            // -----------------------------
            // 1️ Count total elements
            // -----------------------------

            // Query Syntax
            var totalCountQuery = (from n in intNumbers select n).Count();
            Console.WriteLine("Total elements (Query Syntax): " + totalCountQuery);

            // Method Syntax
            var totalCountMethod = intNumbers.Count();
            Console.WriteLine("Total elements (Method Syntax): " + totalCountMethod);

            // -----------------------------
            // 2️ Count elements > 40
            // -----------------------------

            // Query Syntax
            var countGreater40Query = (from n in intNumbers where n > 40 select n).Count();
            Console.WriteLine("Count > 40 (Query Syntax): " + countGreater40Query);

            // Method Syntax
            var countGreater40Method = intNumbers.Count(n => n > 40);
            Console.WriteLine("Count > 40 (Method Syntax): " + countGreater40Method);

            // -----------------------------
            // 3️ Count elements between 10 and 60
            // -----------------------------

            // Query Syntax
            var countBetweenQuery = (from n in intNumbers where n >= 10 && n <= 60 select n).Count();
            Console.WriteLine("Count between 10 and 60 (Query Syntax): " + countBetweenQuery);

            // Method Syntax
            var countBetweenMethod = intNumbers.Count(n => n >= 10 && n <= 60);
            Console.WriteLine("Count between 10 and 60 (Method Syntax): " + countBetweenMethod);

            // -----------------------------
            // 4️ Display ascending order
            // -----------------------------

            // Query Syntax
            var ascQuery = from n in intNumbers orderby n ascending select n;
            Console.WriteLine("Ascending order (Query Syntax): " + string.Join(", ", ascQuery));

            // Method Syntax
            var ascMethod = intNumbers.OrderBy(n => n);
            Console.WriteLine("Ascending order (Method Syntax): " + string.Join(", ", ascMethod));

            // -----------------------------
            // 5️ Display descending order
            // -----------------------------

            // Query Syntax
            var descQuery = from n in intNumbers orderby n descending select n;
            Console.WriteLine("Descending order (Query Syntax): " + string.Join(", ", descQuery));

            // Method Syntax
            var descMethod = intNumbers.OrderByDescending(n => n);
            Console.WriteLine("Descending order (Method Syntax): " + string.Join(", ", descMethod));
        }
    }
}
