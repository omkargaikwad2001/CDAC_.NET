using System;

namespace P4_OOP1
{
    internal class A2_Box
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public A2_Box()
        {
            Height = 0;
            Width = 0;
            Depth = 0;
        }

        public A2_Box(double height, double width, double depth)
        {
            Height = height;
            Width = width;
            Depth = depth;
        }

        public A2_Box(A2_Box b)
        {
            Height = b.Height;
            Width = b.Width;
            Depth = b.Depth;
        }

        public double CalculateVolume()
        {
            return Height * Width * Depth;
        }

        static void Main1(string[] args)
        {
            A2_Box b1 = new A2_Box(10, 5, 2);
            Console.WriteLine("Volume of Box 1 = " + b1.CalculateVolume());

            A2_Box b2 = new A2_Box(b1);
            Console.WriteLine("Volume of Box 2 (Copied) = " + b2.CalculateVolume());
        }
    }
}
