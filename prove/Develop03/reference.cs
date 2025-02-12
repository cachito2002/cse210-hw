public class Reference
{
     private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_startVerse}";
    }
}