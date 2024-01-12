using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            string s = Console.ReadLine();  

            if(s == "2002")
            {
                Console.WriteLine("Acesso Permitido");
                break;
            }
            else
            {
                Console.WriteLine("Senha Invalida");
            }
            

           
        }
    }
}

