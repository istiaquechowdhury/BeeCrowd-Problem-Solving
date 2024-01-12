using System;

public class Program
{
    public static void Main()
    {

        int max = 0;
        int indexPosition = 0;
        for (int i = 1; i <= 100; i++)
        {
            int n = int.Parse(Console.ReadLine());

            

            if(n > max)
            {
                max = n;
                indexPosition = i;
            }
            
        }
        Console.WriteLine(max);
        Console.WriteLine(indexPosition);

        




       
    }
}