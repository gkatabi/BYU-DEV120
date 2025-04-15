using System;
using ExerciseTracking;
{
    class Running:Due// instead of distance
    {
        protected float _lapMiles; 
        protected float _lapKilometers;
        protected float _laps;
    }
    public void Running()
    { 
        Console.WriteLine("They ran a distance of: ");
    }
    public void Running(float lapMiles, float lapKilometers)
    {
        Console.WriteLine("They ran a distance of: "); 
        Console.Write(div(lapMiles/lapKilometers));
        
    }
}
