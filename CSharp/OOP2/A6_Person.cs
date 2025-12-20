using System;

namespace P6_OOP2
{
    internal class A6_Person
    {
        protected string name;
        protected string phone;
        protected string email;

        public A6_Person(string name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        public virtual void Display()
        {
            Console.WriteLine("Person Details:");
            Console.WriteLine("Name  : " + name);
            Console.WriteLine("Phone : " + phone);
            Console.WriteLine("Email : " + email);
        }
    }
}
