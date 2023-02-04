using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(5,4);
        
        Console.WriteLine(fraction1);
        Console.WriteLine(fraction2);
        Console.WriteLine(fraction3);
    }
}