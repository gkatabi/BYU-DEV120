using System;
namespace EternalGoals

{
    public class Readings
    {
        public string _readingScriptureOne;
        public string _readingScriptureTwo;
    public void ReadingOne()
    {
        Console.WriteLine("The book of Mormon ");
    }
    public void ReadingOne(string readingOne)
    {
        Console.WriteLine("Reading"+ readingOne);
    }

    public void ReadingTwo()
    {
        Console.WriteLine("The holly Bible ");
    }
    public void ReadingTwo(string ReadingTwo)
    {
        Console.WriteLine("Reading"+ ReadingTwo);
    }


}}














//using System;
//using System.Diagnostics.CodeAnalysis;
//namespace EternalQuest
//{
//    public class Goal
//    {
//        protected string _description;
//        protected string _goalType1;
//        protected string _goalType2;
//        protected string _howOften;
//        protected string _time; 
//        protected int _rewards;
//        private readonly object M = 0;

//        public void Description()
//    {
//        Console.WriteLine("Since eternal goals are never ending and motal ones are acheivable,\nthis one  ");
//    }
//    public void Description(string description)
//    {
//        Console.WriteLine("Since eternal goals are never ending and motal ones are acheivable,\nthis one I have done it for:  "+ description);
//    }

//    public void GoalTYpe1()
//    {
//        Console.WriteLine(" ever ");
//    }
//    public void GoalType1(string eternalGoals)
//    {
//        Console.WriteLine("I have will do it for: "+ eternalGoals);
//    }

//    public void GoalTYpe2()
//    {
//        Console.WriteLine("all those past months ");
//    }
//    public void GoalType2(string goalType2)
//    {
//        Console.WriteLine("all those past months  "+ goalType2);
//    }

//    public void HowOften()
//    {
//        Console.WriteLine("How many times have you seen me do that?");
//        string Many = Console.ReadLine();
//        int many = Convert.ToInt32(Many);
//        if (many > 1 )
//        {
//            Console.WriteLine(many + "times 🗸");
//        }
//        else if (many <=1)
//        {
//            Console.WriteLine($"Only{many}time");
//        } 
//    }

//    public void HowOften(string howOften)
//    {
//        Console.WriteLine("It has been done for: "+ howOften);
//    } 
    

//    public void Rewards()
//    {
        
//        Console.WriteLine("100");
//    }
//    public void Rewards(int rewards)
//    {
//        Console.WriteLine($"{M} "+ rewards);
//    }

//    public void Time()
//    {
//        Console.WriteLine("days ");
//    }
//    public void Time(string time)
//    {
//        Console.WriteLine("three "+ time);
//    }


//    public class IDid
//    {
//        protected int _repeated;
//        protected int _iAvoided;
    
//    public void Repeated()
//    {
//        Console.WriteLine(" ");
//    }
 //   public void Repeated(string repeated)
///    {
//        Console.WriteLine(" "+ repeated);
//    }

//    public void IAvoided()
//    {
//        Console.WriteLine(" ");
//    }
//    public void IAvoided(string iAvoided)
//    {
//        Console.WriteLine(" "+ iAvoided);
//    }

//    public class Never1
//    {
  //
//      protected string _theWhole;
//        protected int _withInThat;
//
//        public  void TheWhole()
//        {
//            Console.WriteLine(" ");
 //       } 
//        public void TheWhole(string theWhole)
//        {
//            Console.WriteLine(" "+ theWhole);
//        } 

//        public  void WithInThat()
//        {
//            Console.WriteLine(" ");
//        } 
//        public void WithInThat(string withInThat)
//        {
//            Console.WriteLine(" "+ withInThat);
//        } 
//    public class Always1
//    {
//        protected string _tried;
//        protected string _follow;
//    }

//    public void Tried()
//    {
//        Console.WriteLine(" ");
//    }
//    public void Tried(string tried)
//    {
//        Console.WriteLine(" "+ tried);
//    }

//    public void Following()
//    {
//        Console.WriteLine("The ");
//    }
//    public void Following(string following)
//    {
//        Console.WriteLine(" "+ following);
//    }
//    }
//}}}