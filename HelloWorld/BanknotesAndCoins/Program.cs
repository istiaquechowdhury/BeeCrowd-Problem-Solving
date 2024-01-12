using System;


public class Program
{
    public static void Main()
    {

        double d = double.Parse(Console.ReadLine());

        int [] Notes = { 100, 50, 20, 10, 5, 2 };
        decimal[] Coins = {1, 0.50m, 0.25m, 0.10m, 0.05m, 0.01m };
        int count = 0;
        Console.WriteLine("NOTAS:");
        foreach (var bank in Notes)
        {
           
            while(d >= bank)
            {
                d = d - bank;
                count++;
            }

            
            Console.WriteLine($"{count} nota(s) de R$ {bank.ToString("f2")}");
            count = 0;
        }
        count = 0;  
        Console.WriteLine("MOEDAS:");
        foreach (var b in Coins)
        {

            while ((decimal)d >= b)
            {
                d = (double)((decimal)d - b);
                count++;
            }


            Console.WriteLine($"{count} moeda(s) de R$ {b.ToString("f2")}");
            count = 0;

        }








    }




}