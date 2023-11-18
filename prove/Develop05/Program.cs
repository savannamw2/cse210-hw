using System;

class Program
{
    static void Main(string[] args)
    {
        OptionTracker option = new OptionTracker();

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the Menu: ");

            string Choice = Console.ReadLine();
    
            switch (Choice)
            {
                case "1": 
                    option.CreateGoal();
                    break;
                case "2":
                    option.ListGoalsDetails();
                    break;
                case "3":
                    option.SaveGoals();
                    break; 
                case "4":
                    option.LoadGoals();
                    break;
                case "5":
                    option.RecordEvent();
                    break;
                case "6":
                    isRunning = false;
                    break; 
                default:
                    isRunning = false; 
                    break;
    
            }
        }
    }
}