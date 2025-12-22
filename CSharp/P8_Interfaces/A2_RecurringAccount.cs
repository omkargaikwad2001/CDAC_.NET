using System;

namespace P8_Interfaces
{
    internal class A2_RecurringAccount : A2_Account
    {
        public int No_Of_Installments { get; set; }

        public static double Int_Rate = 0.06; 

        public A2_RecurringAccount(int accNo, string name, double installmentAmt, int noOfInstallments)
            : base(accNo, name, installmentAmt)
        {
            No_Of_Installments = noOfInstallments;
        }

        public override double CalBalance()
        {
            double totalAmount = Balance * No_Of_Installments;
            return totalAmount + (totalAmount * Int_Rate);
        }

        public override string ToString()
        {
            return base.ToString() + $", Installments:{No_Of_Installments}";
        }
    }
}
