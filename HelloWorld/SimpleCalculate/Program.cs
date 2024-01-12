using System;


public class Program
{
    public static void Main()
    {
        double finalresult = 0.0;
        for(int i = 0; i < 2;  i++) 
        {
            string[] strings = Console.ReadLine().Split();

            int a = int.Parse(strings[0]);
            int b = int.Parse(strings[1]);
            double d = double.Parse(strings[2]);

            double result = b * d;

            finalresult = finalresult + result;


        }
        Console.WriteLine($"VALOR A PAGAR: R$ {finalresult.ToString("f2")}");

       

    }
}