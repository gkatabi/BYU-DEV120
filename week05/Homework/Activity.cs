using System;
namespace Mindfulness;

    public class Activity
    {
       protected int _duration;
       protected string _description = "";
       protected int _timePause;
       protected string _endMessage = "";

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
       }}

       
