using System;
using System.Configuration.Assemblies;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        int number, byear;
        string userName;
        DisplayWelcome();
        userName = PromptUsername();
        number = PromptUserNumber();
        PromptUserBirthYear(out byear);
        DisplayResult(userName, number, byear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUsername()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
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
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());

    }
    static void DisplayResult(string userName, int userNumber, int byear)
    {
        int square = userNumber * userNumber, age = 2026 - byear;
        Console.WriteLine($"Brother / Sister {userName}, the square of your number is {square}");
        Console.WriteLine($"Brother / Sister {userName}, you will turn {age} this year.");
    }
    
    
}