using System;


public class Program
{
      
    public static void Main()
    {

        int EvenCount = 0;
        int OddCount = 0;
        int Positive = 0;
        int Negative = 0;

        for (int i = 0; i < 5; i++)
        {
            int n = int.Parse(Console.ReadLine());

            if(n % 2 == 0)
            {
                EvenCount++;
            }
            if(n % 2 == 1 || n % 2 == -1)
            {
                OddCount++; 
            }
            if (n > 0)
            {
                Positive++;
            }
            if(n < 0)
            {
                Negative++; 
            }
        }

        Console.WriteLine($"{EvenCount} valor(es) par(es)");
        Console.WriteLine($"{OddCount} valor(es) impar(es)");
        Console.WriteLine($"{Positive} valor(es) positivo(s)");
        Console.WriteLine($"{Negative} valor(es) negativo(s)");
    }
}