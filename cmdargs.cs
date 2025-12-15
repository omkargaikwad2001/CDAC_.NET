using System;

public class CmdArgs
{
    public static void Main(string[] args)
    {
        string name = args[0];
        int n1 = int.Parse(args[1]);
        int n2 = int.Parse(args[2]);
	
	//String interpolation
        Console.WriteLine($"{name} {n1} {n2}");
        Console.WriteLine($"Hello {name}");
        Console.WriteLine($"{n1}+{n2} = {n1 + n2}");

        // Composite formatting style
        Console.WriteLine("{0} {1}+{2}={3}", name, n1, n2, n1 + n2);
    }
}
