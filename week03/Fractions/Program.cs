using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fractionOne = new Fraction();
        Fraction fractionTwo = new Fraction(6);
        Fraction fractionThree = new Fraction(6, 7);

        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionThree.GetFractionString());

        fractionOne.SetTop(8);
        fractionOne.SetBottom(9);
        Console.WriteLine(fractionOne.GetTop());
        Console.WriteLine(fractionOne.GetBottom());

        Console.WriteLine(fractionOne.GetDecimalValue());
        Console.WriteLine(fractionTwo.GetDecimalValue());
        Console.WriteLine(fractionThree.GetDecimalValue());
    }
}