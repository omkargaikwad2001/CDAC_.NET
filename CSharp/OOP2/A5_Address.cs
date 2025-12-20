using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_OOP2
{
    internal class A5_Address
    {
        public string City { get; set; }
        public string State { get; set; }

        public A5_Address(string City, string State) {
            this.City = City;
            this.State = State;
        }
        public void DisplayAddress()
        {
            Console.WriteLine($"City = {City} State = {State}");
        }

    }
}
