using System;
using System.Data;
namespace Mindfulness
{

    public class Activity
    {
       protected int _duration = 15;
       protected string _description = " ";
       protected string _breatheOpt = " ";
       protected string _reflect = " ";
       protected int _timePause = 15;
       protected string _endMessage = "That relaxation which you feel,\nis what I mean.";

       protected void duration ()
       {
           Console.WriteLine("How many minutes would you like to spend om this activity?");
       }

       protected void  description()
       {
           
           Console.WriteLine("Welcome to the Mindfull exercise.\nThree of these prompts will get you in a relaxed mood.");
       }

       protected void breatheOpt()
       {
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
        protected void endMessage()
        {
            Console.WriteLine("That relaxation which you feel,\nis what I mean.");
            timePause();
            Thread.Sleep(6000);
            Console.Write("/");
        }

    }

}
       
    