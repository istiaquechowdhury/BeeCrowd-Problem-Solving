using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            string input = Console.ReadLine();

            int N;

            if(!int.TryParse(input, out N))
            {
                break; 
            }

            if (N == 0)
            {
                Console.WriteLine("vai ter copa!");
            }
            else
            {
                Console.WriteLine("vai ter duas!");
            }

        }

    }
}