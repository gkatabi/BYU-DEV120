using System;
namespace Program;
class Fraction
{
// Attributes space....... still obliged to differenciate between them and objects
    private int top;
    private int bottom;

// The constructor without parameters
    private Fraction ()
    {
        top = 1;
        bottom = 1;
        // A constructor of a value 5 at top but denominator is  none
        top = 5;
        bottom  = 
        // A constructor with a top and a bottom
        top =4 ;
        bottom = 7;
    }
    
    static void Main(string[]args )

    {
        Fraction FractionHolder = new Fraction();
        Console.WriteLine(FractionHolder.top +"/"+ FractionHolder.bottom);//"Hello World! This is the Fractions Project.");
    }
}