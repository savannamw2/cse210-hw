public class BreathingActivity : Activity 
{
    public BreathingActivity()
    {
        ActivityName = "Breathing Activity";
        ActivityDescription = "This activity will help you relax by walking you hrough breathing in and out slowly.\nClear your mind and focuc on your breathing. ";      
    }

    public void BreathIn()
    {
        Console.Write("Now breathe in...");
        for(int seconds = 5; seconds > 0; seconds--)
        {
            Console.Write(seconds);
            Thread.Sleep(1000); 
            Console.Write("\b \b"); 
            }
        Console.WriteLine();
    }

    public void BreathOut()
    {
        Console.Write("Now breathe out..."); 
        for(int seconds = 5; seconds > 0; seconds--)
        {
            Console.Write(seconds);
            Thread.Sleep(1000); 
            Console.Write("\b \b"); 
        }
        Console.WriteLine();
    }

    public void RunBreathingActivity()
    {
        Console.Clear();
        DisplayStart();
        int duration = Int32.Parse(Console.ReadLine());

        Interval(duration);

        Console.Write("Get Ready...");
        SpinnerPause(5);
        Console.WriteLine();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

    
        while (DateTime.Now < endTime)
        {            
            BreathIn();    
            BreathOut();
        }
        
        DisplayEnd();

        SpinnerPause(5);

        Console.Clear();

    }
}
