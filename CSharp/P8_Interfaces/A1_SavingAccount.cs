using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Interfaces
{
    internal class A1_SavingAccount:A1_Account
    {
        private const double MinBalance = 2000;

        public A1_SavingAccount(int AccNo, string Name, double Balance):base(AccNo,Name,Balance) { }
        public override void Withdraw(double amt)
        {
            if (Balance-amt>=MinBalance)
            {
                Balance-=amt;
                Console.WriteLine($"Withdrawal {amt} from saving");
            }
            else
            {
                Console.WriteLine("balance is below 2000");
            }

        }
    }
}
