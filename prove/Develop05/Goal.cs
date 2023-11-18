public abstract class Goal 
{
    private string goalName; 

    private string goalDescription; 

    private string goalPoints;

    public Goal(string name, string description, string points, bool health=true)
    {
        goalName = name;
        goalDescription = description;
        goalPoints = points;
    }

    public string GetName()
    {
        return goalName;
    }

    public string GetDescription()
    {
        return goalDescription;
    }

    public int GetPoints()
    {
        int point = int.Parse(goalPoints);

        return point;
    }

   public void SetPoints(int points)
   {

    goalPoints = points.ToString();

   }  

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetGoalDetails();

    public virtual string CompletedDescription()
    {
        if (IsComplete())
        {
            return($"[x] {goalName} ({goalDescription})");
        }
        else
        {
            return($"[ ] {goalName} ({goalDescription})");
        }
    } 

}