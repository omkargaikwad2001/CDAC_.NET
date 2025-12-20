using System;

namespace P7_OtherOOPConcepts
{
    internal class A2_MyClass2 : A2_MyClass1
    {
        //ERROR: Cannot override sealed method
        /*
        public override int Add(int a, int b)
        {
            return a + b;
        }
        */

        // Allowed (not sealed in parent)
        public override int Subtract(int a, int b)
        {
            return a - b + 2;
        }
    }
}
