using System;
using System.Data;
namespace Mindfulness
{

    public class Activity
    {
       protected int _duration = 15;
       protected string _description = "Welcome to the Mindfull exercise.\nThree of these prompts will get you in a relaxed mood.";
       protected int _timePause = 15;
       protected string _endMessage = "That relaxation which you feel,\nis what I mean.";

       public Activity()
       {

       }
       public int  GetDuration()
       {
            return _duration;
       }
       public void SetDuration(int duration)
       {
           _duration = duration;
       }

       public string  GetDescription()
       {
            return _description;
       }
       public void SetDescription(string description)
       {
           _description = description;
       }

       public int  GetTimePause()
       {
            return _timePause;
       }
       public void SetTimePause(int timePause)
       {
           _timePause = timePause;
       }

       public string  GetEndMessage()
       {
            return _endMessage;
       }
       public void SetEndMessage(string endMessage)
       {
           _endMessage = endMessage;
       }
       public class Breathe
       {
            protected string _breatheOpt = "Breathe in !!! ";
            private object _breatheOpt1;
            private object breatheOpt1;

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
            internal class BreatheOpt1
            {
                protected string _breatheOpt1 = "breathe in";

            }
            public string GetBreatheOpt1()
            {
                return _breatheOpt;
            }

            public void SetBreatheOpt1(string breatheOpt)
            {
                _breatheOpt1 = breatheOpt1;
            }
        }
    }
     
}