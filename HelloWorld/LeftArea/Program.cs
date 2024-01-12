using System;
public class Program
{
    public static void Main()
    {
        char a = char.Parse(Console.ReadLine());

        double[,] d = new double[12, 12];

        for(int i = 0; i < 12; i++)
        {
            for(int j = 0; j < 12; j++)
            {
                d[i, j] = double.Parse(Console.ReadLine());

            }
        }
        double result = 0;
        int Count = 0;

        if(a =='S')
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    
                    result = result + d[i, j];
                    if (i == 6 && j == 4)
                        break;
                    if (i == 7 && j == 3)
                        break;
                    if (i == 8 && j == 2)
                        break;
                    if (i == 9 && j == 1)
                        break;
                    if (i == 10 && j == 0)
                        break;







                }
            }

        }
        else
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    result = result + d[i, j];
                    Count++;
                    if (i == 6 && j == 4)
                        break;
                    if (i == 7 && j == 3)
                        break;
                    if (i == 8 && j == 2)
                        break;
                    if (i == 9 && j == 1)
                        break;
                    if (i == 10 && j == 0)
                        break;







                }
            }
            result = result / Count+0.0;
        }
        Console.WriteLine(result.ToString("f1"));
    }
}