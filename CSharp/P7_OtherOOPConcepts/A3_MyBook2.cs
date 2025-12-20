using System;

namespace P7_OtherOOPConcepts
{
    internal partial class MyBook
    {
        public void Display()
        {
            Console.WriteLine("Book Id : " + bookId);
            Console.WriteLine("Name    : " + name);
            Console.WriteLine("Author  : " + author);
        }
    }
}
