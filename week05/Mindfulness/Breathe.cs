using System;
namespace Mindfulness
{
    



    public class Breathe : Activity
    {
    

        public void breatheOpt()
        {
            
            string _breatheOpt = " "; 

        }

        internal string GetBreatheOpt()
        {
            return "Breathe deep !!!";
            
        }

        internal string GetBreathOpt()
        {
            return "Breathe faster!!!";
        }

        internal string GetBreath()
        {
            return "Ok";
        }

        class Reflection: Activity
    {
        public void Reflect()
        {
            string _reflect = " ";

            
        static void Main(string[]args)
        {
            Breathe BreatheOpt = new Breathe();
            Breathe.breatheOpt();
            {
                Console.WriteLine("Breathe in !!!");
                Thread.Sleep(6000);
                Console.WriteLine("Breathe out !!!");
            }

            Breathe.breatheOpt();
            Thread.Sleep(6000);
    
        }

    }

}
    


internal class Activity
{
    internal class Breathe
    {
        internal static string breatheOpt()
        {
            string _breatheOpt = "breatheOpt ";
            return "Breathe in now !!! ";
        }
    }
}}

    public class Activity
    {
        internal string GetDescription()
        {
            string _description = "Welcome";
            return _description;
        }
    }
}