using System;
namespace ExerciseTracking
{
    class Running:Due// instead of distance
    {
        protected float _lapMiles; 
        protected float _lapKilometers;
        protected float _laps;
    
    public void Runnings()
    { 
        Console.WriteLine("They ran a distance of: ");
    }
    public void Runnings(float lapMiles, float lapKilometers)
    {
        Console.WriteLine("They ran a distance of: "); 
        Console.Write(lapMiles/lapKilometers);
        
    }

        internal void lapMiles()
        {
            Console.WriteLine("Miles in those laps were: "+ 12/7  );
        }
    }
}
