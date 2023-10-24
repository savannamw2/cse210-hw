using System; 

public class Assignment{
    public string studentName {get; set;}
    public string topic {get; set;}

     public Assignment(string studentName1, string topic1)
    {
        studentName = studentName1;
        topic = topic1;
    }

      public string GetSummary()
    {
        return studentName + " - " + topic;
    }

    


}
