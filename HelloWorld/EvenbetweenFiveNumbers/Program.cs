using System;

public class Program
{
    public static void Main()
    {
        int EvenCount = 0;
        for(int i = 0; i < 5; i++)
        {
            int n = int.Parse(Console.ReadLine());  

            if(n % 2 == 0)
            {
                EvenCount++;
            }
        }
        Console.WriteLine($"{EvenCount} valores pares");
    }
}