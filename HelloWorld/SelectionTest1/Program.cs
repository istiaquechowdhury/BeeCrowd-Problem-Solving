using System;


public class Program
{
    public static void Main()
    {

        string[] s = Console.ReadLine().Split();

        int a = int.Parse(s[0]);
        int b = int.Parse(s[1]);
        int c = int.Parse(s[2]);
        int d = int.Parse(s[3]);    

        if(b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && a % 2 == 0)
        {
            Console.WriteLine("Valores aceitos");
        }
        else
        {
            Console.WriteLine("Valores nao aceitos");
        }







    }




}