using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = "";

        for(int i = 0; i < n; i++)
        {
            while(i <=  n - 2)
            {
                 s = "Ho ";

                Console.Write(s);
                i++;

            }
            
          

            if (i == n - 1)
            {
                string l = s.Replace(" ","!");
               Console.Write(l);
                Console.WriteLine();
            }

        }
    }

}