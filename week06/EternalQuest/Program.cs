using System;
namespace EternalQuest
{
    class Goals
    {
        private string description;

        public class Goal
    {
        public string _description;
        protected string _goalType;
        protected string _howOften;
        protected string _rewards;
        protected string _time; 
        protected int _calculations;
        protected char _markIt;
    }
    public class Wash
    {
        protected string _betterThan;
        protected string _toImpress;

    }

    public class SaveMoney
    {
        protected string _enoughFor;
        protected string _every;

    }
    static void Main(string[] args)
    {
        Goals goal  = new Goals ();
        goal.Description("These are they");
        goal.GoalType("I have");
        Money saveMoney  = new Money();
        Console.WriteLine("Ok");
    }

        private void GoalType(string drscription)
        {
            Console.WriteLine("All"+description);
        }

        public void Description(string msg)
        {
            Console.WriteLine("Only you ");
        }
    }
}

