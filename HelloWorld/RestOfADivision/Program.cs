using System;

public class Program
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());    
        int SecondNumber = int.Parse(Console.ReadLine());   

        int X, Y;

        if(firstNumber < SecondNumber) 
        {
            X = firstNumber;
            Y = SecondNumber;
        }
        else
        {
            X = SecondNumber;
            Y = firstNumber;
        }
        int sum = 0;
        
        for(int i = X+1; i < Y; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
               Console.WriteLine(i);
            }

        }
    }
}