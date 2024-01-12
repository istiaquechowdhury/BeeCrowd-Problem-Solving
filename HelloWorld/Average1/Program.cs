using System;

public class Program
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());

        double b = double.Parse(Console.ReadLine());

        double media = (a*3.5 + b*7.5) / 11;
        Console.WriteLine($"MEDIA = {media.ToString("F5")}");
    }
}