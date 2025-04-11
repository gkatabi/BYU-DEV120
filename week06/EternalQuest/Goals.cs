using System;
namespace EternalQuest
{
    public class Goal
    {
        protected string _description;
        protected string _howOften;
        protected char _markIt;
        protected string _time; 
        protected int _calculations;
        protected string _rewards;
    
    
    public void Description()
    {
        Console.WriteLine(" ");
    }
    public void Description(string description)
    {
        Console.WriteLine(" "+ description);
    }

    public void HowOften()
    {
        Console.WriteLine(" ");
    }

    public void HowOften(string howOften)
    {
        Console.WriteLine(" "+ howOften);
    } 
    public void MarkIt()
    {
        Console.WriteLine(" ");
    }
    public void MarkIt(string markIt)
    {
        Console.WriteLine( " "+markIt);
    }

    public void Rewards()
    {
        Console.WriteLine(" ");
    }
    public void Rewards(string rewards)
    {
        Console.WriteLine(" "+ rewards);
    }

    public void Time()
    {
        Console.WriteLine(" ");
    }
    public void Time(string time)
    {
        Console.WriteLine(" "+ time);
    }


    public void Calculations()
    {
        Console.WriteLine(" ");
    }
    public void Calculations(string calculations)
    {
        Console.WriteLine(" "+ calculations);
    }

    public class IDid
    {
        protected int _repeated;
        protected int _iAvoided;
    
    public void Repeated()
    {
        Console.WriteLine(" ");
    }
    public void Repeated(string repeated)
    {
        Console.WriteLine(" "+ repeated);
    }

    public void IAvoided()
    {
        Console.WriteLine(" ");
    }
    public void IAvoided(string iAvoided)
    {
        Console.WriteLine(" "+ iAvoided);
    }

    public class Never1
    {
        protected string _theWhole;
        protected int _withInThat;

        public  void TheWhole()
        {
            Console.WriteLine(" ");
        } 
        public void TheWhole(string theWhole)
        {
            Console.WriteLine(" "+ theWhole);
        } 

        public  void WithInThat()
        {
            Console.WriteLine(" ");
        } 
        public void WithInThat(string withInThat)
        {
            Console.WriteLine(" "+ withInThat);
        } 
    public class Always1
    {
        protected string _tried;
        protected string _follow;
    }

    public void Tried()
    {
        Console.WriteLine(" ");
    }
    public void Tried(string tried)
    {
        Console.WriteLine(" "+ tried);
    }

    public void Following()
    {
        Console.WriteLine("The ");
    }
    public void Following(string following)
    {
        Console.WriteLine(" "+ following);
    }
    }
}}}