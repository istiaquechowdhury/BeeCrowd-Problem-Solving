using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int CountIn = 0;
        int CountOut = 0;   

        for(int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());  

            if(x >= 10 && x <= 20)
            {
                CountIn++;
            }
            else
            {
                CountOut++;
            }
        }
        Console.WriteLine($"{CountIn} in");
        Console.WriteLine($"{CountOut} out");
    }
}