using System;
using System.ComponentModel;
namespace Activities;

    class Activity
    {
        private string _description;
        public int _duration;
        private string _breath ="In";
        public string _endMessage;
    public class breathOut:Activity
    {
        private string _breath1 = "Out";
    }

    public class Reflection:Activity
    {
        private string description1;
        public int _duration1;
        private string _randomPrompt;
        private string _reflect;
        public string  _endMessage1;

    }

    public class Listing:Activity
    {
        private string _description2;
        private int _duration2;
        private string _radomPrompt2;
        public string _items;
        public int _itemsCount;
        public int _count;
    }
    static void Main (string[]args)

    {
        Activity breath = new Activity();
        Activity reflection = new Activity();
        Activity Listing = new Activity();

        Console.WriteLine("You've accomplished the activities");
    }    
        
}
