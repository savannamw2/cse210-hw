using System; 

public class Entry
{   
    public string _entry {get; set;} 
    public string Name {get; set;} 

    public static string[] prompts = new string[]  {"What was your sweet and sour today?",
        "What were your thoughts after morning prayer?",
        "What were you grateful for today?",
        "What do you need to get done tomorrow?",
        "What song did you listen to today, and what did you like about it?",
        "How are you feeling currently?",
        "What are your current stresses?", 
        "What did you do today to serve others?"}; 

    string current_prompt = "";
    
    public void Display()
    {
        Random rnd = new Random();
        int index = rnd.Next(prompts.Length);
        current_prompt = prompts[index];
        Console.WriteLine($"Prompt: {current_prompt}"); 
        
    }

    public string createEntry ()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        return $"\nDate: {dateText} Prompt: {current_prompt} \n Written by: {Name} \n > {_entry}\n";

    }
}
