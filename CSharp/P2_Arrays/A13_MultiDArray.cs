using System;

namespace P2_Arrays
{
    internal class A13_MultiDArray
    {
        static void Main1(string[] args)
        {
            int[,] arr = new int[3, 4];

            // Input elements
            Console.WriteLine("Enter elements for 3x4 matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Display matrix
            Console.WriteLine("\nOriginal Matrix:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // 1. Separate odd and even elements into 1-D arrays
            int evenCount = 0, oddCount = 0;

            foreach (int n in arr)
            {
                if (n % 2 == 0) evenCount++;
                else oddCount++;
            }

            int[] evenArr = new int[evenCount];
            int[] oddArr = new int[oddCount];

            int e = 0, o = 0;
            foreach (int n in arr)
            {
                if (n % 2 == 0)
                    evenArr[e++] = n;
                else
                    oddArr[o++] = n;
            }

            Console.WriteLine("\nEven Elements:");
            foreach (int n in evenArr)
                Console.Write(n + " ");

            Console.WriteLine("\nOdd Elements:");
            foreach (int n in oddArr)
                Console.Write(n + " ");

            // 2. Transpose of array (4x3)
            Console.WriteLine("\n\nTranspose Matrix:");
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // 3. Max element in each row
            Console.WriteLine("\nMaximum element in each row:");
            for (int i = 0; i < 3; i++)
            {
                int maxRow = arr[i, 0];
                for (int j = 1; j < 4; j++)
                {
                    if (arr[i, j] > maxRow)
                        maxRow = arr[i, j];
                }
                Console.WriteLine($"Row {i + 1} Max = {maxRow}");
            }

            // 4. Max element in each column
            Console.WriteLine("\nMaximum element in each column:");
            for (int j = 0; j < 4; j++)
            {
                int maxCol = arr[0, j];
                for (int i = 1; i < 3; i++)
                {
                    if (arr[i, j] > maxCol)
                        maxCol = arr[i, j];
                }
                Console.WriteLine($"Column {j + 1} Max = {maxCol}");
            }
        }
    }
}
