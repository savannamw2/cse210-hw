public class Circle : Shape
{
    private double radious; 

    public Circle(string color, double radious1) : base(color)
    {
        radious = radious1;
    }

    public override double GetArea()
    {
        return radious * radious * Math.PI;
    }

}