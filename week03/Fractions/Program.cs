using System;
using System.Xml;
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
        int _top1 = 1;
        int _bottom1 = 1;
        List <int> _top = new List <int>();
        List <int> _bottom = new List <int>();
        Console.WriteLine($"{_top1}/{_bottom1}");

        int _topd = 1 ;
        int _bottomd = 1;
        List <double> _topx = new List <double>();
        List <double> _bottomx = new List <double>();
        double div = _topd/_bottomd;

        Console.WriteLine ($"{ div}");



        int _top4 = 5;
        int _bottom4 = 1;
        List <int> _top6 = new List <int>();
        List <int> _bottom6 = new List <int>();
        Console.WriteLine($"{_top4}/{_bottom4}");

        int _topl = 5 ;
        int _bottoml = 1;
        List <double> GetDecimalValuel = new List <double>();
        
        double div1 = _topl/_bottoml;

        Console.WriteLine($"{ div1}");



        int _top8 = 3;
        int _bottom8 = 4;
        List <int> _topj = new List <int>();
        List <int> _bottomj = new List <int>();
        Console.WriteLine($"{_top8}/{_bottom8}");

        int _topw = 3 ;
        int _bottomw = 4;
        List <double> GetDecimalValuew = new List <double>();
        
        double div3 = _topw/_bottomw;

        Console.WriteLine($"{ div3}");



        int _top9 = 1;
        int _bottom9 = 3;
        List <int> _topt = new List <int>();
        List <int> _bottomt = new List <int>();
        Console.WriteLine($"{_top9}/{_bottom9}");

        int _topy = 1;
        int _bottomy = 3;
        List <double> GetDecimalValuey = new List <double>();
        
        double div6 = _topy/_bottomy;

        Console.WriteLine($"{div6}");       


    
    }
}
