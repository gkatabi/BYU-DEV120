using System;
namespace ExerciseTracking
{
    public class Swimmings:Due
    {
        protected float _numberOfLaps;
    

    protected void NumberOfLaps()
    {
        Console.WriteLine("Laps ran were: ");
    }
    protected void NumberOfLaps(float numberOfLaps)
    {
        Console.WriteLine($"Laps ran were: {numberOfLaps} ");
    }

        internal void mumberOfLaps()
        {
            throw new NotImplementedException();
        }

        internal void numberOfLaps()
        {
            throw new NotImplementedException();
        }
    }
}