using System;
using System.IO.Compression;

namespace Learning03;

public class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int numerator)
    {
        _topNumber = numerator;
        _bottomNumber = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _topNumber = numerator;
        _bottomNumber = denominator;
    }

    public int Getnuerator()
    {
        return _topNumber;
    }

    public int getDenominator()
    {
        return _bottomNumber;
    }
    public void setNumerator(int entry)
    {
        if (entry >= 0)
        {
            _topNumber = entry;
        }
    }

    public void setDenmoninator(int entry)
    {
        if (entry >= 0)
        {
            _bottomNumber = entry;
        }
    }

    public void getStringfrac()
    {
        Console.WriteLine($"{_topNumber}/{_bottomNumber}");
    }

    public void getDecimalVaule()
    {
        double result = (double)_topNumber / _bottomNumber;
        Console.WriteLine(result);
    }
}
