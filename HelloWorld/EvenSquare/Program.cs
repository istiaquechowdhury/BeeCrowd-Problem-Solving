using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  

        for(int i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                int result = (int)Math.Pow(i,2);
                Console.WriteLine($"{i}^2 = {result}");
            }
        }
        
    }
}