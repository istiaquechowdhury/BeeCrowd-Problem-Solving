using System;


public class Program
{
    public static void Main()
    {
        double X = double.Parse(Console.ReadLine());
        double[] N = new double[100];

        N[0] = X;

        Console.WriteLine($"N[0] = {N[0].ToString("f4")}");




        for (int i = 1; i < N.Length; i++)
        {
            N[i] = N[i-1] / 2.0;
            Console.WriteLine($"N[{i}] = {N[i].ToString("f4")}");


          
            
           
        }




    }
}