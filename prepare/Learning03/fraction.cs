using System.Diagnostics;

public class Fraction
{
    private int _numerator;
    private int _denominator;


    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public string GetTop()
    {
        return $"{_numerator}";
    }
    public void SetTopNumber (int top)
    {
        _numerator = top;
    }
    public string GetBottom()
    {
        return $"{_denominator}";
    }
    public void SetBottomNumber(int bottom)
    {
        _denominator = bottom;
    }
    public string GetFraction()
    {
        return $"{_numerator}/{_denominator}";
    }
    public double GetDecimal()
    {
        return (double)_numerator / _denominator;
    }
}