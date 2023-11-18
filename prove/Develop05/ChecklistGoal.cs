public class ChecklistGoal : Goal 
{
    private int tasksCompleted; 
    private int targetCompletion; 
    private int bonusPoints;

    public ChecklistGoal(string name, string description, string points,int target, int bonus) : base(name, description, points)
    {
        targetCompletion = target;
        bonusPoints = bonus;
        tasksCompleted = 0;
    }

    public override void RecordEvent()
    {
       tasksCompleted++;

       if (targetCompletion == tasksCompleted)
       {
        int totalPoints = GetPoints() + bonusPoints;
        SetPoints(totalPoints);
       } 
    }

    public override bool IsComplete()
    {
        if (tasksCompleted == targetCompletion)
        {  
            return true;
        }
        else
        {
        return false;
        }
    }

    public override string GetGoalDetails()
    {
        string checklistDescription = $"ChecklistGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()},{bonusPoints},{targetCompletion},{tasksCompleted}";

        return checklistDescription;
    }

    public override string CompletedDescription()
    {
        return ($"{base.CompletedDescription()} -- Currently completed: {tasksCompleted}/{targetCompletion}");
    }

    public void SetAmount(int tasks)
    {
        tasksCompleted = tasks;
    }


}