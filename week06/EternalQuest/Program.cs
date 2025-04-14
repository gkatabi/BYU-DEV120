using System;
namespace EternalQuest
{
    class Reading
    {

    public class Readings
    {
        public string _readingOne ;
        public string _readingTwo ;
            private static object reward;

            class Rewards
    {
        public string _value;
        public int _reward;
    }

    public class Emoji
    {
        public const string Heavy_Check_Mark = "✔";

                internal void emoji(string heavy_Check_Mark )
                {
                    Console.WriteLine("✔");
                }
            }      
//        }
    
        static void Main(string[] args)
        {
            
            Readings reading = new Readings();
            reading.ReadingOne("Book of mormon");
            reading.ReadingTwo("The bible"); 

            Reward number = new Reward();
            number.reward(100);
            Reward reward = new Reward();
            reward.value("🗸 ");
            Emoji emoji = new Emoji();
            emoji.emoji("🗸 ");            
        }

            public void ReadingOne(string readingOne)
            {
                Console.WriteLine("How many chapters were read in the book of mormon? ");
                string HowMany = Console.ReadLine();
                int howMany = Convert.ToInt32(HowMany);
                if(howMany>2)
                {
                    Console.WriteLine("Read the "+readingOne+ howMany+"times 🗸");
                    for(int e = howMany; e > 0; e--)
                    {
                    
                        Console.Write(">");
                        Thread.Sleep(1000);
                }   
                Console.WriteLine($"{howMany} is ok");
                }    
                else 
                {
                    Console.WriteLine("Read the "+readingOne+ howMany);
                }   
            }

            private void ReadingTwo(string readingTwo)
            {
                Console.Write("And how many chapters did you read from the bible?: ");
                
                string HowMani = Console.ReadLine();
                int howMani = Convert.ToInt32(HowMani);

                for(int x = howMani; x > 0; x--)
                    {
                    
                        Console.Write(">");
                        Thread.Sleep(1000);
                    
                }   
                Console.WriteLine($"{howMani} is great");
                
                Console.WriteLine("Read the " + readingTwo + howMani);
                }  
//                Console.WriteLine("Then the bible: " + howMani);    
//            }

            private void topic(char value)
            {
                
            }

            private void assignment(string reward)
            {
               
            }
        }
    }
}









//using System;
//namespace EternalQuest
//{
//    class Goals
//    {
        

        //    public static object M { get; private set; }

        //        private static object goalType2;

        //        public static object goalType1 { get; private set; }

//        public class Goal
//    {
//        public string _description;
//        protected string _goalType1;
//        protected string _goalType2;

//        protected string _howOften;
//        protected int _rewards;
//        protected string _time; 
        

//            internal string Goals(string goalType1)
//            {
//                return(goalType1 );
//            }

//            internal static string goalType1(string goalType2)
//            {
//                return(goalType2);
//            }

//            internal void goal(string goal)
//            {
//                Console.WriteLine("These are eternal and non eternal goals");
//            }
//        }
//    public class Wash
//    {
//        protected string _betterThan;
//        protected string _toImpress;

//    }

//    public class SaveMoney
//    {
//        protected string _enoughFor;
//        protected string _every;

//            internal object saveMoney(string saveMoney)
//            {
//                return(saveMoney);
//            }
//        }
//    static void Main(string[] args)
//    {
//        Goals goal  = new Goals ();
//        Description description = new Goal();
//        description.goal("These are eternal and non eternal goals");
//        goal.Description("The Eternal goals are never accomplished & motal ones do");
//        Goal goalType = new Goal();
//        goal.goalType1("Eternal type of every year");
//        goal.goalType2("all those past months");

//        Goal howOften = new Goal();
//        howOften.goal("Once");
//        Goal rewards = new Goal();
//            object M = +100;
//            rewards.goal (0+$"{M}");
//        Goal time = new Goal();
//        time.goal(" ");
//        SaveMoney enoughFor  = new SaveMoney();
//        enoughFor.saveMoney(" ");
//        SaveMoney every = new SaveMoney();
//        every.saveMoney("always ");
//        Console.WriteLine("Ok");
        


//    }

//        public string goalType2(string goalType2)
//        {
//            return("all those past months");
//        }

//        private void goalType1(string goalType1)
//        {
//            Console.WriteLine(" ever ");
//        }

//        private void GoalType(string description)
//        {
//            Console.WriteLine("All"+description);
//        }

//        public void Description(string msg)
//        {
//            Console.WriteLine("Only you ");
//        }
//    }
//}

