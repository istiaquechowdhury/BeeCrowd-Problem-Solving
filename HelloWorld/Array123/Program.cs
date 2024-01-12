using System;

class Program
{
    static void GeneratePattern(int N)
    {
        char[,] matrix = new char[N, N];

        // Fill the matrix with '3's
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = '3';
            }
        }

        // Fill the inner space with '1's
        for (int i = 1; i < N - 1; i++)
        {
            for (int j = 1; j < N - 1; j++)
            {
                matrix[i, j] = '1';
            }
        }

        // Print the generated matrix
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        // Read input until EOF
        string input;
        while ((input = Console.ReadLine()) != null)
        {
            int N = int.Parse(input);
            GeneratePattern(N);
        }
    }
}
