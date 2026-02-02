public class Journal
{
    public List<string>_entry = new List<string>();
    public DateTime _theCurrentTime = DateTime.Now;
   
     Prompt myPrompt = new Prompt ();
    public void GetEntry(List<string> _prompt)
    {
        

        string _dateText = _theCurrentTime.ToShortDateString();

        
        string randomPrompt = myPrompt.GetRandomList(_prompt);
        Console.WriteLine(randomPrompt);
        Console.Write(">");
        string entry = Console.ReadLine();

        string datedEntry = $"Date: {_dateText} - Prompt: {randomPrompt} \n {entry}";
        _entry.Add(datedEntry);

    }
    
    public void DisplayEntry(List<string> _entry)
    {
        foreach (string written in _entry)
        {
            Console.WriteLine(written);
        }
        
    }
}