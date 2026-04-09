class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _requiredAmount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points,
        int requiredAmount, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _requiredAmount = requiredAmount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("This goal has already been fully completed!");
            return 0;
        }
        _amountCompleted++;
        int earned = GetPoints();
        if (_amountCompleted >= _requiredAmount)
        {
            earned += _bonus;
            Console.WriteLine($"  *** Checklist complete! Bonus of {_bonus} points awarded! ***");
        }
        return earned;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _requiredAmount;
    }

    public override string GetDisplayString()
    {
        string status;
        if (IsComplete())
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }
        return $"{status} {GetName()} ({GetDescription()}) -- completed {_amountCompleted}/{_requiredAmount} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal~{GetName()}~{GetDescription()}~{GetPoints()}~{_amountCompleted}~{_requiredAmount}~{_bonus}";
    }
}
