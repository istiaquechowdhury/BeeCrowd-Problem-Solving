using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        int result = 0;
        int result2 = 1;

        Console.Write($"{result} ");

        
        for(int i = 0; i < n - 1; i++)
        {
            if (i == n - 2)
            {
                Console.Write($"{result2}");
                Console.WriteLine();
                break;
            }
            Console.Write($"{result2} ");
            
           

            int next = result + result2;
            result = result2;
            result2 = next;

            
            

          


           
        }
    }
}