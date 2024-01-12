using System;

public class Program
{
    public static void Main()
    {
        int count = 0;
        int Result = 0;
        double average = 0;

        while (true) 
        { 
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                average = (double)Result / count;

                Console.WriteLine(average.ToString("f2"));
                break;
            }
            else
            {
                count++;
                Result = Result + n;
                continue;
            }
            
           
            

            

        }


    }
}