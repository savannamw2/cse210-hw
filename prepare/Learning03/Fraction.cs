using System;

public class Fraction
{
    private int top; 
    private int bottom; 

    public Fraction()
    {
        top = 1; 
        bottom = 1;  
    }

    public Fraction(int numerator)
    {
        top = numerator; 
        bottom = 1; 
    }

    public Fraction(int numerator, int denominator)
    {
        top = numerator; 
        bottom = denominator; 
    }

    public int  GetTopNumber()
    {
        return top;
    }

    public void SetTopNumber(int topNumber)
    {
        top = topNumber; 
    }

    public int GetBottomNumber()
    {
        return bottom;
    }

    public void SetBottomNumber(int BottomNumber)
    {
        bottom = BottomNumber;
    }

    public string GetFractionString()
    {
        string result = $"{top}/{bottom}";
        return result;
    }

    public double GetDecimalValue()
    {
        return (double)top / (double)bottom;
    }
}
