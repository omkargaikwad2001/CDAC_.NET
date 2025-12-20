using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Interfaces
{
    internal abstract class A1_Account
    {
        public int AccNo { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public A1_Account(int AccNo, string Name, double Balance) {
            
            this.AccNo = AccNo;
            this.Name= Name;
            this.Balance = Balance;

        }
        public abstract void Withdraw(double amt);

        public override string ToString() {
            return $"Account NO:{AccNo} Name:{Name} Balance:{Balance}";
        }
    }
}
