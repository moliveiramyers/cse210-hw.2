using System;

public class Videos
{
    //  1.responsibility to track the title, author, and length (in seconds) of the video
    //  2.also has responsibility to store a list of comments,
    //  and should have a method to return the number of comments.
    private string _title;
    private string _author;
    private int _length;
    //private int _commentsAmounts;
    private List<Comments>_listComments = new List<Comments>();
    private List<Videos>_listVideos = new List<Videos>();

    public Videos(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        //_commentsAmounts = _listComments.Count;

    }

    public override string ToString()
    {
        return $"{_title}: {_author} - {_length} secs";
    }

    public void AddComments(Comments comments)
    {
        _listComments.Add(comments);
    }

    public void AddVideos(Videos VideoInfo)
    {
        _listVideos.Add(VideoInfo);
    }

    public int CountComments()
    {
        int numberComments = _listComments.Count;
        return numberComments;
    }

    public void Display()
    {
        foreach(Videos video in _listVideos)
        {    
            Console.WriteLine($"{video} Comments: {CountComments()}");
        // Console.WriteLine($"{_title} - {_author} ({_length}secs) Comments: {CountComments()}");
        // Console.WriteLine($"{_title}");
            foreach (Comments comment in _listComments)
            {
                Console.WriteLine(comment);
            }
        }
    }

}