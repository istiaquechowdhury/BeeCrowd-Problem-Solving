using System;

public class Program
{
    public static void Main()
    {
        int Alchohol = 0;
        int Gesolina = 0;
        int Diesel = 0;
        while (true) 
        {
           

            int n = int.Parse(Console.ReadLine());  

            if(n != 1 && n != 2 && n != 3)
            {
                if (n == 4)
                {

                    Console.WriteLine("MUITO OBRIGADO");
                    Console.WriteLine($"Alcool: {Alchohol}");
                    Console.WriteLine($"Gasolina: {Gesolina}");
                    Console.WriteLine($"Diesel: {Diesel}");
                    break;

                }
                continue;
               
            }
            else if (n == 1)
            {
                Alchohol++;

            }
            else if (n == 2)
            {
                Gesolina++;
            }
            else if (n == 3)
            {
                Diesel++;
            }
           








        }

    }
}