using System;
using System.ComponentModel.DataAnnotations;
namespace Mindfulness
{

    public class Program
    {
        Activity Activity = new Activity();

        Activity Activity1 = new Activity();
    
        Breathe BreatheOpt = new Breathe();
        public string _breatheOpt1 = "Breathe in !!!";
        public string _breatheOpt2 = "Breathe out !!!";
        
        Activity Reflection = new Activity();
        private string[] _reflect = ["Think of a time when you stood up for someone else.\n ", "Think of a time when you did something really difficult.\n ","Think of a time when you helped someone in need.\n ","Think of a time when you did something truly selfless. "];
        Activity List = new Activity();
        protected string[] _listing = [];

         
    
    public static void Main(string[] args)
    {
        
    
        Console.WriteLine("You are welcome go the mindfull activities.The activities are:\n1). The breathing activity\n2). The reflection activity\n3). The Listing activity.\nPlease choose an activity by writing it's number.");
        string activity = Console.ReadLine();
        int Activity  = Convert.ToInt32($"{activity}");
        if (Activity == 1)
        {
            
            Console.WriteLine("Write in numerals the seconds you want to spend on this breathing activity?");
            string Breathing = Console.ReadLine();
            int Breathe = Convert.ToInt32($"{Breathing}");
            Console.WriteLine($"Breathe in and Let's wait for {Breathe}seconds then start breathing");
        }    

                
            
        else if (Activity == 2)
        {
            Console.WriteLine("Write in numerals the seconds you want to spend on that activity of reflecting?");
            string Reflecting = Console.ReadLine();
            int reflect = Convert.ToInt32($"{Reflecting}");
            Console.WriteLine($"Let's wait for {Reflecting} seconds then start reflecting");
            Thread.Sleep(1000);

            Console.WriteLine($"The {reflect} seconds are done now.\nTake another {reflect} seconds think of a time when you stood up for someone else. ");
            for (int item = 15; item > 0; item--)
            {
                Thread.Sleep(item);
                Console.Write("/");
                Console.Write("Weldone");
                Console.WriteLine($"Let's wait for {reflect} seconds then start reflecting");
                Thread.Sleep(reflect * 1000);
                Console.WriteLine("Done");
            }
        }
        
        else if (Activity ==3)
        {
            Console.WriteLine("Write in numerals the seconds you want to take during the Listing activity?");
            string listing = Console.ReadLine();
            int list = Convert.ToInt32($"{listing}");
            Console.WriteLine($"Let's wait for {list} seconds then start listing");
            for (int l = list*1000; l > 0; l--)
            {
                Thread.Sleep(l);
                Console.Write("/");
            }
            Console.WriteLine($"The {list} seconds are done now.\nList the good acheivements in life for {list} seconds. ");
            Console.WriteLine($"Let's wait for {list} seconds then start listing");
            Thread.Sleep(list * 1000);
            Console.WriteLine("Done");
        }         
            
    }
}}
