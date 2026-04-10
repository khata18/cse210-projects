// Exceeds Requirements:
// NegativeGoal class — an extra goal type for tracking bad habits (e.g., skipping a workout).
// It deducts points each time it is recorded, giving a real consequence for habits to break.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        Console.WriteLine("=== Welcome to the Eternal Quest Program ===");

        bool running = true;
        while (running)
        {
            manager.DisplayStatus();
            Console.WriteLine("\nMenu:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Load Goals");
            Console.WriteLine("  6. Quit");
            Console.Write("Choice: ");

            string input = Console.ReadLine();
            if (input == "1")
            {
                manager.CreateNewGoal();
            }
            else if (input == "2")
            {
                Console.WriteLine();
                manager.DisplayGoals();
            }
            else if (input == "3")
            {
                manager.RecordEvent();
            }
            else if (input == "4")
            {
                manager.SaveGoals();
            }
            else if (input == "5")
            {
                manager.LoadGoals();
            }
            else if (input == "6")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        Console.WriteLine("Farewell, adventurer. Keep up the quest!");
    }
}
