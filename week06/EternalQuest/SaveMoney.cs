using System;
namespace EternalQuest
{
    public class Money
    {
        protected string _enoughFor;
        protected string _every;
    public void EnoughFor()
    {
        Console.WriteLine("");
    }
    public void EnoughFor(string enoughFor)
    {
        Console.WriteLine(" "+ enoughFor);
    }
    public void Every()
    {
        Console.WriteLine("");
    }
    public void Every(string every)
    {
        Console.WriteLine(" "+ every);
    }

    }

    public class Never3
    {
        protected string _over; // spend
        protected string _under; // charge
    public void Over()
    {
        Console.WriteLine(" ");
    }
    public void Over(string over)
    {
        Console.WriteLine(""+ over);
    }
    public void Under()
    {
        Console.WriteLine(" ");

    }
    public void Under(string under)
    {
        Console.WriteLine(" " + under);
    }

    }  
     
    public class Always3
    {
        protected string  _keptAwayFrom; // gold diggers
        protected string  _paidTithe;
    public void KeptAwayFrom()
    {
        
        Console.WriteLine("");
    }
    public void KeptAwayFrom(string keptAwayFrom)
    {   
        Console.WriteLine(" "+keptAwayFrom); 
    }
    public void Under()
    {
        Console.WriteLine(" ");

    }
    public void Under(string under)
    {
        Console.WriteLine(" " + under);
    }
 
    } 
} 