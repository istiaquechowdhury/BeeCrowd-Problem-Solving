using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        

        for(int i  = 0; i < n; i++)
        {
            string[] arr = Console.ReadLine().Split();

            string Name = arr[0];
            int NewtonsDigit = int.Parse(arr[1]);

            for(int j  = 1; j < arr.Length; j++)
            {
                if(Name == "Thor" && NewtonsDigit == NewtonsDigit)
                {
                    Console.WriteLine("Y");
                }
                else
                {
                    Console.WriteLine("N");
                }
            } 

            

        }
    }
}