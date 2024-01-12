using System;

public class Program
{
    public static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        int Sum = 0;

        for(int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());  

            for(int j = 1; j < x; j++)
            {
                if (x % j == 0)
                {
                    Sum = Sum + j;
                    
                }
            }
            if (Sum == x)
            {
                Console.WriteLine($"{x} eh perfeito");
                Sum = 0;
            }
            else
            {
                Console.WriteLine($"{x} nao eh perfeito");
                Sum = 0;
            }
        }
    }
}