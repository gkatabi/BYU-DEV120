using System;
namespace Mindfulness;

    public class Breathing
    {
        private int _breatheDuration;
        
        private string _breathIn;
        private int _timer;
        private string _breatheOut;
        public int GetDuration()
        {
            Console.WriteLine("How many seconds in numeral do you wish to take thinking of your response");
            string seconds = Console.ReadLine();
            int Seconds = Convert.ToInt32($"{seconds}");
            return  Seconds;
        }

        
    } 
    public class Reflect
    {
        private int _reflectDuration; // Get duration from user
        private string _description;
        private static string _randomThoughtPrompt;
        // Should display a prompt question related to the experience 
        // Why?, What?, How?
        private static string _randomExperience; 
// The methods which show and display sould be used here because there will be need of showing   
        public int GetDuration()
        {
            return Seconds;
        }     

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
        Console.WriteLine("Welcome to the Mindful program where you will re discover relaxation and strength to carry on with a relaxed mind.");
    }
}