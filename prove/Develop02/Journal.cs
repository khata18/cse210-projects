using System.IO; 
public class Journal
{   
    public List<Entry>_listEntry = new List<Entry>();

    Prompt myPrompt = new Prompt ();
    public Entry GetEntry(List<string> prompt)
    {
        Entry newEntry = new Entry(); //create new instance of Entry template (remember: Entry is an object kind of like a variable, single index in a list)
        myPrompt._prompt = prompt;
        Console.Write("Is this entry for today? (yes/no) ");
        string _answer = Console.ReadLine();
        if (_answer == "yes")
        {
            string _dateText = newEntry._theCurrentTime.ToShortDateString();
            newEntry._date = _dateText;
            newEntry._randomPrompt = myPrompt.GetRandomList(myPrompt._prompt);
            Console.WriteLine(newEntry._randomPrompt);
            Console.Write(">");
            newEntry._entry = Console.ReadLine();           
            
        }
        else if (_answer == "no")
        {
            Console.WriteLine("What date is it for? (MM/DD/YYYY)");
            string _customDate = Console.ReadLine();
            DateTime _readCustomDate = DateTime.Parse(_customDate);
            string _stringOnlyDate = _readCustomDate.ToShortDateString();
            newEntry._date = _stringOnlyDate;

            newEntry._randomPrompt = myPrompt.GetRandomList(myPrompt._prompt);
            Console.WriteLine(newEntry._randomPrompt);
            Console.Write(">");
            newEntry._entry = Console.ReadLine(); 
            
                    
        }
        _listEntry.Add(newEntry);
        return newEntry;
    }

        public void DisplayEntry()
    {
        Entry newEntry = new Entry();
        
        foreach (Entry written in _listEntry)
        {
            newEntry.PrintEntry(written);
        }
        
    }

    public void LoadFile()
    {
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();
        string [] lines = System.IO.File.ReadAllLines(filename);

    
        foreach (string line in lines)
        {
            Entry newEntry = new Entry(); //create new instance of Entry template to use everytime it loops 
            string[] parts = line.Split("-");
            newEntry._date = parts[0];
            newEntry._randomPrompt = parts[1];
            newEntry._entry = parts[2];
            _listEntry.Add(newEntry);
    
        }
        
    }

    public void SaveEntry()
    {
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();
        Entry newEntry = new Entry();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
           foreach (Entry written in _listEntry)
        {
            outputFile.WriteLine($"{written._date}-{written._randomPrompt}-{written._entry}");
        } 
        }
    }


}