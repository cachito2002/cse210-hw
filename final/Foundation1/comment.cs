public class Comment
{
    private string _commentName;
    private string _commentText;
    public Comment(string commentName, string commentText)
    {
        _commentName = commentName;
        _commentText = commentText;
    }

    public string GetCommenterName()
    {
        return _commentName;

    }
    public string GetCommentText()
    {
        return _commentText;
    }

}

