using System;


public class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int c = int.Parse(s[2]);

        for(int i  = 0; i < 3; i++)
        {
            if(a < int.Parse(s[i]))
            {
                a = int.Parse(s[i]);    
            }
        }

        Console.WriteLine($"{a} eh o maior");


    }
}