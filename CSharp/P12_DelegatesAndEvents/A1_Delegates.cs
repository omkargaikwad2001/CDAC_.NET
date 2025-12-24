using System;

namespace P12_DelegatesAndEvents
{
    // Step 1: Declare delegate
    delegate void StringDelegate(string s);

    internal class A1_Delegates
    {
        // Method 1: Print string in upper case
        public void Upper(string s)
        {
            Console.WriteLine("Upper Case: " + s.ToUpper());
        }

        // Method 2: Print string in lower case
        public void Lower(string s)
        {
            Console.WriteLine("Lower Case: " + s.ToLower());
        }

        // Method 3: Print string as it is
        public void Print(string s)
        {
            Console.WriteLine("Original String: " + s);
        }

        static void Main1(string[] args)
        {
            A1_Delegates obj = new A1_Delegates();

            Console.WriteLine("----- Single Cast Delegate -----");
            StringDelegate d1 = obj.Upper;
            d1("Hello World");

            Console.WriteLine("\n----- Multi Cast Delegate -----");
            StringDelegate d2 = obj.Upper;
            d2 += obj.Lower;
            d2 += obj.Print;
            d2("Dot Net Delegates");

            Console.WriteLine("\n----- Action Delegate -----");
            Action<string> act = obj.Upper;
            act += obj.Lower;
            act += obj.Print;
            act("Action Delegate Example");

            Console.ReadLine();
        }
    }
}
