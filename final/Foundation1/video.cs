public class Video
{
    private string _title;
    private string _author;
    private List<Comment> _comments;
    private double _seconds;

    public Video(string title, string author, double seconds)
    {
        _title = title;
        _author = author;
        _comments = new List<Comment>();
        _seconds = seconds;
    }

    public void AddComment(Comment comments)
    {
        _comments.Add(comments);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Seconds: {_seconds}");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");

        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"-{comment.GetCommenterName()}: {comment.GetCommentText()}");
        }
    }
}