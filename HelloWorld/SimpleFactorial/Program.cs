using System;

public class Program
{
    public static void Main()
    {
       int n = int.Parse(Console.ReadLine());

        int result = 1;

       for(int i = 1; i <= n;  i++) 
       {
            result = result * i;
            

       }
       Console.WriteLine(result);

    }
}
