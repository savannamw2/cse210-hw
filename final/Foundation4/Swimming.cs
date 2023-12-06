public class Swimming : Activity
{
    private float laps = 58; 

    public Swimming()
    {
        Date = "12 Dec 2023"; 
        Length = 65; 
    }

    public override float GetSpeed()
    {
        return GetDistance() * 60 / Length;
    }

    public override float GetPace()
    {
        return Length / GetDistance();
    }

    public override float GetDistance()
    {
        return laps * 50 / 1000;
    }

    public override string GetActivity()
    {
        return "Swimming";
    }
}