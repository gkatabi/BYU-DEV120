using System;
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
        public string _words =" ";
        public string _replacement = "_ ";

        private Hider()
        {

        }
        public void Show_words()
        {
            Console.Write(_words);
        }
        public void Show_replacement()
        {
            Console.Write(_replacement);
        }
    
    static void Main(string[] args)
    {
        List <string> Scripture    = new List<string>();
        string _book = "John";
        string _chapter = "5";
        string  _verseStart = "1";
        string _verseEnd = "2";
        Console.WriteLine($"{_book},{_chapter},{_verseStart},{_verseEnd}");
        List <string> Reference    = new List<string>();
        string _dispensation = "Old";
        Console.WriteLine($"{_dispensation}");
    
        List <string> Reminder    = new List<string>();
        string _hour = "3";

        Console.WriteLine($"It's {_hour},hours now. You should read your scriptures. ");
        
        
    }
    
}