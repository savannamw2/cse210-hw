public class Rectangle: Shape
{
    private double side;
    private double side2; 

    public Rectangle(string color, double side1, double sides2) : base(color)
    {
        color = "Blue";
        side = side1;
        side2 = sides2; 
    }

    public override double GetArea()
    {
        return side * side2;
    }

}