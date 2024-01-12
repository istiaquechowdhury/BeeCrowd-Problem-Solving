using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            int result = i * n;

            Console.WriteLine($"{i} x {n} = {result}");
        }
    }
}