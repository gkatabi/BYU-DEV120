using System;
namespace ExerciseTracking
{
    class Cyclings:Due
    {
        protected float _miles1;
        protected float _hours1;
        protected float _kilometers1;
        protected float _pace;
        protected float _speed;

    // method1
    protected void Miles1()
    {
        Console.WriteLine("Miles: ");
    }
    protected void Miles1(float miles1)
    {
        Console.WriteLine("Miles:"+ miles1);
    }
    
    protected void Kilometers1()
    {
        Console.WriteLine("Kilometers: " );
    }
    protected void Kilometers1(float kilometers1)
    {
        Console.WriteLine($"Kilometers:{kilometers1}");
    }

    protected void Hours1()
    {
        Console.WriteLine("Hours: ");
    }
    protected void Hours1 (float hours1)
    {
        Console.WriteLine($"Hours: {hours1}");
    }

    protected void Pace1()
    {
        Console.WriteLine("At a pace of: ");
    }
    
    protected void Pace1(float pace1)
    {
        Console.WriteLine($"At a Pace of: {pace1}");
    }
    
    protected void Speed()
    {
        Console.WriteLine("Speed: ");
    }
    protected void Speed(float speed)
    {
        Console.WriteLine("Speed: "+ speed);
    }

        internal void miles1()
        {
            
            Console.WriteLine("Cycled Miles: 12");
        }

        internal void kilometers1()
        {
            Console.WriteLine("Kilometers in that were: 24");
        }

        internal void hours1()
        {
            Console.WriteLine("With in only hours: 7");
        }

        internal void speed()
        {
            Console.WriteLine("At a speed of km/hr: "+ 24/7);
        }

        internal void pace()
        {
            Console.WriteLine("At a constgant pace of: "+  10/5);
        }
    }
}