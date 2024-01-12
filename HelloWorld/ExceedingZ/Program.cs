using System;

public class Program
{
    public static void Main()
    {
        int X = int.Parse(Console.ReadLine());  
        int Z = int.Parse(Console.ReadLine());
        
        while(Z <= X)
        {
            Z =  int.Parse(Console.ReadLine());
        }
        int result = 0;
        int count = 0;  
        for(int i = X; i <= Z; i++)
        {
            result = result + i;
            count++;
            if (result > Z)
            {
                Console.WriteLine(count);
                break;
            }    


        }
       
    }
}