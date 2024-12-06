public class Video
{
    private string _title;
    private string _author;
    private double _lengthInSec;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double lengthInSec)
    {
        _title = title;
        _author = author;
        _lengthInSec = lengthInSec;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSec} seconds");
        Console.WriteLine();
        int numberOfComments = GetNumberOfComments();
        Console.WriteLine($"Number of Comments: {numberOfComments}");
        foreach(Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}