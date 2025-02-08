using System;

public class Comments
{
    // has the responsibility for tracking both the name
    //  of the person who made the comment and the text of the comment.
    private string _comment;
    private string _commenter;
    //private List<string>_comments = new List<string>();
    public Comments(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public override string ToString()
    {
        return  $"{_commenter}: {_comment}";
    }
    

} 