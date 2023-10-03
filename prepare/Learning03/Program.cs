using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine();

        Fraction primerConstructor = new Fraction();
        Console.WriteLine(primerConstructor.GetFractionString());
        Console.WriteLine(primerConstructor.GetDecimalValue());
        Console.WriteLine();

        Fraction segundoConstructor = new Fraction(1);
        Console.WriteLine(segundoConstructor.GetFractionString());
        Console.WriteLine(segundoConstructor.GetDecimalValue());
        Console.WriteLine();

        Fraction tercerConstructor = new Fraction(3, 4);
        Console.WriteLine(tercerConstructor.GetFractionString());
        Console.WriteLine(tercerConstructor.GetDecimalValue());
        Console.WriteLine();

    }
}