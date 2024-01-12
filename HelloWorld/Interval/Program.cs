using System;


public class Program
{
    public static void Main()
    {

        double d = double.Parse(Console.ReadLine());    

        if(d >= 0.00  && d <= 25)
        {
            Console.WriteLine("Intervalo [0,25]");

        }
        else if(d > 25 && d <= 50) 
        {
            Console.WriteLine("Intervalo (25,50]");
        }
        else if(d > 50 && d <= 75)
        {

            Console.WriteLine("Intervalo (50,75]");
        }
        else if (d > 75 && d <= 100)
        {

            Console.WriteLine("Intervalo (75,100]");
        }
        else
        {
            Console.WriteLine("Fora de intervalo");
        }






    }




}