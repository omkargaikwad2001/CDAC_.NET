using System;

namespace P8_Interfaces
{
    internal class A3_Rectangle : A3_Drawable
    {
        public float Pl { get; set; }  
        public float Breadth { get; set; }

        public A3_Rectangle(float length, float breadth)
        {
            Pl = length;
            Breadth = breadth;
        }

        public void DrawShape()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public float CalculateArea()
        {
            return Pl * Breadth;
        }

        public float CalculatePerimeter()
        {
            return 2 * (Pl + Breadth);
        }
    }
}
