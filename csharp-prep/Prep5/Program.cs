using System;
using System.Configuration.Assemblies;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        PromptUsername();
        PromptUserNumber();

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static void PromptUsername()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favNumber = Console.ReadLine();
        int number =  int.Parse(favNumber);
        return number;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        
    }
    

}