using System;


public class Program
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int Count = 0;
       

        while (x < x + 20)
        {
            if (x % 2 == 0)
            {
                x++;

            }
            else
            {
                Console.WriteLine(x);
                x++;
                Count++;
                if (Count == 6)
                    break;
                
            }
            

        }
    }
}