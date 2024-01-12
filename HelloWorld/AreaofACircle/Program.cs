using System;

public class Program
{
    public static void Main()
    {
        double R = double.Parse(Console.ReadLine());

        double n = 3.14159;

        double A = n * R * R;

        Console.WriteLine($"A={A.ToString("F4")}");
    }


}