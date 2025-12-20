using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Exception
{
    internal class A2_ArraySize
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter array size...");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter value at index "+(i+1));
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Displaying data");

            for (int i = 0; i < arr.Length; i++) { 
                Console.WriteLine(arr[i]);
            }

            try
            {
                Console.WriteLine("Enter index to access data");
                int ind = int.Parse(Console.ReadLine());

                Console.WriteLine(arr[ind]);

            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This is finally....");
            }

        }
    }
}
