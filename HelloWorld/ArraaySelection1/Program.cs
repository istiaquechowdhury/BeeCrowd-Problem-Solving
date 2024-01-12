using System;


public class Program
{
    public static void Main()
    {
        double[] n = new double[100];

        for(int i  = 0; i < n.Length; i++)
        {
            n[i] = double.Parse(Console.ReadLine()); 
            
            
                if (n[i] <= 10)
                {
                Console.WriteLine($"A[{i}] = {n[i].ToString("f1")}");
                }
            
        }
    }
}