using System;

public class Program
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());

        double b = double.Parse(Console.ReadLine());

        double c = double.Parse(Console.ReadLine());

        double media = (a *2 + b *3 + c* 5) / 10;
        Console.WriteLine($"MEDIA = {media.ToString("F1")}");
    }
}