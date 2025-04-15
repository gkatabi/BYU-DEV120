using System;
namespace ExerciseTracking
{
    public static class Program 
    {

    public class Dues
    {
        protected int _day ;
        protected int _month ;
        protected int _year;
        protected float _hours;
        protected float _minutes ;
        protected float _seconds ;
    
    protected class Runnings
    {
        protected float _lapMiles;
        protected float _lapKilometers;

                internal void lapMiles()
                {
                    throw new NotImplementedException();
                }

                internal void lapKilometers()
                {
                    throw new NotImplementedException();
                }

                internal void laps()
                {
                    throw new NotImplementedException();
                }
            }
    protected class Swimming
    {
        protected float _numberOfLaps;

    protected class Swimmings
    {
        protected float _numberOfLaps;
    }

    
    }
    static void Main(string[] args)
    {
        Dues dues = new Dues();
        dues.day(12);
        dues.month(8);
        dues.year(2025);
        dues.hours(7);
        dues.minutes(6);
        dues.seconds(69);

        Runnings runnings = new Runnings();
        runnings.lapMiles( );
        runnings.lapKilometers();
        runnings.laps( );
        Swimmings swimmings = new Swimmings();
        swimmings.numberOfLaps();
        Cyclings cyclings = new Cyclings();
        cyclings.miles1 ();
        cyclings.kilometers1( );
        cyclings.hours1( );
        cyclings.pace( );
        cyclings.speed();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
    }

            protected void minutes(float minutes)
            {
                throw new NotImplementedException();
            }

            protected void seconds(float seconds)
            {
                throw new NotImplementedException();
            }

            protected void hours(float hours)
            {
                throw new NotImplementedException();
            }

            protected void year(int year)
            {
                throw new NotImplementedException();
            }

            protected void month(int month)
            {
                throw new NotImplementedException();
            }

            protected void day(int day)
            {
                throw new NotImplementedException();
            }
        }
}}