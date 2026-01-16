using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is the magic number? ");
        string magicAnswer = Console.ReadLine();
        int magicNumber = int.Parse(magicAnswer);
        int guessNumber, count = 0;
        string response = null;
        
        do {
            do 
            {
                count += 1;
                Console.Write("What is your guess? ");
                string guessAnswer = Console.ReadLine();
                guessNumber = int.Parse(guessAnswer);
                
            
                if (guessNumber == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took {count} tries.");
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
            } while (guessNumber != magicNumber);
            
            Console.Write("Do you still want to play? ");
            response = Console.ReadLine();

            } while (response != "yes");
    }
}