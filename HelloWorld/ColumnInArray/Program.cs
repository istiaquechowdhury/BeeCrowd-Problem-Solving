using System;

public class Program
{
    public static void Main() 
    {
        int C = int.Parse(Console.ReadLine());

        char T = char.Parse(Console.ReadLine());

        double[,] M = new double[12,12];

        for(int i = 0; i < 12; i++)
        {
            for(int j = 0; j < 12; j++)
            {
                M[i,j] = double.Parse(Console.ReadLine());
            }
        }
        double result = 0;

        if(T == 'S')
        {
            for(int i = 0; i < 12; i++)
            {
                result += M[i,C];
            }
        }
        else
        {
            for(int i = 0; i < 12; i++)
            {
                result = result + M[i,C];
            }
            result = result / 12.0;
        }
        Console.WriteLine(result.ToString("f1"));
        


       
    }
}