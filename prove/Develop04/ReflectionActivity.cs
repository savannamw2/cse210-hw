public class ReflectionActivity : Activity
{
    private string CurrentPrompt= "";

    private static string[] Prompts = new string[]  {"Think of a time when you stood up to someone else.",
    "Think of a time when you did something really difficult.",
    "What were you grateful for today?",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."};

    private static string[] Reflection = new string[] {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?", 
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?", 
    "How can you keep this experience in mind in the future?"};  

    private List<string> Name = new List<string>();
    
    public ReflectionActivity()
    {
        ActivityName = "Reflection Activity";
        ActivityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."; 
    } 

    public void PromptDisplay()
    {
        Random rnd = new Random();
        int index = rnd.Next(Prompts.Length);
        CurrentPrompt = Prompts[index];
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"\n--- {CurrentPrompt} ---\n"); 
    } 

    public void ReflectionDisplay(int time)
    {
        Console.Write("When you have something on your mind, press ENTER to continue: ");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in...");
        CountdownPause(5);
        Console.WriteLine();
        int promptResponse = time / 5; 
        Random rnd = new Random();

        for (int i = 0; i < promptResponse; i++)
        {
            Name.Add(Reflection[rnd.Next(Reflection.Length)]);
        }

        foreach (var item in Name)
        {
            Console.Write($"> {item} ");
            SpinnerPause(5);
            Console.WriteLine(); 
        }
            
    }

    public void RunReflectionActivity()
    {
        Console.Clear();
        DisplayStart();
        int duration = Int32.Parse(Console.ReadLine());
        
        Interval(duration);
        Console.Clear();

        Console.Write("Get Ready...");
        SpinnerPause(5);

        PromptDisplay();

        DateTime startTime2 = DateTime.Now;
        DateTime endTime2 = startTime2.AddSeconds(duration);

        Console.WriteLine();

        while (DateTime.Now < endTime2)
        {
            ReflectionDisplay(duration);
        } 
        
        DisplayEnd();

        SpinnerPause(5);

        Console.Clear();

    }
}
