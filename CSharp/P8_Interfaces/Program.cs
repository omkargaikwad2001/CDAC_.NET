namespace P8_Interfaces
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Assignment 1
            // Array of 5 Account references
            //A1_Account[] accounts = new A1_Account[5];

            //accounts[0] = new A1_SavingAccount(101, "Omkar", 10000);
            //accounts[1] = new A1_SavingAccount(102, "Rahul", 5000);
            //accounts[2] = new A1_RecurringAccount(201, "Neha", 15000, 12);
            //accounts[3] = new A1_SavingAccount(103, "Amit", 3000);
            //accounts[4] = new A1_RecurringAccount(202, "Pooja", 20000, 24);

            // Perform some operations
            //accounts[0].Withdraw(3000);   // allowed
            //accounts[1].Withdraw(4000);   // below min balance
            //accounts[2].Withdraw(2000);   // not allowed
            //accounts[3].Withdraw(500);    // allowed
            //accounts[4].Withdraw(1000);   // not allowed

            //Console.WriteLine("\n--- Account Details ---");

            // Iterate and display account info
            //foreach (A1_Account acc in accounts)
            //{
            //    Console.WriteLine(acc);   // calls ToString()
            //}

            //Assignment 2
            //A2_Account[] accounts = new A2_Account[4];

            //accounts[0] = new A2_SavingAccount(101, "Omkar", 10000);
            //accounts[1] = new A2_SavingAccount(102, "Rahul", 5000);
            //accounts[2] = new A2_RecurringAccount(201, "Neha", 3000, 12);
            //accounts[3] = new A2_RecurringAccount(202, "Pooja", 4000, 24);

            //Console.WriteLine("---- Final Balance Details ----");

            //foreach (A2_Account acc in accounts)
            //{
            //    Console.WriteLine(acc);
            //    Console.WriteLine("Calculated Balance: " + acc.CalBalance());
            //    Console.WriteLine();
            //}

            //Assignment 3

            //A3_Drawable[] shapes = new A3_Drawable[3];

            //shapes[0] = new A3_Circle(5);
            //shapes[1] = new A3_Rectangle(10, 5);
            //shapes[2] = new A3_Triangle(6, 4, 5);

            //foreach (A3_Drawable shape in shapes)
            //{
            //    shape.DrawShape();
            //    Console.WriteLine("Area : " + shape.CalculateArea());
            //    Console.WriteLine("Perimeter : " + shape.CalculatePerimeter());
            //    Console.WriteLine();
            //}

            //Assignment 4

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            A4_IintOps obj = new A4_MyNumber(num);

            Console.WriteLine("Is Even : " + obj.IsEven(num));
            Console.WriteLine("Is Odd  : " + obj.IsOdd(num));
            Console.WriteLine("Is Prime: " + obj.IsPrime(num));
            Console.WriteLine("Factorial: " + obj.CalFactorial(num));

        }
    }
}
