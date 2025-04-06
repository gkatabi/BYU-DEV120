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
           
           Console.WriteLine("Welcome to the Mindfull exercise.\nThree of these prompts will get you in a relaxed mood.");
       }
       public string description
       {
           get{return description;}
           set{duration = value;}
       }


       protected void Random()
       {
           Console.WriteLine("1). The breathing actiity\n ","2). The reflection activity\n ","3). The listing activity");
       }
       public string random
       {
           get{return random;}
           set{random = value;}
       }

       protected void EndMessage()
       {
           Console.WriteLine("That relaxation which you feel,\nis what I mean.");
           timePause();
           Thread.Sleep(6000);
           Console.Write("/");
       }

       public string endMessage
       {
           get{return duration;}
           set{duration = value;}
       }

       
       protected void randomPrompt()
       {
           Console.WriteLine ("1). The breathing actiity\n ","2). The reflection activity\n ","3). The listing activity");
           Thread.Sleep(3000);
           Console.WriteLine("Choose any activity you wish by writting it's number. ");
           string Random = Console.ReadLine();
           int random = Convert.ToInt32($"{Random}");
        

       }

       protected void breatheOpt()
       {
           Console.WriteLine("Welcome to the breathing activity");
           Console.WriteLine("Breathe in !!!");
           Thread.Sleep(6000);
           Console.WriteLine("Breathe out !!!");
       }

       public void timePause()
       {
          Console.WriteLine("How many seconds do you want to take on it?");
          string Items = Console.ReadLine();
          int items = Convert.ToInt32(Items);
          for (int item = items; items > 0; items--)
            {
                Thread.Sleep(items);
                Console.Write("/");
            }
        }
    

    }

}
       
    