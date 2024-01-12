using System;

public class Program
{
    public static void Main()
    {
        int[] par = new int[5];
        int[] impar = new int[5];
        for (int i = 1; i <= 15;  i++) 
        {
            int n = int.Parse(Console.ReadLine());  

            if(n % i == 0)
            {
                par[i] = n;
                if (par[i] == 5)
                    Console.WriteLine($"par{i} = {par[i] = n}");
            }


        }

    }
}