using System;
//using System.ComponentModel;
//using static Programs.Activity;
namespace Documents
{
    class Activity
    {
        public Activity SetPrompts { get; private set; }

    public static void Main(string[]args)
    {
        Activity activity = new Activity();
        

    
        activity.SetDescription(" ");
        activity.SetSeconds("5");

        activity.SetPrompts = new Activity();


        }

        public void SetEndMessage(string EndMessage)
        {
            Console.WriteLine("You will improve the more you re-do so");
        }

        public void SetSeconds(string _seconds)
        {
            Console.WriteLine("How many seconds will it take you to think response over in this activity?");
            string Seconds = Console.ReadLine();
            int seconds = Convert.ToInt32($"{Seconds}");
        }

        public void SetDescription(string _description)
        {

            Console.Write("Breathe.GetActivityInfo()");
            string description = Console.ReadLine();

//      public void SetSeconds(string _seconds)
            
            Console.WriteLine("How many seconds will it take you to think response over in this activity?");
            string Seconds = Console.ReadLine();
            int seconds = Convert.ToInt32($"{Seconds}");
            
            
            
        }

        public string GetActivityInfo()
        {
            return $"{GetActivityInfo}";
            
        }
    }
}
