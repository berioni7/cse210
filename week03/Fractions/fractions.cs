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

    public int GetTop()
    {
        return top;
    }
    public void SetTop(int value)
    {
        top = value;
    }

    public int GetBottom()
    {
        return bottom;
    }
    public void SetBottom(int value)
    {
        bottom = value;
    }
    public string GetFractionString()
    {
        return $"{top}/{bottom}";
    }
    public double GetDecimalValue()
    {
        return (double)top / bottom;
    }
}
