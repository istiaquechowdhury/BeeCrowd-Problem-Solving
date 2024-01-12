using System;

public class Program
{
    public static void Main()
    {
        for(int i = 1,j = 60; ; i = i + 3, j = j - 5)
        {
            Console.Write($"I={i}");
            Console.WriteLine($" J={j}");
            if(j == 0)
            {
                break;
            }
        }    
    }
}