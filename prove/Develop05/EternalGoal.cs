public class EternalGoal : Goal 
{
    public EternalGoal(string name, string description, string points) : base(name, description, points){}

    public override void RecordEvent()
    {
        IsComplete(); 
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetGoalDetails()
    {
        string goalDescription = $"Eternal Goal:{base.GetName()},{base.GetDescription()},{base.GetPoints()}";
        return goalDescription;
    }
}