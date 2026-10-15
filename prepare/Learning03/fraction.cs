using System;

namespace Learning03;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public void fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public void fraction(int numerator)
    {
        _topNumber = numerator;
        _bottomNumber = 1;
    }

    public void fraction(int numerator, int denominator)
    {
        _topNumber = numerator;
        _bottomNumber = denominator;
    }
}
