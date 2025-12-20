namespace P8_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1
            // Array of 5 Account references
            A1_Account[] accounts = new A1_Account[5];

            accounts[0] = new A1_SavingAccount(101, "Omkar", 10000);
            accounts[1] = new A1_SavingAccount(102, "Rahul", 5000);
            accounts[2] = new A1_RecurringAccount(201, "Neha", 15000, 12);
            accounts[3] = new A1_SavingAccount(103, "Amit", 3000);
            accounts[4] = new A1_RecurringAccount(202, "Pooja", 20000, 24);

            // Perform some operations
            accounts[0].Withdraw(3000);   // allowed
            accounts[1].Withdraw(4000);   // below min balance
            accounts[2].Withdraw(2000);   // not allowed
            accounts[3].Withdraw(500);    // allowed
            accounts[4].Withdraw(1000);   // not allowed

            Console.WriteLine("\n--- Account Details ---");

            // Iterate and display account info
            foreach (A1_Account acc in accounts)
            {
                Console.WriteLine(acc);   // calls ToString()
            }

        }
    }
}
