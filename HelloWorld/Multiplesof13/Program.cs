using System;

public class Program
{
    public static void Main()
    {
        int FirstNumber = int.Parse(Console.ReadLine());
        int SecondNumber = int.Parse(Console.ReadLine());

        int X , Y;

        if(FirstNumber < SecondNumber)
        {
            X = FirstNumber;
            Y = SecondNumber;
            
        }
        else
        {
            X = SecondNumber;
            Y = FirstNumber;
           
        }
        int sum = 0;
        for(int i = X; i <= Y; i++)
        {
            if(i % 13 != 0)
            {
                sum = sum + i;
            }
        }
        Console.WriteLine(sum);
        


    }
}