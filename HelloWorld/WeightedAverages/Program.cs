using System;

public class Program
{
    public static void Main()
    {
         int n = int.Parse(Console.ReadLine()); 
        

        for(int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();

            double[] arry = Array.ConvertAll(s, double.Parse);

            double a = arry[0];
            double b = arry[1]; 
            double c = arry[2]; 

            double result = (a * 2 + b * 3 + c * 5)/10;
            Console.WriteLine(result.ToString("f1"));

        }
    }
}