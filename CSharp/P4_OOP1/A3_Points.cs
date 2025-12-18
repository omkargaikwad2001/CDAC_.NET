using System;

namespace P4_OOP1
{
    internal class A3_Points
    {
        public int X { get; set; }
        public int Y { get; set; }

        public A3_Points()
        {
            X = 0;
            Y = 0;
        }

        public A3_Points(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"[{X},{Y}]");
        }

        static void Main1(string[] args)
        {
            A3_Points p1 = new A3_Points(10, 20);
            p1.Display();

            A3_Points p2 = new A3_Points { X = 30, Y = 40 };
            p2.Display();
        }
    }
}
