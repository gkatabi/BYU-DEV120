using System;
namespace Mindfulness
{
    



    public class Breathe : Activity
    {
    

        public void breatheOpt()
        {
            string _breatheOpt = " ";

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
        internal static void breatheOpt()
        {
            throw new NotImplementedException();
        }
    }
}}

    public class Activity
    {
    }}