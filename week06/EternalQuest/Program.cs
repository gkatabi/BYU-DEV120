using System;
namespace EternalQuest
{
    class Goals
    {
//        private static object goalType2;

//        public static object goalType1 { get; private set; }

        public class Goal
    {
        public string _description;
        protected string _goalType1;
        protected string _goalType2;

        protected string _howOften;
        protected string _rewards;
        protected string _time; 
        protected int _calculations;
        protected char _markIt;

            internal void Goals(string[] goalType1)
            {
                Console.WriteLine("These are eternal and non eternal goals: "+goalType1 );
            }

            internal static void goalType1(string v)
            {
                throw new NotImplementedException();
            }

            internal void goal(string v)
            {
                throw new NotImplementedException();
            }
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

            internal void saveMoney(string noney)
            {
                throw new NotImplementedException();
            }
        }
    static void Main(string[] args)
    {
        Goals goal  = new Goals ();
        Goal description = new Goal();
        description.goal("These are eternal and non eternal goals");
        goal.Description("These are they");
        Goal goalType = new Goal();
        goal.goalType1("");
        goal.goalType2("");
        goal.GoalType("I have");
        Goal howOften = new Goal();
        howOften.goal("");
        Goal rewards = new Goal();
        rewards.goal(" ");
        Goal time = new Goal();
        time.goal(" ");
        Goal caliculations = new Goal();
        caliculations.goal(" ");
        Goal markIt = new Goal();
        markIt.goal("");
        SaveMoney enoughFor  = new SaveMoney();
        enoughFor.saveMoney(" ");
        SaveMoney every = new SaveMoney();
        every.saveMoney("always ");
        Console.WriteLine("Ok");
        


    }

        private void goalType2(string v)
        {
            throw new NotImplementedException();
        }

        private void goalType1(string v)
        {
            throw new NotImplementedException();
        }

        private void GoalType(string description)
        {
            Console.WriteLine("All"+description);
        }

        public void Description(string msg)
        {
            Console.WriteLine("Only you ");
        }
    }
}

