using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class A1_Person
    {
        public string name {  get; set; }
        public int age { get; set; }

        public A1_Person(string name, int age) { 
            this.name = name;
            this.age = age;
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"Name = {name} Age = {age}");
        }
    }
}
