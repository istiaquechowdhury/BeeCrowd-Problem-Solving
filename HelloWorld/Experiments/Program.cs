using System;

public class Program
{
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int TotalC = 0;
        int TotalR = 0;
        int TotalS = 0;

        int ToTalAmount = 0;

        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();






            if (s[1] == "C")
            {
                TotalC = TotalC + int.Parse(s[0]);
            }
            else if (s[1] == "R")
            {
                TotalR += int.Parse(s[0]);
            }
            else if (s[1] == "S")
            {
                TotalS += int.Parse(s[0]);
            }
        }
    

        ToTalAmount = TotalC + TotalR + TotalS;

        double PercentageC = ((double)TotalC/ToTalAmount) *100;
        double PercentageR = ((double)TotalR / ToTalAmount) * 100;
        double PercentageS = ((double)TotalS / ToTalAmount) * 100;


        Console.WriteLine($"Total: {ToTalAmount} cobaias");
        Console.WriteLine($"Total de coelhos: {TotalC}");
        Console.WriteLine($"Total de ratos: {TotalR}");
        Console.WriteLine($"Total de sapos: {TotalS}");

        Console.WriteLine($"Percentual de coelhos: {PercentageC.ToString("f2")} %");
        Console.WriteLine($"Percentual de ratos: {PercentageR.ToString("f2")} %"); 
        Console.WriteLine($"Percentual de sapos: {PercentageS.ToString("f2")} %");


    }
}