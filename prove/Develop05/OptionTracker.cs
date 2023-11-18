using System;
using System.IO;


public class OptionTracker 
{
    private List<Goal> goal;

    private int points;

    public OptionTracker()
    {
        goal = new List<Goal>();
        points = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string typeGoal = Console.ReadLine();

        SpinnerPause();

        Console.Write("What is the name of your goal? "); 
        string name = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points? ");
        string points = Console.ReadLine();

        switch (typeGoal)
        {
            case "1":
                SimpleGoal simple = new SimpleGoal(name, description, points);
                goal.Add(simple);
                break;
            case "2":
                EternalGoal eternal = new EternalGoal(name, description, points);
                goal.Add(eternal);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus?");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times?");
                int bonus = int.Parse(Console.ReadLine());
                
                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);
                goal.Add(checklist);
                break;
            default:
                break;
        }
    }

    public void ListGoalsDetails() 
    {
        int count = 1;

        Console.WriteLine("The goals are: ");

        foreach (Goal goal in goal) 
            {
                Console.WriteLine($"{count}. {goal.CompletedDescription()}");
                count++;
            }

        Console.WriteLine($"You have {points} points.");
    }  
    
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string goalFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(goalFile)) 
        {
            outputFile.WriteLine(points);
            foreach (Goal goal in goal)
            {
                outputFile.WriteLine(goal.GetGoalDetails());
            }
        }

        SpinnerPause();
        Console.WriteLine("The goals have been saved!");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal life? ");
        string loadFile = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(loadFile);

        points = int.Parse(lines.First());

        string[] text = lines.Skip(1).ToArray();
        
        foreach(string line in text)
        {    
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string details = parts[1];
            string[] part = details.Split(",");

            if (goalType == "SimpleGoal")
            {
                SimpleGoal simpleLoads = new SimpleGoal(part[0], part[1], part[2]);

                goal.Add(simpleLoads);
                
            } else if (goalType == "EternalGoal")
            {
                EternalGoal eternalLoads = new EternalGoal(part[0], part[1], part[2]);
                    
                goal.Add(eternalLoads);

            } else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal checklistLoads = new ChecklistGoal(part[0], part[1], part[2], int.Parse(part[4]), int.Parse(part[3]));
                checklistLoads.SetAmount(int.Parse(part[5]));

                goal.Add(checklistLoads);
            }

        }

        SpinnerPause();
        Console.WriteLine($"You have {points} right now. "); 
    }

    public void RecordEvent()
    {
        ListGoalsDetails();
        Console.WriteLine("Which Goal did you accomplish?");
        int goalCompleted = int.Parse(Console.ReadLine());

        goal[goalCompleted - 1].RecordEvent();

        int totalPoints = goal[goalCompleted - 1].GetPoints();

        points += totalPoints;

        SpinnerPause(); 

        Console.WriteLine($"Congratulations! You have earned {totalPoints} points!");

        Console.WriteLine($"You now have {points} points.");
    }

    public void SpinnerPause() 
    {
        List<string> spinner = new List<string>{"|", "/", "-", "\\", "|"};
    
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(3);

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
} 

