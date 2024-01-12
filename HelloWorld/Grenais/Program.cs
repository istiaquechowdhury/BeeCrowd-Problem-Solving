using System;
using System.Net.Security;

public class Program
{
    public static void Main()
    {
        int Count = 0;
        int InterwinCounts = 0;
        int GremipwinCounts = 0;
        int CountDraw = 0;
        while (true)
        {
           
           
            string[] s = Console.ReadLine().Split();

            Count++;    

            int[] l = Array.ConvertAll(s,int.Parse);

            int Inter = l[0];
            int Gremip = l[1]; 

            if ( Inter > Gremip ) 
            {
                InterwinCounts++;
            }
            else if ( Inter < Gremip ) 
            {
                GremipwinCounts++;  
            }
            else if(Inter == Gremip ) 
            {
                CountDraw++;
            }
            
            


            Console.WriteLine("Novo grenal (1-sim 2-nao)");

            int x = int.Parse(Console.ReadLine());

            if(x == 1)
            {
                continue;
            }
            else if(x == 2)
            {
                Console.WriteLine($"{Count} grenais");
                if( InterwinCounts > GremipwinCounts || InterwinCounts < GremipwinCounts || InterwinCounts == GremipwinCounts )
                {
                    Console.WriteLine($"Inter:{InterwinCounts}");
                    Console.WriteLine($"Gremio:{GremipwinCounts}");
                    Console.WriteLine($"Empates:{CountDraw}");
                    if(InterwinCounts > GremipwinCounts)
                    {
                        Console.WriteLine("Inter venceu mais");
                    }
                    else if( InterwinCounts < GremipwinCounts )
                    {
                        Console.WriteLine("Gremio venceu mais");
                    }
                    else
                    {
                        Console.WriteLine("Não houve vencedor");
                    }
                    


                }
                
               
                break;

            }
        }
    }
}