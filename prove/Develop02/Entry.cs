public class Entry
{
    public DateTime _theCurrentTime = DateTime.Now;
    public string _entry;

         Prompt myPrompt = new Prompt ();
         Journal myJournal = new Journal ();
    public void GetEntry(List<string> _prompt)
    {
        Console.Write("Is this entry for today? (yes/no) ");
        string answer = Console.ReadLine();

        if (answer == "yes")
        {
            string _dateText = _theCurrentTime.ToShortDateString();

            
            string _randomPrompt = myPrompt.GetRandomList(_prompt);
            Console.WriteLine(_randomPrompt);
            Console.Write(">");
            string entry = Console.ReadLine();

            string datedEntry = $"Date: {_dateText} - Prompt: {_randomPrompt} \n {entry} \n";
            myJournal._listEntry.Add(datedEntry);
        }

        else if (answer == "no")
        {
            Console.WriteLine("What date is it for? (MM/DD/YYYY)");
            string _customDate = Console.ReadLine();
            DateTime _readCustomDate = DateTime.Parse(_customDate);
            string _stringOnlyDate = _readCustomDate.ToShortDateString();

            string randomPrompt = myPrompt.GetRandomList(_prompt);
            Console.WriteLine(randomPrompt);
            Console.Write(">");
            string entry = Console.ReadLine();

            string datedEntry = $"Date: {_stringOnlyDate} - Prompt: {randomPrompt} \n {entry} \n";
            myJournal._listEntry.Add(datedEntry);
        }
    
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_dateText} - Prompt: {randomPrompt} \n {entry} \n");
    }
}