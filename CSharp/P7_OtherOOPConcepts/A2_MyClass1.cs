using System;

namespace P7_OtherOOPConcepts
{
    internal class A2_MyClass1 : A2_MyClass
    {
        public sealed override int Add(int a, int b)
        {
            return (a + b) + 10;   // modified behavior
        }

        public override int Subtract(int a, int b)
        {
            return (a - b) - 5;
        }
    }
}
