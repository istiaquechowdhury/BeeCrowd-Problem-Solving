using System;

public class Program
{
    public static void Main()
    {
        char c = char.Parse(Console.ReadLine());

        double[,] doubles = new double[12, 12];

        for(int i = 0; i < 12;  i++)
        {
            for(int j = 0; j < 12; j++)
            {
                doubles[i, j] = double.Parse(Console.ReadLine());
            }
        }
        
        double result = 0;
        int count = 0;
        if (c == 'S')
        {


            for (int i = 1; i < 12; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result = result + doubles[i,j];
                }
            }
        }
        else
        {
            for (int i = 1; i < 12; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    result = result + doubles[i, j];
                    count++;
                }
            }

            result = result / count + 0.0;


        }
        Console.WriteLine(result.ToString("f1"));
    }
}