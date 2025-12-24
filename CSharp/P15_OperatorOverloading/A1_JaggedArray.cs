using System;

namespace P15_OperatorOverloading
{
    internal class A1_JaggedArray
    {
        static void Main1(string[] args)
        {
            int[][] jaggedArray = new int[4][];

            jaggedArray[0] = new int[] { 1, 2, 3 };
            jaggedArray[1] = new int[] { 4, 5 };
            jaggedArray[2] = new int[] { 6, 7, 8, 9 };
            jaggedArray[3] = new int[] { 10 };

            Console.WriteLine("----- Jagged Array Elements -----");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int sum = 0;
                Console.Write("Element " + (i + 1) + ": ");

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                    sum += jaggedArray[i][j];
                }

                Console.WriteLine("=> Sum = " + sum);
            }

            Console.ReadLine();
        }
    }
}
