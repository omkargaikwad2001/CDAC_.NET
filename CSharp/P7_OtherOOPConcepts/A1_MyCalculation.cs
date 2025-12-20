using System;

namespace P7_OtherOOPConcepts
{
    internal sealed class A1_MyCalculation
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Power(double baseNum, double exponent)
        {
            return Math.Pow(baseNum, exponent);
        }
    }

    //error cannot derive
    //internal class TestCalculation : A1_MyCalculation
    //{
    //}

    //sealed class cannot be inherited
    //Used to prevent further extension
    //Improves security & performance
    //Methods of sealed class can be accessed via object
}
