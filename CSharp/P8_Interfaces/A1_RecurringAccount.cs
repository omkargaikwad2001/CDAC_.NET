using System;

namespace P8_Interfaces
{
    internal class A1_RecurringAccount : A1_Account
    {
        public int Installment { get; set; }

        public A1_RecurringAccount(int accNo, string name, double balance, int installment)
            : base(accNo, name, balance)
        {
            Installment = installment;
        }

        public override void Withdraw(double amt)
        {
            Console.WriteLine("Cannot withdraw because it is a recurring account...");
        }
    }
}
