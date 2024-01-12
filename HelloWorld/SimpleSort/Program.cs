using System;


public class Program
{
    public static void Main()
    {

        //string[] S = Console.ReadLine().Split();

        string[] s = Console.ReadLine().Split();

        int[] arr = Array.ConvertAll(s,int.Parse);

         int[] clone = (int[])arr.Clone();

       

        Array.Sort(arr);





        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        Console.WriteLine();    

        for(int i = 0; i < clone.Length; i++)
        {
            Console.WriteLine(clone[i]);
        }









    }




}