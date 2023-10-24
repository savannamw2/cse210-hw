using System; 

public class MathAssignment : Assignment
{
    public string textbookSection {get;set;}
    public string problems {get; set;}

   public MathAssignment(string studentName, string topic, string textbookSection1, string problems1)
        : base(studentName, topic)
    {
        textbookSection = textbookSection1; 
        problems = problems1;  
    }

    public string GetHomeworkList()
    {
        return "Section " + textbookSection + " " + "Problems " + problems;
    }



}