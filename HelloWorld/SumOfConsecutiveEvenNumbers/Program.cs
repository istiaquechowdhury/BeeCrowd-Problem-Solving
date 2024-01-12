using System;

public class Program
{
    public static void Main()
    {
        

        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            if (n == 0)
                break;

            for (int i = 0; i < 5; i++)
            {
                if (n % 2 == 0)
                {
                    sum = sum + n;
                    n = n + 2;
                }
                else if (n % 2 != 0)
                {
                    n++;
                    i--;
                }
            }
            Console.WriteLine(sum);

        }
       

    }
}
