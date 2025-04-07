using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
namespace Mindfull
{
    public class Program
    {
        private static object breathe1;

        public static void Main(string[] args)
        {
            Breathe Breathe1 = new Breathe();
             Thread.Sleep( 6000);
                string _breathe1 = "Breathe in !!!";
                Console.WriteLine(_breathe1);
                Thread.Sleep(6000);

            Breathe Breathe2 = new Breathe();


            Console.WriteLine("You are welcome go the mindfull activities.The activities are:\n1). The breathing activity\n2). The reflection activity\n3). The Listing activity.\nPlease choose an activity by writing it's number.");
            Thread.Sleep(3000);
            Console.WriteLine("Write the number that refers to the activity of your wish");
            string Wish = Console.ReadLine();
            int wish = Convert.ToInt32(Wish);
            if (wish == 1)
            {
                Console.WriteLine("Welcome to the breathing activity.\nThe activity will train you to hold your breathe for a while.\nHow many seconds would you want to take on each step? ");
                string Interval = Console.ReadLine();
                int interval = Convert.ToInt32(Interval);
                for(int e = interval; e > 0; e--)
                {
                    
                    Console.Write(">");
                    Thread.Sleep(1000);
                
                }
    
                int wis4 = Convert.ToInt32(Wish);
            if (wish == 2)
            {
                Console.WriteLine("Welcome to the reflection activity.\nThe activity will train you to reflect for a while.\nHow many seconds would you want to take on each step? ");
                string Time = Console.ReadLine();
                int time = Convert.ToInt32(Time);
                for(int e = time; e > 0; e--)
                {
                    
                    Console.Write(">");
                    Thread.Sleep(1000);
                
                }
            
            }


            Console.WriteLine("You are welcome to the reflection activity.The breathing activity,\nallows you to reflect on ambitions .");
            Thread.Sleep(3000);
            Console.WriteLine("Write the number that refers to the activity of your wish");
            string Wish1 = Console.ReadLine();
            int wish1 = Convert.ToInt32(Wish1);
            if (wish1 == 2)
            {
                Console.WriteLine("Get ready.\nThe activity will train  you reflect on acheivements.\nHow many seconds do you wish to take reflecting? ");
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
//            Console.WriteLine("Breathe out low");

            else if (wish == 2)
            {
                Console.WriteLine("Welcome to the reflection activity");
                Reflection reflect  = new Reflection();
                 
                Thread.Sleep( 6000);
                string _rerflect = Reflection.GetReflection();
                Console.WriteLine(reflect );
                Thread.Sleep(6000);
             
            Console.WriteLine("You are welcome go the mindfull activities.The activities are:\n1). The breathing activity\n2). The reflection activity\n3). The Listing activity.\nPlease choose an activity by writing it's number.");
            string activity = Console.ReadLine();
//            int Activity  = Convert.ToInt32($"{activity}");
            if (wish == 3)
            {
                Console.WriteLine("Welcome to the Listing activity");
                Listing list  = new Listing();
                Console.WriteLine("How many seconds would you wanna spend while listing?");
                string Length = Console.ReadLine();
                int length = Convert.ToInt32(Length);
                for (int x = length; x > 0; x--)
                {
                    Console.Write(">");//Line(x);
                    Thread.Sleep(1000);
                    Console.WriteLine("Who are people that you appreciate?");
                    Console.Write(">");//Line(x);
                    Thread.Sleep(1000);
                    Console.WriteLine("What are personal strengths of yours?");
                    Console.Write(">");//Line(x);
                    Thread.Sleep(1000);
                    Console.WriteLine("Who are people that you have helped this week?");
                    Console.Write(">");//Line(x);
                    Thread.Sleep(1000);
                    Console.WriteLine("When have you felt the Holy Ghost this month?");
                    Console.Write(">");//Line(x);
                    Thread.Sleep(1000);
                    Console.WriteLine("Who are some of your personal heroes?");
                    Console.Write(">");//Line(x);
                    Thread.Sleep(1000);
                
                }


            
            }         
            
        }
    }
}

    internal class Reflection
    {
        internal static string GetReflection()
        {
            string _reflect = " ";
            return " ";
        
        }
        
    }
}

    internal class Listing
    {
    }

    internal class Breathe
    {
        public Breathe()
        {
        }
    }
}