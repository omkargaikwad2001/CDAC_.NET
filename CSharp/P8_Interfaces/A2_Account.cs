using System;

namespace P8_Interfaces
{
    internal abstract class A2_Account
    {
        public int AccNo { get; set; }
        public string Name { get; set; }

        public double Balance { get; set; }

        public A2_Account(int accNo, string name, double balance)
        {
            AccNo = accNo;
            Name = name;
            Balance = balance;
        }

        public abstract double CalBalance();

        public override string ToString()
        {
            return $"AccNo:{AccNo}, Name:{Name}";
        }
    }
}
