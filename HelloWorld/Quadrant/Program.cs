using System;

public class Program
{
    public static void Main()
    {
        while(true) 
        {
            string[] s = Console.ReadLine().Split();

            int a = int.Parse(s[0]);    
            int b = int.Parse(s[1]);

            if(a > 0 && b > 0)
            {
                Console.WriteLine("primeiro");
            }
            else if(a > 0 && b < 0)
            {
                Console.WriteLine("quarto");
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine("terceiro");
            }
            else if (a < 0 && b > 0)
            {
                Console.WriteLine("segundo");
            }
            else if(a == 0 || b == 0)
            {
                break;
            }

        }

    }
}