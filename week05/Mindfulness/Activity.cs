using System;
//using System.ComponentModel;
//using static Programs.Activity;
namespace Documentss
{

    public class Activity
    {
        protected string _description= " ";
        protected  string _seconds = "";
        protected string _breatheInfo = "Breathe in and hold still!";
        protected string _prompts ="";
        protected string _endMessage ="";

        public string GetActivityInfo()
        {
            return $"{_description},{_prompts}";
        }


        public string GetDescription()
        {
           // Console.WriteLine("Welcome to the mindfull activities.They will be 3 only of which will relax your min.\nDo you want to continue? ");
            return _description;

        }
        public void SetDescription(string description )
        {
            _description = description;
        }

        static void GetActivity(string _descriptions,int _seconds,string _prompts,string _endMessage)
        {
            Console.WriteLine("Ok") ;


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

