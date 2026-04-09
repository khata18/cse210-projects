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

            switch (Console.ReadLine())
            {
                case "1": manager.CreateNewGoal(); break;
                case "2": Console.WriteLine(); manager.DisplayGoals(); break;
                case "3": manager.RecordEvent(); break;
                case "4": manager.SaveGoals(); break;
                case "5": manager.LoadGoals(); break;
                case "6": running = false; break;
                default:  Console.WriteLine("Invalid choice."); break;
            }
        }
        Console.WriteLine("Farewell, adventurer. Keep up the quest!");
    }
}
