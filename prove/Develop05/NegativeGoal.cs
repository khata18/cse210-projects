// NegativeGoal is an extra goal type added to exceed requirements.
// It tracks bad habits (e.g., skipping a workout, eating junk food) and
// deducts points each time the user records it, giving a real consequence
// for habits they want to break.
class NegativeGoal : Goal
{
    private int _timesRecorded;

    public NegativeGoal(string name, string description, int points, int timesRecorded = 0)
        : base(name, description, points)
    {
        _timesRecorded = timesRecorded;
    }

    public override int RecordEvent()
    {
        _timesRecorded++;
        return -GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDisplayString()
    {
        return $"[-] {GetName()} ({GetDescription()}) -- occurred {_timesRecorded} time(s)";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal~{GetName()}~{GetDescription()}~{GetPoints()}~{_timesRecorded}";
    }
}
