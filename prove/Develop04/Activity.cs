public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public int Duration { get { return _duration; } }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
        File.AppendAllText("activitylog.txt", $"{DateTime.Now:yyyy-MM-dd HH:mm} | {_name} | {_duration} sec\n");
    }

    public static void DisplayLog()
    {
        if (!File.Exists("activitylog.txt"))
        {
            Console.WriteLine("\nNo activity log found yet.");
            return;
        }
        string[] lines = File.ReadAllLines("activitylog.txt");
        Console.WriteLine($"\n--- Activity Log ({lines.Length} sessions) ---");
        foreach (string line in lines)
            Console.WriteLine("  " + line);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinnerChars = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(spinnerChars[i % spinnerChars.Length]);
            System.Threading.Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
