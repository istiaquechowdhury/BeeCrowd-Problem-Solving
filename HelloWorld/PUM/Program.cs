using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int count = 1;

        for( int i = 0; i < n; i++ )
        {
            Console.WriteLine($"{count} {count + 1} {count + 2} PUM");

            count = count + 4;

        }
    }
}