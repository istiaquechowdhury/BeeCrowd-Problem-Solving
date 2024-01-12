using System;


public class Program
{
    public static void Main()
    {
       double radius = double.Parse(Console.ReadLine());

        double pi = 3.14159;

        double result = (4.0/3) * pi * radius * radius * radius;

        Console.WriteLine($"VOLUME = {result.ToString("F3")}");


    }
}