using System;
namespace Program;
class Fraction
{
// Attributes space....... still obliged to differenciate between them and objects
    private int top;
    private int bottom;

    private Fraction ()
    {
        top = 2;
        bottom = 4;
    }

    static void Main(string[]args )

    {
        Fraction FractionHolder = new Fraction();
        Console.WriteLine(FractionHolder.top +"/"+ FractionHolder.bottom);//"Hello World! This is the Fractions Project.");
    }
}