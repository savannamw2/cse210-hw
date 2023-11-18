public class SimpleGoal : Goal 
{
    private bool isComplete; 

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        isComplete = false;
    }

    public override void RecordEvent()
    {
        isComplete = true; 
    }

    public override bool IsComplete()
    {
        return isComplete;
    }

    public override string GetGoalDetails()
    {
        string goalDescription = $"SimpleGoal:{base.GetName()},{base.GetDescription()},{base.GetPoints()},{isComplete}";
        return goalDescription;
    }

}