using System;
using System.Collections;

namespace P10_Collections
{
    internal class A5_Queue
    {
        static void Main1(string[] args)
        {
            Queue queue = new Queue();
            int choice;

            do
            {
                Console.WriteLine("\n--- Queue Operations ---");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Display Queue");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter string to enqueue: ");
                        string data = Console.ReadLine();
                        queue.Enqueue(data);
                        Console.WriteLine("Inserted successfully");
                        break;

                    case 2:
                        if (queue.Count > 0)
                        {
                            Console.WriteLine("Dequeued element: " + queue.Dequeue());
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Queue elements:");
                        foreach (var item in queue)
                        {
                            Console.WriteLine(item);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 4);
        }
    }
}
