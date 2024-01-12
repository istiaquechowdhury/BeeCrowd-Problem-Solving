using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int CountOdd = 0;

        for(int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();

            int firstNumber = int.Parse(s[0]);  
            int SecondNumber = int.Parse(s[1]);

            int start, end;

            if (firstNumber < SecondNumber)
            { 
                start = firstNumber;
                end = SecondNumber;

            }
            else 
            {
                start = SecondNumber;
                end = firstNumber;
            }

            for(int j = start+1; j < end; j++)
            {
                if (j % 2 != 0)
                {
                    CountOdd = CountOdd + j;
                }
            }
            Console.WriteLine(CountOdd);
            CountOdd = 0;
        }
    }
}