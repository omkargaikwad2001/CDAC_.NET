using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP1
{
    internal class A13_Indexer
    {
        int[] arr;
        public A13_Indexer() { 
            arr = new int[5];
        }

        public int this[int index]
        {
            get {  return arr[index]; }
            set { arr[index] = value; }
        }

        static void Main1(string[] args)
        {
            A13_Indexer a = new A13_Indexer();

            //This is direct access not using indexer
            //a.arr[0] = 10;
            //a.arr[1] = 20;
            //a.arr[2] = 30;
            //a.arr[3] = 40;
            //a.arr[4] = 50;

            //Console.WriteLine(a.arr[0]);
            //Console.WriteLine(a.arr[1]);
            //Console.WriteLine(a.arr[2]);
            //Console.WriteLine(a.arr[3]);
            //Console.WriteLine(a.arr[4]);

            //using indexer
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
            a[4] = 50;

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);
        }
    }
}
