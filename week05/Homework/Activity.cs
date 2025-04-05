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
           _duration = 15;
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
            return 15;
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
       
    }
     
}