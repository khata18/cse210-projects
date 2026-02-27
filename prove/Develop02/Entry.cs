public class Entry
{
    public DateTime _theCurrentTime = DateTime.Now;
    public string _entry;
    public string _date;
    public string _randomPrompt;        
    public void PrintEntry(Entry datedEntry)
    {  
        Console.WriteLine($"Date: {datedEntry._date} - Prompt: {datedEntry._randomPrompt} \n {datedEntry._entry} \n");
    }   
}
