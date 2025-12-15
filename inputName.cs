using System;

public class InputName
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();

        Console.WriteLine($"Welcome {name}");
    }
}
