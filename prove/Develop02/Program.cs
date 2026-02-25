using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.IO; 


// I added a feature under 1. Write. It will ask if the entry is for today or for another date so that users can add entries from the past or have skipped a day in their journaling.

class Program
{
    static void Main(string[] args)
    {
        Prompt myPrompt = new Prompt();
        myPrompt._prompt.Add("Who was the most interesting person I interacted with today?");
        myPrompt._prompt.Add("What are the things that I am grateful for?");
        myPrompt._prompt.Add("What are the things that I can improve on?");
        myPrompt._prompt.Add("How did I see the hand of the Lord in my life today?");
        myPrompt._prompt.Add("What are the accomplishments that you did today?");
        myPrompt._prompt.Add("What was the most challenging thing I faced today?");

        Journal myJorunal = new Journal ();
        Entry myEntry = new Entry ();
        
        bool loop = false;
        do
        {
            

            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select the following choices:");
            Console.WriteLine("1. Write"); 
            Console.WriteLine("2. Display"); 
            Console.WriteLine("3. Load"); 
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit"); 
            Console.Write("What would you like to do? ");

            string response = Console.ReadLine();
            
            if (response == "1")
            {
                myEntry.GetEntry(myPrompt._prompt);

            }
            else if (response == "2")
            {
            //    myJorunal.DisplayEntry(myJorunal._entry); 
            }
            else if (response == "3")
            {
                // myJorunal.LoadFile();
            }
            else if (response == "4")
            {
                // myJorunal.SaveEntry(myJorunal._entry);
            }
            else if (response == "5")
            {
                loop = true;
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
            }
        } while (!loop);
        
    }
}