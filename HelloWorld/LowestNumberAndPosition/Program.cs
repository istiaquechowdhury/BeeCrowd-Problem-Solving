using System;


public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] s = Console.ReadLine().Split();

        int[]X = new int[n];    
    

        for (int i  = 0; i < n; i++)
        {
            X[i] = int.Parse(s[i]);
            
        }
      
       

       




            
            int min = X[0]; 
            int IndexCount = 0;
            for ( int j = 1; j < X.Length; j++)
            {
                if (min > X[j])
                {
                    min = X[j];
                    IndexCount = j;
                    
                }
            }

            Console.WriteLine($"Menor valor: {min}");
            Console.WriteLine($"Posicao: {IndexCount}");
            
        
       

    }
}