using System;
namespace Mindfulness
{
    



    class Breathe : Activity
    {

    
        protected string[] _breatheOpt = [" Breathe in !!!","Breathe out"];
        public Breathe ()
        {


        }
    
        public string[] GetBreatheOpt()
        {
            string _breatheopt;

            return _breatheOpt;
        }
        public static void SetBreatheOpt(string breatheOpt1, string breatheOpt2)
        {
            string _breatheOpt1 = "Breathe in !!!";
            Thread.Sleep(6000);
            string _breatheOpt2 ="breathe out !!!";
            
        }

    
    }
  
}


internal class Activity
{
    internal class Breathe
    {
    }
}