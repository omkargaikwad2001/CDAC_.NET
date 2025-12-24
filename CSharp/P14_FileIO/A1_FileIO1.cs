using System;
using System.Collections.Generic;
using System.IO;

namespace P14_FileIO
{
    internal class A1_FileIO1
    {
        static void Main1(string[] args)
        {
            string filePath = "MyData.txt";
            List<string> lines = new List<string>();

            Console.WriteLine("Enter text (type 'quit' to stop):");

            // Accept input till user enters 'quit'
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                lines.Add(input);
            }

            // a.1 Create File and Write Data
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("\nData written to file (Create & Write).");

            // a.2 Override data in existing file
            File.WriteAllText(filePath, "This data is overwritten.\n");
            Console.WriteLine("File data overridden.");

            // a.3 Append data in existing file
            File.AppendAllLines(filePath, lines);
            Console.WriteLine("Data appended to file.");

            // Read all lines from file
            string[] fileData = File.ReadAllLines(filePath);

            // b. Display data with line numbers
            Console.WriteLine("\n--- File Data with Line Numbers ---");
            for (int i = 0; i < fileData.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {fileData[i]}");
            }

            // c. Display data without line numbers
            Console.WriteLine("\n--- File Data without Line Numbers ---");
            foreach (string line in fileData)
            {
                Console.WriteLine(line);
            }

            // d. Find longest line length
            int maxLength = 0;
            foreach (string line in lines)
            {
                if (line.Length > maxLength)
                    maxLength = line.Length;
            }

            Console.WriteLine("\nLength of longest line entered by user: " + maxLength);

            Console.ReadLine();
        }
    }
}
