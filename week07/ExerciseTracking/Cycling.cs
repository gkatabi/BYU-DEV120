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
            throw new NotImplementedException();
        }

        internal void kilometers1()
        {
            throw new NotImplementedException();
        }

        internal void hours1()
        {
            throw new NotImplementedException();
        }

        internal void speed()
        {
            throw new NotImplementedException();
        }

        internal void pace()
        {
            throw new NotImplementedException();
        }
    }
}