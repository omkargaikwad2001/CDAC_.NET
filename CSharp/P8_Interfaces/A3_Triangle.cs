using System;

namespace P8_Interfaces
{
    internal class A3_Triangle : A3_Drawable
    {
        public float Pl { get; set; }
        public float Height { get; set; }
        public float Side { get; set; }

        public A3_Triangle(float baseVal, float height, float side)
        {
            Pl = baseVal;
            Height = height;
            Side = side;
        }

        public void DrawShape()
        {
            Console.WriteLine("Drawing Triangle");
        }

        public float CalculateArea()
        {
            return 0.5f * Pl * Height;
        }

        public float CalculatePerimeter()
        {
            return Pl + Height + Side;
        }
    }
}
