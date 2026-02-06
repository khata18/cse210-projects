using System.IO; 
public class Journal
{
    public List<string>_entry = new List<string>();
    public DateTime _theCurrentTime = DateTime.Now;
   
     Prompt myPrompt = new Prompt ();
    public void GetEntry(List<string> _prompt)
    {
        Console.Write("Is this entry for today? (yes/no) ");
        string answer = Console.ReadLine();

        if (answer == "yes")
        {
            string _dateText = _theCurrentTime.ToShortDateString();

            
            string randomPrompt = myPrompt.GetRandomList(_prompt);
            Console.WriteLine(randomPrompt);
            Console.Write(">");
            string entry = Console.ReadLine();

            string datedEntry = $"Date: {_dateText} - Prompt: {randomPrompt} \n {entry} \n";
            _entry.Add(datedEntry);
        }
        else if (answer == "no")
        {
            Console.WriteLine("What date is it for? (MM/DD/YYYY)");
            string customDate = Console.ReadLine();
            DateTime readCustomDate = DateTime.Parse(customDate);
            string stringOnlyDate = readCustomDate.ToShortDateString();

            string randomPrompt = myPrompt.GetRandomList(_prompt);
            Console.WriteLine(randomPrompt);
            Console.Write(">");
            string entry = Console.ReadLine();

            string datedEntry = $"Date: {stringOnlyDate} - Prompt: {randomPrompt} \n {entry} \n";
            _entry.Add(datedEntry);
        }

            

    }
    
    public void DisplayEntry(List<string> _entry)
    {
        foreach (string written in _entry)
        {
            Console.WriteLine(written);
        }
        
    }

    public void LoadFile(){
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();

        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _entry.Add(line);
        }

    }

    public void SaveEntry(List<string> _entry)
    {
        Console.WriteLine("What is the file name?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
           foreach (string written in _entry)
        {
            outputFile.WriteLine(written);
        } 
        }
    }
}
