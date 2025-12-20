using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7_OtherOOPConcepts
{
    internal class A4_Book
    {
        public static int BookId { get; set; } = 0; 
        public string BName {  get; set; }
        public float BPrice { get; set; }

        public A4_Book() {

            BookId++;

        }
        public A4_Book(string BName, float BPrice)
        {
            BookId++;
            this.BName = BName;
            this.BPrice = BPrice;
        }
          
        public void DisplayBookInfo()
        {
            Console.WriteLine("Book Id = "+BookId);
            Console.WriteLine("Book Name = " + BName);
            Console.WriteLine("Book Price = " + BPrice);
            Console.WriteLine();
        }

    }
}
