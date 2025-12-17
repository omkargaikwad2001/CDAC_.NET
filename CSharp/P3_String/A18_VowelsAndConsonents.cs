using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_String
{
    internal class A18_VowelsAndConsonents
    {
        static void Main(string[] args)
        {
            string str = "Omkar";
            int vowelcnt = 0;
            int consocnt = 0;

            string str2 = str.ToLower();
            for (int i = 0; i < str2.Length; i++)
            {
                char ch = str2[i];

                if (ch >= 'a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vowelcnt++;
                    }
                    else
                    {
                        consocnt++;
                    }
                }

            }


            Console.WriteLine("Count of Vowels = " + vowelcnt);
            Console.WriteLine("Count of Consonents = " + consocnt);

        }
    }
}
