using System;


public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int Count = 0;


        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            for (int j = 1; j <= x; j++)
            {

                if (x % j == 0)
                {
                    Count++;
                }
               
            }
            if(Count > 2)
            {
                Console.WriteLine($"{x} nao eh primo");
                Count = 0;
            }
            else if(Count == 2) 
            {
                Console.WriteLine($"{x} eh primo");
                Count = 0;
            }
        }
    }
}