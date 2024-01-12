using System;

public class Program
{
    public static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        int[] N = new int[1000];

        for(int i = 0; i < N.Length;)
        {
            
             
            for(int j = 0; j < T; j++)
            {

                if (i < N.Length)
                {
                    N[i] = j;
                    Console.WriteLine($"N[{i}] = {N[i] = j}");
                    i++;
                }
                
                
                

                    

                   

                    


                

            }
        }
    }
}