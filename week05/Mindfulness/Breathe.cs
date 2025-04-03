using System;
namespace Mindfulness
{

    class Breathe : Activity
    {

    
        protected string _breatheOpt = " ";
    
        public Breathe ()
        {

        }
    
        public string GetBreatheOpt()
        {
            return _breatheOpt;
        }

        public void SetBreatheOpt(string breatheOpt)
        {
            _breatheOpt = breatheOpt;
        }

    }

}  
