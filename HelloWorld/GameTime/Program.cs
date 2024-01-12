using System;

public class Program
{
    public static void Main()
    {
        string [] s = Console.ReadLine().Split();

        int[] x = Array.ConvertAll(s,int.Parse);

        int a = x[0];
        int b = x[1];

        int Duration;

        if(a < b)
        {
           
            Duration = b - a;
        }
        else
        {
            Duration = (24 - a) + b;
        }

        Console.WriteLine($"O JOGO DUROU {Duration} HORA(S)");

    }
}