using System;
using System.Data;
namespace Mindfulness
{

    public class Activity
    {
       protected int _duration = 15;
       protected string _description = " ";
       protected string[] _random  = ["1). The breathing actiity ","2). The reflection activity ","3). The listing activity"];
       protected string _randomPrompt = " ";
       protected string _breatheOpt = " ";
       protected string _reflect = " ";
       protected int _timePause = 15;
       protected string _endMessage = " ";

       public class Breathe: Activity
       {
           protected void Duration ()
           {
               Console.WriteLine("How many minutes would you like to spend om this activity?");
           }
           public string duration
           {
               get{return duration;}
               set{duration = value;}
           }

           protected void  Description()
           {
           
               Console.WriteLine("Welcome to the Mindfull exercise.\nThree of these activities will get you in a relaxed mood.");
           }
           public string description
           {
               get{return description;}
               set{duration = value;}
           }

           
            protected void BreatheOpt()
            {
                
                Console.WriteLine("Breathe in !!!");
                Thread.Sleep(6000);
                Console.Write("Welldone!");
            }
            public string breatheOpt
            {
                get{return _breatheOpt;}
                set{_breatheOpt =value;}

            }
            
            protected void EndMessage()
            {
                Console.WriteLine("That relaxation which you feel,\nis what I mean.");
                Thread.Sleep(6000);
                Console.Write("Weldone !");
            }

            public string endMessage
            {
                get{return duration;}
                set{duration = value;}
            }

        public class Reflection: Activity
        {
            protected void RandomOpt()
            {
                Console.WriteLine("Welcome to the reflection activity.\nThe activity will train you to reflect for a while.\nHow many seconds would you want to take on each step? ");
                string Interval1 = Console.ReadLine();
                int interval1 = Convert.ToInt32(Interval1);
                for(int e = interval1; e > 0; e--)
                {
                    
                    Console.Write(">");
                    Thread.Sleep(1000);
                
                }
                Console.WriteLine("Think of a time when you stood up for someone else.");
                Console.Write(">");
                Thread.Sleep(6000);
                Console.WriteLine("Think of a time when you did something really difficult.");
                Console.Write(">");
                Thread.Sleep(6000);
                Console.WriteLine("Think of a time when you helped someone in need.");
                Console.Write(">");
                Thread.Sleep(6000);
                Console.WriteLine("Think of a time when you did something truly selfless.");
                Console.Write(">");
                Thread.Sleep(6000);
                Console.WriteLine("Well done");
            }
                           
            public string randomOpt
            {
                get{return randomOpt;}
                set{randomOpt = value;}

            }



            public class RandomPrompt:RandomOpt
            {
                protected static void randomPrompt()
                {
                    Console.WriteLine("You are welcome to this part of the reflection activity.The random choices will,\nallows you to reflect on your ambitions .");
                    Thread.Sleep(3000);
                    Console.WriteLine("How many seconds do you want to spend on each?");
                    string Interval1 = Console.ReadLine();
                int interval1 = Convert.ToInt32(Interval1);
                for(int e = interval1; e > 0; e--)
                {
                    
                    Console.Write(">");
                    Thread.Sleep(1000);
                
                }
                Console.WriteLine("Why was this experience meaningful to you?");
                Console.Write(">");
                Thread.Sleep(6000);
                Console.WriteLine("Have you ever done anything like this before?");
                Console.Write(">");
                Thread.Sleep(6000);
                Console.WriteLine("How did you get started?");
                Console.Write(">");
                Thread.Sleep(6000);
                Console.WriteLine("How did you feel when it was complete?");
                Console.Write(">");
                Thread.Sleep(6000);
                Console.WriteLine("What made this time different than other times when you were not as successful?");
                Console.Write(">");
                Thread.Sleep(6000);
                Console.WriteLine("What is your favorite thing about this experience?");
                Console.Write(">");
                Thread.Sleep(6000);
                Console.WriteLine("What could you learn from this experience that applies to other situations?");
                Console.Write(">");
                Thread.Sleep(6000);
                Console.WriteLine("What did you learn about yourself through this experience?");
                Console.Write(">");
                Thread.Sleep(6000);


                Console.WriteLine("Weldone");

                }
        



            public string _randomPrompt
            {
                get{return _randomPrompt;}
                set{_randomPrompt=value;}
            }

    public class Listing: Activity
    {
        
    }        
        }    
       
    }


    public class RandomOpt
    {
        string _randomOpt = "";
    }
}}}
    //       protected void randomPrompt()
     //       {
     //           Console.WriteLine ("1). The breathing actiity\n ","2). The reflection activity\n ","3). The listing activity");
     //           Thread.Sleep(3000);
     //           Console.WriteLine("Choose any activity you wish by writting it's number. ");
     //           string Random = Console.ReadLine();
     //           int random = Convert.ToInt32($"{Random}");
     //       }



//       public void timePause()
//       {
//          Console.WriteLine("How many seconds do you want to take on it?");
//         string Items = Console.ReadLine();
//          int items = Convert.ToInt32(Items);
//          for (int item = items; items > 0; items--)
//            {
//                Thread.Sleep(items);

//
//                Console.Write("/");



