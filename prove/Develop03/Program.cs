using System;

// The feature I added for creativity is a the Scripture.HideWords(). I made sure that the random selection of hiding words are always 3. It selects a random index,but it makes sure that the index is never slected again therefore making it clean and hides 3 words consistently.
class Program
{
    static void Main(string[] args)
    {
        
        bool quit = false;
        string response = null;
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Reference reference = new Reference("John", 3, 16);

        reference.DisplayReference1();
        scripture.GetRenderedText();

        do
        {
        
            Console.WriteLine();
            Console.WriteLine("\nPlease enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            Console.Clear();
            scripture.HideWords();
            reference.DisplayReference1();
            scripture.GetRenderedText();
            
            if (scripture.IsCompletelyHidden())
            {
                quit = true;
            }
            if (response == "quit")
            {
                quit = true;
            }

            

        }while (!quit);

    }
}