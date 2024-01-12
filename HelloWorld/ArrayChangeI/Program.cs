using System;

public class Program
{
    public static void Main()
    {
        int[] N = new int[20];
        
        for(int i = 0; i < N.Length; i++)
        {
            N[i] = int.Parse(Console.ReadLine());   


        }

       
        Array.Reverse(N);   

        for(int i = 0 ; i < N.Length;i++)
        {
            Console.WriteLine($"N[{i}] = {N[i]}");
        }
    }

}