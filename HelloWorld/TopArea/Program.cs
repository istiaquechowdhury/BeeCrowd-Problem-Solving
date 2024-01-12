using System;


public class Program
{
    public static void Main()
    {
        char c = char.Parse(Console.ReadLine());

        double[,] d = new double[12,12];


        for(int i = 0; i < 12; i++)
        {
            for(int j = 0; j < 12; j++)
            {
                d[i,j] =  double.Parse(Console.ReadLine());
            }
        }
        double result = 0;  
        int k = 0;
        int l = 11;
        int Count = 0;


        if(c == 'S')
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = k+1; j < l; j++)
                {
                    result = result + d[i,j];   
                }
                k++;
                l--;
            }
        }
        else
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = k + 1; j < l; j++)
                {
                    result = result + d[i, j];
                    Count++;
                }
                k++;
                l--;
            }
            result = result / Count+0.0;
        }

        Console.WriteLine(result.ToString("f1"));
    }
}