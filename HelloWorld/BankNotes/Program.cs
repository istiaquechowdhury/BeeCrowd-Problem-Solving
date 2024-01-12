using System;


public class Program
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n);
        BankNotes(n);
        

        



    }

    public static void BankNotes(int n)
    { 
        int count = 0;
        while(n >= 100)
        {
            n = n - 100;
            count++;
           
            
        }

        Console.WriteLine($"{count} nota(s) de R$ 100,00");
        count = 0;
        while (n >= 50)
        {
            n = n - 50;
            count++;
        }
        
        Console.WriteLine($"{count} nota(s) de R$ 50,00");
        count = 0;
        while (n >= 20)
        {
            n = n - 20;
            count++;
        }
        Console.WriteLine($"{count} nota(s) de R$ 20,00");
        count = 0;
        while (n >= 10)
        {
            n = n - 10;
            count++;
        }
        Console.WriteLine($"{count} nota(s) de R$ 10,00");
        count = 0;
        while (n >= 5)
        {
            n = n - 5;
            count++;
        }
        Console.WriteLine($"{count} nota(s) de R$ 5,00");
        count = 0;
        while (n >= 2)
        {
            n = n - 2;
            count++;
        }
        Console.WriteLine($"{count} nota(s) de R$ 2,00");
        count = 0;
        while (n >= 1)
        {
            n = n - 1;
            count++;
        }
        Console.WriteLine($"{count} nota(s) de R$ 1,00");
        count = 0;

       

    }
}