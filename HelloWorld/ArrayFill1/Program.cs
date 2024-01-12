using System;

public class Program
{
    public static void Main()
    {

        int v = int.Parse(Console.ReadLine());  

        int[] N = new int[10];

        N[0] = v;

        Console.WriteLine($"N[0] = {v}");

        for(int i = 1; i < N.Length; i++)
        {
            N[i] = N[i - 1] * 2;
            Console.WriteLine($"N[{i}] = {N[i]}");
        }


    }
}