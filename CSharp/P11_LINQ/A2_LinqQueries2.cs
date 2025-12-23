using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_LINQ
{
    internal class A2_LinqQueries2
    {
        static void Main1(string[] args)
        {
            List<string> list = new List<string>()
            {
                "orange",
                "cherry",
                "banana",
                "strawberry",
                "mango",
                "fig"
            };

            // -----------------------------
            // 1️ Count total elements
            // -----------------------------
            var totalCountQuery = (from s in list select s).Count();
            var totalCountMethod = list.Count();
            Console.WriteLine("Total elements: Query={0}, Method={1}", totalCountQuery, totalCountMethod);

            // -----------------------------
            // 2️ Count elements with length > 3
            // -----------------------------
            var countLengthGT3Query = (from s in list where s.Length > 3 select s).Count();
            var countLengthGT3Method = list.Count(s => s.Length > 3);
            Console.WriteLine("Count with length > 3: Query={0}, Method={1}", countLengthGT3Query, countLengthGT3Method);

            // -----------------------------
            // 3️ Count elements with length between 4 and 7
            // -----------------------------
            var countLengthBetweenQuery = (from s in list where s.Length >= 4 && s.Length <= 7 select s).Count();
            var countLengthBetweenMethod = list.Count(s => s.Length >= 4 && s.Length <= 7);
            Console.WriteLine("Count with length between 4 and 7: Query={0}, Method={1}", countLengthBetweenQuery, countLengthBetweenMethod);

            // -----------------------------
            // 4️ Display ascending order
            // -----------------------------
            var ascQuery = from s in list orderby s ascending select s;
            var ascMethod = list.OrderBy(s => s);
            Console.WriteLine("Ascending order (Query): " + string.Join(", ", ascQuery));
            Console.WriteLine("Ascending order (Method): " + string.Join(", ", ascMethod));

            // -----------------------------
            // 5️ Display descending order
            // -----------------------------
            var descQuery = from s in list orderby s descending select s;
            var descMethod = list.OrderByDescending(s => s);
            Console.WriteLine("Descending order (Query): " + string.Join(", ", descQuery));
            Console.WriteLine("Descending order (Method): " + string.Join(", ", descMethod));

            // -----------------------------
            // 6️ Display elements with length > 5
            // -----------------------------
            var lengthGT5Query = from s in list where s.Length > 5 select s;
            var lengthGT5Method = list.Where(s => s.Length > 5);
            Console.WriteLine("Elements with length > 5 (Query): " + string.Join(", ", lengthGT5Query));
            Console.WriteLine("Elements with length > 5 (Method): " + string.Join(", ", lengthGT5Method));

            // -----------------------------
            // 7️ Elements starting with 'm'
            // -----------------------------
            var startsWithMQuery = from s in list where s.StartsWith("m") select s;
            var startsWithMMethod = list.Where(s => s.StartsWith("m"));
            Console.WriteLine("Elements starting with 'm' (Query): " + string.Join(", ", startsWithMQuery));
            Console.WriteLine("Elements starting with 'm' (Method): " + string.Join(", ", startsWithMMethod));

            // -----------------------------
            // 8️ Elements ending with 'rry'
            // -----------------------------
            var endsWithRryQuery = from s in list where s.EndsWith("rry") select s;
            var endsWithRryMethod = list.Where(s => s.EndsWith("rry"));
            Console.WriteLine("Elements ending with 'rry' (Query): " + string.Join(", ", endsWithRryQuery));
            Console.WriteLine("Elements ending with 'rry' (Method): " + string.Join(", ", endsWithRryMethod));
        }
    }
}
