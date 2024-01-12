using System;

public class Program
{
    public static void Main()
    {
        int LevelOneCount = 0;
        int LevelTwoCount = 0;  
        int LevelThreeCount = 0;    
        while (true) 
        {
            string input = Console.ReadLine();

            int N;

            if(!int.TryParse(input,out N))
            {
                break;
            }

            string[] arry = Console.ReadLine().Split();

            int[] speed = Array.ConvertAll(arry,int.Parse);

            for(int i  = 0; i < speed.Length; i++)
            {
                if (speed[i] < 10) 
                {
                    LevelOneCount++;    
                }
                else if (speed[i] >= 10 && speed[i] < 20)
                {
                    LevelTwoCount++;    
                }
                else if (speed[i] >= 20)
                {
                    LevelThreeCount++;
                }
            }
            if(LevelThreeCount > 0)
            {
                Console.WriteLine(3);
                LevelThreeCount = 0;
                LevelTwoCount = 0;
                LevelOneCount = 0;
            }
            else if(LevelTwoCount > 0)
            {
                Console.WriteLine(2);
                LevelThreeCount = 0;
                LevelTwoCount = 0;
                LevelOneCount = 0;
            }
            else if (LevelOneCount > 0)
            {
                Console.WriteLine(1);
                LevelThreeCount = 0;
                LevelTwoCount = 0;
                LevelOneCount = 0;
            }
                
        }

    }
}