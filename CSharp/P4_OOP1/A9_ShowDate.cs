using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_OOP1
{
    internal class A9_ShowDate
    {
        public void ShowDate(char ch)
        {
            Console.WriteLine($"12{ch}18{ch}2025");
        }
        static void Main1(string[] args)
        {
            A9_ShowDate d = new A9_ShowDate();

            d.ShowDate(':');
            d.ShowDate(',');
            d.ShowDate(' ');
            d.ShowDate('$');
        }
    }
}
