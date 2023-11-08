public abstract class Shape
{
    public string color;
     
    public Shape(string color1)
    {
        color = color1;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string color1)
    {
        color = color1;
    }

    public abstract double GetArea();
}