using System;
using System.Security.Cryptography.X509Certificates;
namespace Mindfulness
{
    class Activity
    {
        public Activity SetPrompts { get; private set; }

    public static void Main(string[]args)
    {
        Activity activity = new Activity();
        

    
        activity.SetDescription(" ");
        activity.SetSeconds("5");
        activity.SetBreathe(" ");
        activity.SetPrompts = new Activity();


        }

        private void SetBreathe(string breathe)
        {

        }
        public string GetBreathe(string _breatheinfo)
        {
            return _breatheinfo;
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

            Console.WriteLine("This is the Mindful exercise. We will take you through steps\nthat will get you relaxed");
            Console.WriteLine("Step\nNo.1) Breathe in  !!!!  ");
            Console.WriteLine("Step\nNo.2) Breathe Out !!!!  ");
            Console.WriteLine("How many seconds will it take you to hold your breath?");
            string Seconds = Console.ReadLine();
            int seconds = Convert.ToInt32($"{Seconds}");
            Console.WriteLine($"{seconds}");
            Thread.Sleep(1000* seconds);
            Console.WriteLine($"The {seconds}seconds are done\nPlease breathe in & hold your breath\nfor another{seconds} seconds");
            for (int i = seconds; i>0; i-- )
            {
                Console.Write($"{i}");
                Console.WriteLine("Breathe Out !!!");
                Thread.Sleep(4*1000);
                Console.WriteLine("breathe in !!");
            }
        }
        public string GetActivityInfo()
        {
            return $"{GetActivityInfo}";
            
        }
    }
}
