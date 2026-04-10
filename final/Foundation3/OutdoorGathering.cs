class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        string details = GetStandardDetails() + "\n";
        details += "Type: Outdoor Gathering\n";
        details += "Weather Forecast: " + _weatherForecast;
        return details;
    }

    public override string GetShortDescription()
    {
        return "Type: Outdoor Gathering\n" + base.GetShortDescription();
    }
}
