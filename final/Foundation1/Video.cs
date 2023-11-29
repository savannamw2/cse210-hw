public class Video 
{
    public string title; 
    public string author; 
    public float length; 

    public List<Comment> comments = new List<Comment>();

    public Video(string titles, string authors, float lengths)
    {
        title = titles; 
        author = authors; 
        length = lengths; 
    }

    public string VideoDetails()
    {
        return $"Title: {title}\nAuthor: {author}\nLength: {length}\nNumber of Comments: {comments.Count}";
    }

    public void DisplayComments()
    {
        foreach(Comment comment in comments)
        {
            comment.DisplayComment();
        }
    }
}