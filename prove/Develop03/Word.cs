using System.Reflection.Metadata.Ecma335;

public class Word
{  
    private List<char>_letters = new List<char>();

//----------------------------------------------------


    public Word (string word)
    {
        foreach (char letter in word)
        {
            _letters.Add(letter);
        }
    }
  
    public void Hide()
    {    

        for (int underscore = 0; underscore < _letters.Count; underscore++)
        {
            _letters[underscore] = '_';
        }
        
    }

    public void GetRenderedWord()
    {
        foreach (char character in _letters)
        {
            Console.Write(character);
        }
    }

    public bool Hidden()
    {
        
        foreach (char character in _letters)
        {
            if (character != '_')
            {
                return false;
            }
        }
        return true;

    }



    
}