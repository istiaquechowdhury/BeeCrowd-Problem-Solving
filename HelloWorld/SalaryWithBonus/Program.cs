using System;


public class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();

        double a = double.Parse(Console.ReadLine());

        double b = double.Parse(Console.ReadLine());


        double total = a + (b * 15) / 100;

        Console.WriteLine($"TOTAL = R$ {total.ToString("f2")}");
    }
}