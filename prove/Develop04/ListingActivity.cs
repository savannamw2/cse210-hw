public class ListingActivity : Activity 
{
    string CurrentListPrompt = "";

    private static string[] Prompts = new string[]  {"Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};

    List<string> Lists = new List<string>();

    public ListingActivity()
    {
        ActivityName = "Listing Activity";
        ActivityDescription =  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";      
    }

    public void PromptListDisplay()
    {
        Random rnd = new Random();
        int index = rnd.Next(Prompts.Length);
        CurrentListPrompt = Prompts[index];
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"\n--- {CurrentListPrompt} ---\n");
        Console.Write("You msy begin in...");
        CountdownPause(5);
        Console.WriteLine();
        
    }

    public void ListResponses()
    { 
        Console.Write("> ");
        string response = Console.ReadLine();
        Lists.Add(response); 
    }

    public void RunListActivity()
    {
        Console.Clear();
        DisplayStart();
        int duration = Int32.Parse(Console.ReadLine());

        Interval(duration);


        Console.Clear();
        
        Console.Write("Get Ready...");
        SpinnerPause(5);
        Console.WriteLine();

        PromptListDisplay();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            if (DateTime.Now < endTime)
            {
                ListResponses();
            }
        }

        Console.WriteLine($"You listed {Lists.Count} items!");

        DisplayEnd();
        SpinnerPause(5);
        Console.Clear();

    }

}