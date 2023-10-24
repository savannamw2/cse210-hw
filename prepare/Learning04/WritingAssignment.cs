public class WritingAssignment : Assignment
{
    public string title {get; set;}


    public WritingAssignment(string studentName, string topic, string title1)
        : base(studentName, topic)
    {
       title = title1; 
    }

    public string GetWritingInformation()
    {
        
        return $"{title} by {studentName}";
;    }

}