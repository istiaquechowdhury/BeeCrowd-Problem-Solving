
using System;

public class Program
{
    public static void Main()
    {
        string[] S = Console.ReadLine().Split();

        double[] d = Array.ConvertAll(S, double.Parse);   


        Array.Sort(d);
        Array.Reverse(d);

        double a = (d[0]);

        double b = (d[1]);

        double c = (d[2]);

        if (a >= (b + c))
        {
            Console.WriteLine("NAO FORMA TRIANGULO");
        }
        else
        {
            if (a * a == b * b + c * c)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if (a * a > (b * b + c * c))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if (a * a < (b * b + c * c))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if ((a == b && a != c) || (a == c && a!= b) || (b == c && b != a))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}

