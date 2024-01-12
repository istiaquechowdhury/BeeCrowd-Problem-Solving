using System;


class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());


        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);

            int sum = 0;
            for (int j = 1; j <= Y; j++)
            {
                if (X % 2 != 0)
                {
                    sum = sum + X;
                    X++;
                }
                else if(X % 2 == 0)
                {
                    j--;
                    X++;
                }
                    
                

                    
            }

            Console.WriteLine(sum);
        }
    }
}
