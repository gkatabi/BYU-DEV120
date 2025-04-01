using System;
using System.ComponentModel;
namespace Activity;

    class Breathing
    {
        private string _description;
        public int _duration;
        private string _breath ="In";
        public string _endMessage;
    public class breathOut:Breathing
    {
        private string _breath1 = "Out";
    }

    public class Reflection:Breathing
    {
        private string _description1;
        public int _duration1;
        private string _randomPrompt;
        private string _reflect;
        public string  _endMessage1;

    }

    public class Listing:Breathing
    {
        private string _description2;
        private int _duration2;
        private string _radomPrompt2;
        public string _items;
        public int _itemsCount;
        public int _count;
    }
    public void Main (string[] args)
    {
        Console.WriteLine("You've accomplished the activities");
    }    
        
}
