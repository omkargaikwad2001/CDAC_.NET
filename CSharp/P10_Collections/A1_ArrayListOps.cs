using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_Collections
{
    internal class A1_ArrayListOps
    {
        static void Main1(string[] args)
        {
            
            ArrayList al = new ArrayList();
            
            //add element
            al.Add(1);
            al.Add("omkar");
            al.Add(56.23f);
            al.Add(true);

            Console.WriteLine("all elements in arraylist");
            foreach (var i in al) {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            //remove element
            al.Remove("omkar");
            Console.WriteLine("list after removing omkar");
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //remove element at index
            al.RemoveAt(0);
            Console.WriteLine("list after removing 0 index");
            foreach (var i in al)
            {
                Console.WriteLine(i);
            }
        }
    }
}
