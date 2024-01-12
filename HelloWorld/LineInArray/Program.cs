using System;

public class Program
{
    public static void Main()
    {
        int L = int.Parse(Console.ReadLine());  

        char N = char.Parse(Console.ReadLine());    

        double[,] M = new double[12, 12];

        for(int i = 0; i < 12; i++)
        {
            for(int j = 0; j < 12; j++)
            {
                M[i, j] = double.Parse(Console.ReadLine());
            }
        }


        double result = 0;

        if(N =='S')
        {
            for(int i = 0; i < 2; i++)
            {
                result = result + M[L, i];
            }
        }
        else
        {
            for (int i = 0; i < 12; i++)
            {
                result = result + M[L, i];
              
            }
            result = result /12.0;
        }
        Console.WriteLine(result.ToString("f1"));
    }
}