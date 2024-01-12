using System;


public class Program
{
    public static void Main()
    {

        string[] s = Console.ReadLine().Split();

        for(int i = 0; i < s.Length-1; i++)
        {
            if (int.Parse(s[i+1]) > 0)
            {
                    
                    
               
                    int result = 0;
                    for (int j = int.Parse(s[0]); j < int.Parse(s[0]) + int.Parse(s[i+1]); j++)
                    {
                        result = result + j;
                    }
                    Console.WriteLine(result);
                
            }
        }
        



           


            


           


           
        
    }
}