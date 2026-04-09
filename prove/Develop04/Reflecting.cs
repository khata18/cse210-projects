public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different from other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _remainingPrompts = new List<string>();
    private List<string> _remainingQuestions = new List<string>();

    public Reflecting() : base(
        "Reflecting",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
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

    private string GetNextQuestion()
    {
        if (_remainingQuestions.Count == 0)
            _remainingQuestions = new List<string>(_questions);
        Random rand = new Random();
        int index = rand.Next(_remainingQuestions.Count);
        string question = _remainingQuestions[index];
        _remainingQuestions.RemoveAt(index);
        return question;
    }

    public void Run()
    {
        DisplayStartMessage();

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {GetNextPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowSpinner(3);

        DateTime end = DateTime.Now.AddSeconds(Duration);
        while (DateTime.Now < end)
        {
            Console.Write($"\n> {GetNextQuestion()} ");
            ShowSpinner(5);
        }

        DisplayEndMessage();
    }
}
