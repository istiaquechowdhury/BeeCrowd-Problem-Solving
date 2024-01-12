using System;


public class Program
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int y = int.Parse(Console.ReadLine());

        int multiply = n * y;

        double result = (double)multiply / 12;

        Console.WriteLine(result.ToString("F3"));



    }
}