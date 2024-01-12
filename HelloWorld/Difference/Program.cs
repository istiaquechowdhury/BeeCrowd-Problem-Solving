using System;

public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        int b = int.Parse(Console.ReadLine());

        int c = int.Parse(Console.ReadLine());
        
        int d = int.Parse(Console.ReadLine());

        int DIFERENCA = a * b - c * d;

        
        Console.WriteLine($"DIFERENCA = {DIFERENCA}");
    }
}