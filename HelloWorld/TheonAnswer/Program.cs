using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] arr = Console.ReadLine().Split();

        int[] T = Array.ConvertAll(arr, int.Parse);

        int min = T[0];
        int j = 0;  

        for(int i = 1; i < n;  i++)
        {
            if((min > T[i]))
            {
                min = T[i];
                
                j = i;
            }
        }
        Console.WriteLine(j + 1);
       

    }
}