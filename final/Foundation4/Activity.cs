public abstract class Activity
{
    private string date; 

    public string Date
    {
        get {return date ;}
        set {date = value; }
    }

    private float length; 

    public float Length 
    {
        get {return length ;}
        set {length = value;}
    }

    public abstract float GetDistance();

    public abstract float GetSpeed();

    public abstract float GetPace();

    public abstract string GetActivity();

    public string GetSummary()
    {
    
        return($"{Date} {GetActivity()} ({Math.Round(Length,2)} min) - Distance: {Math.Round(GetDistance(), 2)} kilometers, Speed: {Math.Round(GetSpeed(),2)}km/hour, Pace: {Math.Round(GetPace(),2)} min/km.");
    
    }

    
}