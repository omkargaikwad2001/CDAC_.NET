using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Exception
{
    internal class A1_NumberException
    {

        static void Main1(string[] args)
        {
            Console.WriteLine("Enter first number");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int n2 = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(n1/n2);
            }
            catch(DivideByZeroException e) {
                Console.WriteLine("This is divide by zero catch");
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("This is general catch block");
                Console.WriteLine(ex.ToString());
            }
            finally {
                Console.WriteLine("This is finally block...");
            }

        }

    }
}
