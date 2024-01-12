using System;


public class Program
{
    public static void Main()
    {

        string[] S = Console.ReadLine().Split();

        int A = int.Parse(S[0]);

        int B = int.Parse(S[1]);    

        if(B % A == 0 || A % B ==0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }







    }




}