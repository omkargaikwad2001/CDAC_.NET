using System;

namespace P8_Interfaces
{
    internal class A2_SavingAccount : A2_Account
    {
        public static double Int_Rate = 0.04;

        public A2_SavingAccount(int accNo, string name, double balance)
            : base(accNo, name, balance)
        {
        }

        public override double CalBalance()
        {
            return Balance + (Balance * Int_Rate);
        }
    }
}
