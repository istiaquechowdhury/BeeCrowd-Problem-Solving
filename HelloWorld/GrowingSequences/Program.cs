using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
                break;
            
            StringBuilder sb = new StringBuilder();

            for(int i = 1; i <= n; i++)
            {
                sb.Append(i);
                if(i < n)
                {
                    sb.Append(" ");
                }
            }
            Console.WriteLine(sb);
        }

    }

}