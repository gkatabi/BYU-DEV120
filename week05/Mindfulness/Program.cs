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
        

    
        activity.SetDescription("breathe in !");
        activity.SetSeconds("5");

        activity.SetPrompts = new Activity();
//        activity.SetEndMessage();
//        {
//        ListingActivity = new ();
//        activityListing.SetListedItems();
//        activityListing.SetTotalItems();

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
            Console.Write("Welcome to the mindfull activities.They will be 3 only of which will relax your min.\nDo you want to continue? ");
            string description = Console.ReadLine();
            
            
            
        }

        public string GetActivityInfo()
        {
            return $"{GetActivityInfo}";
            Console.WriteLine("You are in");
        }
    }
}

//        private string _description;
//        public int _duration;
//        private string _breathe;
//        public string _endMessage;
//    public class breatheOut:Activity
//    {
//        private string _breath1 ;
//    }

//    public class Reflection:Activity
//    {
//        private string description1;
//        public int _duration1;
//        private string _randomPrompt;
//        private string _reflect;
//        public string  _endMessage1;

//    }

//    public class Listing:Activity
//    {
//        private string _description2;
//        private int _duration2;
//        private string _radomPrompt2;
//        public string _items;
//        public int _itemsCount;
//        public int _count;
//    }
//    static void Main (string[]args)

//    {
//        Activity activity = new Activity();
//        Breathe breathe = new Breathe();

//        Reflection reflection = new Reflection();
//        Listing listing = new Listing();

//        Console.WriteLine("You've accomplished the activities");
//    }    
        
//}

//internal class Breathe
//{
//    public Breathe()
//    {
//    }
