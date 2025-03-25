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
//        Console.WriteLine($"{_top1},/,{_bottom1}");
        int _top1 = 1;
        int _bottom1 = 1;
        List <int> _top = new List <int>();
        List <int> _bottom = new List <int>();
        Console.WriteLine($"{_top1}/{_bottom1}");

        int _top2 = 1;
        int _bottom2 = 1;
        List <int> _top3 = new List  <int>();
        List <int> _bottom3 = new List <int>();
        Console.WriteLine($"{_top2}");


        int _top4 = 5;
        int _bottom4 = 1;
        List <int> _top6 = new List <int>();
        List <int> _bottom6 = new List <int>();
        Console.WriteLine($"{_top4}/{_bottom4}");


        int _top5 = 5;
        int _bottom5 = 0;
        List <int> _top7 = new List <int>();
        List <int> _bottom7 = new List <int>();
        Console.WriteLine($"{_top5}");


        
        Console.Write($"{_bottom1}");
//        int _bottom2 = 0;
        Console.Write($"{_bottom2}");
//        int _bottom3 = 1;
        Console.Write($"{_bottom3}");
//        int _bottom4 = 0;
        Console.Write($"{_bottom4}");

    
    }
}
