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
                    Console.WriteLine("Laps were: 13");
                }

                internal void lapKilometers()
                {
                    Console.WriteLine("Laps kilometers: 33");
                }

                internal void laps()
                {
                    Console.WriteLine("Laps done: 12");
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
        dues.day();
        dues.month(8);
        dues.year(2025);
        dues.hours(7);        
        dues.seconds(69);
        dues.minutes(267);

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

            private void minutes(float minutes)
            {
                Console.WriteLine("267");
            }

            private void hours(float hours)
            {
                Console.WriteLine("7");
            }

            private void year(int year)
            {
                Console.Write("2024");
            }

            private void month(int month)
            {
                Console.Write("8/");
            }

            private void day()
            {
                Console.Write("10/");
            }

            protected static void minutes1(float minutes)
            {
                int minutes1 = 267;
                Console.WriteLine("mins: "+ 267 );
            }

            protected void seconds(float seconds)
            {
                Console.WriteLine("Sec: " + 6765.76 );
            }

            protected void Hours(float hours)
            {
                Console.WriteLine("Hrs: "+ 13 );
            }

            protected void Year(int year)
            {
                Console.WriteLine("Year: "+ 2024 );
            }

            protected void Month(int month)
            {
                Console.WriteLine("Mnth:"+ 6 );
            }

            protected void Day(int day)
            {
                Console.WriteLine("Day:"+10 );
            }
            
        }
}}