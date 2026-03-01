public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _secondVerse;

//----------------------------------------------------

    public Reference (string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;

    }

    public Reference (string book, int chapter, int firstVerse, int secondVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _secondVerse = secondVerse;

    }

    public void DisplayReference1()
    {
        Console.Write($"{_book} {_chapter}:{_firstVerse} ");
    }

    public void DisplayReference2()
    {
        Console.Write($"{_book} {_chapter}:{_firstVerse}-{_secondVerse} ");
    }

}