public class Activity{

    private string activityName; // field

    public string ActivityName   // property
    {
        get { return activityName; }   // get method
        set { activityName = value; }  // set method
    }

    private string description; 

    public string ActivityDescription
    {
        get { return description; }   
        set { description = value; } 

    } 

    private int duration; 

    public int ActivityDuration 
    {
        get { return duration; }
        set { duration = value; } 
    }   

    public void DisplayStart()
    {
        Console.WriteLine($"\n\nWelcome to the {ActivityName}\n");
        Console.WriteLine($"{ActivityDescription}\n");
        Console.Write("How long, in seconds, would like for this activity to be? "); 
    }

    public void DisplayEnd()
    {
        Console.WriteLine("Well Done!!"); 


        Console.WriteLine($"You have completed {ActivityDuration} seconds of the {ActivityName}.");

    } 

    public void SpinnerPause(int timerDuration) 
    {
        List<string> spinner = new List<string>{"|", "/", "-", "\\", "|"};
    

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timerDuration);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string displaySpinner = spinner[i];
            Console.Write(displaySpinner);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= spinner.Count)
            {
                i=0;
            }
        }
    
    }

    public void CountdownPause(int timerDuration)
    {

        for (int i = timerDuration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }


    }
}
  