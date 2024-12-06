public class Comment
{
    private string _commenter;
    private string _text;

    public Comment(string commenter, string text)
    {
        _commenter = commenter;
        _text = text;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"{_commenter} > {_text}");
    }

    // Getters and Setters
    public void SetCommenter(string commenter)
    {
        _commenter = commenter;
    }
    public string GetCommenter()
    {
        return _commenter;
    }
    public void SetText(string text)
    {
        _text = text;
    }
    public string GetText()
    {
        return _text;
    }
}