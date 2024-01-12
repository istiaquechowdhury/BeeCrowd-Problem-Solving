using System;

public class Program
{
    public static void Main()
    {

        
            string[] strings = Console.ReadLine().Split();

            int[] arr = Array.ConvertAll(strings, int.Parse);


            int first = arr[0];
            int second = arr[1];
            int third = arr[2];

            if (first > second && second <= third)
            {
                Console.WriteLine(":)");
            }
            else if (first < second && second >= third)
            {
                Console.WriteLine(":(");
            }
            else if ((first - second) < (second - third))
            {
                Console.WriteLine(":(");
            }
            else if ((first - second) <= (second - third))
            {
                Console.WriteLine(":)");
            }
            else if ((first - second) > (second - third))
            {
                Console.WriteLine(":)");
            }
            else if ((second - third) >= (first - second))
            {
                Console.WriteLine(":(");
            }
            else if (first == second)
            {
                Console.WriteLine(":)");
            }
            else if (second > third)
            {
                Console.WriteLine(":(");
            }
        
        

    }
}