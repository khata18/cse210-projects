class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points, int timesCompleted = 0)
        : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDisplayString()
    {
        return $"[-] {GetName()} ({GetDescription()}) -- completed {_timesCompleted} time(s)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal~{GetName()}~{GetDescription()}~{GetPoints()}~{_timesCompleted}";
    }
}
