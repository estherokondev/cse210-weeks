class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    public List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string author, string text)
    {
        Comments.Add(new Comment(author, text));
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
}