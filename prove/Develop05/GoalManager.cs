using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayStatus()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }


    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("  (no goals yet)");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDisplayString()}");
        }
    }

    public void CreateNewGoal()
    {
        Console.WriteLine("\nGoal types:");
        Console.WriteLine("  1. Simple Goal    (complete once for points)");
        Console.WriteLine("  2. Eternal Goal   (record any number of times)");
        Console.WriteLine("  3. Checklist Goal (complete N times for a bonus)");
        Console.WriteLine("  4. Negative Goal  (bad habit — lose points each time)");
        Console.Write("Select type: ");
        string choice = Console.ReadLine();

        Console.Write("Goal name: ");
        string name = Console.ReadLine();
        Console.Write("Short description: ");
        string desc = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Points for completing this goal: ");
            _goals.Add(new SimpleGoal(name, desc, int.Parse(Console.ReadLine())));
        }
        else if (choice == "2")
        {
            Console.Write("Points each time you record this goal: ");
            _goals.Add(new EternalGoal(name, desc, int.Parse(Console.ReadLine())));
        }
        else if (choice == "3")
        {
            Console.Write("Points per completion: ");
            int pts = int.Parse(Console.ReadLine());
            Console.Write("Number of times required: ");
            int req = int.Parse(Console.ReadLine());
            Console.Write("Bonus for reaching the target: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, pts, req, bonus));
        }
        else if (choice == "4")
        {
            Console.Write("Points you will LOSE each time this is recorded: ");
            _goals.Add(new NegativeGoal(name, desc, int.Parse(Console.ReadLine())));
        }
        else
        {
            Console.WriteLine("Invalid choice — goal not created.");
            return;
        }
        Console.WriteLine("Goal created!");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }
        Console.WriteLine("\nGoals:");
        DisplayGoals();
        Console.Write("Which goal did you accomplish? ");

        int idx;
        if (!int.TryParse(Console.ReadLine(), out idx) || idx < 1 || idx > _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        int earned = _goals[idx - 1].RecordEvent();
        _score += earned;

        if (earned > 0)
        {
            Console.WriteLine($"You earned {earned} points! Total: {_score}");
        }
        else if (earned < 0)
        {
            Console.WriteLine($"You lost {Math.Abs(earned)} points. Total: {_score}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Filename to save: ");
        string filename = Console.ReadLine();
        using (StreamWriter file = new StreamWriter(filename))
        {
            file.WriteLine(_score);
            foreach (Goal g in _goals)
                file.WriteLine(g.GetStringRepresentation());
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Filename to load: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            int sep = line.IndexOf('~');
            string type = line.Substring(0, sep);
            string[] p = line.Substring(sep + 1).Split('~');

            if (type == "SimpleGoal")
            {
                // p: name, desc, points, isComplete
                _goals.Add(new SimpleGoal(p[0], p[1], int.Parse(p[2]), bool.Parse(p[3])));
            }
            else if (type == "EternalGoal")
            {
                // p: name, desc, points, timesCompleted
                _goals.Add(new EternalGoal(p[0], p[1], int.Parse(p[2]), int.Parse(p[3])));
            }
            else if (type == "ChecklistGoal")
            {
                // p: name, desc, points, amountCompleted, requiredAmount, bonus
                _goals.Add(new ChecklistGoal(p[0], p[1], int.Parse(p[2]),
                    int.Parse(p[4]), int.Parse(p[5]), int.Parse(p[3])));
            }
            else if (type == "NegativeGoal")
            {
                // p: name, desc, points, timesRecorded
                _goals.Add(new NegativeGoal(p[0], p[1], int.Parse(p[2]), int.Parse(p[3])));
            }
        }
        Console.WriteLine("Goals loaded.");
    }
}
