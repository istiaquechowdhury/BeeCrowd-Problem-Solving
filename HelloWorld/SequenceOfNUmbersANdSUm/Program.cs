using System;

public class Program
{
    public static void Main()
    {
        int Count = 0; 
        
        for(int i = 0; i < 3; i++)
        {
            string[] s = Console.ReadLine().Split();


            
            int firstnumber = int.Parse(s[0]);
            int secondnumber = int.Parse(s[1]);

            int start, end;
            if(firstnumber > secondnumber) 
            {
                start = secondnumber;
                end = firstnumber;
            }
            else
            {
                start = firstnumber;
                end = secondnumber; 
            }

            for(int j = start; j <= end; j++)
            {
                if(start <= 0 || end <= 0)
                {
                    continue;
                }
                Count = Count + j;
                Console.Write(j + " ");
            }
            if (start <= 0 || end <= 0)
            {
                break;
            }

            Console.WriteLine($"Sum={Count}");
            Count = 0;  
        }
    }
}