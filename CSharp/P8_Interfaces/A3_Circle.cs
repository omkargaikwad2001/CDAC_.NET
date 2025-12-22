using System;

namespace P8_Interfaces
{
    internal class A3_Circle : A3_Drawable
    {
        public float Pl { get; set; }

        public A3_Circle(float radius)
        {
            Pl = radius;
        }

        public void DrawShape()
        {
            Console.WriteLine("Drawing Circle");
        }

        public float CalculateArea()
        {
            return (float)(Math.PI * Pl * Pl);
        }

        public float CalculatePerimeter()
        {
            return (float)(2 * Math.PI * Pl);
        }
    }
}
