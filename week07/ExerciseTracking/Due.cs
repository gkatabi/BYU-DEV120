using System;
using ExerciseTracking;
{
    protected class Due
    {
        protected int _day;
        protected int  _month;
        protected int  _year;
        protected float _hours;
        protected float _minutes ;
        protected float _seconds ;
        
    }

    public void Date()
    {
        Console.WriteLine("On: ")
    }
    public void Day(int day,int month,int year)
    {
        Clnsole.Write($"On {day}/  {month}/ {year}");
    }
    public void  Time () 
    {
    
        Console.Write("Time was: ");
    }
    public void Time (int hours, int minutes, int seconds)
    {
        Console.WriteLine($"Time was:{hours}:{minutes}:{seconds} ")
    }
}    

