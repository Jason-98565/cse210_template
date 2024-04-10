using System;

public class Fraction
{
    private float _numerator;
    private float _denominator;
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(float number)
    {
        _numerator = number;
        _denominator = 1;
    }
    public Fraction(float number,float num2)
    {
        _numerator = number;
        _denominator = num2;
    }
    override
    public string ToString()
    {
        string f = ($"{_numerator}/{_denominator}");
        return f;
    }
    public double DecimalValue()
    {
        return (double)_numerator/(double)_denominator;
    }
}