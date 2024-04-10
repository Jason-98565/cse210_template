using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.ToString());
        Console.WriteLine(f1.DecimalValue());

        Fraction f2 = new Fraction(3);
        Console.WriteLine(f2.ToString());
        Console.WriteLine(f2.DecimalValue());

        Fraction f3 = new Fraction(5,7);
        Console.WriteLine(f3.ToString());
        Console.WriteLine(f3.DecimalValue());

        Fraction f4 = new Fraction(3,4);
        Console.WriteLine(f4.ToString());
        Console.WriteLine(f4.DecimalValue());
    }
}