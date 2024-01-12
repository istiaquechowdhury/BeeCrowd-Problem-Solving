using System;


public class Program
{
    public static void Main()
    {
        int j = 0;
        char c = char.Parse(Console.ReadLine());

        double[,] d = new double[12, 12];

        for (int i = 0; i < 12; i++)
        {
            for (j = 0; j < 12; j++)
            {
                d[i, j] = double.Parse(Console.ReadLine());

            }
        }

        double result = 0;
        int k = 11;
        int Count = 0;

        if (c == 'S')
        {



            for (int i = 1; i < 11; i++)
            {
                for (j = k; j > 1; j--)
                {
                    result = result + d[i, j];
                    if (i == 1 && j == 11)
                    {
                        break;
                    }
                    if (i == 2 && j == 10)
                    {
                        break;
                    }
                    if (i == 3 && j == 9)
                    {
                        break;
                    }
                    if (i == 4 && j == 8)
                    {
                        break;

                    }
                    if (i == 5 && j == 7)
                    {
                        break;
                    }
                    if (i == 6 && j == 7)
                    {
                        break;
                    }
                    if (i == 7 && j == 8)
                    {
                        break;
                    }
                    if (i == 8 && j == 9)
                    {
                        break;
                    }
                    if (i == 9 && j == 10)
                    {
                        break;
                    }
                    if (i == 10 && j == 11)
                    {
                        break;
                    }
                }





            }
        }
        else
        {
            for (int i = 1; i < 11; i++)
            {
                for (j = k; j > 1; j--)
                {
                    result = result + d[i, j];
                    Count++;
                    if (i == 1 && j == 11)
                    {
                        break;
                    }
                    if (i == 2 && j == 10)
                    {
                        break;
                    }
                    if (i == 3 && j == 9)
                    {
                        break;
                    }
                    if (i == 4 && j == 8)
                    {
                        break;

                    }
                    if (i == 5 && j == 7)
                    {
                        break;
                    }
                    if (i == 6 && j == 7)
                    {
                        break;
                    }
                    if (i == 7 && j == 8)
                    {
                        break;
                    }
                    if (i == 8 && j == 9)
                    {
                        break;
                    }
                    if (i == 9 && j == 10)
                    {
                        break;
                    }
                    if (i == 10 && j == 11)
                    {
                        break;
                    }
                }



            }
            result = result / Count+0.0;

            
        }
        Console.WriteLine(result.ToString("f1"));
    }
}