using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());  
        
        for(int i = 0; i < n; i++)
        {
            string[] arr = Console.ReadLine().Split();

            int Numerator = int.Parse(arr[0]);  
            int Denominator = int.Parse(arr[1]);  

            if(Denominator == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double x = (double)Numerator / Denominator;
                Console.WriteLine(x.ToString("f1"));
            }
        }
    }
}
