using System;
public class Hello 
{
   public static void Main(String[] args)
{
   string no = Console.ReadLine();
   string no1 = Console.ReadLine(); 

   if(int.TryParse(no,out int num) && int.TryParse(no1,out int num1))
{
	Console.WriteLine($"{num}+{num1}={num+num1}");
}
else{
Console.WriteLine("Invalid Output");
}

}
}