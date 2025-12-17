using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_String
{
    internal class A16_StringMenu
    {
        static void Main1(string[] args)
        {

            string[] cities = { "Mumbai", "Delhi", "Pune", "Bengaluru", "Chennai", "Hyderabad", "Kolkata", "Jaipur", "Ahmedabad", "Nagpur" };

            int choice=1;
            do
            {

                Console.WriteLine("Enter 1 to display all strings");
                Console.WriteLine("Enter 2 to display all strings in Capital case");
                Console.WriteLine("Enter 3 to display all strings in Lower case");
                Console.WriteLine("Enter 4 to sort elements in ascending order");
                Console.WriteLine("Enter 5 to sort elements in descending order");
                Console.WriteLine("Enter 6 to reverse array elements");
                Console.WriteLine("Enter 7 to reverse each string(each array element) in array");
                Console.WriteLine("Enter 8 to find string with max length");
                Console.WriteLine("Enter 9 to find string with min length");
                
                Console.WriteLine("Enter 0 exit");
                
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        break;

                    case 1:
                        //Console.WriteLine("1");
                        foreach(string str in cities)
                        {
                            Console.WriteLine(str);
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        //Console.WriteLine("2");
                        foreach(string str in cities)
                        {
                            Console.WriteLine(str.ToUpper());
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        //Console.WriteLine("3");
                        foreach (string str in cities)
                        {
                            Console.WriteLine(str.ToLower());
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        //Console.WriteLine("4");
                        Array.Sort(cities);
                        foreach(String str in cities)
                        {
                            Console.WriteLine(str);
                        }
                        break;

                    case 5:
                        //Console.WriteLine("5");
                        Array.Sort(cities);
                        Array.Reverse(cities);
                        foreach (String str in cities)
                        {
                            Console.WriteLine(str);
                        }
                        break;

                    case 6:
                        //Console.WriteLine("6");
                        Array.Reverse(cities);
                        foreach (String str in cities)
                        {
                            Console.WriteLine(str);
                        }
                        break;

                    case 7:
                        //Console.WriteLine("7");
                        Console.WriteLine("Before Reversing word");

                        foreach (String str in cities)
                        {
                            Console.Write(str+", ");
                        }

                        for (int i = 0; i < cities.Length; i++)
                        {
                            char[] arr = cities[i].ToCharArray();
                            Array.Reverse(arr);
                            cities[i] = new string(arr);
                        }

                        Console.WriteLine("After Reversing word");
                        foreach (String str in cities)
                        {
                            Console.Write(str+", ");
                        }
                        break;

                    case 8:
                        //Console.WriteLine("8");
                        int maxLen = 0;
                        int posi = 0;
                        for(int i = 0; i < cities.Length; i++)
                        {
                            if(cities[i].Length > maxLen)
                            {
                                maxLen = cities[i].Length;
                                posi = i;
                            }
                        }
                        Console.WriteLine("String with maxLen = " + cities[posi]+" with Length "+maxLen);
                        break;

                    case 9:
                        //Console.WriteLine("9");
                        int minLen = 9999;
                        int posi2 = 0;
                        for (int i = 0; i < cities.Length; i++)
                        {
                            if (cities[i].Length < minLen)
                            {
                                minLen = cities[i].Length;
                                posi2 = i;
                            }
                        }
                        Console.WriteLine("String with minLen = " + cities[posi2] + " with Length " + minLen);
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            } while (choice != 0);

            Console.WriteLine("Out of loop");

        }
    }
}
