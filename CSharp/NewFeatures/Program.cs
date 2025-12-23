using System;

namespace NewFeatures
{
    // ================= INTERFACE (C# 8 FEATURES) =================
    interface ICalculator
    {
        // 1️ Default Instance Method with Body
        void Add(int a, int b)
        {
            Log("Add method called");
            Console.WriteLine($"Addition: {a + b}");
        }

        // 2️ Static Method in Interface
        static void Subtract(int a, int b)
        {
            Console.WriteLine($"Subtraction: {a - b}");
        }

        // 3️ Static Property in Interface
        static string Version => "C# 8 Interface";

        // 4️ Private Method in Interface (Helper)
        private void Log(string msg)
        {
            Console.WriteLine("[LOG] " + msg);
        }
    }

    // ================= CLASS IMPLEMENTING INTERFACE =================
    class Calculator : ICalculator
    {
        // No implementation required for Add()
    }

    // ================= MAIN PROGRAM =================
    internal class Program
    {
        static void Main1(string[] args)
        {
            // 5️ Nullable Reference Types
            string? name = null;
            Console.WriteLine(name ?? "Name is null");

            // 6️ Null-Coalescing Assignment
            string city = null;
            city ??= "Pune";
            Console.WriteLine("City: " + city);

            // 7️ Switch Expression
            int day = 2;
            string dayName = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                _ => "Invalid Day"
            };
            Console.WriteLine(dayName);

            // 8️ Using Declaration
            using var writer = new System.IO.StringWriter();
            writer.Write("Using declaration in C# 8");
            Console.WriteLine(writer.ToString());

            // 9️ Indices and Ranges
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Last Element: " + arr[^1]);
            int[] subArr = arr[1..4];
            Console.WriteLine("Range: " + string.Join(", ", subArr));

            // 10 Pattern Matching Enhancement
            PrintValue(10);
            PrintValue("Omkar");
            PrintValue(null);

            // ================= INTERFACE USAGE =================
            ICalculator calc = new Calculator();

            // Default interface method
            calc.Add(10, 20);

            // Static interface method
            ICalculator.Subtract(50, 30);

            // Static interface property
            Console.WriteLine(ICalculator.Version);
        }

        static void PrintValue(object obj)
        {
            switch (obj)
            {
                case int i when i > 0:
                    Console.WriteLine("Positive Integer");
                    break;
                case string s:
                    Console.WriteLine("String: " + s);
                    break;
                case null:
                    Console.WriteLine("Null value");
                    break;
                default:
                    Console.WriteLine("Other type");
                    break;
            }
        }
    }
}
