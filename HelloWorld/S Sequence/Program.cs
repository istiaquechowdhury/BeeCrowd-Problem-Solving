using System;

public class Program
{
    public static void Main()
    {
        double S = 0;
        for (int i = 1; i <= 100; i++)
        {
            S = S + 1.0 / i;
        }
        Console.WriteLine(S.ToString("f2"));
    }
}