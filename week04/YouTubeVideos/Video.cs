using System.Runtime.CompilerServices;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length, List<Comment> commentList)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = commentList;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length}\n# of comments: {NumComments()}");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

    public int NumComments()
    {
        return _comments.Count;
    }

}