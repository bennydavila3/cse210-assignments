public class Reference
{
    private string _book;
    private string _chapter;
    private string _verseStart;
    private string _verseEnd;

    // Constructor for 1 verse
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = null;
    }

    // Constructor for multiple verses
    public Reference(string book, string chapter, string start, string end)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = start;
        _verseEnd = end;
    }
    public string GetReference()
    {
        if (_verseEnd != null)
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
        return $"{_book} {_chapter}:{_verseStart}";
    }
}