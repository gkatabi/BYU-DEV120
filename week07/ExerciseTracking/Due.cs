using System;
namespace ExerciseTracking
{
    public class Due
    {
        protected int _day = 4;
        protected int  _month = 7;
        protected int year = 2025;
        protected float _hours=3;
        protected float _minutes = 180;
        protected float _seconds = 797678;
        
    

    public void Date()
    {
        Console.WriteLine("On: ");
    }
    public void Day(int day,int month,int year)
    {
        Console.Write($"On {day}/  {month}/ {year}");
    }
    public void  Time () 
    {
    
        Console.Write("Time was: ");
    }
    public void Time (int hours, int minutes, int seconds)
    {
        Console.WriteLine($"Time was:{hours}:{minutes}:{seconds} ");
    }
}}    

