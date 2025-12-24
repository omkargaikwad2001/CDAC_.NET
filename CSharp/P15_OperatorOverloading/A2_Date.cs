using System;

namespace P15_OperatorOverloading
{
    internal class A2_Date
    {
        int day;
        int month;
        int year;

        public A2_Date(int d, int m, int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public static A2_Date ReadDate()
        {
            Console.Write("Enter Day: ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("Enter Month: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Enter Year: ");
            int y = int.Parse(Console.ReadLine());

            return new A2_Date(d, m, y);
        }

        public void Display()
        {
            Console.WriteLine($"Date: {day}/{month}/{year}");
        }

        public static A2_Date operator ++(A2_Date dt)
        {
            dt.day++;

            if (dt.day > 30) 
            {
                dt.day = 1;
                dt.month++;

                if (dt.month > 12)
                {
                    dt.month = 1;
                    dt.year++;
                }
            }
            return dt;
        }

        public static bool operator >(A2_Date d1, A2_Date d2)
        {
            if (d1.year != d2.year)
                return d1.year > d2.year;
            if (d1.month != d2.month)
                return d1.month > d2.month;
            return d1.day > d2.day;
        }

        public static bool operator <(A2_Date d1, A2_Date d2)
        {
            if (d1.year != d2.year)
                return d1.year < d2.year;
            if (d1.month != d2.month)
                return d1.month < d2.month;
            return d1.day < d2.day;
        }

        static void Main1(string[] args)
        {
            Console.WriteLine("Enter First Date:");
            A2_Date d1 = ReadDate();

            Console.WriteLine("\nEnter Second Date:");
            A2_Date d2 = ReadDate();

            Console.WriteLine("\nFirst Date:");
            d1.Display();

            Console.WriteLine("Second Date:");
            d2.Display();

            Console.WriteLine("\nIncrementing First Date by one day...");
            d1++;
            d1.Display();

            if (d1 > d2)
                Console.WriteLine("First Date is greater than Second Date");
            else if (d1 < d2)
                Console.WriteLine("Second Date is greater than First Date");
            else
                Console.WriteLine("Both Dates are equal");
        }
    }
}
