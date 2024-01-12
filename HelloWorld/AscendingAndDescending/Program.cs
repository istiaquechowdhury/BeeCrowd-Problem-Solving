using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            string[] s = Console.ReadLine().Split();

            int a = int.Parse(s[0]);    
            int b = int.Parse(s[1]);    

            if (a == b)
            {
                break;
            }

            if (a > b)
            {
                Console.WriteLine("Decrescente");
            }
            else
            {
                Console.WriteLine("Crescente");
            }
        }

    }
}