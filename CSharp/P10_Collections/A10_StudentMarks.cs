using System.Collections.Generic;

namespace P10_Collections
{
    internal class A10_StudentMarks : IComparer<A10_Student>
    {
        public int Compare(A10_Student x, A10_Student y)
        {
            return x.Marks.CompareTo(y.Marks);
        }
    }
}
