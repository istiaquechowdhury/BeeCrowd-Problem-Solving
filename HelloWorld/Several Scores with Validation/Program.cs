using System;


public class Program
{
    public static void Main()
    {
        double Count = 0;
        int CountDown = 0;
        while (true)
        {
               
            double d = double.Parse(Console.ReadLine());
            if (d > 0 && d <= 10)
            {



                Count = Count + d;
                CountDown++;
                if (CountDown == 2)
                {
                    double media = (double)(Count / 2);
                    Console.WriteLine($"media = {media.ToString("f2")}");
                    CountDown = 0;
                    Count = 0;
                    
                    int x;

                    do
                    {
                        Console.WriteLine("novo calculo (1-sim 2-nao)");

                        x = int.Parse(Console.ReadLine());

                        if (x == 1)
                            break;
                        else if (x == 2)
                        {
                            return;
                        }
                    }while(x != 1);



                   
                    


                }

            }
            else
            {
                Console.WriteLine("nota invalida");
            }



        }
    }
}