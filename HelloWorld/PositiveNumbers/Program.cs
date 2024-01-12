using System;

public class Program
{
    public static void Main()
    {
       int Count = 0;

        for(int i = 0; i < 6;i++)
        {
            double n = double.Parse(Console.ReadLine());
            if(n > 0)
            {
                Count++;    
            }
        }
        Console.WriteLine($"{Count} valores positivos");

        
    }
}