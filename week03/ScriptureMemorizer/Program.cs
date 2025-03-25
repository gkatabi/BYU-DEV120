using System;
using System.Collections.Generic;
namespace Reminder;

    class Scripture
    {
        public string _book = " ";
        public string _chapter =  " "; 

        public string _verseStart = " ";
        public string _verseEnd = "";
        

        public Scripture()
        {

        }
        public void Display_book()
        {
            Console.WriteLine($"{_book}");
        }
        public void Display_chapter()
        {
            Console.WriteLine($"{_chapter}");
        }
        public void Display_verseStart()
        {
            Console.WriteLine($"{_verseStart}");
        }
        public void Display_verseEnd()
        {
            Console.WriteLine($"{_verseEnd}");
        }
        
        



    }

    class Reference
    {
        public string _dispensation = " ";

        public Reference()
    
        {
            Console.WriteLine("Ok");
        }
        
        

  

    }


    class Reminder
    {
        public string  _hour = " " ;

        public string _message = " ";

        public Reminder()
        {

        }
        public void Show_hour()
        {
            Console.WriteLine($"{_hour}");
        }

        public void Show_message()
        {
            Console.WriteLine($"{_message}");
        }

    }


    class Hider
    {
        public string _Words = "";

    
        public string _replacement = "_";

        private Hider()
        {
         
        }
        public void Show_Words()
        {
            Console.Write(_Words);
        }
        public void Show_replacement()
        {
              
            Console.Write(_replacement);
        }
    public static void Main(string[] args)
    {

        static void YesMethod()
        {
            Console.WriteLine("I love you");
        }

        static void NoMethod()
        {
            Console.WriteLine("Ok");
    
        }



        Console.WriteLine("This is a scripture reminder.\nWould you like to continue? 'Y' for Yes and 'N' for no");
        string Decission = Console.ReadLine();



        List <string> Scripture    = new List<string>();
        string _book = "John";
        string _chapter = "5";
        string  _verseStart = "1";
        string _verseEnd = "2";
        Console.WriteLine($"{_book},{_chapter},{_verseStart},{_verseEnd}");

        List <string>Random = new List <string>();
        List <string> Reference    = new List<string>();
        string _dispensation = "Old";
        Console.WriteLine($"{_dispensation}");
    
        List <string> Reminder    = new List<string>();
        string _hour = "3";

        List <string> Hider = new List <string>();
        string _Words = ("After this there was  a feast of the Jews; and Jesus went up to Jerusalem.\nNow there is at Jerusalem by the sheep market a pool, which is called in the Hebrew tongue Bethesda, having five Porches.");
        string _replacement = ("_");

        Console.WriteLine($"It's {_hour},hours now. You should read your scriptures. ");
        Console.Write($"{_Words}");

        
        
        
    
    }
    
}