using System;
namespace ExerciseTracking
{
    public class Swimmings:Due
    {
        protected float _numberOfLaps;
    

    protected void NumberOfLaps()
    {
        for(int e = 10; e > 0; e--)
        {
            Console.Write("/");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Laps ran were: ");
        for(int e = 10; e > 0; e--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
    protected void NumberOfLaps(float numberOfLaps)
    {
        Console.WriteLine($"Laps ran were: {numberOfLaps} ");
        for(int e = 10; e > 0; e--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

        internal void mumberOfLaps()
        {
            Console.WriteLine("Here the laps were: ");
        }

        internal void numberOfLaps()
        {
            Console.WriteLine("25");
        }
    }
}