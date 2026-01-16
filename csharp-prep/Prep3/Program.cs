using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        
        
    
        string response = null;
        do {
            Random randomGenerator = new Random ();
            int magicNumber = randomGenerator.Next(1,100);
            int guessNumber, count = 0;
            
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

            } while (response != "no");
    }
}