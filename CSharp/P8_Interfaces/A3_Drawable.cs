using System;

namespace P8_Interfaces
{
    internal interface A3_Drawable
    {
        float Pl { get; set; }

        void DrawShape();
        float CalculateArea();
        float CalculatePerimeter();
    }
}
