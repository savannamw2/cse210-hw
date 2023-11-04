using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        BreathingActivity breathing = new BreathingActivity();
        ReflectionActivity reflection = new ReflectionActivity();
        ListingActivity listing = new ListingActivity(); 
        
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the Menu: ");

            string Choice = Console.ReadLine();
    
            switch (Choice)
            {
                case "1": 
                    breathing.RunBreathingActivity();
                    break;
                case "2":
                    reflection.RunReflectionActivity();
                    break;
                case "3":
                    listing.RunListActivity();
                    break;
                case "4":
                    isRunning = false;
                    break; 
                default:
                    break;
                     

            } 
        }
    }
}