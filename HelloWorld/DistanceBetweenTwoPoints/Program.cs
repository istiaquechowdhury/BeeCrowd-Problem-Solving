using System;


public class Program
{
    public static void Main()
    {
        
            string[] s = Console.ReadLine().Split();

            string[] s1 = Console.ReadLine().Split();

            double x1 = double.Parse(s[0]);
            double y1 = double.Parse(s[1]);

            double x2 = double.Parse(s1[0]);
            double y2 = double.Parse(s1[1]);

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


            Console.WriteLine(distance.ToString("f4"));
            
            
            
           
        


    }
}