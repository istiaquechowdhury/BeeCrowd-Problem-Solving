using System;


public class Program
{
    public static void Main()
    {
        double a, b,c;
        double pi = 3.14159;

        string[] s = Console.ReadLine().Split();
        a = double.Parse(s[0]);
        b = double.Parse(s[1]);
        c = double.Parse(s[2]);

        double triangle = (a * c) / 2;
        double circle =  pi* c * c;
        double trapezium = ((a + b) * c) / 2;
        double square = b * b;
        double rectangle = a * b;

        Console.WriteLine($"TRIANGULO: {triangle.ToString("f3")}");
        Console.WriteLine($"CIRCULO: {circle.ToString("f3")}");
        Console.WriteLine($"TRAPEZIO: {trapezium.ToString("f3")}");

        Console.WriteLine($"QUADRADO: {square.ToString("f3")}");
        Console.WriteLine($"RETANGULO: {rectangle.ToString("f3")}");



    }
}