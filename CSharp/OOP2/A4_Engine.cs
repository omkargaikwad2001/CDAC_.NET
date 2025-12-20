using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_OOP2
{
    internal class A4_Engine
    {
        public int CC {  get; set; }

        public A4_Engine(int CC) {
            this.CC = CC;
        }
        public void StartEngine()
        {
            Console.WriteLine("Engine started...");
        }
    }
}
