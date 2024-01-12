using System;

public class Program
{
    public static void Main()
    {
        string Firstwords = Console.ReadLine();
        string SecondWords = Console.ReadLine();    
        string lastwords = Console.ReadLine();  

        if(Firstwords == "vertebrado" && SecondWords == "ave" && lastwords == "carnivoro") 
        {
            Console.WriteLine("aguia");
        }
        else if((Firstwords == "vertebrado" && SecondWords == "ave" && lastwords == "onivoro"))
        {
            Console.WriteLine("pomba");

        }
        else if ((Firstwords == "vertebrado" && SecondWords == "mamifero" && lastwords == "onivoro"))
        {
            Console.WriteLine("homem");
        }
        else if ((Firstwords == "vertebrado" && SecondWords == "mamifero" && lastwords == "herbivoro"))
        {
            Console.WriteLine("vaca");
        }
        else if ((Firstwords == "invertebrado" && SecondWords == "inseto" && lastwords == "hematofago"))
        {
            Console.WriteLine("pulga");
        }
        else if ((Firstwords == "invertebrado" && SecondWords == "inseto" && lastwords == "herbivoro"))
        {
            Console.WriteLine("lagarta");
        }
        else if ((Firstwords == "invertebrado" && SecondWords == "anelideo" && lastwords == "hematofago"))
        {
            Console.WriteLine("sanguessuga");

        }
        else if ((Firstwords == "invertebrado" && SecondWords == "anelideo" && lastwords == "onivoro"))
        {
            Console.WriteLine("minhoca");
        }
    }
}