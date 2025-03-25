using System;
namespace Documents;

    public class Fraction
    {
       private int _top ;
       private int _bottom;

       public Fraction()
       {
        // Default to 1/1
           
           int _top1  ;
    
           int _bottom ;
        }

           public Fraction(int wholeNumber)
        {
            _top = wholeNumber;
            _bottom = 1;
        }

        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        public string GetFractionString()
        {
        
            string text = $"{_top}/{_bottom}";
            return text;
        }

        public double GetDecimalValue()
        {
            
            return (double)_top / (double)_bottom;
    }
    public static void Main(string[]args)
    {
        List <int> _top = new List <int>();
        int _top1 = 1;
        Console.Write($"{_top1}");
        int _top2 = 1 ;
        Console.Write($"{_top2}");
        int _top3 = 5;
        Console.Write($"{_top3}");
        int _top4 = 5;
        Console.Write($"{_top4}");
        Console.Write($"{_top}");
        List <int> _bottom = new List <int>();
        int _bottom1 = 1;
        Console.Write($"{_bottom1}");
        int _bottom2 = 0;
        Console.Write($"{_bottom2}");
        int _bottom3 = 1;
        Console.Write($"{_bottom3}");
        int _bottom4 = 0;
        Console.Write($"{_bottom4}");

    
    }
}
