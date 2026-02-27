using System.Collections.Generic;


public class Prompt
{
    public List<string>_prompt = new List<string>();
    

    public string GetRandomList(List<string> prompt)
    {
        _prompt = prompt;
        Random randomGenerator = new Random ();
        int randomIndex = randomGenerator.Next(_prompt.Count);
        string randomPrompt = _prompt[randomIndex];
        return randomPrompt;
    }


        
}