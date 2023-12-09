class Video
{
    public string Title;
    public string Author;
    public int Length;
    public List<Comment> Comments;

    public Video()
    {
        Comments = new List<Comment>();
    }
    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment{ CommenterName = commenterName, Text = text};
        Comments.Add(comment);
    }
    public int GetNumComments()
    {
        return Comments.Count;
    }
}