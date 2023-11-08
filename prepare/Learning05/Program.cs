using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Yellow", 4);
        shapes.Add(s1);
        Rectangle r1 = new Rectangle("Teal", 4, 2);
        shapes.Add(r1);
        Circle c1 = new Circle("Pink", 2);
        shapes.Add(c1);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }


    }
}