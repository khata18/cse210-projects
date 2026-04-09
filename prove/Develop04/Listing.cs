public class Listing : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _remainingPrompts = new List<string>();

    public Listing() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    private string GetNextPrompt()
    {
        if (_remainingPrompts.Count == 0)
            _remainingPrompts = new List<string>(_prompts);
        Random rand = new Random();
        int index = rand.Next(_remainingPrompts.Count);
        string prompt = _remainingPrompts[index];
        _remainingPrompts.RemoveAt(index);
        return prompt;
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetNextPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < end)
        {
            Console.Write("\n> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                items.Add(input);
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        DisplayEndMessage();
    }
}
