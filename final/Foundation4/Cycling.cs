public class Cycling : Activity 
{ 
    private float speed = 15; 

    public Cycling()
    {
        Date = "02 Dec 2023";
        Length = 20; 
    }

    public override float GetDistance()
    {
        return speed * Length / 60;
    }

    public override float GetPace()
    {
        return Length / GetDistance();
    }

    public override float GetSpeed()
    {
        return speed;
    }

    public override string GetActivity()
    {
        return "Cycling";
    }
}