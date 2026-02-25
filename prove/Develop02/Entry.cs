public class Entry
{
    public DateTime _theCurrentTime = DateTime.Now;
    public string _entry;
    public string _date;
    public string datedEntry;

         Prompt myPrompt = new Prompt ();
         Journal myJournal = new Journal ();
    public Entry GetEntry(List<string> prompts)
    {
        Console.Write("Is this entry for today? (yes/no) ");
        string answer = Console.ReadLine();
        Entry newEntry = new Entry();

        if (answer == "yes")
        {
            string _dateText = _theCurrentTime.ToShortDateString();
            newEntry._date = _dateText;
            string _randomPrompt = myPrompt.GetRandomList(myPrompt._prompt);
            Console.WriteLine(_randomPrompt);
            Console.Write(">");
            newEntry._entry = Console.ReadLine();           
            
        }

        else if (answer == "no")
        {
            Console.WriteLine("What date is it for? (MM/DD/YYYY)");
            string _customDate = Console.ReadLine();
            DateTime _readCustomDate = DateTime.Parse(_customDate);
            string _stringOnlyDate = _readCustomDate.ToShortDateString();
            newEntry._date = _stringOnlyDate;

            string randomPrompt = myPrompt.GetRandomList(myPrompt._prompt);
            Console.WriteLine(randomPrompt);
            Console.Write(">");
            _entry = Console.ReadLine();
            newEntry._entry = Console.ReadLine();         
        }
        return newEntry;
    }
    
    public void DisplayEntry()
    {
        
    }
}