public class Running : Activity
{
    private float distance = 3; 

    public Running()
    {
        Date = "08 Dec 2023";
        Length = 45; 
    }

    public override float GetSpeed()
    {
        return distance * 60 / Length;
    }

    public override float GetPace()
    {
        return Length / distance;
    }

    public override float GetDistance()
    {
        return distance;
    }

    public override string GetActivity()
    {
        return "Running";
    }

}