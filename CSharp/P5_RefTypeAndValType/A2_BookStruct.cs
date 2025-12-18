using System;

namespace P5_RefTypeAndValType
{
    internal class A2_BookStruct
    {
        struct Books
        {
            public int bookId;
            public string bookName;
            public string author;
            public float price;

            public void display()
            {
                Console.WriteLine("BookId = " + bookId);
                Console.WriteLine("BookName = " + bookName);
                Console.WriteLine("Author = " + author);
                Console.WriteLine("Price = " + price);
            }
        }

        static void Main1(string[] args)
        {
            Books[] book = new Books[3];

            book[0].bookId = 101;
            book[0].bookName = "CPP";
            book[0].author = "Omkar";
            book[0].price = 500.00f;
            book[0].display();

            book[1].bookId = 102;
            book[1].bookName = "Java";
            book[1].author = "James";
            book[1].price = 650.00f;

            book[2].bookId = 103;
            book[2].bookName = "C#";
            book[2].author = "Anders";
            book[2].price = 700.00f;

            //for (int i = 0; i < book.Length; i++)
            //{
            //    book[i].display();
            //    Console.WriteLine("**************************");
            //}
        }
    }
}
