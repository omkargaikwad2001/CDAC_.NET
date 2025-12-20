using System;

namespace P6_OOP2
{
    internal class A8_RegCustomer : A8_Customer
    {
        private int regNo;

        public A8_RegCustomer(string emailId, string address, int regNo)
            : base(emailId, address)
        {
            this.regNo = regNo;
        }

        // 5% discount for registered customer
        public override double GiveDiscount(double shoppingPrice)
        {
            double discount = shoppingPrice * 0.05;
            return shoppingPrice - discount;
        }
    }
}
