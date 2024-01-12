using System;


public class Program
{
    public static void Main()
    {
       double Count = 0;
       int CountDown = 0;
       while (true)
       {
           double d = double .Parse(Console.ReadLine());    
           if(d > 0 && d <= 10)
           {
               
               
                
                Count = Count + d;
                CountDown++;
                if (CountDown == 2)
                {
                    double media = (double)(Count / 2);
                    Console.WriteLine($"media = {media.ToString("f2")}");

                    break;
                }
                
           }
           else
           {
                Console.WriteLine("nota invalida");
           }

       }
    }
}