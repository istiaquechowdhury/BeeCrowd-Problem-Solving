using System;

public class Program
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());      

        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            ulong fib = Fibonncci(n);
            Console.WriteLine($"Fib({n}) = {fib}");
        }
        
    }

    public static ulong Fibonncci(int x)
    {
        ulong a = 0, b = 1, result = 0; 

        if(x == 0)
        {
            return a;
        }

        for(int i = 2; i <= x; i++)
        {
            result = a + b;

            a = b;

            b = result; 

        }
        return b;
        

    }
}