using System.Collections.Generic;

class Video
{
    public string Title;
    public string Author;
    public int LengthInSeconds;
    public List<Comment> Comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}
