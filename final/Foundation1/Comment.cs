public class Comment
{
    public string userName; 
    public string text; 

    public Comment(string name, string comment)
    {
        userName = name; 
        text = comment; 
    }

    public void DisplayComment()
    {
        Console.WriteLine($"UserName: {userName} Comment: {text}");

    }
}