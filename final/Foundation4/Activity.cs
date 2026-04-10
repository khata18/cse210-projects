class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public virtual double GetPace()
    {
        return _minutes / GetDistance();
    }

    public virtual string GetSummary()
    {
        string summary = _date + " " + GetType().Name + " (" + _minutes + " min)";
        summary += " - Distance: " + GetDistance().ToString("0.0") + " miles";
        summary += ", Speed: " + GetSpeed().ToString("0.0") + " mph";
        summary += ", Pace: " + GetPace().ToString("0.0") + " min per mile";
        return summary;
    }
}
