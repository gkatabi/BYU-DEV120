using System;
using System.ComponentModel;
namespace Mindfulness;

    class BreathActivity
    {
//        public class BreathIn
//        {
         
// Describe proceedings of the activity data type long message;
        private string _description;
        
        
        private string _breath1 = "In";
        private string _reflect;
        public int _breathDuration;
        private string _breath2 = "Out";
        private string _endComments;

// Set up time for a deep breath in
//        public string _reflect;
    
        public BreathActivity(string reflect)
        {
            _reflect = reflect;
        }
        public  string GetReflect()
        {
        
            return _reflect;
        }
        private string _breatheOut; 


        private string _endComments;
    }



    public class Reflect: BreatheIn        
    {
        private string _description;
        public int _reflectDuration;




        private string _random;
        {
           string _random  = Random;
        }
         // Get duration from user
        
        
        
        
        
        
        private Reflect(string reflect)
        {
       
            _reflect = reflect;
        }
        public string GetReflect()
        {
            return _reflect;
        }

        public class RandomPrompt:Reflect
        {
            private string _description1;

            private int _randomPromptDuration;
            public string[] _randomPrompt = " ";
            //["Think of a time when you stood up for someone else.",
//            "Think of a time when you did something really difficult.",
//            "Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."];
            private string _response ; // fetch   response from user questioning in terms of the random prompt
        
            private string _endMessage = "You look relaxed after all thism"
        }











        // space for the descriptive message
        private string _description = " ";
        
        private randomThoughtPrompt:Reflect;
        // Should display a prompt question related to the experience 
        // Why?, What?, How?
        private static string _randomExperience; 
// The methods which show and display sould be used here because there will be need of showing   
        public int GetDuration();    

    public class ListingActivity
    {
        private string _duration;
        private string _description;
        private String _randomPrompt;
// Show styling should be used here because there will be need of displaying 
//After displaying the prompt, the program should give them a countdown of several seconds to
//  begin thinking about the prompt. Then, it should prompt them to keep listing items. 

        private string _items;
//The user lists as many items as they can until they they reach the duration specified by the user at the beginning.
//The activity them displays back the number of items that were entered.
//The activity should conclude with the standard finishing message for all activities.


    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this Mindful program where you will re discover relaxation and strength to carry on with a relaxed mind.");
    }
}