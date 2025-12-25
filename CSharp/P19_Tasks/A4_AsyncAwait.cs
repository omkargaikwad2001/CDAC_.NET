using System;
using System.Threading.Tasks;

namespace P19_Tasks
{
    internal class A4_AsyncAwait
    {
        static async Task Main1(string[] args)
        {
            // Start printing numbers
            Task t1 = printNos();

            // Calculate salary
            int res = await CalculateSalary();

            // Calculate tax
            Task t2 = CalculateTax(res);

            // Wait for all async tasks to finish
            await Task.WhenAll(t1, t2);

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static async Task CalculateTax(int res)
        {
            Console.WriteLine("In Calculate Tax");
            Console.WriteLine("Tax is : " + (res * 0.30));
            await Task.Delay(100);
        }

        private static async Task<int> CalculateSalary()
        {
            Console.WriteLine("In Calculate Salary");
            await Task.Delay(1000);
            return 50000;
        }

        public static async Task printNos()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                await Task.Delay(100);
            }
        }
    }
}
