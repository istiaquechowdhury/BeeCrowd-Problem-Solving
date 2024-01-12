using System;


public class Program
{
    public static void Main()
    {
        Char a = char.Parse(Console.ReadLine());

        double[,] d = new double[12, 12];

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                d[i, j] = double.Parse(Console.ReadLine());
            }
        }
       
        double result = 0;
        int count = 0;
        if(a =='S')
        {
            
            for(int i = 0;i < 11; i++)
            {
               
                for( int j = i+1;j < 12;j++)
                {
                    result = result + d[i, j];


                }
                
                
               
            }
        }
        else if(a == 'M')
        {
            for (int i = 0; i < 11; i++)
            {

                for (int j = i + 1; j < 12; j++)
                {
                    result = result + d[i, j];
                    count++;    

                }
                



            }
            result = (double)result / count + 0.0;
        }
        Console.WriteLine(result.ToString("f1"));


    }
}