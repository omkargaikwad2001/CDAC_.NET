using System;

namespace P6_OOP2
{
    internal class A8_Customer
    {
        protected string emailId;
        protected string address;

        public A8_Customer(string emailId, string address)
        {
            this.emailId = emailId;
            this.address = address;
        }

        // No discount for normal customer
        public virtual double GiveDiscount(double shoppingPrice)
        {
            return shoppingPrice;
        }
    }
}
