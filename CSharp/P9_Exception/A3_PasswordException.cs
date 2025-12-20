using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Exception
{
    internal class A3_PasswordException
    {
        static void Main1(string[] args)
        {

            Console.WriteLine("Enter password...");
            string pass = Console.ReadLine();

            if (pass.Length > 12)
            {
                throw new PasswordToLongException("Password is to long");
            }

            if (pass.Length < 8)
            {
                throw new PasswordToShortException("Password is to short");
            }

            Console.WriteLine("Password length is correct...");

        }
    }
}
