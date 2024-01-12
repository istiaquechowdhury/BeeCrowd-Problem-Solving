using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int Number1 = 1;
        int Number2 = 1;
        int result = 1;

        
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine($"{Number1} {Number2} {result}");

            Number1 = Number1 + 1;
            Number2 = Number1 * Number1;

            result = Number1 * Number2;
        }
    }
}