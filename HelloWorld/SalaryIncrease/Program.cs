using System;
public class Program
{
    public static void Main()
    {
       double Salary = double.Parse(Console.ReadLine());

        double Result;
        double FinalResult = 0;
       
       if(Salary > 0 && Salary <= 400)
       {
            Result = (15.0/100) * Salary;

            FinalResult = Result + Salary;

            Console.WriteLine($"Novo salario: {FinalResult.ToString("f2")}");
            Console.WriteLine($"Reajuste ganho: {Result.ToString("f2")}");
            Console.WriteLine($"Em percentual: 15 %");
       }
       else if(Salary > 400 && Salary <= 800)
       {
            Result = (12.0 / 100) * Salary;

            FinalResult = Result + Salary;

            Console.WriteLine($"Novo salario: {FinalResult.ToString("f2")}");
            Console.WriteLine($"Reajuste ganho: {Result.ToString("f2")}");
            Console.WriteLine($"Em percentual: 12 %");
       }
        else if (Salary > 800 && Salary <= 1200)
        {
            Result = (10.0 / 100) * Salary;

            FinalResult = Result + Salary;

            Console.WriteLine($"Novo salario: {FinalResult.ToString("f2")}");
            Console.WriteLine($"Reajuste ganho: {Result.ToString("f2")}");
            Console.WriteLine($"Em percentual: 10 %");
        }
        else if (Salary > 1200 && Salary <= 2000)
        {
            Result = (7.0 / 100) * Salary;

            FinalResult = Result + Salary;

            Console.WriteLine($"Novo salario: {FinalResult.ToString("f2")}");
            Console.WriteLine($"Reajuste ganho: {Result.ToString("f2")}");
            Console.WriteLine($"Em percentual: 7 %");
        }
        else  
        {
            Result = (4.0 / 100) * Salary;

            FinalResult = Result + Salary;

            Console.WriteLine($"Novo salario: {FinalResult.ToString("f2")}");
            Console.WriteLine($"Reajuste ganho: {Result.ToString("f2")}");
            Console.WriteLine($"Em percentual: 4 %");
        }

    }
}