using System;
namespace EternalQuest

{
    class Reward
    {
        public int _reward;
        public string _value;
    
    public void reward()
    {
        Console.WriteLine("...you've earned: ");  
    }
    public void reward(int number)
    {
        Console.WriteLine("...you've earned: "+ number);
    }

    public void value()
    {
        Console.WriteLine("Congra!!!... ");  
    }
    public void value(string imoji)
    {
        Console.WriteLine("Congra!!!..."+ imoji);
    }
}}












////using System;
//namespace EternalQuest
//{
//    public class Money
//    {
//        protected string _enoughFor;
//        protected string _every;
//    public void EnoughFor()
//    {
//        Console.WriteLine("");
//    }
//    public void EnoughFor(string enoughFor)
//    {
//        Console.WriteLine(" "+ enoughFor);
//    }
//    public void Every()
//    {
//        Console.WriteLine("");
//    }
//    public void Every(string every)
//    {
//        Console.WriteLine(" "+ every);
//    }

//    }

//    public class Never3
//    {
//        protected string _over; // spend
//        protected string _under; // charge
//    public void Over()
//    {
//        Console.WriteLine(" ");
//    }
//    public void Over(string over)
//    {
//        Console.WriteLine(""+ over);
//    }
//    public void Under()
//    {
//        Console.WriteLine(" ");

//    }
//    public void Under(string under)
//    {
//        Console.WriteLine(" " + under);
//    }

//    }  
     
//    public class Always3
//    {
//        protected string  _keptAwayFrom; // gold diggers
//        protected string  _paidTithe;
//    public void KeptAwayFrom()
//    {
        
//        Console.WriteLine("");
//    }
//    public void KeptAwayFrom(string keptAwayFrom)
//    {   
//        Console.WriteLine(" "+keptAwayFrom); 
//    }
//    public void Under()
//    {
///        Console.WriteLine(" ");

//    }
//    public void Under(string under)
//    {
//        Console.WriteLine(" " + under);
//    }
 
//    } 
//} 