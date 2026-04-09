// Exceeded requirements:
// 1. No repeated prompts/questions
// 2. Activity log: Each completed activity is appended to activitylog.txt with the
//    date, activity name, and duration. Users can view the full log from the menu.

class Program
{
    static void Main(string[] args)
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View activity log");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            string response = Console.ReadLine();

            if (response == "1")
            {
                Breathing breathing = new Breathing();
                breathing.Run();
            }
            else if (response == "2")
            {
                Reflecting reflecting = new Reflecting();
                reflecting.Run();
            }
            else if (response == "3")
            {
                Listing listing = new Listing();
                listing.Run();
            }
            else if (response == "4")
            {
                Activity.DisplayLog();
            }
            else if (response == "5")
            {
                quit = true;
            }
        }
    }
}
