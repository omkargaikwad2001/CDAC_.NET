using System;

namespace P7_OtherOOPConcepts
{
    internal partial class MyBook
    {
        private int bookId;
        private string name;
        private double price;
        private string author;

        public MyBook(int bookId, string name, double price, string author)
        {
            this.bookId = bookId;
            this.name = name;
            this.price = price;
            this.author = author;
        }
    }
}
