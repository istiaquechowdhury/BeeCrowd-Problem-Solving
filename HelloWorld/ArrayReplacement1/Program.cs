using System;


public class Program
{
    public static void Main()
    {
        int[] X = new int[10];

        for (int i = 0; i < X.Length; i++)
        {
            X[i] = int.Parse(Console.ReadLine());

            if (X[i] == 0 || X[i] < 0)
            {
                Console.WriteLine($"X[{i}] = {X[i] = 1}");
                
            }
            else
            {
                Console.WriteLine($"X[{i}] = {X[i]}");
              
            }
            

        }
       
    }
}