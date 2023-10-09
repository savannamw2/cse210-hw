using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5); 
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction();
        fraction4.SetTopNumber(1);
        Console.WriteLine(fraction4.GetTopNumber());

        Fraction fraction5 = new Fraction();
        fraction5.SetBottomNumber(6);
        Console.WriteLine(fraction5.GetBottomNumber());

    }
}