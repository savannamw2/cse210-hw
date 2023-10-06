using System; 

public class Entry
{   
    public string Response {get; set;} 
    public string Name {get; set;} 

    public static string[] Prompts = new string[]  {"What was your sweet and sour today?",
        "What were your thoughts after morning prayer?",
        "What were you grateful for today?",
        "What do you need to get done tomorrow?",
        "What song did you listen to today, and what did you like about it?",
        "How are you feeling currently?",
        "What are your current stresses?", 
        "What did you do today to serve others?"}; 

    string CurrentPrompt= "";
    
    public void Display()
    {
        Random rnd = new Random();
        int index = rnd.Next(Prompts.Length);
        CurrentPrompt = Prompts[index];
        Console.WriteLine($"Prompt: {CurrentPrompt}"); 
        
    }

    public string CreateEntry ()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        return $"\nDate: {dateText} Prompt: {CurrentPrompt} \n Written by: {Name} \n > {Response}\n";

    }
}
