using System;


public class Program
{
    public static void Main()
    {

        string[] s = Console.ReadLine().Split();

        int a = int.Parse(s[0]);    

        int b = int.Parse(s[1]);

        double Quantity = 0;

        if (a == 1 ) 
        { 
            for(int i = 0; i < b; i++)
            {
                Quantity = Quantity + 4.00;
            }
        }
        else if(a == 2)
        {
            for (int i = 0; i < b; i++)
            {
                Quantity = Quantity + 4.50;
            }
        }
        else if (a == 3)
        {
            for (int i = 0; i < b; i++)
            {
                Quantity = Quantity + 5.00;
            }
        }
        else if (a == 4)
        {
            for (int i = 0; i < b; i++)
            {
                Quantity = Quantity + 2.00;
            }
        }
        else if (a == 5)
        {
            for (int i = 0; i < b; i++)
            {
                Quantity = Quantity + 1.50;
            }

        }
        Console.WriteLine($"Total: R$ {Quantity.ToString("f2")}");








    }




}