using System;
namespace EternalQuest
{
    public class Wash: Goal
    {
        protected string _betterThan;
        protected string _toImpress;
    public void BetterThan()
    {
        Console.WriteLine(" ");
    }
    public void BetterThan(string betterThan)
    {
        Console.WriteLine(" " + betterThan);
    }

    public void ToImpress()
    {
        Console.WriteLine(" ");
    }
    public void ToImpress(string toImpress)
    {
        Console.WriteLine(" " + toImpress);
    }


    }
    public class Never2: Goal
    {
        protected string _waitUntill;
        protected string _sniffUnderMy;
    public void WaitUntill()
    {
        Console.WriteLine(" ");
    }
    public void WaitUntill(string waitUntill)
    {
        Console.WriteLine(" " + waitUntill);
    }

    public void SniffUnderMy()
    {
        Console.WriteLine(" ");
    }
    public void SniffUnderMy(string sniffUnderMy)
    {
        Console.WriteLine(" " + sniffUnderMy);
    }
    

    
    public void ToImpress(string sniffUnderMy)
    {
        Console.WriteLine(" " + sniffUnderMy);
    }

    public class Always2: Goal
    {
        protected int _howManyTimesADay;
        protected string _alwaysBe;
    }

    public void HowManyTimesADay()
    {
        Console.WriteLine(" ");
    }
    public void HowManyTimesADay(string howManyTimesADay)
    {
        Console.WriteLine(" " + howManyTimesADay);
    }

    public void AlwaysBe()
    {
        Console.WriteLine(" ");
    }
    public void AlwaysBe(string alwaysBe)
    {
        Console.WriteLine(" " + alwaysBe);
    }

}}