using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        int[] arr = Array.ConvertAll(s, int.Parse);

        int X = arr[0];
        int Y = arr[1]; 

        StringBuilder stringBuilder = new StringBuilder();
        
        for(int i =1; i <= Y; i++)
        {
             stringBuilder.Append(i);

            if(i < Y)
            {
                stringBuilder.Append(" ");
            }
            Console.WriteLine(stringBuilder.ToStr);
            

            if(i % X == 0 || i == X)
            {
                Console.WriteLine();            
            }
        }
    }
}