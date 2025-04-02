using System;
//using System.ComponentModel;
//using static Programs.Activity;
namespace Programs
{

    public class Activity
    {
        private string _description= "Well  come to the mindfull activity";
        private string _seconds = "";
        private string _prompts ="";
        private string _endMessage ="";
        public string GetDescription()
        {
            return _description;

        }
        public void SetDescription(string description )
        {
            _description = description;
        }

//      value for time delays chosen
        public string GetSeconds()
        {
            return _seconds;

        }
        public void SetSeconds(string seconds)
        {
        _seconds = seconds;
        }

// Get and set prompts

        public string GetPrompts()
        {
            return _prompts;

        }
        public void SetPrompts(string prompts)
        {
        _prompts = prompts;
        }

//   Set up eneMessages

        public string GetEndMessage()
        {
            return _endMessage;

        }
        public void SetEndMessage(string endMessage)
        {
        _endMessage = endMessage;
        }
    }
}

//        public string _activityDescription;
//        protected int _activityDuration = 3000 ;
//        private string _activityBreath;
//        private string _activityEndMessage;
  
//        private string description;
//        private string breathe;

//        public Activity(string breathe)
//        {
//            this.breathe = breathe;
//        }

    //    private int duration;


//    public class Breath:Activity
//    {
//        protected string _breathe;
//        public void BreathOut(string breathe)
//        {
//        }
//        public Breath(string breathe) : base(breathe)
//        {
//            _breathe  = breathe;
//        }

//        public  string Breathe()
//        {
        
//            return _breathe;
//        }

//        public string Get_description()
//        {
//        _activityDescription = description;
//        return _activityDescription;

//    }
//    public void Set_activityDescription(string description )
  
//    {
//        _activityDescription = description;
//    }
//    public  void  GetActivityEndMessage()
//    {
//        _activityEndMessage = "OK";
//        Console.WriteLine("Tell me so");

//    }

//        internal static string GetBreath()
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class Reflection:Activity
//    {
//        public string GetRandomPrompt;
        
//        public Reflection(string breathe = "breathe In",string randomPrompt="Think of a time when you stood up for someone else.") : base(breathe= "breathe in")
//        { 
//            string _randomPrompt  = randomPrompt;
//            Console.WriteLine($"{_randomPrompt}");

//        }


//    public class Listing : Activity
//    {
//        public Listing(string breathe = "Breathe out!", string items = "",int itemsCount=5)   : base(breathe = "Breathe out!")
//        {
//            Console.WriteLine("List your items for me please");
//        }
//        }
//    }
//}