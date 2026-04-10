class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        string details = GetStandardDetails() + "\n";
        details += "Type: Reception\n";
        details += "RSVP Email: " + _rsvpEmail;
        return details;
    }

    public override string GetShortDescription()
    {
        return "Type: Reception\n" + base.GetShortDescription();
    }
}
