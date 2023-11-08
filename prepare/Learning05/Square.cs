public class Square : Shape
{
    private double side; 

    public Square(string color,double sides) : base(color)
    {
        side = sides;
    }

    public override double GetArea()
    {
        return side * side;
    }

}