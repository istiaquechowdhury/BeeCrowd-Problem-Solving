using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] M  = new int[n,n]; 

        if(n == 1)
        {
            Console.WriteLine(1);
        }


        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                M[i, j] = 1;
            }
        }

    }
}