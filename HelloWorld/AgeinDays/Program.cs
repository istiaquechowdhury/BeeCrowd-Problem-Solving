using System;


public class Program
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int year = n / 365;

        int month = (n % 365) / 30;

        int days = (n % 365) % 30;

        Console.WriteLine($"{year} ano(s)");
        Console.WriteLine($"{month} mes(es)");
        Console.WriteLine($"{days} dia(s)");





    }




}