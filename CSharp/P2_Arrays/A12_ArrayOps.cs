using System;

namespace P2_Arrays
{
    internal class A12_ArrayOps
    {
        static void Main1(string[] args)
        {
            int[] arr = new int[10];

            // Input array elements
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int choice;
            do
            {
                Console.WriteLine("\n----- MENU -----");
                Console.WriteLine("1. Display array elements");
                Console.WriteLine("2. Sum of array elements");
                Console.WriteLine("3. Min and Max element");
                Console.WriteLine("4. Check perfect numbers");
                Console.WriteLine("5. Check prime numbers");
                Console.WriteLine("6. Frequency of each element");
                Console.WriteLine("7. Second smallest element");
                Console.WriteLine("8. Second largest element");
                Console.WriteLine("9. Sort ascending");
                Console.WriteLine("10. Sort descending");
                Console.WriteLine("11. Reverse array");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Array Elements:");
                        foreach (int n in arr)
                            Console.Write(n + " ");
                        Console.WriteLine();
                        break;

                    case 2:
                        int sum = 0;
                        foreach (int n in arr)
                            sum += n;
                        Console.WriteLine("Sum = " + sum);
                        break;

                    case 3:
                        int min = arr[0], max = arr[0];
                        foreach (int n in arr)
                        {
                            if (n < min) min = n;
                            if (n > max) max = n;
                        }
                        Console.WriteLine($"Min = {min}, Max = {max}");
                        break;

                    case 4:
                        Console.WriteLine("Perfect Numbers:");
                        foreach (int n in arr)
                        {
                            int s = 0;
                            for (int i = 1; i <= n / 2; i++)
                            {
                                if (n % i == 0)
                                    s += i;
                            }
                            if (s == n)
                                Console.Write(n + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Prime Numbers:");
                        foreach (int n in arr)
                        {
                            if (n <= 1) continue;
                            bool isPrime = true;
                            for (int i = 2; i <= n / 2; i++)
                            {
                                if (n % i == 0)
                                {
                                    isPrime = false;
                                    break;
                                }
                            }
                            if (isPrime)
                                Console.Write(n + " ");
                        }
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine("Frequency of elements:");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            int count = 1;
                            bool visited = false;

                            for (int j = 0; j < i; j++)
                            {
                                if (arr[i] == arr[j])
                                {
                                    visited = true;
                                    break;
                                }
                            }

                            if (visited) continue;

                            for (int j = i + 1; j < arr.Length; j++)
                            {
                                if (arr[i] == arr[j])
                                    count++;
                            }
                            Console.WriteLine($"{arr[i]} -> {count}");
                        }
                        break;

                    case 7:
                        Array.Sort(arr);
                        Console.WriteLine("Second Smallest = " + arr[1]);
                        break;

                    case 8:
                        Array.Sort(arr);
                        Console.WriteLine("Second Largest = " + arr[arr.Length - 2]);
                        break;

                    case 9:
                        Array.Sort(arr);
                        Console.WriteLine("Sorted Ascending:");
                        foreach (int n in arr)
                            Console.Write(n + " ");
                        Console.WriteLine();
                        break;

                    case 10:
                        Array.Sort(arr);
                        Array.Reverse(arr);
                        Console.WriteLine("Sorted Descending:");
                        foreach (int n in arr)
                            Console.Write(n + " ");
                        Console.WriteLine();
                        break;

                    case 11:
                        Array.Reverse(arr);
                        Console.WriteLine("Reversed Array:");
                        foreach (int n in arr)
                            Console.Write(n + " ");
                        Console.WriteLine();
                        break;

                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);
        }
    }
}
