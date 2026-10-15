using System;
using System.Diagnostics.Contracts;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        Fraction n1 = new Fraction();
        Fraction n2 = new Fraction(5);
        Fraction n3 = new Fraction(3,4);
        Fraction n4 = new Fraction(1/3);

        n1.getStringfrac();
        n1.getDecimalVaule();
        n2.getStringfrac();
        n2.getDecimalVaule();
        n3.getStringfrac();
        n3.getDecimalVaule();
        n4.getStringfrac();
        n4.getDecimalVaule();
    }
}