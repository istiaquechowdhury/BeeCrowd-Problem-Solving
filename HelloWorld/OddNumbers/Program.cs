using System;

public class Program
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < x; i++)
        {
            Console.WriteLine(i+1);
            i = i + 1;
        }
    }
}