using System;

public class Program
{
    public static void Main()
    {
        for(int i = 1,j=7; i <= 9; i+=2)
        {
            Console.WriteLine($"I={i} J={j}");
            Console.WriteLine($"I={i} J={j - 1}");
            Console.WriteLine($"I={i} J={j - 2}");
            j = j + 2;
        }
    }
}