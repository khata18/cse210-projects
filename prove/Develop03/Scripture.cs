using System.Globalization;

public class Scripture
{
    private Reference _refernce;
    private string[] _text;
    private List<Word>_listText = new List <Word>();
    private List<int> _indexList = new List<int>();
    
    
  //----------------------------------------------------  
    
    public Scripture(string text)
    {
        _text = text.Split(" ");
        
        foreach (string line in _text)
        {
            Word word = new Word(line);
            _listText.Add(word);
        }
    }


    public void GetRenderedText()
    {
        
        foreach (Word word in _listText)
        {
            word.GetRenderedWord();
            Console.Write(" ");
        } 
    }


    public void HideWords()
    {
        
        Random randomGenerator = new Random ();
        int num = 0;
        while (num <3 && !IsCompletelyHidden())
        {        
            
            int randomIndex = randomGenerator.Next(_listText.Count);
            if (!_indexList.Contains(randomIndex))
            {
                _indexList.Add(randomIndex);
                Word randomWord = _listText[randomIndex];
                randomWord.Hide();
                num += 1;
            }
        }   
    }
          

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _listText)
        {
            if (!word.Hidden())
            {
                return false;
            }
        }
        return true;
    }

    public List<Word> GetList()
    {
        return _listText;
    }

}
