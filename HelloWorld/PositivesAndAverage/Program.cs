using System;

public class Program
{
    public static void Main()
    {
        int Count = 0;
        double StoredPositiveValues = 0.0;
        for(int i = 0; i < 6; i++)
        {
            double n = double.Parse(Console.ReadLine());    
            if(n > 0)
            {
                Count++;
                StoredPositiveValues += n;
                
                
            }
        }
        StoredPositiveValues /= Count;
        Console.WriteLine($"{Count} valores positivos");

        Console.WriteLine(StoredPositiveValues.ToString("f1"));
        

    }
}