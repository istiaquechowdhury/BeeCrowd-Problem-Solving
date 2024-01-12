using System;


public class Program
{
    public static void Main()
    {
       int a = int.Parse(Console.ReadLine());

       double b = double.Parse(Console.ReadLine());

        double result = a / b;

        Console.WriteLine($"{result.ToString("F3")} km/l");


    }
}